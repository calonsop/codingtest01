// ----------------------------------------------------------------------------
// <copyright file="Vehicle.cs" company="CristianAlonsoSoft">
//     Copyright © CristianAlonsoSoft. All rights reserved.
// </copyright>
// ----------------------------------------------------------------------------
namespace CodingTest01.Domain
{
    using System;

    ////using CodingTest01.Exceptions;

    /// <summary>
    /// The Vehicle domain object.
    /// </summary>
    public class Vehicle : IVehicleOperations
    {
        /// <summary>
        /// The current position value.
        /// </summary>
        private readonly Position currentPosition;

        /// <summary>
        /// The context terrain.
        /// </summary>
        private readonly Terrain contextTerrain;

        /// <summary>
        /// Initializes a new instance of the <see cref="Vehicle"/> class.
        /// </summary>
        /// <param name="contextTerrain">The context terrain.</param>
        public Vehicle(Terrain contextTerrain)
        {
            if (contextTerrain == null)
            {
                throw new ArgumentNullException("contextTerrain");
            }

            this.contextTerrain = contextTerrain;
            this.currentPosition = new Position();
            this.CurrentOrientation = Orientation.N;
        }

        /// <summary>
        /// Gets the Vehicle's current position value.
        /// </summary>
        public Position CurrentPosition => new Position(this.currentPosition);

        /// <summary>
        /// Gets the current orientation value.
        /// </summary>
        public Orientation CurrentOrientation { get; private set; }

        /// <summary>
        /// Moves the vehicle in its front direction.
        /// </summary>
        public void Advance()
        {
            if (this.CanMove())
            {
                switch (this.CurrentOrientation)
                {
                    case Orientation.N:
                        this.currentPosition.Y++;
                        break;
                    case Orientation.E:
                        this.currentPosition.X++;
                        break;
                    case Orientation.S:
                        this.currentPosition.Y--;
                        break;
                    case Orientation.W:
                        this.currentPosition.X--;
                        break;
                }
            }
        }

        /// <summary>
        /// Turns the vehicle in left direction.
        /// </summary>
        public void TurnLeft()
        {
            if (this.CanMove())
            {
                // The orientation enum is evaluated in clockwise order between 0 and 3.
                // If we add one to the current orientation is the same that rotate in counterclockwise order.
                // If the current numeric value is lower than 0 (the min value), we add 4 to have always a value greather or equal 0, and apply the mod(4) to the value to have a value in range 0-3
                this.CurrentOrientation = (Orientation)((((int)this.CurrentOrientation) - 1 + 4) % 4);
            }
        }

        /// <summary>
        /// Turns the vehicle in left direction.
        /// </summary>
        public void TurnRight()
        {
            if (this.CanMove())
            {
                // The orientation enum is evaluated in clockwise order between 0 and 3.
                // If we substract one to the current orientation is the same that rotate in clockwise order.
                // If the current numeric value is greather than 3 (the max value), we apply the mod(4) to the value to have a value in range 0-3
                this.CurrentOrientation = (Orientation)((((int)this.CurrentOrientation) + 1) % 4);
            }
        }

        /// <summary>
        /// Verifies the current position and determines if is valid.
        /// </summary>
        /// <returns><b>True</b> if the current position is valid, <b>False</b> in otherwise.</returns>
        /// <remarks>The position is valid only if there is into the terrain boundaries.</remarks>
        public bool InValidPosition()
        {
            return this.currentPosition.X >= default(int) &&
                  this.currentPosition.Y >= default(int) &&
                  this.currentPosition.X < this.contextTerrain.Witdh &&
                  this.currentPosition.Y < this.contextTerrain.Height;
        }

        /// <summary>
        /// Initilizes the vehicle into the world.
        /// </summary>
        /// <param name="posX">The initial X position.</param>
        /// <param name="posY">The initial Y position.</param>
        /// <param name="orientation">The initial orientation.</param>
        public void Initialize(int posX, int posY, Orientation orientation)
        {
            this.currentPosition.X = posX;
            this.currentPosition.Y = posY;
            ////if (!this.InValidPosition())
            ////{
            ////    throw new InvalidPositionException(this.currentPosition);
            ////}

            this.CurrentOrientation = orientation;
        }

        /// <summary>
        /// Gets the current status of the vehicle.
        /// </summary>
        /// <returns>The current status of the vehicle.</returns>
        public VehicleStatus GetCurrentStatus()
        {
            return new VehicleStatus(this);
        }

        /// <summary>
        /// Determines if the vehicle can move.
        /// </summary>
        /// <returns><b>True</b> if the vehicle can move, <b>False</b> in otherwise.</returns>
        /// <remarks>
        /// I determined that the vehicle only can move if it is in valid position.
        /// In otherwise, i assume that i lost the vehicle control.
        /// </remarks>
        private bool CanMove()
        {
            return this.InValidPosition();
        }
    }
}