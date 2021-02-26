using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkBJA
{
    static class Identificador
    {
        static public string GeraID()
        {
            return Guid.NewGuid().ToString().Substring(4, 4).ToUpper();
        }
    }
}
