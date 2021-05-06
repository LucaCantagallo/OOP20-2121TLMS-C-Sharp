using System;
using System.Collections.Generic;
using System.Text;

namespace Morlino.src.model.score
{
    interface IScoreBuilder<TName, TScore>
    {
		IScoreBuilder<TName, TScore> NameFromString(string name);

		IScoreBuilder<TName, TScore> Score(int score);

		IScore<TName, TScore> Build();
	}
}
