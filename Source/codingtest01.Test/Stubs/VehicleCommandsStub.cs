// ----------------------------------------------------------------------------
// <copyright file="VehicleCommandsStub.cs" company="CristianAlonsoSoft">
//     Copyright © CristianAlonsoSoft. All rights reserved.
// </copyright>
// ----------------------------------------------------------------------------

namespace CodingTest01.Test.Stubs
{
    using CodingTest01.Domain;

    /// <summary>
    /// Defines the stub for the vehicle commands interface.
    /// </summary>
    public class VehicleCommandsStub : IVehicleCommands
    {
        /// <summary>
        /// Gets the invocation number of the Advance method.
        /// </summary>
        public int AdvanceInvocations { get; private set; } = 0;

        /// <summary>
        /// Gets the invocation number of the TurnLeft method.
        /// </summary>
        public int TurnLeftInvocations { get; private set; } = 0;

        /// <summary>
        /// Gets the invocation number of the TurnRight method.
        /// </summary>
        public int TurnRightInvocations { get; private set; } = 0;

        /// <summary>
        /// The advance method.
        /// </summary>
        public void Advance()
        {
            this.AdvanceInvocations++;
        }

        /// <summary>
        /// The turn left method.
        /// </summary>
        public void TurnLeft()
        {
            this.TurnLeftInvocations++;
        }

        /// <summary>
        /// the turn right method.
        /// </summary>
        public void TurnRight()
        {
            this.TurnRightInvocations++;
        }
    }
}
