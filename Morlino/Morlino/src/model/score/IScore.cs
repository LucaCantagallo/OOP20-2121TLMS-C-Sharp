using System;
using System.Collections.Generic;
using System.Text;

namespace Morlino.src.model.score
{
    public interface IScore<TName, TScore>
    {
        TName Name { get; set; }
        TScore Score { get; set; }

    }
}
