using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convidados
{
    class Program
    {
        static int menu()
        {
            Console.Clear();
            Console.WriteLine("1 - Exibir lista");
            Console.WriteLine("2 - Inserir convidado");
            Console.WriteLine("3 - Remover convidado");
            Console.WriteLine("4 - Consultar convidado");
            Console.WriteLine("5 - Consultar velhos");
            Console.WriteLine("6 - Remover jovens");
            Console.WriteLine("15 - Sair");
            Console.Write("Opção: ");

            return (int.Parse(Console.ReadLine()));
        }

        static void Main(string[] args)
        {
            int op;

            do
            {
                op = menu();

                switch (op)
                {
                    case 1:
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        break;

                    case 6:
                        break;
                }

            } while (op != 15);
        }
    }
}
