namespace DClare.Sdk;

/// <summary>
/// Defines the fundamentals of a component that can be referenced by name instead of being defined inline.
/// </summary>
[Description("Defines the fundamentals of a component that can be referenced by name instead of being defined inline.")]
public interface IReferenceable
{

    /// <summary>
    /// Gets the name of the referenced component, if any.
    /// </summary>
    [Description("The name of the referenced component, if any. If set, the component is expected to be resolved from a predefined collection.")]
    string? Use { get; }

}