// ----------------------------------------------------------------------------
// <copyright file="VehicleAdvanceCommandUnitTest.cs" company="CristianAlonsoSoft">
//     Copyright © CristianAlonsoSoft. All rights reserved.
// </copyright>
// ----------------------------------------------------------------------------
namespace CodingTest01.Test
{
    using CodingTest01.Commands;
    using CodingTest01.Test.Stubs;
    using Xunit;

    /// <summary>
    /// Defines the unit test class for the vehicle advance command.
    /// </summary>
    public class VehicleAdvanceCommandUnitTest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleAdvanceCommandUnitTest"/> class.
        /// </summary>
        public VehicleAdvanceCommandUnitTest()
        {
        }

        /// <summary>
        /// Verifies that executes method calls one time to advance method of the vehicle.
        /// </summary>
        [Fact]
        public void Execute_MustExecuteTheAdvanceOperation()
        {
            // ARRANCE
            VehicleCommandsStub vehicleStub = new VehicleCommandsStub();
            VehicleAdvanceCommand sut = new VehicleAdvanceCommand(vehicleStub);

            // ACT
            sut.Execute();

            // ASSERT
            Assert.Equal<int>(1, vehicleStub.AdvanceInvocations);
            Assert.Equal<int>(0, vehicleStub.TurnRightInvocations);
            Assert.Equal<int>(0, vehicleStub.TurnLeftInvocations);
        }
    }
}
