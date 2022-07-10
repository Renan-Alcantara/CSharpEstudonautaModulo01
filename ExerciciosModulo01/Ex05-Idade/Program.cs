using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.DateTime;

namespace Ex05_Idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Em que ano você nasceu? ");
            int ano = 0;
            int.TryParse(Console.ReadLine(), out ano);

            string ifem = new String('-', 30);
            Console.WriteLine(ifem);

            int anoAtual = DateTime.Now.Year;
            Console.WriteLine($"Atualmente, estamos no ano de {anoAtual}");
            Console.WriteLine($"Se você nasceu em {ano}, vai ter entre {anoAtual - ano - 1} e {anoAtual - ano} anos.");
            Console.ReadKey();
        }
    }
}
