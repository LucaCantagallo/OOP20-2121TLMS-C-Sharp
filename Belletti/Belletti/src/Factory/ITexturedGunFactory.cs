using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belletti.src.Factory
{
    interface ITexturedGunFactory
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="type">gun type</param>
		/// <returns>an instance of a textured gun of type "type"</returns>
		TexturedGun GetTexturedGun(TLMSType type);
	}
}