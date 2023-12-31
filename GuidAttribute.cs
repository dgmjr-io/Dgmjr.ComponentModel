/*
 * GuidAttribute.cs
 *
 *   Created: 2022-10-19-05:58:09
 *   Modified: 2023-10-01-07:32:13
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace System.ComponentModel.DataAnnotations;

/// <summary>
/// A class that represents a Guid attribute.
/// </summary>
[AttributeUsage(
    AttributeTargets.Class
        | AttributeTargets.Struct
        | AttributeTargets.Property
        | AttributeTargets.Field,
    Inherited = true,
    AllowMultiple = false
)]
public sealed class GuidAttribute(string guid) : ValueAttribute<guid>(System.Guid.Parse(guid))
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GuidAttribute"/> class
    /// using the specified <see cref="guid" /> value.
    /// </summary>
    /// <param name="guid">A GUID value.</param>
    public GuidAttribute(guid guid)
        : this(guid.ToString()) { }

/// <summary>
/// Gets the GUID value represented by the current <see cref="GuidAttribute"/>.
/// </summary>
public guid Guid => Value;
}
