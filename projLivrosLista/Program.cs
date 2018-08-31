using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projLivrosLista
{
    class Program
    {
        static void Main(string[] args)
        {
		// oi
            int resposta;
            Console.WriteLine("----------------------------------");
            Console.WriteLine("|0 - Sair                        |");
            Console.WriteLine("|1 - Adicionar Livro             |");
            Console.WriteLine("|2 - Pesquisar Livro (sintético) |");
            Console.WriteLine("|3 - Pesquisar Livro (analítico) |");
            Console.WriteLine("|4 - Adicionar exemplar          |");
            Console.WriteLine("|5 - Registrar empréstimo        |");
            Console.WriteLine("|6 - Registrar devolução         |");
            Console.WriteLine("----------------------------------");
            resposta = Convert.ToInt32(Console.ReadLine());

            switch (resposta)
            {
                case 0:
                    break;
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
            Console.ReadKey();
        }
    }
}
