using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace popcornpk.DataModel
{
    public class Category
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Categorys
    {
        public List<Category> Categorys_list { get; set; }
    }
}
