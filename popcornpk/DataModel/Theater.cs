using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace popcornpk.DataModel
{
    public class Theater
    {
        public string theater_id { get; set; }
        public string theater_title { get; set; }
    }

    public class Theaters
    {
        public bool result { get; set; }
        public List<Theater> theaters { get; set; }
    }
}
