// ----------------------------------------------------------------------------
// <copyright file="VehicleCommandFactoryUnitTest.cs" company="CristianAlonsoSoft">
//     Copyright © CristianAlonsoSoft. All rights reserved.
// </copyright>
// ----------------------------------------------------------------------------
namespace CodingTest01.Test
{
    using System;
    using CodingTest01.Commands;
    using CodingTest01.Domain;
    using CodingTest01.Exceptions;
    using CodingTest01.Test.Dummies;

    using Xunit;

    /// <summary>
    /// Defines the test class of the commadns class.
    /// </summary>
    public class VehicleCommandFactoryUnitTest
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleCommandFactoryUnitTest"/> class.
        /// </summary>
        public VehicleCommandFactoryUnitTest()
        {
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Verifies if the factory builds an vehicle advance command correctly.
        /// The command is introduced in upper case.
        /// </summary>
        [Fact]
        public void BuildCommandAdvance_MustBeCorrectUpperCase()
        {
            // ARRANGE
            Terrain terrain = new Terrain(default(uint), default(uint));
            Vehicle vehicle = new Vehicle(terrain);
            char commandKey = 'A';

            // ACT
            var command = VehicleCommandFactory.Build(vehicle, commandKey);

            // ASSERT
            Assert.NotNull(command);
            Assert.Equal<Type>(typeof(VehicleAdvanceCommand), command.GetType());
        }

        /// <summary>
        /// Verifies if the factory builds an vehicle advance command correctly.
        /// The command is introduced in lower case.
        /// </summary>
        [Fact]
        public void BuildCommandAdvance_MustBeCorrectLoweCase()
        {
            // ARRANGE
            Terrain terrain = new Terrain(default(uint), default(uint));
            Vehicle vehicle = new Vehicle(terrain);
            char commandKey = 'a';

            // ACT
            var command = VehicleCommandFactory.Build(vehicle, commandKey);

            // ASSERT
            Assert.NotNull(command);
            Assert.Equal<Type>(typeof(VehicleAdvanceCommand), command.GetType());
        }

        /// <summary>
        /// Verifies if the factory builds an vehicle  turn feft command correctly.
        /// The command is introduced in upper case.
        /// </summary>
        [Fact]
        public void BuildCommandTurnLeft_MustBeCorrectUpperCase()
        {
            // ARRANGE
            Terrain terrain = new Terrain(default(uint), default(uint));
            Vehicle vehicle = new Vehicle(terrain);
            char commandKey = 'L';

            // ACT
            var command = VehicleCommandFactory.Build(vehicle, commandKey);

            // ASSERT
            Assert.NotNull(command);
            Assert.Equal<Type>(typeof(VehicleTurnLeftCommand), command.GetType());
        }

        /// <summary>
        /// Verifies if the factory builds an vehicle turn feft command correctly.
        /// The command is introduced in lower case.
        /// </summary>
        [Fact]
        public void BuildCommandTurnLeft_MustBeCorrectLoweCase()
        {
            // ARRANGE
            Terrain terrain = new Terrain(default(uint), default(uint));
            Vehicle vehicle = new Vehicle(terrain);
            char commandKey = 'l';

            // ACT
            var command = VehicleCommandFactory.Build(vehicle, commandKey);

            // ASSERT
            Assert.NotNull(command);
            Assert.Equal<Type>(typeof(VehicleTurnLeftCommand), command.GetType());
        }

        /// <summary>
        /// Verifies if the factory builds an vehicle  turn right command correctly.
        /// The command is introduced in upper case.
        /// </summary>
        [Fact]
        public void BuildCommandTurnRight_MustBeCorrectUpperCase()
        {
            // ARRANGE
            Terrain terrain = new Terrain(default(uint), default(uint));
            Vehicle vehicle = new Vehicle(terrain);
            char commandKey = 'R';

            // ACT
            var command = VehicleCommandFactory.Build(vehicle, commandKey);

            // ASSERT
            Assert.NotNull(command);
            Assert.Equal<Type>(typeof(VehicleTurnRightCommand), command.GetType());
        }

        /// <summary>
        /// Verifies if the factory builds an vehicle turn right command correctly.
        /// The command is introduced in lower case.
        /// </summary>
        [Fact]
        public void BuildCommandTurnRight_MustBeCorrectLoweCase()
        {
            // ARRANGE
            Terrain terrain = new Terrain(default(uint), default(uint));
            Vehicle vehicle = new Vehicle(terrain);
            char commandKey = 'r';

            // ACT
            var command = VehicleCommandFactory.Build(vehicle, commandKey);

            // ASSERT
            Assert.NotNull(command);
            Assert.Equal<Type>(typeof(VehicleTurnRightCommand), command.GetType());
        }

        /// <summary>
        /// Verifies that the command passed as a parameter belongs an unknown command, throws a InvalidCommandException.
        /// The command is introduced in lower case.
        /// </summary>
        [Fact]
        public void UnknownCommand_MustThrowInvalidCommandException()
        {
            // ARRANGE
            Terrain terrain = new Terrain(default(uint), default(uint));
            Vehicle vehicle = new Vehicle(terrain);
            char commandKey = 'x';

            // ACT
            Func<VehicleCommand> actTodo = () => VehicleCommandFactory.Build(vehicle, commandKey);

            // ASSERT
            Assert.Throws<InvalidCommandException>(() => actTodo.Invoke());
        }

        #endregion Methods
    }
}