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
        public bool IsInTopThree(List<String> list, int score)
        {
            return list.Select(l => l.Split(' '))
                .Select(s => Int32.Parse(s[0]))
                .Where(n => n > score).Count() != 3;
        }
  
        public List<Pair<string, List<string>>> RankingListRefactor(List<string> rankingList)
        {
            List<Pair<String, List < String >>> newList = new List<Pair<String, List<String>>>();
            rankingList.ForEach(line =>
                newList.Add(
                    new Pair<String, List<String>>(
                      line.Split(':')[0],
                          new List<string>()
                          {
                              line.Split(':')[1].Split(',')[0].Split(' ')[1] + " " + line.Split(':')[1].Split(',')[0].Split(' ')[0],
                              line.Split(':')[1].Split(',')[1].Split(' ')[1] + " " + line.Split(':')[1].Split(',')[1].Split(' ')[0],
                              line.Split(':')[1].Split(',')[2].Split(' ')[1] + " " + line.Split(':')[1].Split(',')[2].Split(' ')[0]
                          }
                    )
                )
            );
            return newList;
        }

        public List<string> UpdateRanking(List<string> list, IScore<string, int> newScore)
        {
            List<string> newList = new List<string>(list);
            string strName = newScore.Name;
            string strScore = newScore.Score.ToString();
            newList.Add(strScore + " " + strName);
            newList.Sort((string c1, string c2) => int.Parse(c2.Split(' ')[0]).CompareTo(int.Parse(c1.Split(' ')[0])));
            newList.Remove(newList.ElementAt(newList.Count() - 1));
            return newList;
        }
    }
}
