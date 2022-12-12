using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    internal class Index
    {
        public int Number { get; set; }

        public static List<Index> index = new List<Index>();

        public Index(int number)
        {
            this.Number = number;

            index.Add(this);
        }
    }
}
