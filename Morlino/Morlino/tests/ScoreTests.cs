
using Morlino.src.model.score;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class ScoreTests
    {
			[Fact]
			public void ScoreModelTopThreeTest()
			{
				IScoreModel model = new ScoreModel();
            List<string> list = new List<string>
            {
                "15 MARK",
                "51 LUKE",
                "24 JOHN"
            };
            Assert.False(model.IsInTopThree(list, 13));
				Assert.False(model.IsInTopThree(list, -10));
				Assert.True(model.IsInTopThree(list, 15));
				Assert.True(model.IsInTopThree(list, 100));
			}

			[Fact]
			public void ScoreModelUpdateRankingTest()
			{
				IScoreModel model = new ScoreModel();
				List<string> list = new List<string>
                {
					"19 MARK",
					"51 LUKE",
					"23 JOHN"
				};
			IScore<string, int> newScore = new JsonScore("MICHAEL", 45);
				List<string> newList = new List<string>
				{
					"51 LUKE",
					"45 MICHAEL",
					"23 JOHN"
				};
            Assert.Equal(newList, model.UpdateRanking(list, newScore));

				list.Clear();
				newList.Clear();

				newScore = new JsonScore("MICHAEL", 55);
				list.Add("19 MARK");
				list.Add("52 LUKE");
				list.Add("27 JOHN");
				newList.Add("55 MICHAEL");
				newList.Add("52 LUKE");
				newList.Add("27 JOHN");
				Assert.Equal(model.UpdateRanking(list, newScore), newList);

				list.Clear();
				newList.Clear();

				newScore = new JsonScore("GUNTHER", 20);
				list.Add("21 JOEY");
				list.Add("25 ROSS");
				list.Add("30 CHANDLER");
				newList.Add("30 CHANDLER");
				newList.Add("25 ROSS");
				newList.Add("21 JOEY");
				Assert.Equal(model.UpdateRanking(list, newScore), newList);
			}
		[Fact]
        public void JSonScoreBuilderTest()
        {
            IScore<string, int> score = new JsonScore("Phoebe", 300);
            IScore<string, int> score1 = new JsonScoreBuilder()
                                                .NameFromString("Phoebe")
                                                .Score(300)
                                                .Build();
            Assert.Equal(score, score1);
            IScore<String, int> score2 = new JsonScoreBuilder()
                       .NameFromString("PHOEBE")
                       .Score(300)
                       .Build();
            Assert.NotEqual(score, score2);
            IScore<String, int> score3 = new JsonScoreBuilder()
                                                      .NameFromString("John")
                                                      .Score(300)
                                                      .Build();
            Assert.NotEqual(score, score3);
        }

    }
}
