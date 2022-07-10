using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace M01A11A_Temporizador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia = DateTime.Now.Day;
            int mes = DateTime.Now.Month;
            int ano = DateTime.Now.Year;
            Console.Write("Hoje é dia ");
            Thread.Sleep(1000);
            Console.Write(dia);
            Thread.Sleep(1000);
            Console.Write(" do mês ");
            Thread.Sleep(1000);
            Console.Write(mes);
            Thread.Sleep(1000);
            Console.Write(" de ");
            Thread.Sleep(1000);
            Console.Write(ano);
            Console.ReadKey();
        }
    }
}
