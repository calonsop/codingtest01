// ----------------------------------------------------------------------------
// <copyright file="InvalidOrientationException.cs" company="CristianAlonsoSoft">
//     Copyright © CristianAlonsoSoft. All rights reserved.
// </copyright>
// ----------------------------------------------------------------------------
namespace CodingTest01.Exceptions
{
    using System;

    /// <summary>
    /// Defines the invalid position exception.
    /// </summary>
    public class InvalidOrientationException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidOrientationException"/> class.
        /// </summary>
        /// <param name="orientation">The current invalid orientation.</param>
        public InvalidOrientationException(string orientation)
            : base($"The current orientation ({orientation}) is not valid. Values allowed (N, E, S, W)")
        {
            this.Orientation = orientation;
        }

        /// <summary>
        /// Gets the invalid command.
        /// </summary>
        public string Orientation { get; private set; }
    }
}
