using System;
using System.Collections.Generic;
using System.Text;

namespace Cantagallo
{
    /// <summary>
    /// This interface contains transformation method.
    /// </summary>
    interface IPlayerPowerUp
    {
        /// <summary>
        /// this method changes some player's values
        /// </summary>
        /// <param name="color"></param>
        /// <param name="speed"></param>
        /// <param name="health"></param>
        /// <param name="jumps"></param>
        void Transformation(PlayerColor color, int speed, int health, int jumps);
    }
}
