using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex01_BrasilBrasileiroConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(20, 10);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Thread.Sleep(1500);
            Console.Write(" Brasil ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Green;
            Thread.Sleep(1000);
            Console.Write(" Meu Brasil ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Thread.Sleep(1000);
            Console.Write(" Brasileiro!!! ");
            Console.ReadKey();
        }
    }
}
