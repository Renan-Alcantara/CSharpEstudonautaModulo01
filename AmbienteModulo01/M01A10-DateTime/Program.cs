using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A10_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia = DateTime.Now.Day;
            int mes = DateTime.Now.Month;
            int ano = DateTime.Now.Year;
            Console.WriteLine("Hoje é o dia " + dia + " do " + mes + " de " + ano + "!");

            int hora = DateTime.Now.Hour;
            int min = DateTime.Now.Minute;
            int sec = DateTime.Now.Second;
            Console.WriteLine("Atualmente são " + hora + " horas, " + min + " minutos e " + sec + " segundos.");

            Console.Write("\nDigite o ano em que você nasceu (com 4 digitos): ");
            int anoNasc;
            int.TryParse(Console.ReadLine(), out anoNasc);
            Console.WriteLine("Atualmente, você tem " + (ano - anoNasc) + " anos.");
            Console.ReadKey();

        }
    }
}
