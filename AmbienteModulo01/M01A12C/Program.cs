using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A12C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float sal = 0;
            Console.Write("Qual é seu salario? ");
            float.TryParse(Console.ReadLine(), out sal);
            Console.WriteLine($"O Seu salário é de {sal:c} por mês!");
            Console.ReadKey();
        }
    }
}
