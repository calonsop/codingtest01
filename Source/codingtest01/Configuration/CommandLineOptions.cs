﻿// ----------------------------------------------------------------------------
// <copyright file="CommandLineOptions.cs" company="CristianAlonsoSoft">
//     Copyright © CristianAlonsoSoft. All rights reserved.
// </copyright>
// ----------------------------------------------------------------------------
namespace CodingTest01.Configuration
{
    using CodingTest01.Domain;
    using CommandLine;

    /// <summary>
    /// Entity that contains the command line options.
    /// </summary>
    public class CommandLineOptions
    {
        #region Properties

        /// <summary>
        /// Gets or sets the terrain's witdh.
        /// </summary>
        [Option('w', "TerrainWidth", Required = true, HelpText = "The terrain's width.")]
        public uint TerrainWidth { get; set; }

        /// <summary>
        /// Gets or sets the terrain's height.
        /// </summary>
        [Option('h', "terrainheight", Required = true, HelpText = "The terrain's height.")]
        public uint TerrainHeight { get; set; }

        /// <summary>
        /// Gets or sets the Rover's X position.
        /// </summary>
        [Option('x', "roverx", Required = true, HelpText = "The Rover's X position.")]
        public uint RoverX { get; set; }

        /// <summary>
        /// Gets or sets the Rover's Y position.
        /// </summary>
        [Option('y', "rovery", Required = true, HelpText = "The Rover's Y position.")]
        public uint RoverY { get; set; }

        /// <summary>
        /// Gets or sets the Rover's X orientation.
        /// </summary>
        [Option('o', "rovero", Required = true, HelpText = "The Rover's Orientation {N, S, E, W}.")]
        public string RoverO { get; set; }

        /// <summary>
        /// Gets or sets the Rover's movement commands.
        /// </summary>
        [Option('c', "commands", Required = true, HelpText = "The Rover's movement commands. Array without spaces with the secuence of commands: Advance (Ä), Turn Left (L), Turn Right (R). Example : AALAARALA")]
        public string Commands { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether will be a pause after the execution.
        /// </summary>
        [Option('p', "pause", Required = false, Default = false, HelpText = "True if we wan't the program makes a pause to watch the results.")]
        public bool Pause { get; set; }

        #endregion Properties
    }
}