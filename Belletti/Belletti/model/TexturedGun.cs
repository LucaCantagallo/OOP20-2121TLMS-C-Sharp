using System;
using System.Collections.Generic;
using System.Text;

namespace Belletti
{
    abstract class TexturedGun : AbstractGun
    {
        readonly Texture texture = new Texture();
		//calls super constructor and adds all textures to textures
		public TexturedGun(int shotDMG, int maxAmmo, double shotSpeed, Dictionary<string, String> texturePaths) 
			: base(shotDMG, maxAmmo, shotSpeed)
		{
			foreach(string key in texturePaths.Keys)
            {
				texture.AddTexture(key, texturePaths.GetValueOrDefault(key));
            }
		}
		/**
		 * 
		 * @return the texture map straight from texture's method
		*/
		public Texture getTexture()
		{
			return this.texture;
		}

	}
}
