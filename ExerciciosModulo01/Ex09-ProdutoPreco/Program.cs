using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09_ProdutoPreco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Produto 1: ");
            string prod1 = Console.ReadLine();
            Console.Write("Preço 1: ");
            float prec1 = 0f;
            float.TryParse(Console.ReadLine(), out prec1);

            Console.Write("Produto 2: ");
            string prod2 = Console.ReadLine();
            Console.Write("Preço 2: ");
            float prec2 = 0f;
            float.TryParse(Console.ReadLine(), out prec2);

            Console.SetCursorPosition(0 , 15);

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{" Produto",-20}{"Preço ",20}");

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"{prod1,-20}{prec1,20:c}");
            Console.WriteLine($"{prod2,-20}{prec2,20:c}");

            Console.ReadKey();
        }
    }
}
