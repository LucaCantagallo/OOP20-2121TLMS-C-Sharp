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

		/// <summary>
		/// </summary>
		/// <param name="type">Enum in TLMSType, defines the type of texture</param>
		/// <param name="path">Path to texture file</param>
		public void AddTexture( TypeOfTexture type,  String path)
		{
			this.textureMap.Add(type, path);
		}

		/// <summary>
        /// </summary>
        /// <returns>Texture map created</returns>
		public IDictionary<TypeOfTexture, string> getTextureMap()
		{
			return this.textureMap;
		}
	}
}
