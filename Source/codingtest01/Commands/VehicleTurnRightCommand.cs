// ----------------------------------------------------------------------------
// <copyright file="VehicleTurnRightCommand.cs" company="CristianAlonsoSoft">
//     Copyright © CristianAlonsoSoft. All rights reserved.
// </copyright>
// ----------------------------------------------------------------------------
namespace CodingTest01.Commands
{
    using CodingTest01.Domain;

    /// <summary>
    /// The vehicle turn right command.
    /// Rotates the underlying vehicle in clockwise direction.
    /// </summary>
    public class VehicleTurnRightCommand : VehicleCommand
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleTurnRightCommand"/> class.
        /// </summary>
        /// <param name="vehicle">The vehicle to apply the commands.</param>
        public VehicleTurnRightCommand(IVehicleCommands vehicle)
            : base(vehicle)
        {
        }

        /// <summary>
        /// The executation method.
        /// </summary>
        public override void Execute()
        {
            this.Vehicle.TurnRight();
        }
    }
}
