using System;
using System.Collections.Generic;
using System.Text;

namespace Morlino.src.model.score
{   /// <summary>
    /// This interface provides methods to set and get maps of the game.
    /// </summary>
    interface IMap
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns>a set of maps</returns>
        ISet<string> GetMaps();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="map">the map to remove</param>
        void RemoveMap(string map);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="map">the map to add to the set</param>
        void AddMap(string map);
    }
}
