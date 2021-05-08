using System;
using Di_Zio.model;


namespace Di_Zio
{
    public interface IZombieTextureDecorator: IEnemy
    {
        /// <summary>
        /// </summary>
        /// <returns>Texture map of this zombie</returns>
        Texture GetTexture();
	}

    public enum Gender
    {

        /// <summary>
        /// Male Gender
        /// </summary>
        MALE,

        /// <summary>
        /// Female Gender
        /// </summary>
		FEMALE
    }
}
