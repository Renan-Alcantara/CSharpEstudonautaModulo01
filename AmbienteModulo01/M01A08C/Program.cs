using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A08C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Olá, por favor digite um numero: ");
            int num = Convert.ToInt16(Console.ReadLine());
            int dobro = num * 2;
            Console.WriteLine("o numero digitado foi " + num + "!");
            Console.WriteLine("o dobro de " + num + " é " + dobro + "!");
            Console.ReadKey();
        }
    }
}
