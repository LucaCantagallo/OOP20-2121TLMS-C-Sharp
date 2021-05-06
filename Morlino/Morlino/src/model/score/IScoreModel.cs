using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Morlino.src.model.score
{
    interface IScoreModel
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"> the top three ranking stream</param>
        /// <param name="score">the score to compare with the top3</param>
        /// <returns>true if the score is in the top3 and the ranking will be updated </returns>
        bool IsInTopThree(List<String> list, int score);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="list">the list with the top3</param>
        /// <param name="newScore">the score to insert in top3</param>
        /// <returns>the list updated</returns>
        List<string> UpdateRanking(List<String> list, IScore<string, int> newScore);

        /// <summary>
        /// This method takes a list of strings. Each string is in the "map:USER1 score,USER2 score,USER3 score" form.
        /// It returns a list of pairs.Each pair is in the (map, ["USER1 score", "USER2 score", "USER3 score"]) form
        /// </summary>
        /// <param name="rankingList"></param>
        /// <returns>the new list</returns>
        List<Pair<string, List<string>>> RankingListRefactor(List<string> rankingList);
    }
}