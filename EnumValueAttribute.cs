/*
 * EnumValueAttribute.cs
 *
 *   Created: 2023-04-01-03:29:38
 *   Modified: 2023-04-01-03:29:38
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */
namespace System.ComponentModel.DataAnnotations;

/// <summary>
/// Attribute to store a custom value for an enum member.
/// </summary>
/// <param name="value">The custom value associated with the enum member.</param>
[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
public class EnumValueAttribute(string value) : ValueAttribute<string>(value)
{
}
