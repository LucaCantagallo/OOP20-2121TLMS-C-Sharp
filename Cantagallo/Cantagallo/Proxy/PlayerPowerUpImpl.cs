using System;
using System.Collections.Generic;
using System.Text;

namespace Cantagallo
{
    /// <summary>
    /// this is the class which implements the interface IPlayerPowerUp where the real transformation takes place
    /// </summary>
    /// <seealso cref="IPlayerPowerUp"/>
    class PlayerPowerUpImpl : IPlayerPowerUp
    {
        private IPlayer player;

        /// <summary>
        /// power-up initializing
        /// </summary>
        /// <param name="playerSettings"></param>
        public PlayerPowerUpImpl(IPlayer playerSettings)
        {
            player = playerSettings;
        }

        /// <param name="color"></param>
        /// <param name="speed"></param>
        /// <param name="health"></param>
        /// <param name="jumps"></param>
        /// <seealso cref="IPlayerPowerUp.Transformation(PlayerColor, int, int, int)"/>
        public void Transformation(PlayerColor color, int speed, int health, int jumps)
        {
            player.PColor = color;
            player.Speed = speed;
            player.Health = health;
            player.MaxJumps = jumps;
        }
    }
}
