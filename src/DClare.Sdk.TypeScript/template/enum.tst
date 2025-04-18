${
    using System.Text.RegularExpressions;
    using Typewriter.Extensions.Types;
    using Typewriter.VisualStudio;
    
    static ILog log;
    static string directory = "enums";
    static List<string> exportedFiles = [];

    Template(Settings settings)
    {
      settings
          .IncludeProject("DClare.Sdk")
          .DisableUtf8BomGeneration()
          .OutputFilenameFactory = (file) => $"..\\{directory}\\{GetFileName(file, ".ts")}";
          
      settings.PartialRenderingMode = PartialRenderingMode.Combined;
      log = settings.Log;
    }

    string ToKebabCase(string typeName)
    {
      return Regex.Replace(typeName, "(?<!^)([A-Z][a-z]|(?<=[a-z])[A-Z])", "-$1", RegexOptions.Compiled)
                   .Trim().ToLower();
    }

    string GetFileName(File file, string extention = "")
    {
        return ToKebabCase(file.Name).Replace(".cs", extention);
    }

    bool IsStaticEnum(Class c)
    {
        return c.IsStatic &&
            c.Name != "IServiceCollectionExtensions" &&
            !c.FullName.StartsWith("DClare.Sdk.Models");
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

    void BuildIndex(Class c)
    {
        var file = (File)c.Parent;
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

    string Export(Class c)
    {
        return $"export enum {c.Name}";
    }

    string ConstantValue(Constant constant)
    {
        if (constant.Type == "string") return $"`{constant.Value}`";
        return $"{constant.Value}";
    }

}$Classes($IsStaticEnum)[$BuildIndex$Export{$Constants[
  $Name = $ConstantValue,]
}]