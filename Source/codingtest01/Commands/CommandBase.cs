// ----------------------------------------------------------------------------
// <copyright file="CommandBase.cs" company="CristianAlonsoSoft">
//     Copyright © CristianAlonsoSoft. All rights reserved.
// </copyright>
// ----------------------------------------------------------------------------

namespace CodingTest01.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Defines the base class for our commands.
    /// </summary>
    public abstract class CommandBase
    {
        /// <summary>
        /// The executation method.
        /// </summary>
        public abstract void Execute();
    }
}
