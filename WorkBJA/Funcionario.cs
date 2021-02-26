using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkBJA
{
    class Funcionario
    {
        public string Código { get; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Departamento { get; set; }

        public Funcionario()
        {
            Código = Identificador.GeraID();
            Nome = "";
            Cargo = "";
            Departamento = "";
        }

        public void InsereFunc()
        {
            Console.WriteLine("Código do Funcionário: {0}", this.Código);

            Console.Write("Nome.................: ");
            this.Nome = Console.ReadLine();

            Console.Write("Cargo................: ");
            this.Cargo = Console.ReadLine();

            Console.Write("Departamento.........: ");
            this.Departamento = Console.ReadLine();

            Dados.Adiciona(this);
        }

        public void ListaFunc()
        {
            List<Funcionario> Lista = Dados.RecuperaDados();

            foreach (Funcionario x in Lista)
            {
                Console.WriteLine("{0} ({1})", x.Nome, x.Código);
                Console.WriteLine("Cargo.......: {0}", x.Cargo);
                Console.WriteLine("Departamento: {0}\n", x.Departamento);
            }

            Console.ReadKey();
        }

    }
}