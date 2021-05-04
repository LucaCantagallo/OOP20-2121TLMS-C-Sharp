using System;
using Di_Zio.model;

namespace Di_Zio
{
    public interface IZombieTextureDecorator: IEnemy
    {
        /**
        * @return Texture map of this zombie
        */
        Texture GetTexture();
	}
}
