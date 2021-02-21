using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Erpha.KvDi
{
    public class KvInhApp : IKvApp
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public IEnumerable<string> Cities { get { return _cities(); } }

        public KvInhApp()
        {
            Name = "Erpha UK";
            Author = "Team Cesto";
            
        }

       IEnumerable<String> _cities()
        {
            yield return "Vijapur";
            yield return "Jamnagar";
        }
    }
}
