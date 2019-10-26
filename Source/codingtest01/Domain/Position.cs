// ----------------------------------------------------------------------------
// <copyright file="Position.cs" company="CristianAlonsoSoft">
//     Copyright © CristianAlonsoSoft. All rights reserved.
// </copyright>
// ----------------------------------------------------------------------------
namespace CodingTest01.Domain
{
    using System;

    /// <summary>
    /// The Position domain object.
    /// </summary>
    public class Position
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Position"/> class.
        /// </summary>
        public Position()
        {
            this.X = default(int);
            this.Y = default(int);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Position"/> class.
        /// </summary>
        /// <param name="src">The original element.</param>
        public Position(Position src)
        {
            this.X = src.X;
            this.Y = src.Y;
        }

        #region Properties

        /// <summary>
        /// Gets or sets the X coordinate.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Gets or sets the Y coordinate.
        /// </summary>
        public int Y { get; set; }

        #endregion Properties
    }
}