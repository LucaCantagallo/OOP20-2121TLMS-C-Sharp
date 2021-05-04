using System;
using System.Collections.Generic;
using System.Text;

namespace Morlino.src.model.score
{
    class JsonScoreBuilder : IScoreBuilder<string, int>
    {
        private string name;
        private int score;

        public IScore<string, int> build()
        {
            if (this.name == null || this.score == 0)
            {
                throw new ArgumentException();
            }
            return new JsonScore(name, score);
        }

        public IScoreBuilder<string, int> NameFromString(string name)
        {
            this.name = name;
            return this;
        }

        public IScoreBuilder<string, int> Score(int score)
        {
            this.score = score;
            return this;
        }
    }
}
