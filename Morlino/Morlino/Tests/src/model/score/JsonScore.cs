using System;
using System.Collections.Generic;
using System.Text;

namespace Morlino.src.model.score
{
    class JsonScore:IScore<string, int>
    {
        private string name;
        private int score;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public JsonScore(string name, int score)
        {
            this.name = name;
            this.score = score;
        }


        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
            {
                return true;
            }
            if (obj == null || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            JsonScore other = (JsonScore)obj;
            return name.Equals(other.name)
                && score.Equals(other.score);
        }
    }
}
