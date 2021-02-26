using System;
using System.Threading;

namespace WorkBJA
{
    class Program
    {
        public static void Main(string[] args)
        {
            int Op;

            do
            {
                Console.Clear();

                Funcionario Func = new Funcionario();

                Console.WriteLine("Opções: \n");

                Console.WriteLine("1 - Inserir");
                Console.WriteLine("2 - Listar");
                Console.WriteLine("3 - Sair do Programa");

                Console.Write("\nDigite uma Opção: ");
                Op = int.Parse(Console.ReadLine());

                switch (Op)
                {
                    case 1:
                        Console.Clear();

                        Console.WriteLine("Inserção de Funcionário: \n");

                        Func.InsereFunc();

                        break;
                    case 2:
                        Console.Clear();

                        Console.WriteLine("Listagem de Funcionários: \n");

                        Func.ListaFunc();

                        break;
                    case 3:
                        Console.WriteLine("\nSaída do Programa...");

                        Thread.Sleep(2000);

                        break;
                    default:
                        Console.WriteLine("\nOpção Inválida...");

                        Thread.Sleep(2000);

                        break;
                }
            } while (Op != 3);
        }

    }
}