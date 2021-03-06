// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Composition
{
    /// <summary>
    /// Place on a type that should not be discovered as a MEF part.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public sealed class PartNotDiscoverableAttribute : Attribute
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="PartNotDiscoverableAttribute"/> class.
        /// </summary>
        public PartNotDiscoverableAttribute()
        {
        }
    }
}
