using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] carros = new string[30];
            string busca;
            string search;

            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine("digite o nome do veiculo");
                carros[i] = Console.ReadLine();
                Console.Clear();

            }

            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine(i + carros[i]);
            }
            Console.ReadKey();

            Console.WriteLine("qual veiculo você deseja pesquisar?");

            busca = Console.ReadLine();


            for (int i = 0; i <= 20; i++)
            {
                search = carros[i];
                if (busca == search)
                {
                    Console.WriteLine("veiculo cadastrado");
                }


                else
                {
                    Console.WriteLine("veiculo não cadastrado");

                }
                break;
            }
            Console.ReadKey();
        }
    }
}
