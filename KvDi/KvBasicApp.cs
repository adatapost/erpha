using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Erpha.KvDi
{
    public class KvBasicApp : IKvApp
    {
        public string Name { get; set; } = "Erpha";
        public string Author { get; set; } = "KV";
        public IEnumerable<string> Cities => new string[]{"Surat","Mehsana"};
    }
}
