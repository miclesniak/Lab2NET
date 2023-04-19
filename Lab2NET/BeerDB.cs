using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2NET
{
    internal class BeerDB
    {
        public int BeerDBID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public string BrewersTips { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
