// ----------------------------------------------------------------------------
// <copyright file="MarsRoverEngine.cs" company="CristianAlonsoSoft">
//     Copyright © CristianAlonsoSoft. All rights reserved.
// </copyright>
// ----------------------------------------------------------------------------
namespace CodingTest01
{
    using System.Collections.Generic;

    using CodingTest01.Commands;
    using CodingTest01.Common;
    using CodingTest01.Domain;

    /// <summary>
    /// The core of the program.
    /// Puts a Rover in Mars and Sends orders to move, and finaly request the status.
    /// </summary>
    public class MarsRoverEngine
    {
        /// <summary>
        /// The vehicle.
        /// </summary>
        private readonly IVehicleOperations vehicle;

        /// <summary>
        /// The commands.
        /// </summary>
        private readonly IEnumerable<VehicleCommand> commands;

        /// <summary>
        /// Initializes a new instance of the <see cref="MarsRoverEngine"/> class.
        /// </summary>
        /// <param name="vehicle">The vehicle.</param>
        /// <param name="commands">The commands.</param>
        public MarsRoverEngine(IVehicleOperations vehicle, IEnumerable<VehicleCommand> commands)
        {
            this.vehicle = vehicle;
            this.commands = commands;
        }

        /// <summary>
        /// Execute the movement commands.
        /// </summary>
        public void ExecuteCommands()
        {
            this.commands.Execute();
        }

        /// <summary>
        /// Gets the current vehicle status.
        /// </summary>
        /// <returns>The current vehicle status.</returns>
        public VehicleStatus GetCurrentVehicleStatus()
        {
            return this.vehicle.GetCurrentStatus();
        }
    }
}
