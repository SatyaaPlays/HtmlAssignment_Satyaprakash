using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSystem.BAL
{
    internal class Movies
    {
        public int ID { get; set; }
        public string TITLE { get; set; }
        public string BOXOFFICE { get; set; }
        public string ACTIVE { get; set; }
        public string DATEOFLANUCH { get; set; }

        public string GENRE { get; set; }
        public string HASTEASER { get; set; }
    }
}
