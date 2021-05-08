using System;
namespace Di_Zio
{
    public class ZombieModel: IEnemy
    {
        public Guid Guid { get; }
        public int Life { get; set; }
        public int Speed { get; set; }
        public int Damage { get; set; }
        public TypeOfMovement TypeOfMovement{ get; }


        /// <summary>
        /// Model Generic Zombie
        /// </summary>
        /// <param name="life">life of this zombie</param>
        /// <param name="speed">speed of this zombie</param>
        /// <param name="damage">damage that the zombie does in contact with the player</param>
        /// <param name="typeOfMovement">type of movement of this zombie </param>
        public ZombieModel(int life, int speed, int damage, TypeOfMovement typeOfMovement)
        {
            this.Guid = Guid.NewGuid();
            this.Life = life;
            this.Speed = speed;
            this.Damage = damage;
            this.TypeOfMovement = typeOfMovement;

        }

        /// <summary>
        /// Based on the value assigned by the enum, it allows to define a movement strategy
        /// </summary>
        /// <returns>Movement Strategy</returns>
        public String GetMovementStrategy()
        {
            int value = (int)TypeOfMovement;

            if (value.Equals(0))
            {
                return "followingZombie";
            }
            else
            {
                return "stupidZombie";
            }
        }
    }
}

