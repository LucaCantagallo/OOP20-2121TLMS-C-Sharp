using System;
using System.Collections.Generic;
using System.Text;

namespace Belletti
{
    class TexturedGunLimited : TexturedGun
    {
        readonly Texture texture = new Texture();
		/// <summary>
		/// calls super constructor and adds all textures to textures 
		/// </summary>
		public TexturedGunLimited(int shotDMG, int maxAmmo, double shotSpeed, Dictionary<TLMSType, string> texturePaths) 
			: base(shotDMG, maxAmmo, shotSpeed, texturePaths)
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
		public Texture GetTexture() => this.texture;

        public override void Shoot() => SetNAmmo(GetNAmmo() - 1);
    }
}
