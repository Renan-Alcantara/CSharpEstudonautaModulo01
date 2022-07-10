using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_NumRealInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número Real: ");
            float num = 0f;
            float.TryParse(Console.ReadLine(), out num);

            string ifem = new String('-',30);
            Console.WriteLine(ifem);

            Console.WriteLine($"Você digitou o valor {num}");
            Console.WriteLine($"A parte inteira do número é {(int)num}");
            Console.WriteLine($"Arredondando, temos o número {Convert.ToInt16(num)}");
            Console.ReadKey();
        }
    }
}
