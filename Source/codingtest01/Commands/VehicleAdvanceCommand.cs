// ----------------------------------------------------------------------------
// <copyright file="VehicleAdvanceCommand.cs" company="CristianAlonsoSoft">
//     Copyright © CristianAlonsoSoft. All rights reserved.
// </copyright>
// ----------------------------------------------------------------------------
namespace CodingTest01.Commands
{
    using CodingTest01.Domain;

    /// <summary>
    /// The vehicle advance command.
    /// Moves the vehicle one position ahead its current position, y direction will be determined by its orientation.
    /// </summary>
    public class VehicleAdvanceCommand : VehicleCommand
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleAdvanceCommand"/> class.
        /// </summary>
        /// <param name="vehicle">The vehicle to apply the commands.</param>
        public VehicleAdvanceCommand(IVehicleCommands vehicle)
            : base(vehicle)
        {
        }

        /// <summary>
        /// The executation method.
        /// </summary>
        public override void Execute()
        {
            this.Vehicle.Advance();
        }
    }
}
