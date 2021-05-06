using System;
using System.Collections.Generic;
using System.Text;

namespace Morlino.src.model.score
{
    interface IMap
    {
        ISet<string> GetMaps();

        void RemoveMap(string map);

        void AddMap(string map);
    }
}
