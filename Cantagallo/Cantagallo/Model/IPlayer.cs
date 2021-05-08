using System;
using System.Collections.Generic;
using System.Text;

namespace Cantagallo
{
    /// <summary>
    /// This interface gets and sets the values ​​of the main characteristics of the player
    /// </summary>
	public interface IPlayer
	{
        /// <summary>
        /// speed's getter and setter
        /// </summary>
        /// <returns>
        /// valid only for the setter. Setter returns player's speed
        /// </returns>
		int Speed { get; set; }

        /// <summary>
        /// speed's getter and setter
        /// </summary>
        /// <returns>
        /// valid only for the setter. Setter returns player's  current avaiable jumps
        /// </returns>
        int JumpCounter { get; set; }

        /// <summary>
        /// speed's getter and setter
        /// </summary>
        /// <returns>
        /// valid only for the setter. Setter returns player's max number of jumps avaible
        /// </returns>
        int MaxJumps { get; set; }

        /// <summary>
        /// speed's getter and setter
        /// </summary>
        /// <returns>
        /// valid only for the setter. Setter returns player's  jumps height
        /// </returns>
        int JumpsHeight { get; set; }

        /// <summary>
        /// speed's getter and setter
        /// </summary>
        /// <returns>
        /// valid only for the setter. Setter returns player's life missing
        /// </returns>
        int Health { get; set; }

        /// <summary>
        /// speed's getter and setter
        /// </summary>   
        /// <returns>
        /// valid only for the setter. Setter returns max value of player's life
        /// </returns>
        int MaxHealth { get; set; }

        /// <summary>
        /// speed's getter and setter
        /// </summary>
        /// <returns>
        /// valid only for the setter. Setter returns player's dimension
        /// </returns>
        double Dimension { get; set; }

        /// <summary>
        /// speed's getter and setter
        /// </summary>
        /// <returns>
        /// valid only for the setter. Setter returns player's color
        /// </returns>
        PlayerColor PColor { get; set; }

        /// <summary>
        /// number of jumps available returns to the maximum
        /// </summary>
        void ResetNJumps();

        /// <summary>
        /// decrease number of jumps
        /// </summary>
		void DecreaseJumps();

	}
}
