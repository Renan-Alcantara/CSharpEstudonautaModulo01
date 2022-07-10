using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex07_SorteadorNumeroConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorteador de Número");
            string ifem = new String('-', 30);
            Console.WriteLine(ifem);
            Console.Write("Início: ");
            int numIni = 0;
            int.TryParse(Console.ReadLine(), out numIni);
            Console.Write("Final ");
            int numFin = 0;
            int.TryParse(Console.ReadLine(), out numFin);
            Console.WriteLine(ifem);
            Console.Write("Sorteando");
            byte time = 0;
            while (time < 20)
            {
                Thread.Sleep(0200);
                Console.Write(".");
                time = (byte)(time + 1);
            }
            Random random = new Random();
            int numSor = random.Next(numIni,numFin);
            Console.WriteLine($"\rEntre o número {numIni} e {numFin}, sorteei o número {numSor}.");
            Console.ReadKey();
            
            

        }
    }
}
