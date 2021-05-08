using System;
using System.Collections.Generic;
using System.Text;

namespace Cantagallo
{
    /// <summary>
    /// this is the implementation of "IPlayerImplementation"
    /// </summary>
    /// <seealso cref="IPlayer"/>
    partial class PlayerImpl : IPlayer
    {

        public PlayerImpl()
        {
            Speed = 450;
            MaxJumps = 1;
            JumpCounter = MaxJumps;
            JumpsHeight = -550;
            MaxHealth = 15;
            Health = MaxHealth;           
            Dimension = 1;
            PColor = PlayerColor.Blue;
        }

        /// <seealso cref="IPlayer.Speed"/>
        public int Speed { get; set; }

        /// <seealso cref="IPlayer.JumpCounter"/>
        public int JumpCounter { get; set; }

        /// <seealso cref="IPlayer.MaxJumps"/>
        public int MaxJumps { get; set; }

        /// <seealso cref="IPlayer.JumpsHeight"/>
        public int JumpsHeight { get; set; }

        /// <seealso cref="IPlayer.Health"/>
        public int Health { get; set; }

        /// <seealso cref="IPlayer.MaxHealth"/>
        public int MaxHealth { get; set; }

        /// <seealso cref="IPlayer.Dimension"/>
        public double Dimension { get; set; }

        /// <seealso cref="IPlayer.PColor"/>
        public PlayerColor PColor { get; set; }

        /// <seealso cref="IPlayer.DecreaseJumps"/>
        public void DecreaseJumps() => this.JumpCounter--;

        /// <seealso cref="IPlayer.ResetNJumps"/>
        public void ResetNJumps() => JumpCounter = MaxJumps;
    }
}
