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

        public ZombieModel(int life, int speed, int damage, TypeOfMovement typeOfMovement)
        {
            this.Guid = Guid.NewGuid();
            this.Life = life;
            this.Speed = speed;
            this.Damage = damage;
            this.TypeOfMovement = typeOfMovement;

        }

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



