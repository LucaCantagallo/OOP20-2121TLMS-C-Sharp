using System;
using System.Collections.Generic;
using System.Text;

namespace Morlino.src.model.score
{
    class Pair<TFirst, TSecond>
    {
		private readonly TFirst x;
		private readonly TSecond y;

        public Pair(TFirst x, TSecond y)
        {
            this.x = x;
            this.y = y;
        }

		public TFirst X { get; set; }

		public TSecond Y { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Pair<TFirst, TSecond> pair &&
                   EqualityComparer<TFirst>.Default.Equals(x, pair.x) &&
                   EqualityComparer<TSecond>.Default.Equals(y, pair.y);
        }

        public override int GetHashCode()
        {
            int hashCode = 1502939027;
            hashCode = hashCode * -1521134295 + EqualityComparer<TFirst>.Default.GetHashCode(x);
            hashCode = hashCode * -1521134295 + EqualityComparer<TSecond>.Default.GetHashCode(y);
            return hashCode;
        }
    }
}
