using System;
using System.Collections.Generic;
using System.Text;

namespace Belletti
{
	abstract class TexturedGun : AbstractGun
	{
		readonly Texture texture = new Texture();
		//calls super constructor and adds all textures to textures
		public TexturedGun(int shotDMG, int maxAmmo, double shotSpeed, Dictionary<TLMSType, string> texturePaths)
			: base(shotDMG, maxAmmo, shotSpeed)
		{
			foreach (KeyValuePair<TLMSType, string> nameTexture in texturePaths)
			{
				texture.AddTexture(nameTexture.Key, nameTexture.Value);
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