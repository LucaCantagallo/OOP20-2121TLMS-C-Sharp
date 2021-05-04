using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Morlino.src.model.score
{
    interface IScoreModel
    {
        bool isInTopThree(List<String> list, int score);

        List<string> updateRanking(List<String> list, IScore<string, int> newScore);

        List<Pair<string, List<string>>> rankingListRefactor(List<string> rankingList);
    }
}