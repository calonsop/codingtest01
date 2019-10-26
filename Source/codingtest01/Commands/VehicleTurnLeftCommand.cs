// ----------------------------------------------------------------------------
// <copyright file="VehicleTurnLeftCommand.cs" company="CristianAlonsoSoft">
//     Copyright © CristianAlonsoSoft. All rights reserved.
// </copyright>
// ----------------------------------------------------------------------------
namespace CodingTest01.Commands
{
    using CodingTest01.Domain;

    /// <summary>
    /// The vehicle turn left command.
    /// Rotates the underlying vehicle in counterclockwise direction.
    /// </summary>
    public class VehicleTurnLeftCommand : VehicleCommand
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleTurnLeftCommand"/> class.
        /// </summary>
        /// <param name="vehicle">The vehicle to apply the commands.</param>
        public VehicleTurnLeftCommand(IVehicleCommands vehicle)
            : base(vehicle)
        {
        }

        /// <summary>
        /// The executation method.
        /// </summary>
        public override void Execute()
        {
            this.Vehicle.TurnLeft();
        }
    }
}
