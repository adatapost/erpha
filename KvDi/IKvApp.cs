using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Erpha.KvDi
{
    public interface IKvApp
    {
        string Name { get; set; }
        string Author { get; set; }
        IEnumerable<string> Cities { get; }
       

    }
}
