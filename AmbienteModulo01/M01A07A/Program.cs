using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A07A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Conversão de Variaveis - Implícita (int -> float):
            int a = 7;
            float b = a;
            Console.WriteLine("O Valor da minha variavel \"a\" é " + a + " e o seu tipo é " + a.GetType());
            Console.WriteLine("O Valor da minha variavel \"b\" é " + b + " e o seu tipo é " + b.GetType());
            Console.ReadKey();
            

            // Conversão de Variaveis - Explícita (float -> int):       (Ignora o que existe após a virgula) 
            float c = 8.999f;
            int d = (int)c;
            Console.WriteLine("O Valor da minha variavel \"c\" é " + c + " e o seu tipo é " + c.GetType());
            Console.WriteLine("O Valor da minha variavel \"d\" é " + d + " e o seu tipo é " + d.GetType());
            Console.ReadKey();


            // Conversão de Variaveis - Classes Auxiliares (float -> int):   (Trabalha melhor com arredondamento)
            float x = 8.977f;
            int y = Convert.ToInt16(x);
            Console.WriteLine("O Valor da minha variavel \"x\" é " + x + " e o seu tipo é " + x.GetType());
            Console.WriteLine("O Valor da minha variavel \"y\" é " + y + " e o seu tipo é " + y.GetType());
            Console.ReadKey();



        }
    }
}
