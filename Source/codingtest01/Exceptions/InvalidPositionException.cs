// ----------------------------------------------------------------------------
// <copyright file="InvalidPositionException.cs" company="CristianAlonsoSoft">
//     Copyright © CristianAlonsoSoft. All rights reserved.
// </copyright>
// ----------------------------------------------------------------------------
namespace CodingTest01.Exceptions
{
    using System;
    using CodingTest01.Domain;

    /// <summary>
    /// Defines the invalid position exception.
    /// </summary>
    public class InvalidPositionException : Exception
    {
        /// <summary>
        /// The position.
        /// </summary>
        private readonly Position position;

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidPositionException"/> class.
        /// </summary>
        /// <param name="position">The current invalid position.</param>
        public InvalidPositionException(Position position)
            : base($"The current position ({position.X},{position.Y}) is out of the terrain.")
        {
            this.position = position;
        }

        /// <summary>
        /// Gets a copy of the position.
        /// </summary>
        public Position Position => new Position(this.position);
    }
}
