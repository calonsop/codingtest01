// ----------------------------------------------------------------------------
// <copyright file="Terrain.cs" company="CristianAlonsoSoft">
//     Copyright © CristianAlonsoSoft. All rights reserved.
// </copyright>
// ----------------------------------------------------------------------------
namespace CodingTest01.Domain
{
    using System;

    /// <summary>
    /// Defines the Terrain object.
    /// </summary>
    public class Terrain
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Terrain"/> class.
        /// </summary>
        /// <param name="width">The terrain's width.</param>
        /// <param name="height">The terrain's height.</param>
        public Terrain(uint width, uint height)
        {
            this.Witdh = width;
            this.Height = height;
        }

        #region Properties

        /// <summary>
        /// Gets the terrain's witdh.
        /// </summary>
        public uint Witdh { get; private set; }

        /// <summary>
        /// Gets the terrain's height.
        /// </summary>
        public uint Height { get; private set; }

        #endregion Properties
    }
}