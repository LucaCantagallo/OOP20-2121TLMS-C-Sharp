using System;
namespace Di_Zio.model
{
    public enum TypeOfTexture
    {
		/// <summary>
		/// Used to define the status of a stopped / waiting entity
		/// </summary>
		IDLE,
		/// <summary>
		/// Used to define the status of a walking entity
		/// </summary>
		WALK,

		/// <summary>
		/// Used to define the status of a dead entity
		/// </summary>
		DEAD,

		/// <summary>
		/// Used to define the status of a jumping entity
		/// </summary>
		JUMP,

		/// <summary>
		/// Used to define the status of a attacking entity
		/// </summary>
		ATTACK
	}
}
