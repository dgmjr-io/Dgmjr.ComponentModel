/*
 * FromStringAttribute.cs
 *
 *   Created: 2023-04-14-06:23:15
 *   Modified: 2023-10-01-07:32:31
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace System.ComponentModel.DataAnnotations;

/// <summary>
/// Marker attribute for properties of that can be created from a string.
/// </summary>
[AttributeUsage(
    AttributeTargets.Property | AttributeTargets.Field,
    AllowMultiple = false,
    Inherited = true
)]
public sealed class FromStringAttribute : Attribute { }
