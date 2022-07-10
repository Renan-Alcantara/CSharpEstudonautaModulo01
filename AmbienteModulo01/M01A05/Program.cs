using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de Variaveis
            var nome = "Renan";
            sbyte n = 20;

            Console.WriteLine("A Variavel nome tem " + nome);
            Console.WriteLine("e é do tipo " + nome.GetType());
            Console.ReadKey();
            Console.WriteLine("Já a variavel n tem " + n);
            Console.WriteLine("e é do tipo " + n.GetType());
            Console.ReadKey();
        }
    }
}
