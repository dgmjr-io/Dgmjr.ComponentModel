/*
 * SynonymsAttribute.cs
 *
 *   Created: 2023-04-14-06:23:15
 *   Modified: 2023-10-01-07:32:58
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using System;

namespace System.ComponentModel.DataAnnotations;

/// <summary>
/// Attribute that stores an array of synonyms for a given value.
/// </summary>
[AttributeUsage(
    AttributeTargets.Field
        | AttributeTargets.Property
        | AttributeTargets.Class
        | AttributeTargets.Struct
        | AttributeTargets.Enum
        | AttributeTargets.Interface,
    AllowMultiple = false
)]
public sealed class SynonymsAttribute(params string[] synonyms) : ValueAttribute<string[]>(synonyms)
{
    public SynonymsAttribute(string synonyms)
        : this(synonyms.Split(',')) { }

/// <summary>
/// Gets the array of synonyms stored in the base class's "Value" property.
/// </summary>
public string[] Synonyms => Value;
}
