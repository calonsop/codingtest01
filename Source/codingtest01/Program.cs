// ----------------------------------------------------------------------------
// <copyright file="Program.cs" company="CristianAlonsoSoft">
//     Copyright © CristianAlonsoSoft. All rights reserved.
// </copyright>
// ----------------------------------------------------------------------------
namespace CodingTest01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CodingTest01.Commands;
    using CodingTest01.Common;
    using CodingTest01.Configuration;
    using CodingTest01.Domain;
    using CodingTest01.Exceptions;
    using CommandLine;

    /// <summary>
    /// The main class.
    /// </summary>
    public class Program
    {
        #region Methods

        /// <summary>
        /// The application entrypoint.
        /// </summary>
        /// <param name="args">The arguments.</param>
        /// <returns>
        ///         <ul>
        ///             <b>0</b> if all executed correctly.</returns>
        ///             <b>-1</b> if the arguments are missed.
        ///             <b>-2</b> if the orientation is incorrect.
        ///             <b>-3</b> if the command secuence contains an incorrect command.
        ///             <b>-4</b> if the Rover leaves Mars!!.
        ///         </ul>
        /// </returns>
        public static int Main(string[] args)
        {
            bool pause = false;
            int result = -1;
            try
            {
                Parser.Default.ParseArguments<CommandLineOptions>(args)
                     .WithParsed<CommandLineOptions>(o =>
                     {
                         pause = o.Pause;

                         Orientation initialOrientation = o.RoverO.ToOrientation();
                         Terrain mars = new Terrain(o.TerrainWidth, o.TerrainHeight);
                         Vehicle rover = new Vehicle(mars);
                         rover.Initialize((int)o.RoverX, (int)o.RoverY, initialOrientation);

                         IEnumerable<VehicleCommand> vehicleActions = o.Commands.Trim().Select(command => VehicleCommandFactory.Build(rover, command));

                         MarsRoverEngine marsRoverEngine = new MarsRoverEngine(rover, vehicleActions);
                         marsRoverEngine.ExecuteCommands();
                         var status = rover.GetCurrentStatus();
                         Console.WriteLine(status);

                         if (!status.InTerrainLimits)
                         {
                             result = -4;
                         }
                         else
                         {
                             result = 0;
                         }
                     })
                     .WithNotParsed<CommandLineOptions>(errors =>
                     {
                         result = -1;
                     });
            }
            catch (InvalidOrientationException)
            {
                result = -2;
            }
            catch (InvalidCommandException)
            {
                result = -3;
            }
            catch (InvalidPositionException)
            {
                result = -4;
            }

            Console.WriteLine($"Result value: {result}");
            if (pause)
            {
                Console.ReadLine();
            }

            return result;
        }

        #endregion Methods
    }
}