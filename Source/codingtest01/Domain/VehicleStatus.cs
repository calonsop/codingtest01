// ----------------------------------------------------------------------------
// <copyright file="VehicleStatus.cs" company="CristianAlonsoSoft">
//     Copyright © CristianAlonsoSoft. All rights reserved.
// </copyright>
// ----------------------------------------------------------------------------
namespace CodingTest01.Domain
{
    /// <summary>
    /// Defines the vehicle status.
    /// </summary>
    public struct VehicleStatus
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleStatus"/> struct.
        /// </summary>
        /// <param name="vehicle">The implicit vehicle.</param>
        public VehicleStatus(IVehicleOperations vehicle)
        {
            this.InTerrainLimits = vehicle.InValidPosition();
            this.Orientation = vehicle.CurrentOrientation;
            this.Position = vehicle.CurrentPosition;
        }

        /// <summary>
        /// Gets a value indicating whether determines if the current position of the vehicle is into the terrain limits.
        /// </summary>
        public bool InTerrainLimits { get; private set; }

        /// <summary>
        /// Gets a current vehicle orientation.
        /// </summary>
        public Orientation Orientation { get; private set; }

        /// <summary>
        /// Gets a current vehicle Position.
        /// </summary>
        public Position Position { get; private set; }

        /// <summary>
        /// Serializes the current object.
        /// </summary>
        /// <returns>The serialized value of the current object.</returns>
        public override string ToString()
        {
            return $"{this.InTerrainLimits}, {this.Orientation}, ({this.Position.X}, {this.Position.Y})";
        }
    }
}
