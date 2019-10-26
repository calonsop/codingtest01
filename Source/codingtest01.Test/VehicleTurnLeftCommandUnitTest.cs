// ----------------------------------------------------------------------------
// <copyright file="VehicleTurnLeftCommandUnitTest.cs" company="CristianAlonsoSoft">
//     Copyright © CristianAlonsoSoft. All rights reserved.
// </copyright>
// ----------------------------------------------------------------------------
namespace CodingTest01.Test
{
    using CodingTest01.Commands;
    using CodingTest01.Test.Stubs;
    using Xunit;

    /// <summary>
    /// Defines the unit test class for the vehicle TurnLeft command.
    /// </summary>
    public class VehicleTurnLeftCommandUnitTest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleTurnLeftCommandUnitTest"/> class.
        /// </summary>
        public VehicleTurnLeftCommandUnitTest()
        {
        }

        /// <summary>
        /// Verifies that executes method calls one time to turnleft method of the vehicle.
        /// </summary>
        [Fact]
        public void Execute_MustExecuteTheAdvanceOperation()
        {
            // ARRANCE
            VehicleCommandsStub vehicleStub = new VehicleCommandsStub();
            VehicleTurnLeftCommand sut = new VehicleTurnLeftCommand(vehicleStub);

            // ACT
            sut.Execute();

            // ASSERT
            Assert.Equal<int>(0, vehicleStub.AdvanceInvocations);
            Assert.Equal<int>(0, vehicleStub.TurnRightInvocations);
            Assert.Equal<int>(1, vehicleStub.TurnLeftInvocations);
        }
    }
}
