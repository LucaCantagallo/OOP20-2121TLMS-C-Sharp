using System.Collections.Generic;

namespace Belletti
{
    class Texture
    {
		Dictionary<TLMSType, string> textureMap;
		/// <summary>
		/// initializes textureMap
		/// </summary>
		public Texture()
		{
			textureMap = new Dictionary<TLMSType, string>();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="type">Enum in TLMSType, defines the type of texture</param>
		/// <param name="path">Path to texture file</param>
		public void AddTexture(TLMSType type, string path)
		{
			this.textureMap.Add(type, path);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns>texture map created</returns>
		public Dictionary<TLMSType, string> GetTextureMap()
		{
			return textureMap;
		}
    }
}