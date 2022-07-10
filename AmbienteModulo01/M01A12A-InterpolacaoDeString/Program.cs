using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A12A_InterpolacaoDeString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hey, qual o seu nome? ");
            string nome = Console.ReadLine();
            Console.WriteLine("Olá, " + nome + "! Tudo bem?");
            Console.ReadKey();
            Console.WriteLine($"Sabia, Sr. {nome}, que a interpolação de strings facilita muito a programar?");
            Console.ReadKey();
        }
    }
}
