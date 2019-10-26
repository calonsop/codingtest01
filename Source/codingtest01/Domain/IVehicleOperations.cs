// ----------------------------------------------------------------------------
// <copyright file="IVehicleOperations.cs" company="CristianAlonsoSoft">
//     Copyright © CristianAlonsoSoft. All rights reserved.
// </copyright>
// ----------------------------------------------------------------------------
namespace CodingTest01.Domain
{
    /// <summary>
    /// Defines the operations for a vehicle.
    /// </summary>
    public interface IVehicleOperations : IVehicleCommands
    {
        /// <summary>
        /// Gets the Vehicle's current position value.
        /// </summary>
        Position CurrentPosition { get; }

        /// <summary>
        /// Gets the current orientation value.
        /// </summary>
        Orientation CurrentOrientation { get; }

        /// <summary>
        /// Verifies the current position and determines if is valid.
        /// </summary>
        /// <returns><b>True</b> if the current position is valid, <b>False</b> in otherwise.</returns>
        /// <remarks>The position is valid only if there is into the terrain boundaries.</remarks>
        bool InValidPosition();

        /// <summary>
        /// Initilizes the vehicle into the world.
        /// </summary>
        /// <param name="posX">The initial X position.</param>
        /// <param name="posY">The initial Y position.</param>
        /// <param name="orientation">The initial orientation.</param>
        void Initialize(int posX, int posY, Orientation orientation);

        /// <summary>
        /// Gets the current status of the vehicle.
        /// </summary>
        /// <returns>The current status of the vehicle.</returns>
        VehicleStatus GetCurrentStatus();
    }
}
