using System;
using System.Collections.Generic;
using System.Text;

namespace Cantagallo
{
    /// <summary>
    /// this class is usefull to fill a dictionary with different path
    /// </summary>
    class PlayerTexture
    {
        private Texture pTexture;

        /// <summary>
        /// Initialized with initial strings
        /// </summary>
        /// <param name="color"></param>
        public PlayerTexture(PlayerColor color)
        {
            pTexture = new Texture();

            pTexture.AddTexture(TLMSType.IDLE, "Gunner_" + color + "_Idle.png");
            pTexture.AddTexture(TLMSType.RUN, "Gunner_" + color + "_Run.png");
            pTexture.AddTexture(TLMSType.JUMP, "Gunner_" + color + "_Jump.png");
            pTexture.AddTexture(TLMSType.DEAD, "Gunner_" + color + "_Death.png");
        }

        /// <summary>
        /// this method is usefull to get this dictionary
        /// </summary>
        /// <returns></returns>
        public Texture GetTexture() => pTexture;

    }
}
