// ----------------------------------------------------------------------------
// <copyright file="VehicleOperationsStub.cs" company="CristianAlonsoSoft">
//     Copyright © CristianAlonsoSoft. All rights reserved.
// </copyright>
// ----------------------------------------------------------------------------
namespace CodingTest01.Test.Stubs
{
    using CodingTest01.Domain;

    /// <summary>
    /// The vehicle operations stub only for testing purposes.
    /// </summary>
    public class VehicleOperationsStub : VehicleCommandsStub, IVehicleOperations
    {
        /// <summary>
        /// Gets the invocation number of the InValidPosition method.
        /// </summary>
        public int InValidPositionInvocations { get; private set; } = 0;

        /// <summary>
        /// Gets the invocation number of the Initialize method.
        /// </summary>
        public int InitializeInvocations { get; private set; } = 0;

        /// <summary>
        /// Gets the invocation number of the GetCurrentStatus method.
        /// </summary>
        public int GetCurrentStatusInvocations { get; private set; } = 0;

        /// <summary>
        /// Gets the Vehicle's current position value.
        /// </summary>
        public Position CurrentPosition => new Position();

        /// <summary>
        /// Gets the current orientation value.
        /// </summary>
        public Orientation CurrentOrientation => Orientation.N;

        /// <summary>
        /// GetCurrentStatus stub method.
        /// </summary>
        /// <returns>A new VehicleStatus object.</returns>
        public VehicleStatus GetCurrentStatus()
        {
            this.GetCurrentStatusInvocations++;
            return new VehicleStatus(this);
        }

        /// <summary>
        /// Initialize stub method.
        /// </summary>
        /// <param name="posX">The x position.</param>
        /// <param name="posY">The y position.</param>
        /// <param name="orientation">The orientation.</param>
        public void Initialize(int posX, int posY, Orientation orientation)
        {
            this.InitializeInvocations++;
        }

        /// <summary>
        /// InValidPosition stub method.
        /// </summary>
        /// <returns>Returns true.</returns>
        public bool InValidPosition()
        {
            this.GetCurrentStatusInvocations++;
            return true;
        }
    }
}
