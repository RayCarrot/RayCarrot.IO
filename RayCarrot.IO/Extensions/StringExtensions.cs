using System;
using System.Collections.Generic;
using System.Linq;

namespace RayCarrot.IO
{
    /// <summary>
    /// Extension methods for a <see cref="String"/>
    /// </summary>
    internal static class StringExtensions
    {
        /// <summary>
        /// Returns true if the string is null or an empty string or just whitespace
        /// </summary>
        /// <param name="value">The string</param>
        /// <returns>True if the string is null, empty or just white space, false if not</returns>
        public static bool IsNullOrWhiteSpace(this string value)
        {
            return String.IsNullOrWhiteSpace(value);
        }
    }
}