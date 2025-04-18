${
    using System.Text.RegularExpressions;
    using Typewriter.Extensions.Types;
    using Typewriter.VisualStudio;
    
    static ILog log;
    static string directory = "models";
    static List<string> exportedFiles = [];
    static class options
    {
      public static char IndentationChar = ' ';
      public static int IndentationCount = 2;
    }
    static List<KeyValuePair<string, string>> commentFormattingPatterns = new List<KeyValuePair<string, string>>() {
        new KeyValuePair<string, string>(@"<see cref=""T:DClare\.Sdk\(.*)"" \/>" , "@see {@link $1}")
    };
    
    const string NEW_LINE = "\r\n";

    Template(Settings settings)
    {
      settings
          .IncludeProject("DClare.Sdk")
          .DisableUtf8BomGeneration()
          .OutputFilenameFactory = (file) => $"..\\{directory}\\{GetFileName(file, ".ts")}";
          
      settings.PartialRenderingMode = PartialRenderingMode.Combined;
      log = settings.Log;
    }

    bool IsModel(Record r)
    {
        return r.FullName.StartsWith("DClare.Sdk.Models");
    }

    string ToKebabCase(string typeName)
    {
      return Regex.Replace(typeName, "(?<!^)([A-Z][a-z]|(?<=[a-z])[A-Z])", "-$1", RegexOptions.Compiled)
                   .Trim().ToLower();
    }

    string CleanupName(string name) => name.Replace("[]", "").Replace(" | null", "");

    string GetFileName(File file, string extention = "")
    {
        return ToKebabCase(file.Name).Replace(".cs", extention);
    }

    string GetFileName(Type t, string extention = "")
    {
        return ToKebabCase(CleanupName(t.Name)) + extention;
    }

    string Indent(int quantity, string message, Boolean newLine = true)
    {
      return new String(options.IndentationChar, options.IndentationCount * quantity) + message + (newLine ? NEW_LINE : "");
    }  

    System.IO.DirectoryInfo GetSrcDirectory(File file)
    {
      System.IO.DirectoryInfo directory = new System.IO.FileInfo(file.FullName).Directory;
      while (directory.Name != "src" && directory.Parent != null)
      {
        directory = directory.Parent;
      }
      return directory;
    }

    void BuildIndex(Record r)
    {
        var file = (File)r.Parent;
        var filePath = $"./{GetFileName(file)}";
        if (exportedFiles.Contains(filePath)) return;
        var exports = $"export {{ { String.Join(",", file.Classes.Select(cls => cls.Name)) } }} from '{filePath}';";
        string indexPath = System.IO.Path.Combine(new string[] {
            GetSrcDirectory(file).FullName,
            "DClare.Sdk.TypeScript",
            directory,
            "index.ts"
        });
        using (var stream = System.IO.File.Open(indexPath, exportedFiles.Count == 0 ? System.IO.FileMode.Create : System.IO.FileMode.Append, System.IO.FileAccess.Write, System.IO.FileShare.Read))
        {
            using (var writer = new System.IO.StreamWriter(stream))
            {
                writer.WriteLine(exports);
            }
        }
        exportedFiles.Add(filePath);
    }

    bool RequiresImport(Record r, Type t) {
      return (!t.IsPrimitive || t.IsEnum)
              && CleanupName(t.Name) != r.Name
              && (r.BaseRecord == null || t.Name != CleanupName(r.BaseRecord.Name))
              && CleanupName(t.Name) != "T"
              && CleanupName(t.Name) != "Version"
              && CleanupName(t.Name) != "Uri"
              && t.OriginalName != "JObject"
              && t.OriginalName != "Any"
              && t.OriginalName != "JsonSchema"
              && t.OriginalName != "JToken"
              && t.OriginalName != "JSchema"
              && t.OriginalName != "ExpandoObject"
              && t.OriginalName != "JsonPatchDocument"
              && t.OriginalName != "TimeOnly"              
              && !r.TypeArguments.Select(a => CleanupName(a.Name)).Contains(CleanupName(t.Name))
              && !t.Attributes.Any(a => a.Name == "JsonIgnore")
              ;
    }

    string Imports(Record r)
    {
        string output = "";
        if (r.BaseRecord != null)
        {
            /* The Parent of BaseRecord is the record `r`, not the `File` declaring the BaseRecord, using its type instead */
            output += $"import {{ {r.BaseRecord.Name} }} from './{GetFileName(r.BaseRecord)}';";
        }
        output += r.Properties
            .SelectMany(p => !p.Type.IsGeneric ?
              new[] { p.Type } as IEnumerable<Type> :
              p.Type.FullName.Contains("System") ?
                p.Type.TypeArguments :
                (new[] { p.Type } as IEnumerable<Type>).Concat(p.Type.TypeArguments)
            )
            .Where(t => RequiresImport(r, t))
            .Distinct()
            .Select(t => $"import {{ {CleanupName(t.Name)} }} from './{GetFileName(t)}';")
            .Aggregate("", (all, import) => $"{all}{import}\r\n")
            .TrimStart();
        return output;
    }

    string TranslateComment(int depth, DocComment comment)
    {
        string output = "";
        if (!string.IsNullOrWhiteSpace(comment?.Summary))
        {
            string summary = comment.Summary;
            /*
            commentFormattingPatterns.ForEach(pattern =>
            {
                summary = Regex.Replace(summary, pattern.Key, pattern.Value);
            });
            */
            output +=  Indent(depth, $" * {summary}");
        }
        if (comment?.Parameters != null && comment.Parameters.Count > 0)
        {
            output += String.Join("", comment.Parameters.Select(param => {
                var paramStr = Indent(depth, $" * @param {param.Name} - {param.Description}");
                /*
                commentFormattingPatterns.ForEach(pattern =>
                {
                    paramStr = Regex.Replace(paramStr, pattern.Key, pattern.Value);
                });
                */
                return paramStr;
            }));
        }
        if (!string.IsNullOrWhiteSpace(comment?.Returns))
        {
            string returns = comment.Returns;
            /*
            commentFormattingPatterns.ForEach(pattern =>
            {
                returns = Regex.Replace(returns, pattern.Key, pattern.Value);
            });
            */
            output += Indent(depth, $" * {returns}");
        }
        return output;
    }

    string Comments(Record r)
    {
        if (r.DocComment == null) return "";
        string output = "";
        output += Indent(0, $"/**");
        output += TranslateComment(0, r.DocComment);
        output += Indent(0, $" */", false);
        return output;
    }

    string Export(Record r)
    {
      string recordName = r.Name;
      if (r.IsGeneric)
      {
        recordName += $"<{String.Join(",",r.TypeArguments.Select(t => t.Name))}>";
      }
      if (r.BaseRecord != null)
      {
        return Indent(0, $"export class {recordName} extends {r.BaseRecord.Name}");
      }
      return Indent(0, $"export class {recordName}");
    }

    string Property(Property p)
    {
        string output = "";
        output += Indent(1, $"/**");
        output += TranslateComment(1, p.DocComment);
        output += Indent(1, $" */");
        output += Indent(1, $"{p.name}: {p.Type.Name};");
        return output;
    }

    string DeclareProperties(Record r)
    {
        return String.Join("", r.Properties
            .Select(p => Property(p))
            .Distinct()
        ).TrimEnd();
    }
}$Records($IsModel)[$BuildIndex$Imports
$Comments
$Export {
$DeclareProperties
}]