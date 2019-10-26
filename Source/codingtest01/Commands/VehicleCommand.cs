// ----------------------------------------------------------------------------
// <copyright file="VehicleCommand.cs" company="CristianAlonsoSoft">
//     Copyright © CristianAlonsoSoft. All rights reserved.
// </copyright>
// ----------------------------------------------------------------------------

namespace CodingTest01.Commands
{
    using CodingTest01.Domain;

    /// <summary>
    /// Defines the base class for our commands.
    /// </summary>
    public abstract class VehicleCommand : CommandBase
    {
        /// <summary>
        /// The vehicle to apply the commands.
        /// </summary>
        private readonly IVehicleCommands vehicle;

        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleCommand"/> class.
        /// </summary>
        /// <param name="vehicle">The vehicle to apply the commands.</param>
        protected VehicleCommand(IVehicleCommands vehicle)
        {
            this.vehicle = vehicle;
        }

        /// <summary>
        /// Gets the vehicle.
        /// </summary>
        protected IVehicleCommands Vehicle => this.vehicle;
    }
}
