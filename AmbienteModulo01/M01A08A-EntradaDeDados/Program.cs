using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A08A_EntradaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Olá, qual o seu nome? ");
            string nome = Console.ReadLine();
            Console.WriteLine("\nSeja bem vindo(a) Sr(a). " + nome + ". Muito prazer.");
            Console.ReadKey();
        }
    }
}
