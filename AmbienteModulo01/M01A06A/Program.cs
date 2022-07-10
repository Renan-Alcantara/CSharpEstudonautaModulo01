 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A06A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string escola = "Estudonauta";
            escola = "Curso em Video";
            const float PI = 3.1415f;



            Console.WriteLine("Eu estudo no " + escola);
            Console.WriteLine("O Tipo da variavel escola é " + escola.GetType());
            Console.WriteLine("O valor PI é " + PI);
            Console.WriteLine("O Tipo da Variavel PI é " + PI.GetType());
            Console.WriteLine("O Valor oficial de PI é " + Math.PI);
            Console.WriteLine("O Tipo da Variavel oficial Math.PI é " + Math.PI.GetType());
            Console.ReadKey();
        }
    }
}
