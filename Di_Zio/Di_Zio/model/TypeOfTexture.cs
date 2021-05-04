﻿using System;
namespace Di_Zio.model
{
    public enum TypeOfTexture
    {
		/**
		 * Used to define the status of a stopped / waiting entity
		 */
		IDLE,

		/**
		 * Used to define the status of a walking entity
		 */
		WALK,

		/**
		 * Used to define the status of a dead entity
		 */
		DEAD,

		/**
		 * Used to define the status of a jumping entity
		 */
		JUMP,

		/**
		 * Used to define the status of a attacking entity
		 */
		ATTACK
	}
}
