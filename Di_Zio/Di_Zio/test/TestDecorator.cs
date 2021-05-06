using Xunit;
using Di_Zio.model;
namespace Di_Zio
{
    public class TestDecorator
    {
        private const int LIFE = 10;
        private const int SPEED = 170;
        private const int DAMAGE = 2;

        private const int DAMAGE_BONUS = 1;
        private const int SPEED_BONUS = 20;


        /// <summary>
        /// Test Decorated zombie with male texture
        /// </summary>
        [Fact]
        public void TestMaleDecorator()
        {
            IZombieTextureDecorator zombieMale = new ZombieMaleDecorator(new ZombieModel(LIFE, SPEED, DAMAGE, TypeOfMovement.FOLLOW));

            Assert.NotNull(zombieMale);
            Assert.Equal(LIFE, zombieMale.Life);
            Assert.Equal(SPEED, zombieMale.Speed);
            Assert.Equal(DAMAGE + DAMAGE_BONUS, zombieMale.Damage);

            Assert.Equal("followingZombie", zombieMale.GetMovementStrategy());

            Texture texture = zombieMale.GetTexture();

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
            if (texture.getTextureMap().TryGetValue(TypeOfTexture.DEAD, out value))
            {
                Assert.Equal("path_dead", value);
            }
            else
            {
                Assert.True(false, "Can't get DEAD TEXTURE ​​from the map");
            }

            Assert.False(texture.getTextureMap().TryGetValue(TypeOfTexture.JUMP, out value));

        }


        /// <summary>
        /// Test Decorated zombie with female texture
        /// </summary>
        [Fact]
        public void TestFemaleDecorator()
        {
            IZombieTextureDecorator zombieFemale = new ZombieFemaleDecorator(new ZombieModel(LIFE, SPEED, DAMAGE, TypeOfMovement.RANDOM));

            Assert.NotNull(zombieFemale);
            Assert.Equal(LIFE, zombieFemale.Life);
            Assert.Equal(SPEED + SPEED_BONUS, zombieFemale.Speed);
            Assert.Equal(DAMAGE, zombieFemale.Damage);

            Assert.Equal("stupidZombie", zombieFemale.GetMovementStrategy());

            Texture texture = zombieFemale.GetTexture();

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
            if (texture.getTextureMap().TryGetValue(TypeOfTexture.DEAD, out value))
            {
                Assert.Equal("path_dead", value);
            }
            else
            {
                Assert.True(false, "Can't get DEAD TEXTURE ​​from the map");
            }

            Assert.False(texture.getTextureMap().TryGetValue(TypeOfTexture.JUMP, out value));
        }
    }
}
