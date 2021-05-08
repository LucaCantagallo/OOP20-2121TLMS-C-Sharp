using Xunit;
using Di_Zio.model;


namespace Di_Zio.test
{
    
    public class TestModel
    {
        private const int LIFE = 10;
        private const int SPEED = 170;
        private const int DAMAGE = 2;


        /// <summary>
        /// Test model of zombie
        /// </summary>
        [Fact]
        public void TestZombie()
        {
            IEnemy zombieFollow = new ZombieModel(LIFE,SPEED,DAMAGE, TypeOfMovement.FOLLOW);

            Assert.NotNull(zombieFollow);
            Assert.Equal(LIFE, zombieFollow.Life);
            Assert.Equal(SPEED, zombieFollow.Speed);
            Assert.Equal(DAMAGE, zombieFollow.Damage);
        }

        /// <summary>
        /// Test movement strategy 
        /// </summary>
        [Fact]
        public void TestMovementStrategy()
        {
            IEnemy zombieFollow = new ZombieModel(LIFE, SPEED, DAMAGE, TypeOfMovement.FOLLOW);
            IEnemy zombieRandom = new ZombieModel(LIFE, SPEED, DAMAGE, TypeOfMovement.RANDOM);

            Assert.Equal("followingZombie", zombieFollow.GetMovementStrategy());
            Assert.Equal("stupidZombie", zombieRandom.GetMovementStrategy());

        }

        /// <summary>
        /// Test texture model
        /// </summary>
        [Fact]
        public void TestTexture()
        {
            Texture texture = new Texture();

            texture.AddTexture(TypeOfTexture.IDLE, "path_idle");
            texture.AddTexture(TypeOfTexture.ATTACK, "path_attack");
            texture.AddTexture(TypeOfTexture.WALK, "path_walk");
            texture.AddTexture(TypeOfTexture.JUMP, "path_jump");
            texture.AddTexture(TypeOfTexture.DEAD, "path_dead");

            string value;
            if (texture.getTextureMap().TryGetValue(TypeOfTexture.IDLE, out value))
            {
                Assert.Equal("path_idle", value);
            }
            else
            {
                Assert.True(false, "Can't get IDLE TEXTURE ​​from the map");
            }
            if (texture.getTextureMap().TryGetValue(TypeOfTexture.ATTACK, out value))
            {
                Assert.Equal("path_attack", value);
            }
            else
            {
                Assert.True(false, "Can't get ATTACK TEXTURE ​​from the map");
            }
            if (texture.getTextureMap().TryGetValue(TypeOfTexture.WALK, out value))
            {
                Assert.Equal("path_walk", value);
            }
            else
            {
                Assert.True(false, "Can't get WALK TEXTURE ​​from the map");
            }
            if (texture.getTextureMap().TryGetValue(TypeOfTexture.JUMP, out value))
            {
                Assert.Equal("path_jump", value);
            }
            else
            {
                Assert.True(false, "Can't get JUMP TEXTURE ​​from the map");
            }
            if (texture.getTextureMap().TryGetValue(TypeOfTexture.DEAD, out value))
            {
                Assert.Equal("path_dead", value);
            }
            else
            {
                Assert.True(false, "Can't get DEAD TEXTURE ​​from the map");
            }
        }
    }
}
