// ----------------------------------------------------------------------------
// <copyright file="MainArgsDummy.cs" company="CristianAlonsoSoft">
//     Copyright © CristianAlonsoSoft. All rights reserved.
// </copyright>
// ----------------------------------------------------------------------------
namespace CodingTest01.Test.Dummies
{
    using System.Collections.Generic;

    /// <summary>
    /// Defines the input args for a main class.
    /// </summary>
    public class MainArgsDummy
    {
        /// <summary>
        /// The args template.
        /// </summary>
        private const string ArgumentTemplate = "-{0} {1}";

        /// <summary>
        /// Gets or sets the terrain's witdh.
        /// </summary>
        /// <remarks>
        /// Valid values: Only integer numbers greather than 0.
        /// </remarks>
        public string TerrainWidth { get; set; }

        /// <summary>
        /// Gets or sets the terrain's height.
        /// </summary>
        /// <remarks>
        /// Valid values: Only integer numbers greather than 0.
        /// </remarks>
        public string TerrainHeight { get; set; }

        /// <summary>
        /// Gets or sets the Rover's X position.
        /// </summary>
        /// <remarks>
        /// Valid values: Only integer numbers greather than 0 and lower than TerrainWidth.
        /// </remarks>
        public string RoverX { get; set; }

        /// <summary>
        /// Gets or sets the Rover's Y position.
        /// </summary>
        /// <remarks>
        /// Valid values: Only integer numbers greather than 0 and lower than TerrainHeight.
        /// </remarks>
        public string RoverY { get; set; }

        /// <summary>
        /// Gets or sets the Rover's X orientation.
        /// </summary>
        /// <remarks>
        /// Valid values: Only char element included in the set {N, S, E, W}.
        /// </remarks>
        public string RoverO { get; set; }

        /// <summary>
        /// Gets or sets the Rover's movement commands.
        /// </summary>
        /// <remarks>
        /// Valid values: Only string not null, composed with chars included in the set {A, L, R}.
        /// </remarks>
        public string Commands { get; set; }

        /// <summary>
        /// Gets or sets the pause argument
        /// </summary>
        /// <remarks>
        /// Valid values: true and false. The value is false as default.
        /// </remarks>
        public string Pause { get; set; } = "false";

        /// <summary>
        /// Generate a command line args array with the content values.
        /// </summary>
        /// <returns>The resulted command array args to introduce in main class.</returns>
        public string[] GenerateCommandLineArgs()
        {
            List<string> result = new List<string>();
            if (!string.IsNullOrWhiteSpace(this.TerrainWidth))
            {
                result.Add(string.Format(ArgumentTemplate, "w", this.TerrainWidth));
            }

            if (!string.IsNullOrWhiteSpace(this.TerrainHeight))
            {
                result.Add(string.Format(ArgumentTemplate, "h", this.TerrainHeight));
            }

            if (!string.IsNullOrWhiteSpace(this.RoverX))
            {
                result.Add(string.Format(ArgumentTemplate, "x", this.RoverX));
            }

            if (!string.IsNullOrWhiteSpace(this.RoverY))
            {
                result.Add(string.Format(ArgumentTemplate, "y", this.RoverY));
            }

            if (!string.IsNullOrWhiteSpace(this.RoverO))
            {
                result.Add(string.Format(ArgumentTemplate, "o", this.RoverO));
            }

            if (!string.IsNullOrWhiteSpace(this.Commands))
            {
                result.Add(string.Format(ArgumentTemplate, "c", this.Commands));
            }

            if (!string.IsNullOrWhiteSpace(this.Pause))
            {
                result.Add(string.Format(ArgumentTemplate, "p", this.Pause));
            }

            return result.ToArray();
        }
    }
}
