using System;
using Di_Zio.model;

namespace Di_Zio
{
	/**
    * This Class models a Male Zombie 
    */
	public class ZombieFemaleDecorator : IZombieTextureDecorator
	{
		private ZombieModel zombie;
        private Texture texture;
		private const int SPEED_BONUS = 20;

		public Guid Guid { get => zombie.Guid; }

		public int Life { get => zombie.Life; set => zombie.Life=Life; }
        public int Speed { get => zombie.Speed + SPEED_BONUS; set => zombie.Speed = Speed; }
        public int Damage { get => zombie.Damage; set => zombie.Damage=Damage; }

		public TypeOfMovement TypeOfMovement { get => zombie.TypeOfMovement; }

		/// <summary>
        /// Make Female Zombie
        /// </summary>
        /// <param name="zombie">Model of zombie</param>
		public ZombieFemaleDecorator(ZombieModel zombie)
		{
			this.zombie = zombie;
			this.texture = new Texture();

			this.texture.AddTexture(TypeOfTexture.IDLE, "path_idle");
			this.texture.AddTexture(TypeOfTexture.WALK, "path_walk");
			this.texture.AddTexture(TypeOfTexture.DEAD, "path_dead");
			this.texture.AddTexture(TypeOfTexture.ATTACK, "path_attack");
		}

		public String GetMovementStrategy()
		{
			return this.zombie.GetMovementStrategy();
		}

		public Texture GetTexture()
		{
			return this.texture;
		}
	}
}