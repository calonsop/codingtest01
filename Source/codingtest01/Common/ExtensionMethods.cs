// ----------------------------------------------------------------------------
// <copyright file="ExtensionMethods.cs" company="CristianAlonsoSoft">
//     Copyright © CristianAlonsoSoft. All rights reserved.
// </copyright>
// ----------------------------------------------------------------------------
namespace CodingTest01.Common
{
    using System;
    using System.Collections.Generic;
    using CodingTest01.Commands;
    using CodingTest01.Domain;
    using CodingTest01.Exceptions;

    /// <summary>
    /// Defines a set of extension methods.
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Executes a vehicle command collection in iterative order.
        /// </summary>
        /// <param name="src">The command collection to execute.</param>
        /// <remarks>This method can throw an InvalidPositionException.</remarks>
        public static void Execute(this IEnumerable<VehicleCommand> src)
        {
            foreach (var command in src)
            {
                command.Execute();
            }
        }

        /// <summary>
        /// Tries to cast the string into a Orientation.
        /// </summary>
        /// <param name="src">The string to cast.</param>
        /// <returns>The resulted Orientation.</returns>
        /// <remarks>This method can throw an InvalidOrientationException.</remarks>
        public static Orientation ToOrientation(this string src)
        {
            if (string.IsNullOrWhiteSpace(src) || !Enum.TryParse<Orientation>(src, out Orientation result))
            {
                throw new InvalidOrientationException(src);
            }

            return result;
        }
    }
}
