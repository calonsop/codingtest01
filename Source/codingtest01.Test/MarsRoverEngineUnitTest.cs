// ----------------------------------------------------------------------------
// <copyright file="MarsRoverEngineUnitTest.cs" company="CristianAlonsoSoft">
//     Copyright © CristianAlonsoSoft. All rights reserved.
// </copyright>
// ----------------------------------------------------------------------------
namespace CodingTest01.Test
{
    using System.Collections.Generic;
    using System.Linq;

    using CodingTest01.Commands;
    using CodingTest01.Domain;
    using CodingTest01.Test.Stubs;

    using Xunit;

    /// <summary>
    /// Defines the mars rover engine unit test class.
    /// </summary>
    public class MarsRoverEngineUnitTest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarsRoverEngineUnitTest"/> class.
        /// </summary>
        public MarsRoverEngineUnitTest()
        {
        }

        /// <summary>
        /// Case of test 00.
        /// </summary>
        [Fact]
        public void TestCase00()
        {
            // ARRANGE
            Terrain mars = new Terrain(5, 5);
            Vehicle rover = new Vehicle(mars);
            rover.Initialize(0, 0, Orientation.N);
            IEnumerable<VehicleCommand> commands = "AAARAARA".Select(command => VehicleCommandFactory.Build(rover, command));
            MarsRoverEngine sut = new MarsRoverEngine(rover, commands);

            // ACT
            sut.ExecuteCommands();
            var finalStatus = sut.GetCurrentVehicleStatus();

            // ASSERT
            Assert.Equal<int>(2, finalStatus.Position.X);
            Assert.Equal<int>(2, finalStatus.Position.Y);
            Assert.Equal<Orientation>(Orientation.S, finalStatus.Orientation);
            Assert.True(finalStatus.InTerrainLimits);
        }

        /// <summary>
        /// Case of test 00  with Stub Vehicle.
        /// </summary>
        [Fact]
        public void TestCase00_StubVehicle()
        {
            // ARRANGE
            VehicleOperationsStub roverStub = new VehicleOperationsStub();
            IEnumerable<VehicleCommand> commands = "AAARAARA".Select(command => VehicleCommandFactory.Build(roverStub, command));
            MarsRoverEngine sut = new MarsRoverEngine(roverStub, commands);

            // ACT
            sut.ExecuteCommands();

            // ASSERT
            Assert.Equal<int>(6, roverStub.AdvanceInvocations);
            Assert.Equal<int>(2, roverStub.TurnRightInvocations);
            Assert.Equal<int>(0, roverStub.TurnLeftInvocations);
        }

        /// <summary>
        /// Case of test 01.
        /// </summary>
        [Fact]
        public void TestCase01()
        {
            // ARRANGE
            Terrain mars = new Terrain(5, 5);
            Vehicle rover = new Vehicle(mars);
            rover.Initialize(0, 0, Orientation.N);
            IEnumerable<VehicleCommand> commands = "AAARAARAAAA".Select(command => VehicleCommandFactory.Build(rover, command));
            MarsRoverEngine sut = new MarsRoverEngine(rover, commands);

            // ACT
            sut.ExecuteCommands();
            var finalStatus = sut.GetCurrentVehicleStatus();

            // ASSERT
            Assert.Equal<int>(2, finalStatus.Position.X);
            Assert.Equal<int>(-1, finalStatus.Position.Y);
            Assert.Equal<Orientation>(Orientation.S, finalStatus.Orientation);
            Assert.False(finalStatus.InTerrainLimits);
        }

        /// <summary>
        /// Case of test 01 with Stub Vehicle.
        /// </summary>
        [Fact]
        public void TestCase01_StubVehicle()
        {
            // ARRANGE
            VehicleOperationsStub roverStub = new VehicleOperationsStub();
            IEnumerable<VehicleCommand> commands = "AAARAARAAAA".Select(command => VehicleCommandFactory.Build(roverStub, command));
            MarsRoverEngine sut = new MarsRoverEngine(roverStub, commands);

            // ACT
            sut.ExecuteCommands();

            // ASSERT
            Assert.Equal<int>(9, roverStub.AdvanceInvocations);
            Assert.Equal<int>(2, roverStub.TurnRightInvocations);
            Assert.Equal<int>(0, roverStub.TurnLeftInvocations);
        }

        /// <summary>
        /// Case of test 02.
        /// </summary>
        [Fact]
        public void TestCase02()
        {
            // ARRANGE
            Terrain mars = new Terrain(5, 5);
            Vehicle rover = new Vehicle(mars);
            rover.Initialize(0, 0, Orientation.N);
            IEnumerable<VehicleCommand> commands = "AAARAARALAALAA".Select(command => VehicleCommandFactory.Build(rover, command));
            MarsRoverEngine sut = new MarsRoverEngine(rover, commands);

            // ACT
            sut.ExecuteCommands();
            var finalStatus = sut.GetCurrentVehicleStatus();

            // ASSERT
            Assert.Equal<int>(4, finalStatus.Position.X);
            Assert.Equal<int>(4, finalStatus.Position.Y);
            Assert.Equal<Orientation>(Orientation.N, finalStatus.Orientation);
            Assert.True(finalStatus.InTerrainLimits);
        }

        /// <summary>
        /// Case of test 02 with Stub Vehicle.
        /// </summary>
        [Fact]
        public void TestCase02_StubVehicle()
        {
            // ARRANGE
            VehicleOperationsStub roverStub = new VehicleOperationsStub();
            IEnumerable<VehicleCommand> commands = "AAARAARALAALAA".Select(command => VehicleCommandFactory.Build(roverStub, command));
            MarsRoverEngine sut = new MarsRoverEngine(roverStub, commands);

            // ACT
            sut.ExecuteCommands();

            // ASSERT
            Assert.Equal<int>(10, roverStub.AdvanceInvocations);
            Assert.Equal<int>(2, roverStub.TurnRightInvocations);
            Assert.Equal<int>(2, roverStub.TurnLeftInvocations);
        }
    }
}
