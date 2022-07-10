using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A02_SequenciasDeEscape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alcântara");
            Console.WriteLine("Alcân\ntara"); // \n Pula Linha 
            Console.WriteLine("Alcân\ttara"); // \t Tabulação
            Console.WriteLine("Alcân\btara"); // \b Backspace
            Console.WriteLine("Alcân\atara"); // \a Alerta Sonoro
            Console.WriteLine("Alcân\rtara"); // \r Retorno
            Console.WriteLine("Alcân\\tara"); // \\ Barra
            Console.WriteLine("Alcân\"tara"); // \" Aspas
            Console.ReadKey();
        }
    }
}
