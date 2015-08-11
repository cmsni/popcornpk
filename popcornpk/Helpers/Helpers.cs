using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace popcornpk.Helpers
{
    public static class Helpers
    {
        public static T Deserialize<T>(this string SerializedJSONString)
        {
            var stuff = JsonConvert.DeserializeObject<T>(SerializedJSONString);
            return stuff;
        }
    }
}
