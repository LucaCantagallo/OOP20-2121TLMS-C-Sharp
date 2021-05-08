using System;
using System.Collections.Generic;
using System.Text;

namespace Cantagallo
{
    /// <summary>
    /// Interface used as a strategy to decide speed's value
    /// </summary>
    interface IPlayerSpeedStrategy
    {
        /// <summary>
        /// this method is used to get the actual player's speed
        /// </summary>
        int Velocity { get; }
    }
}
