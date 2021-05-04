using System;
using System.Collections.Generic;

namespace Di_Zio.model
{
    public class Texture
    {
        IDictionary<TypeOfTexture, string> textureMap;
        public Texture()
        {
            this.textureMap  = new Dictionary<TypeOfTexture, string>(); 
        }

		/**
	 * 
	 * @param type - Enum in TLMSType, defines the type of texture 
	 * 
	 * @param path - Path to texture file
	 */
		public void AddTexture( TypeOfTexture type,  String path)
		{
			this.textureMap.Add(type, path);
		}

		/**
		 * 
		 * @return texture map created
		 */
		public IDictionary<TypeOfTexture, string> getTextureMap()
		{
			return this.textureMap;
		}
	}
}
