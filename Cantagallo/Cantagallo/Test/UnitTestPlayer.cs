using System;
using Xunit;

namespace Cantagallo
{
    /// <summary>
    /// this class is used to test methods and classes
    /// </summary>
    public class UnitTestPlayer
    {
        /// <summary>
        /// this method tests player's getters
        /// </summary>
        /// <seealso cref="IPlayer"/>
        [Fact]
        public void PlayerGettersTest()
        {
            IPlayer player = new PlayerImpl();

            Assert.Equal(450, player.Speed);
            Assert.Equal(1, player.MaxJumps);
            Assert.Equal(1, player.JumpCounter);
            Assert.Equal(15, player.Health);
            Assert.Equal(-550, player.JumpsHeight);
            Assert.Equal(1, player.Dimension);
            Assert.Equal(PlayerColor.Blue, player.PColor);
        }

        /// <summary>
        /// this method tests player's speed
        /// </summary>
        /// <seealso cref="IPlayer.Speed"/>
        [Fact]
        public void PlayerSpeedSetterTest()
        {
            IPlayer player = new PlayerImpl();
            int tmp;

            Assert.Equal(450, player.Speed);
            tmp = player.Speed;
            player.Speed = 10;
            Assert.True(tmp > player.Speed);
            Assert.Equal(10, player.Speed);
        }

        /// <summary>
        /// this method tests player's jumps
        /// </summary>
        /// <seealso cref="IPlayer.JumpCounter"/>
        /// <seealso cref="IPlayer.JumpsHeight"/>
        /// <seealso cref="IPlayer.MaxJumps"/>
        /// <seealso cref="IPlayer.ResetNJumps"/>
        /// <seealso cref="IPlayer.DecreaseJumps"/>
        [Fact]
        public void PlayerJumpSetterTest()
        {
            IPlayer player = new PlayerImpl();

            Assert.Equal(-550, player.JumpsHeight);
            player.JumpsHeight = 0;
            Assert.Equal(0, player.JumpsHeight);

            Assert.True(player.JumpCounter == player.MaxJumps);
            player.DecreaseJumps();
            Assert.True(player.JumpCounter < player.MaxJumps);
            Assert.Equal(0, player.JumpCounter);
            player.ResetNJumps();
            Assert.True(player.JumpCounter == player.MaxJumps);
            player.MaxJumps = 5;
            Assert.True(player.JumpCounter < player.MaxJumps);
        }

        /// <summary>
        /// this method tests player's health
        /// </summary>
        /// <seealso cref="IPlayer.Health"/>
        /// <seealso cref="IPlayer.MaxHealth"/>
        [Fact]
        public void PlayerHealthSetterTest()
        {
            IPlayer player = new PlayerImpl();

            Assert.Equal(15, player.Health);
            player.Health--;
            Assert.Equal(14, player.Health);
        }

        /// <summary>
        /// this method tests player's dimension
        /// </summary>
        /// <seealso cref="IPlayer.Dimension"/>
        [Fact]
        public void PlayerDimensionSetterTest()
        {
            IPlayer player = new PlayerImpl();

            Assert.Equal(1, player.Dimension);
            player.Dimension = 2;
            Assert.Equal(2, player.Dimension);
        }

        /// <summary>
        /// this method tests player's color
        /// </summary>
        /// <seealso cref="IPlayer.PColor"/>
        [Fact]
        public void PlayerColorSetterTest()
        {
            IPlayer player = new PlayerImpl();

            Assert.Equal(PlayerColor.Blue, player.PColor);
            player.PColor = PlayerColor.Red;
            Assert.Equal(PlayerColor.Red, player.PColor);
        }

        /// <summary>
        /// this method tests player's textures
        /// </summary>
        /// <seealso cref="PlayerTexture"/>
        [Fact]
        public void PlayerTextureTest()
        {
            IPlayer player = new PlayerImpl();
            PlayerTexture texture = new PlayerTexture(PlayerColor.Blue);

            string idleblue;
            texture.GetTexture().TextureMap.TryGetValue(TLMSType.IDLE, out idleblue);
            Assert.Equal("Gunner_Blue_Idle.png", idleblue);

            string jumpblue;
            texture.GetTexture().TextureMap.TryGetValue(TLMSType.JUMP, out jumpblue);
            Assert.Equal("Gunner_Blue_Jump.png", jumpblue);

            texture = new PlayerTexture(PlayerColor.Red);

            string runred;
            texture.GetTexture().TextureMap.TryGetValue(TLMSType.RUN, out runred);
            Assert.Equal("Gunner_Red_Run.png", runred);

            texture = new PlayerTexture(PlayerColor.Blue);

            string bluedead;
            texture.GetTexture().TextureMap.TryGetValue(TLMSType.DEAD, out bluedead);
            Assert.Equal("Gunner_Blue_Death.png", bluedead);
        }

        /// <summary>
        /// this method tests player's speed with strategy 
        /// </summary>
        /// <seealso cref="IPlayerSpeedStrategy"/>
        [Fact]
        public void PlayerSpeedStrategyTest()
        {
            IPlayer player = new PlayerImpl();

            IPlayerSpeedStrategy playerSpeed = new PlayerSpeed(player);
            Assert.True(player.Speed == playerSpeed.Velocity);

            player.Speed = 10;

            playerSpeed = new PlayerSpeed(player);
            Assert.Equal(player.Speed, playerSpeed.Velocity);

            playerSpeed = new PlayerSpeedTurnsAround();
            Assert.Equal(0, playerSpeed.Velocity);
        }

        /// <summary>
        /// this method tests player's transformation, with proxy
        /// </summary>
        /// <seealso cref="IPlayerPowerUp"/>
        [Fact]
        public void PlayerPowerUpProxyTest()
        {
            IPlayer player = new PlayerImpl();
            IPlayerPowerUp powerUp = new PlayerPowerUpProxy(player);
            int speed = 650;
            int health = 15;
            int maxJumps = 5;
            int randomValue = 123;

            Assert.Equal(PlayerColor.Blue, player.PColor);

            powerUp.Transformation(PlayerColor.Red, speed, health, maxJumps);

            Assert.Equal(PlayerColor.Red, player.PColor);
            Assert.Equal(speed, player.Speed);
            Assert.Equal(health, player.MaxHealth);
            Assert.Equal(maxJumps, player.MaxJumps);

            powerUp.Transformation(PlayerColor.Red, randomValue, randomValue, randomValue);

            Assert.True(player.Speed != randomValue);
            Assert.Equal(PlayerColor.Red, player.PColor);
            Assert.Equal(speed, player.Speed);
            Assert.Equal(health, player.MaxHealth);
            Assert.Equal(maxJumps, player.MaxJumps);
        }
    }
}
