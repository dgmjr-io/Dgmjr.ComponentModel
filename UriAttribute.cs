/*
 * UriAttribute.cs
 *
 *   Created: 2022-10-16-10:50:42
 *   Modified: 2023-10-01-07:33:02
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */
namespace System.ComponentModel.DataAnnotations;

/// <summary>
/// Attribute that can be applied to properties, fields, and parameters. Allows multiple instances of the attribute to be used on a single target.
/// </summary>
/// <param name="uri">The string representation of the Uri value.</param>
[AttributeUsage(
    AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter,
    AllowMultiple = true
)]
public sealed class UriAttribute(
#if NET7_0_OR_GREATER
    [StringSyntax(StringSyntaxAttribute.Regex)]
#endif
    string uri) : ValueAttribute<Uri>(new Uri(uri))
{
    /// <summary>
    /// Initializes a new instance of the UriAttribute class with a specified Uri parameter and passes it to the base constructor.
    /// </summary>
    /// <param name="uri">The Uri value.</param>
    public UriAttribute(Uri uri)
        : this(uri.ToString()) { }

/// <summary>
/// Gets the value of the URI stored in the base class's "Value" property.
/// </summary>
public Uri Uri => Value;
}
