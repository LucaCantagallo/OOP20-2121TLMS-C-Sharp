using System.Collections.Generic;

namespace Belletti
{
    class Texture
    {
		Dictionary<string, string> textureMap;

        public Texture()
		{
			textureMap = new Dictionary<string, string>();
		}


		/**
			* 
			* @param type - Enum in TLMSType, defines the type of texture 
			* {@link model.TLMSType#IDLE IDLE} 
			* {@link model.TLMSType#ATTACK ATTACK} 
			* {@link model.TLMSType#WALK WALK} 
			* {@link model.TLMSType#RUN RUN}
			* {@link model.TLMSType#SHOT SHOT}
			* 
			* @param path - Path to texture file
			*/
		public void AddTexture(string type, string path)
		{
			this.textureMap.Add(type, path);
		}

		/**
			* 
			* @return texture map created
			*/
		public Dictionary<string, string> GetTextureMap()
		{
			return textureMap;
		}
    }
}