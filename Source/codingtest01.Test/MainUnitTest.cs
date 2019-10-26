// ----------------------------------------------------------------------------
// <copyright file="MainUnitTest.cs" company="CristianAlonsoSoft">
//     Copyright © CristianAlonsoSoft. All rights reserved.
// </copyright>
// ----------------------------------------------------------------------------
namespace CodingTest01.Test
{
    using System;
    using CodingTest01.Test.Dummies;

    using Xunit;

    /// <summary>
    /// Defines the test class of the Main class.
    /// </summary>
    public class MainUnitTest
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MainUnitTest"/> class.
        /// </summary>
        public MainUnitTest()
        {
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Verifies that with the Main class behavior its ok with valid parameters.
        /// </summary>
        [Fact]
        public void MainInputParamsAreCorrect()
        {
            // ARRANGE
            MainArgsDummy arguments = new MainArgsDummy();
            arguments.TerrainWidth = 5.ToString();
            arguments.TerrainHeight = 5.ToString();
            arguments.RoverX = 0.ToString();
            arguments.RoverY = 0.ToString();
            arguments.RoverO = 'N'.ToString();
            arguments.Commands = "AAAA";

            var args = arguments.GenerateCommandLineArgs();

            // ACT
            Func<int> actTodo = () => Program.Main(args);

            // ASSERT
            Assert.Equal<int>(0, actTodo.Invoke());
        }

        #endregion Methods
    }
}