using System;
namespace Di_Zio
{
    public interface IEnemy
    {
        /// <summary>
        /// Enemy identifier
        /// </summary>
        public Guid Guid { get; }

        /// <summary>
        /// Enemy Life
        /// </summary>
        public int Life { get; set; }

        /// <summary>
        /// Enemy speed
        /// </summary>
        public int Speed { get; set; }

        /// <summary>
        /// Enemy damage
        /// </summary>
        public int Damage { get; set; }

        /// <summary>
        /// Specifies the type of movement of the enemy
        /// </summary>
        public TypeOfMovement TypeOfMovement { get; }

        /// <summary>
        /// Specify the movement strategy
        /// </summary>
        public String GetMovementStrategy();
    }
}
