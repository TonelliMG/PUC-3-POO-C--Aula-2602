using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkBJA
{
    class Dados
    {
        private static List<Funcionario> Lista = new List<Funcionario>();

        public static void Adiciona(Funcionario x)
        {
            Lista.Add(x);
        }

        public static List<Funcionario> RecuperaDados()
        {
            return Lista;
        }
    }
}
