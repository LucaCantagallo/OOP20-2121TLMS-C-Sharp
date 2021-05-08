using System;
using System.Collections.Generic;
using System.Text;

namespace Cantagallo
{
    /// <summary>
    /// class usefull to create in a easily way dictionaries
    /// </summary>
    class Texture
    {
        internal Dictionary<TLMSType, string> TextureMap { get; } = new Dictionary<TLMSType, string>();

        /// <summary>
        /// this method is usefull to add a texture to our dictionary
        /// </summary>
        /// <param name="type"></param>
        /// <param name="path"></param>
        public void AddTexture(TLMSType type, string path) => TextureMap.Add(type, path);
    }
}
