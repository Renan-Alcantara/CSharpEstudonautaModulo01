using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A09_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criando Objeto "gerador"
            Random gerador = new Random();

            // Gerar um numero aleatório longo:
            int n1 = gerador.Next();

            // Gerar um numero aleatório entre 0 e 9
            int n2 = gerador.Next(10);

            // Gerar um numero aleatório entre 5 e 19
            int n3 = gerador.Next(5,20);

            Console.WriteLine("a variavel n1 é " + n1 + "\n\na variavel n2 é " + n2 + "\n\na variavel n3 é " + n3);
            Console.ReadKey();
        }
    }
}
