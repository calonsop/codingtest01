// ----------------------------------------------------------------------------
// <copyright file="InvalidCommandException.cs" company="CristianAlonsoSoft">
//     Copyright © CristianAlonsoSoft. All rights reserved.
// </copyright>
// ----------------------------------------------------------------------------

namespace CodingTest01.Exceptions
{
    using System;
    using CodingTest01.Domain;

    /// <summary>
    /// Defines the invalid command exception.
    /// </summary>
    public class InvalidCommandException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidCommandException"/> class.
        /// </summary>
        /// <param name="command">The current invalid command.</param>
        public InvalidCommandException(char command)
            : base($"The current command ({command}). The commands accepted are Advance (A), Turn Left (L), Turn Right (R) is out of the terrain.")
        {
            this.Command = command;
        }

        /// <summary>
        /// Gets the current invalid command.
        /// </summary>
        public char Command { get; private set; }
    }
}
