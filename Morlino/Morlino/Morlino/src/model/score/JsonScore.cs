using System;
using System.Collections.Generic;
using System.Text;

namespace Morlino.src.model.score
{
    class JsonScore:IScore<string, int>
    {
        private string name;
        private int score;

        public string Name { get; set; }

        public int Score { get; set; }

        public JsonScore(string name, int score)
        {
            this.name = name;
            this.score = score;
        }

        public override bool Equals(object obj)
        {
            return obj is JsonScore score &&
                   name == score.name &&
                   this.score == score.score;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(name, score);
        }
    }
}
