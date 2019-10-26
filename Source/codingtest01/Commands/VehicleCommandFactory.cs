// ----------------------------------------------------------------------------
// <copyright file="VehicleCommandFactory.cs" company="CristianAlonsoSoft">
//     Copyright © CristianAlonsoSoft. All rights reserved.
// </copyright>
// ----------------------------------------------------------------------------
namespace CodingTest01.Commands
{
    using CodingTest01.Domain;
    using CodingTest01.Exceptions;

    /// <summary>
    /// Defines the vehicle command factory.
    /// </summary>
    public static class VehicleCommandFactory
    {
        /// <summary>
        /// Builds a new instance of VehicleCommand depending the command key value.
        /// </summary>
        /// <param name="vehicle">The vehicle to attach to command.</param>
        /// <param name="command">The command key value.</param>
        /// <returns>The vehicle command.</returns>
        public static VehicleCommand Build(IVehicleCommands vehicle, char command)
        {
            VehicleCommand result = null;
            switch (char.ToUpper(command))
            {
                case 'A':
                    result = new VehicleAdvanceCommand(vehicle);
                    break;
                case 'L':
                    result = new VehicleTurnLeftCommand(vehicle);
                    break;
                case 'R':
                    result = new VehicleTurnRightCommand(vehicle);
                    break;
                default:
                    throw new InvalidCommandException(command);
            }

            return result;
        }
    }
}
