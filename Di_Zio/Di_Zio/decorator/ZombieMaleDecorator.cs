﻿using System;
using Di_Zio.model;

namespace Di_Zio
{
    /**
    * This Class models a Male Zombie 
    */
    public class ZombieMaleDecorator : IZombieTextureDecorator
    {
        private ZombieModel zombie;
        private Texture texture;
        private const int DAMAGE_BONUS = 1;

        /**
	     * @param model of zombie
	    */
        public ZombieMaleDecorator(ZombieModel zombie)
        {
            this.zombie = zombie;
            this.texture = new Texture();

            this.texture.AddTexture(TypeOfTexture.IDLE, ""); //inserire path delle texture
            this.texture.AddTexture(TypeOfTexture.WALK, "");
            this.texture.AddTexture(TypeOfTexture.DEAD, "");
            this.texture.AddTexture(TypeOfTexture.ATTACK, "");
        }

        public string GetMovementStrategy()
        {
            return this.zombie.GetMovementStrategy();
        }

        public Texture GetTexture()
        {
            return this.texture;
        }

		
		public void SetLife( int life)
		{
			this.zombie.Life = life;
		}

		
		public void SetSpeed( int spd)
		{
			this.zombie.Speed = spd;

		}

		
		public void SetDamage( int dmg)
		{
			this.zombie.Damage = dmg;

		}


		public Guid GetUUID()
		{
			return this.zombie.Guid;
		}

		public int GetSpeed()
		{
			return this.zombie.Speed;
		}


		public int GetLife()
		{
			return this.zombie.Life;
		}


		public int GetDamage()
		{
			return this.zombie.Damage + DAMAGE_BONUS;
		}

	}
}