using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Morlino.src.model.score
{
    interface IScoreModel
    {
        bool IsInTopThree(List<String> list, int score);

        List<string> UpdateRanking(List<String> list, IScore<string, int> newScore);

        List<Pair<string, List<string>>> RankingListRefactor(List<string> rankingList);
    }
}