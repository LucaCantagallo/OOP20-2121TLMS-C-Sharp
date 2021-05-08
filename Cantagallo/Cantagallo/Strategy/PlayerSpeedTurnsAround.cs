using System;
using System.Collections.Generic;
using System.Text;

namespace Cantagallo
{
    /// <summary>
    /// this class is used to return another value for the speed (speed = 0)
    /// </summary>
    class PlayerSpeedTurnsAround : IPlayerSpeedStrategy
    {
        private readonly int velocity = 0;

        /// <summary>
        /// this method return velocity = 0
        /// </summary>
        /// <seealso cref="IPlayerSpeedStrategy.Velocity"/>
        public int Velocity => velocity;
    }
}
