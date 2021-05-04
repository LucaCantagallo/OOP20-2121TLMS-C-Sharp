using System;

namespace Di_Zio
{
    class UseZombie
    {
        static public Random random = new Random();

        private const int MINIMUM_LIFE = 10;
        private const int MINIMUM_SPEED = 170;
        private const int MINIMUM_DAMAGE = 2;

        static void Main(string[] args)
        {

            Console.WriteLine("Spawn Start");
            while (true)
            {
                IZombieTextureDecorator zombie = null;
                switch (random.Next(2))
                {
                    case 0:
                        zombie = new ZombieMaleDecorator(getRandomZombie());
                        break;
                    case 1:
                        zombie = new ZombieFemaleDecorator(getRandomZombie());
                        break;
                }
                spawn(zombie);
                System.Threading.Thread.Sleep(5000);
            }
        }

        private static ZombieModel getRandomZombie()
        {
            int life = random.Next(MINIMUM_LIFE, 20);
            int speed = random.Next(MINIMUM_SPEED, 250);
            int damage = random.Next(MINIMUM_DAMAGE, 4);

            Array values = Enum.GetValues(typeof(TypeOfMovement));
            TypeOfMovement typeOfMovement = (TypeOfMovement)values.GetValue(random.Next(values.Length));

            return new ZombieModel(life, speed, damage, typeOfMovement);
        }

        private static void spawn(IZombieTextureDecorator zombieDecorated)
        {
            Console.WriteLine("##### Spawning Zombie #####");
            Console.WriteLine("-- Character --");
            Console.WriteLine("Guid: " + zombieDecorated.Guid.ToString());
            if (zombieDecorated.GetType().Name.Equals("ZombieMaleDecorator"))
            {
                Console.WriteLine("Gender: Male");
            }
            else
            {
                Console.WriteLine("Gender: Female");
            }

            Console.WriteLine("Life: "+zombieDecorated.Life);
            Console.WriteLine("Speed: " + zombieDecorated.Speed);
            Console.WriteLine("Damage: " + zombieDecorated.Damage);
            Console.WriteLine("MovementStrategy: "+ zombieDecorated.GetMovementStrategy());
            Console.WriteLine("##### ##### #####\n");
        }
    }
}
