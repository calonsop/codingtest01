// ----------------------------------------------------------------------------
// <copyright file="VehicleUnitTest.cs" company="CristianAlonsoSoft">
//     Copyright © CristianAlonsoSoft. All rights reserved.
// </copyright>
// ----------------------------------------------------------------------------
namespace CodingTest01.Test
{
    using System;

    using CodingTest01.Domain;
    using Xunit;

    /// <summary>
    /// Defines the vehicle unit test.
    /// </summary>
    public class VehicleUnitTest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleUnitTest"/> class.
        /// </summary>
        public VehicleUnitTest()
        {
        }

        /// <summary>
        /// Verifies the constructor.
        /// </summary>
        [Fact]
        public void VerifyConstructor()
        {
            // ARRANGE
            Terrain terrain = new Terrain(5, 5);
            Vehicle sut;

            // ACT
            sut = new Vehicle(terrain);

            // ASSERT
            Assert.Equal<Orientation>(Orientation.N, sut.CurrentOrientation);
            Assert.Equal<int>(default(int), sut.CurrentPosition.X);
            Assert.Equal<int>(default(int), sut.CurrentPosition.Y);
            Assert.True(sut.InValidPosition());
        }

        /// <summary>
        /// Verifies the constructor.
        /// The construct must throw exception when the terrain is null.
        /// </summary>
        [Fact]
        public void VerifyConstructor_TerrainMustBeSet()
        {
            // ARRANGE
            Terrain terrain = null;
            Vehicle sut;

            // ACT
            Action actTodo = () => sut = new Vehicle(terrain);

            // ASSERT
            Assert.Throws<ArgumentNullException>(actTodo);
        }

        /// <summary>
        /// Verifies the initialization in valid position.
        /// </summary>
        [Fact]
        public void Initalices_InValidPosition()
        {
            // ARRANGE
            Terrain terrain = new Terrain(5, 5);
            Vehicle sut = new Vehicle(terrain);

            // ACT
            sut.Initialize(1, 2, Orientation.S);

            // ASSERT
            Assert.Equal<int>(1, sut.CurrentPosition.X);
            Assert.Equal<int>(2, sut.CurrentPosition.Y);
            Assert.Equal<Orientation>(Orientation.S, sut.CurrentOrientation);
            Assert.True(sut.InValidPosition());
        }

        /// <summary>
        /// Verifies the initialization in not valid position.
        /// </summary>
        [Fact]
        public void Initalices_InNotValidPosition()
        {
            // ARRANGE
            Terrain terrain = new Terrain(5, 5);
            Vehicle sut = new Vehicle(terrain);

            // ACT
            sut.Initialize(6, 2, Orientation.S);

            // ASSERT
            Assert.Equal<int>(6, sut.CurrentPosition.X);
            Assert.Equal<int>(2, sut.CurrentPosition.Y);
            Assert.Equal<Orientation>(Orientation.S, sut.CurrentOrientation);
            Assert.False(sut.InValidPosition());
        }

        /// <summary>
        /// Verifies the advance movement, when the vehicle can move, and its orientation is North, and the destination position is valid.
        /// </summary>
        [Fact]
        public void Advance_CanMoveToNorthToValidPosition()
        {
            // ARRANGE
            Terrain terrain = new Terrain(5, 5);
            Vehicle sut = new Vehicle(terrain);
            sut.Initialize(0, 0, Orientation.N);

            // ACT
            sut.Advance();

            // ASSERT
            Assert.Equal<int>(0, sut.CurrentPosition.X);
            Assert.Equal<int>(1, sut.CurrentPosition.Y);
            Assert.Equal<Orientation>(Orientation.N, sut.CurrentOrientation);
            Assert.True(sut.InValidPosition());
        }

        /// <summary>
        /// Verifies the advance movement, when the vehicle can move, and its orientation is North, and the destination position is not valid.
        /// </summary>
        [Fact]
        public void Advance_CanMoveToNorthToNotValidPosition()
        {
            // ARRANGE
            Terrain terrain = new Terrain(5, 5);
            Vehicle sut = new Vehicle(terrain);
            sut.Initialize(0, 4, Orientation.N);

            // ACT
            sut.Advance();

            // ASSERT
            Assert.Equal<int>(0, sut.CurrentPosition.X);
            Assert.Equal<int>(5, sut.CurrentPosition.Y);
            Assert.Equal<Orientation>(Orientation.N, sut.CurrentOrientation);
            Assert.False(sut.InValidPosition());
        }

        /// <summary>
        /// Verifies the advance movement, when the vehicle can move, and its orientation is South, and the destination position is valid.
        /// </summary>
        [Fact]
        public void Advance_CanMoveToSouthToValidPosition()
        {
            // ARRANGE
            Terrain terrain = new Terrain(5, 5);
            Vehicle sut = new Vehicle(terrain);
            sut.Initialize(0, 4, Orientation.S);

            // ACT
            sut.Advance();

            // ASSERT
            Assert.Equal<int>(0, sut.CurrentPosition.X);
            Assert.Equal<int>(3, sut.CurrentPosition.Y);
            Assert.Equal<Orientation>(Orientation.S, sut.CurrentOrientation);
            Assert.True(sut.InValidPosition());
        }

        /// <summary>
        /// Verifies the advance movement, when the vehicle can move, and its orientation is South, and the destination position is not valid.
        /// </summary>
        [Fact]
        public void Advance_CanMoveToSouthToNotValidPosition()
        {
            // ARRANGE
            Terrain terrain = new Terrain(5, 5);
            Vehicle sut = new Vehicle(terrain);
            sut.Initialize(0, 0, Orientation.S);

            // ACT
            sut.Advance();

            // ASSERT
            Assert.Equal<int>(0, sut.CurrentPosition.X);
            Assert.Equal<int>(-1, sut.CurrentPosition.Y);
            Assert.Equal<Orientation>(Orientation.S, sut.CurrentOrientation);
            Assert.False(sut.InValidPosition());
        }

        /// <summary>
        /// Verifies the advance movement, when the vehicle can move, and its orientation is East, and the destination position is valid.
        /// </summary>
        [Fact]
        public void Advance_CanMoveToEastToValidPosition()
        {
            // ARRANGE
            Terrain terrain = new Terrain(5, 5);
            Vehicle sut = new Vehicle(terrain);
            sut.Initialize(0, 0, Orientation.E);

            // ACT
            sut.Advance();

            // ASSERT
            Assert.Equal<int>(1, sut.CurrentPosition.X);
            Assert.Equal<int>(0, sut.CurrentPosition.Y);
            Assert.Equal<Orientation>(Orientation.E, sut.CurrentOrientation);
            Assert.True(sut.InValidPosition());
        }

        /// <summary>
        /// Verifies the advance movement, when the vehicle can move, and its orientation is East, and the destination position is not valid.
        /// </summary>
        [Fact]
        public void Advance_CanMoveToEastToNotValidPosition()
        {
            // ARRANGE
            Terrain terrain = new Terrain(5, 5);
            Vehicle sut = new Vehicle(terrain);
            sut.Initialize(4, 0, Orientation.E);

            // ACT
            sut.Advance();

            // ASSERT
            Assert.Equal<int>(5, sut.CurrentPosition.X);
            Assert.Equal<int>(0, sut.CurrentPosition.Y);
            Assert.Equal<Orientation>(Orientation.E, sut.CurrentOrientation);
            Assert.False(sut.InValidPosition());
        }

        /// <summary>
        /// Verifies the advance movement, when the vehicle can move, and its orientation is West, and the destination position is valid.
        /// </summary>
        [Fact]
        public void Advance_CanMoveToWestToValidPosition()
        {
            // ARRANGE
            Terrain terrain = new Terrain(5, 5);
            Vehicle sut = new Vehicle(terrain);
            sut.Initialize(4, 0, Orientation.W);

            // ACT
            sut.Advance();

            // ASSERT
            Assert.Equal<int>(3, sut.CurrentPosition.X);
            Assert.Equal<int>(0, sut.CurrentPosition.Y);
            Assert.Equal<Orientation>(Orientation.W, sut.CurrentOrientation);
            Assert.True(sut.InValidPosition());
        }

        /// <summary>
        /// Verifies the advance movement, when the vehicle can move, and its orientation is West, and the destination position is not valid.
        /// </summary>
        [Fact]
        public void Advance_CanMoveToWestToNotValidPosition()
        {
            // ARRANGE
            Terrain terrain = new Terrain(5, 5);
            Vehicle sut = new Vehicle(terrain);
            sut.Initialize(0, 0, Orientation.W);

            // ACT
            sut.Advance();

            // ASSERT
            Assert.Equal<int>(-1, sut.CurrentPosition.X);
            Assert.Equal<int>(0, sut.CurrentPosition.Y);
            Assert.Equal<Orientation>(Orientation.W, sut.CurrentOrientation);
            Assert.False(sut.InValidPosition());
        }

        /// <summary>
        /// Verifies that when the current position is invalid, the vehicle can't advance.
        /// </summary>
        [Fact]
        public void Advance_CanNotMove()
        {
            // ARRANGE
            Terrain terrain = new Terrain(5, 5);
            Vehicle sut = new Vehicle(terrain);
            sut.Initialize(6, 0, Orientation.W);

            // ACT
            sut.Advance();

            // ASSERT
            Assert.Equal<int>(6, sut.CurrentPosition.X);
            Assert.Equal<int>(0, sut.CurrentPosition.Y);
            Assert.Equal<Orientation>(Orientation.W, sut.CurrentOrientation);
            Assert.False(sut.InValidPosition());
        }

        /// <summary>
        /// Verifies that when the current position is invalid, the vehicle can't rotate to left.
        /// </summary>
        [Fact]
        public void RotateLeft_CanNotMove()
        {
            // ARRANGE
            Terrain terrain = new Terrain(5, 5);
            Vehicle sut = new Vehicle(terrain);
            sut.Initialize(6, 0, Orientation.W);

            // ACT
            sut.TurnLeft();

            // ASSERT
            Assert.Equal<int>(6, sut.CurrentPosition.X);
            Assert.Equal<int>(0, sut.CurrentPosition.Y);
            Assert.Equal<Orientation>(Orientation.W, sut.CurrentOrientation);
            Assert.False(sut.InValidPosition());
        }

        /// <summary>
        /// Verifies that when the current position is invalid, the vehicle can't rotate to right.
        /// </summary>
        [Fact]
        public void RotateRight_CanNotMove()
        {
            // ARRANGE
            Terrain terrain = new Terrain(5, 5);
            Vehicle sut = new Vehicle(terrain);
            sut.Initialize(6, 0, Orientation.W);

            // ACT
            sut.TurnRight();

            // ASSERT
            Assert.Equal<int>(6, sut.CurrentPosition.X);
            Assert.Equal<int>(0, sut.CurrentPosition.Y);
            Assert.Equal<Orientation>(Orientation.W, sut.CurrentOrientation);
            Assert.False(sut.InValidPosition());
        }

        /// <summary>
        /// Verifies the turn to left movement, when the vehicle can move, and its orientation is North.
        /// </summary>
        [Fact]
        public void TurnLeft_CanMoveFromNorth()
        {
            // ARRANGE
            Terrain terrain = new Terrain(5, 5);
            Vehicle sut = new Vehicle(terrain);
            sut.Initialize(0, 0, Orientation.N);

            // ACT
            sut.TurnLeft();

            // ASSERT
            Assert.Equal<int>(0, sut.CurrentPosition.X);
            Assert.Equal<int>(0, sut.CurrentPosition.Y);
            Assert.Equal<Orientation>(Orientation.W, sut.CurrentOrientation);
            Assert.True(sut.InValidPosition());
        }

        /// <summary>
        /// Verifies the turn to left movement, when the vehicle can move, and its orientation is West.
        /// </summary>
        [Fact]
        public void TurnLeft_CanMoveFromWest()
        {
            // ARRANGE
            Terrain terrain = new Terrain(5, 5);
            Vehicle sut = new Vehicle(terrain);
            sut.Initialize(0, 0, Orientation.W);

            // ACT
            sut.TurnLeft();

            // ASSERT
            Assert.Equal<int>(0, sut.CurrentPosition.X);
            Assert.Equal<int>(0, sut.CurrentPosition.Y);
            Assert.Equal<Orientation>(Orientation.S, sut.CurrentOrientation);
            Assert.True(sut.InValidPosition());
        }

        /// <summary>
        /// Verifies the turn to left movement, when the vehicle can move, and its orientation is South.
        /// </summary>
        [Fact]
        public void TurnLeft_CanMoveFromSouth()
        {
            // ARRANGE
            Terrain terrain = new Terrain(5, 5);
            Vehicle sut = new Vehicle(terrain);
            sut.Initialize(0, 0, Orientation.S);

            // ACT
            sut.TurnLeft();

            // ASSERT
            Assert.Equal<int>(0, sut.CurrentPosition.X);
            Assert.Equal<int>(0, sut.CurrentPosition.Y);
            Assert.Equal<Orientation>(Orientation.E, sut.CurrentOrientation);
            Assert.True(sut.InValidPosition());
        }

        /// <summary>
        /// Verifies the turn to left movement, when the vehicle can move, and its orientation is East.
        /// </summary>
        [Fact]
        public void TurnLeft_CanMoveFromEast()
        {
            // ARRANGE
            Terrain terrain = new Terrain(5, 5);
            Vehicle sut = new Vehicle(terrain);
            sut.Initialize(0, 0, Orientation.E);

            // ACT
            sut.TurnLeft();

            // ASSERT
            Assert.Equal<int>(0, sut.CurrentPosition.X);
            Assert.Equal<int>(0, sut.CurrentPosition.Y);
            Assert.Equal<Orientation>(Orientation.N, sut.CurrentOrientation);
            Assert.True(sut.InValidPosition());
        }

        /// <summary>
        /// Verifies the turn to right movement, when the vehicle can move, and its orientation is North.
        /// </summary>
        [Fact]
        public void TurnRight_CanMoveFromNorth()
        {
            // ARRANGE
            Terrain terrain = new Terrain(5, 5);
            Vehicle sut = new Vehicle(terrain);
            sut.Initialize(0, 0, Orientation.N);

            // ACT
            sut.TurnRight();

            // ASSERT
            Assert.Equal<int>(0, sut.CurrentPosition.X);
            Assert.Equal<int>(0, sut.CurrentPosition.Y);
            Assert.Equal<Orientation>(Orientation.E, sut.CurrentOrientation);
            Assert.True(sut.InValidPosition());
        }

        /// <summary>
        /// Verifies the turn to right movement, when the vehicle can move, and its orientation is West.
        /// </summary>
        [Fact]
        public void TurnRight_CanMoveFromWest()
        {
            // ARRANGE
            Terrain terrain = new Terrain(5, 5);
            Vehicle sut = new Vehicle(terrain);
            sut.Initialize(0, 0, Orientation.W);

            // ACT
            sut.TurnRight();

            // ASSERT
            Assert.Equal<int>(0, sut.CurrentPosition.X);
            Assert.Equal<int>(0, sut.CurrentPosition.Y);
            Assert.Equal<Orientation>(Orientation.N, sut.CurrentOrientation);
            Assert.True(sut.InValidPosition());
        }

        /// <summary>
        /// Verifies the turn to right movement, when the vehicle can move, and its orientation is South.
        /// </summary>
        [Fact]
        public void TurnRight_CanMoveFromSouth()
        {
            // ARRANGE
            Terrain terrain = new Terrain(5, 5);
            Vehicle sut = new Vehicle(terrain);
            sut.Initialize(0, 0, Orientation.S);

            // ACT
            sut.TurnRight();

            // ASSERT
            Assert.Equal<int>(0, sut.CurrentPosition.X);
            Assert.Equal<int>(0, sut.CurrentPosition.Y);
            Assert.Equal<Orientation>(Orientation.W, sut.CurrentOrientation);
            Assert.True(sut.InValidPosition());
        }

        /// <summary>
        /// Verifies the turn to right movement, when the vehicle can move, and its orientation is East.
        /// </summary>
        [Fact]
        public void TurnRight_CanMoveFromEast()
        {
            // ARRANGE
            Terrain terrain = new Terrain(5, 5);
            Vehicle sut = new Vehicle(terrain);
            sut.Initialize(0, 0, Orientation.E);

            // ACT
            sut.TurnRight();

            // ASSERT
            Assert.Equal<int>(0, sut.CurrentPosition.X);
            Assert.Equal<int>(0, sut.CurrentPosition.Y);
            Assert.Equal<Orientation>(Orientation.S, sut.CurrentOrientation);
            Assert.True(sut.InValidPosition());
        }

        /// <summary>
        /// Verifies the current element is in not valid position becouse is out of boundaries in North direction.
        /// </summary>
        [Fact]
        public void InValidPosition_InNotValidNorth()
        {
            // ARRANGE
            Terrain terrain = new Terrain(5, 5);
            Vehicle sut = new Vehicle(terrain);
            sut.Initialize(0, 5, Orientation.N);

            // ACT
            sut.InValidPosition();

            // ASSERT
            Assert.Equal<int>(0, sut.CurrentPosition.X);
            Assert.Equal<int>(5, sut.CurrentPosition.Y);
            Assert.Equal<Orientation>(Orientation.N, sut.CurrentOrientation);
            Assert.False(sut.InValidPosition());
        }

        /// <summary>
        /// Verifies the current element is in not valid position becouse is out of boundaries in South direction.
        /// </summary>
        [Fact]
        public void InValidPosition_InNotValidSouth()
        {
            // ARRANGE
            Terrain terrain = new Terrain(5, 5);
            Vehicle sut = new Vehicle(terrain);
            sut.Initialize(0, -1, Orientation.N);

            // ACT
            sut.InValidPosition();

            // ASSERT
            Assert.Equal<int>(0, sut.CurrentPosition.X);
            Assert.Equal<int>(-1, sut.CurrentPosition.Y);
            Assert.Equal<Orientation>(Orientation.N, sut.CurrentOrientation);
            Assert.False(sut.InValidPosition());
        }

        /// <summary>
        /// Verifies the current element is in not valid position becouse is out of boundaries in East direction.
        /// </summary>
        [Fact]
        public void InValidPosition_InNotValidEast()
        {
            // ARRANGE
            Terrain terrain = new Terrain(5, 5);
            Vehicle sut = new Vehicle(terrain);
            sut.Initialize(5, 0, Orientation.N);

            // ACT
            sut.InValidPosition();

            // ASSERT
            Assert.Equal<int>(5, sut.CurrentPosition.X);
            Assert.Equal<int>(0, sut.CurrentPosition.Y);
            Assert.Equal<Orientation>(Orientation.N, sut.CurrentOrientation);
            Assert.False(sut.InValidPosition());
        }

        /// <summary>
        /// Verifies the current element is in not valid position becouse is out of boundaries in West direction.
        /// </summary>
        [Fact]
        public void InValidPosition_InNotValidWest()
        {
            // ARRANGE
            Terrain terrain = new Terrain(5, 5);
            Vehicle sut = new Vehicle(terrain);
            sut.Initialize(-1, 0, Orientation.N);

            // ACT
            sut.InValidPosition();

            // ASSERT
            Assert.Equal<int>(-1, sut.CurrentPosition.X);
            Assert.Equal<int>(0, sut.CurrentPosition.Y);
            Assert.Equal<Orientation>(Orientation.N, sut.CurrentOrientation);
            Assert.False(sut.InValidPosition());
        }

        /// <summary>
        /// Verifies the current element is in not valid position becouse is out of boundaries in West direction.
        /// </summary>
        [Fact]
        public void GetCurrentStatus()
        {
            // ARRANGE
            Terrain terrain = new Terrain(5, 5);
            Vehicle sut = new Vehicle(terrain);
            sut.Initialize(2, 0, Orientation.E);

            // ACT
            var currentStatus = sut.GetCurrentStatus();

            // ASSERT
            Assert.Equal<int>(2, currentStatus.Position.X);
            Assert.Equal<int>(0, currentStatus.Position.Y);
            Assert.Equal<Orientation>(Orientation.E, currentStatus.Orientation);
            Assert.True(sut.InValidPosition());
        }
    }
}
