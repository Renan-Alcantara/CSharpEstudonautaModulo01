using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A13A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Renan";
            float num = 125.85f;
            Console.WriteLine($"Muito Prazer em te conhecer {nome,- 20}!!!");
            Console.WriteLine($"O valor inserido na variavel num é {num,-5:C}!!!");
            Console.ReadKey();
        }
    }
}
