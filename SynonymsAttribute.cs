using System;
namespace System.ComponentModel.DataAnnotations;

/// <summary>
/// Attribute that stores an array of synonyms for a given value.
/// </summary>
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface, AllowMultiple = false)]
public sealed class SynonymsAttribute(params string[] synonyms) : ValueAttribute<string[]>(synonyms)
{
    public SynonymsAttribute(string synonyms) : this(synonyms.Split(',')) { }

    /// <summary>
    /// Gets the array of synonyms stored in the base class's "Value" property.
    /// </summary>
    public string[] Synonyms => Value;
}
