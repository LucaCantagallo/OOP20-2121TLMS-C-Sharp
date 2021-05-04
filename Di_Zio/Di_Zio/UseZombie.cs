using System;

namespace Di_Zio
{
    class UseZombie
    {
        Random random = new Random();

        private const int SPAWN_TIME = 4;
        private const int MINIMUM_LIFE = 10;
        private const int MINIMUM_SPEED = 170;
        private const int MINIMUM_DAMAGE = 2;

        static void Main(string[] args)
        {
            Console.WriteLine("Spawn Start");
            while (true)
            {
                //make zombie 
            }
        }

        private ZombieModel getRandomZombie()
        {
            int life = random.Next(MINIMUM_LIFE, 20);
            int speed = random.Next(MINIMUM_SPEED, 250);
            int damage = random.Next(MINIMUM_DAMAGE, 4);

            Array values = Enum.GetValues(typeof(TypeOfMovement));
            TypeOfMovement typeOfMovement = (TypeOfMovement)values.GetValue(random.Next(values.Length));

            return new ZombieModel(life, speed, damage, typeOfMovement);
        }
    }
}
