namespace Belletti
{
    public enum TLMSType
    {
		/*
		 * Defines the SHOT type, used to spawn shots.
		 * @see TLMSFactory
		 */
		SHOT,

		/**
		 * Defines MACHINEGUN type, used to spawn gun prop.
		 * 
		 * but also to build a textured gun from type
		 * @see TexturedGunFactoryImpl
		 */
		MACHINEGUN,

		/**
		 * Defines MAGMAGUN type, used to spawn gun prop.
		 * 
		 * but also to build a textured gun from type
		 * @see TexturedGunFactoryImpl
		 */
		MAGMAGUN,

		/**
		 * Defines BERETTA92 type, to build weapon from type, coherently with others gun types.
		 * BERETTA92 it's set as default gun (the one the player is spawned with), so it has no prop
		 * @see TexturedGunFactoryImpl
		 */
		BERETTA92,

		/**
		 * Defines GUN type,
		 * used to get Texture from maps, by type searching.
		 */
		GUN,
	}
}