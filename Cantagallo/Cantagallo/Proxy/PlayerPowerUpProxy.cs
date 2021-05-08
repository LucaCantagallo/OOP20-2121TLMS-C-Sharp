using System;
using System.Collections.Generic;
using System.Text;

namespace Cantagallo
{
    /// <summary>
    /// this class implements IPlayerPowerUp as a pattern proxy
    /// </summary>
    /// <seealso cref="IPlayerPowerUp"/>
    class PlayerPowerUpProxy : IPlayerPowerUp
    {
        private IPlayerPowerUp playerPowerUp;
        private IPlayer player;

        /// <summary>
        /// initializing
        /// </summary>
        /// <param name="playerSettings"></param>
        public PlayerPowerUpProxy (IPlayer playerSettings)
        {
            player = playerSettings;
            playerPowerUp = new PlayerPowerUpImpl(player);
        }

        /// <summary>
        /// this method works like a cache: save the player's state and gives or denies the possibility to go to the real method
        /// </summary>
        /// <param name="color"></param>
        /// <param name="speed"></param>
        /// <param name="health"></param>
        /// <param name="jumps"></param>
        private void CalledCached(PlayerColor color, int speed, int health, int jumps)
        {
            if (player.PColor != color)
            {
                playerPowerUp.Transformation(color, speed, health, jumps);
            }
        }

        /// <summary>
        /// this method doesn't change player's state but it passes his parameters to a "cache" used to analyze them
        /// </summary>
        /// <param name="color"></param>
        /// <param name="speed"></param>
        /// <param name="health"></param>
        /// <param name="jumps"></param>
        /// <seealso cref="IPlayerPowerUp.Transformation(PlayerColor, int, int, int)"/>
        public void Transformation(PlayerColor color, int speed, int health, int jumps)
        {
            CalledCached(color, speed, health, jumps);
        }
    }
}