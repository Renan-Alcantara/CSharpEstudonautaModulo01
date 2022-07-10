using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A08E
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
            int num;
            int.TryParse(Console.ReadLine(), out num);
            Console.WriteLine("O Valor digitado foi " + num + "!");
            Console.WriteLine("O dobro de " + num + " é " + (num * 2) + "!");
            Console.ReadKey();
        }
    }
}
