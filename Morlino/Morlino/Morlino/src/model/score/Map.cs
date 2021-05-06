using System;
using System.Collections.Generic;
using System.Text;

namespace Morlino.src.model.score
{
    class Map : IMap
    {
        private readonly string[] arr1 = { "Cemetery", "Canyon", "Pyramid" };
        private readonly ISet<string> maps;

        public Map(ISet<string> maps)
        {
            this.maps = new HashSet<string>(arr1);
        }

        public void addMap(string map)
        {
            this.maps.Add(map);
        }

        public ISet<string> getMaps()
        {
            return this.maps;
        }

        public void removeMap(string map)
        {
            this.maps.Remove(map);
        }
    }
}
