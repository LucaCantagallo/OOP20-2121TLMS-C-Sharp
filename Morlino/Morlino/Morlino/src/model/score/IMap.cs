using System;
using System.Collections.Generic;
using System.Text;

namespace Morlino.src.model.score
{
    interface IMap
    {
        ISet<string> getMaps();

        void removeMap(string map);

        void addMap(string map);
    }
}
