// ----------------------------------------------------------------------------
// <copyright file="VehicleTurnRightCommandUnitTest.cs" company="CristianAlonsoSoft">
//     Copyright © CristianAlonsoSoft. All rights reserved.
// </copyright>
// ----------------------------------------------------------------------------
namespace CodingTest01.Test
{
    using CodingTest01.Commands;
    using CodingTest01.Test.Stubs;
    using Xunit;

    /// <summary>
    /// Defines the unit test class for the vehicle TurnRight command.
    /// </summary>
    public class VehicleTurnRightCommandUnitTest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleTurnRightCommandUnitTest"/> class.
        /// </summary>
        public VehicleTurnRightCommandUnitTest()
        {
        }

        /// <summary>
        /// Verifies that executes method calls one time to TurnRight method of the vehicle.
        /// </summary>
        [Fact]
        public void Execute_MustExecuteTheAdvanceOperation()
        {
            // ARRANCE
            VehicleCommandsStub vehicleStub = new VehicleCommandsStub();
            VehicleTurnRightCommand sut = new VehicleTurnRightCommand(vehicleStub);

            // ACT
            sut.Execute();

            // ASSERT
            Assert.Equal<int>(0, vehicleStub.AdvanceInvocations);
            Assert.Equal<int>(1, vehicleStub.TurnRightInvocations);
            Assert.Equal<int>(0, vehicleStub.TurnLeftInvocations);
        }
    }
}
