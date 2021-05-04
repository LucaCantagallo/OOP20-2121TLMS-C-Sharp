using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Morlino.src.model.score
{
    class ScoreModel : IScoreModel
    {
        public bool isInTopThree(List<String> list, int score)
        {
            return list.Select(l => l.Split(" "))
                .Select(s => Int32.Parse(s[0]))
                .Where(n => n > score).Count() != 3;
        }
  
        public List<Pair<string, List<string>>> rankingListRefactor(List<string> rankingList)
        {
            throw new NotImplementedException();
        }

        public List<string> updateRanking(List<string> list, IScore<string, int> newScore)
        {
            List<string> newList = new List<string>(list);
            string strName = newScore.Name;
            string strScore = newScore.Score.ToString();
            newList.Add(strScore + " " + strName);
            newList.Sort(delegate (string c1, string c2) { return int.Parse(c1).CompareTo(int.Parse(c2)); });
            newList.Remove(newList.ElementAt(newList.Count() - 1)));
            return newList;
        }
    }
}
