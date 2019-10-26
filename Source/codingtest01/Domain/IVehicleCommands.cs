// ----------------------------------------------------------------------------
// <copyright file="IVehicleCommands.cs" company="CristianAlonsoSoft">
//     Copyright © CristianAlonsoSoft. All rights reserved.
// </copyright>
// ----------------------------------------------------------------------------
namespace CodingTest01.Domain
{
    /// <summary>
    /// Determines the functionality of the commands for a vehicle.
    /// </summary>
    public interface IVehicleCommands
    {
        /// <summary>
        /// Moves the vehicle in its front direction.
        /// </summary>
        void Advance();

        /// <summary>
        /// Turns the vehicle in left direction.
        /// </summary>
        void TurnLeft();

        /// <summary>
        /// Turns the vehicle in left direction.
        /// </summary>
        void TurnRight();
    }
}
