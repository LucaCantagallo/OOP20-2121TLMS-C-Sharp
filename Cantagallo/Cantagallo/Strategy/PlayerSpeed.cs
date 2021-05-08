using System;
using System.Collections.Generic;
using System.Text;

namespace Cantagallo
{
    /// <summary>
    /// this is the implementation of "IPlayerSpeedStrategy" that compares with input parameters
    /// </summary>
    class PlayerSpeed : IPlayerSpeedStrategy
    {
        private IPlayer player;

        /// <summary>
        /// initializing with player's values
        /// </summary>
        /// <param name="playerSettings"></param>
        public PlayerSpeed (IPlayer playerSettings)
        {
            player = playerSettings;
        }

        /// <summary>
        /// this method returns player's speed
        /// </summary>
        /// <seealso cref="IPlayerSpeedStrategy.Velocity"/>
        public int Velocity => player.Speed;
    }
}
