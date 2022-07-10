 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A04_TiposPrimitivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Valores numéricos Inteiros
            Console.WriteLine("O Tipo byte vai de " + byte.MinValue + " Até " + byte.MaxValue); // Usa 1 byte (8 bits)
            Console.WriteLine("O Tipo sbyte vai de " + sbyte.MinValue + " Até " + sbyte.MaxValue); // Usa 1 byte (8 bits)
            Console.WriteLine("O Tipo short vai de " + short.MinValue + " Até " + short.MaxValue); // Usa 2 bytes (16 bits)
            Console.WriteLine("O Tipo ushort vai de " + ushort.MinValue + " Até " + ushort.MaxValue); // Usa 2 bytes (16 bits)
            Console.WriteLine("O Tipo int vai de " + int.MinValue + " Até " + int.MaxValue); // Usa 4 bytes (32 bits)
            Console.WriteLine("O Tipo uint vai de " + uint.MinValue + " Até " + uint.MaxValue); // Usa 4 bytes (32 bits)
            Console.WriteLine("O Tipo long vai de " + long.MinValue + " Até " + long.MaxValue); // Usa 8 bytes (64 bits)
            Console.WriteLine("O Tipo ulong vai de " + ulong.MinValue + " Até " + ulong.MaxValue); // Usa 8 bytes (64 bits)
            // Valores numéricos Reais
            Console.WriteLine("O Tipo float vai de " + float.MinValue + " Até " + float.MaxValue); // Usa 4 bytes (32 bits)
            Console.WriteLine("O Tipo double vai de " + double.MinValue + " Até " + double.MaxValue); // Usa 8 bytes (64 bits)
            Console.WriteLine("O Tipo decimal vai de " + decimal.MinValue + " Até " + decimal.MaxValue); // Usa 16 bytes (128 bits)
            // Valores Lógicos
            Console.WriteLine("O Tipo bool aceita " + bool.FalseString + " ou " + bool.TrueString); // Usa 1 bit (True e False)
            Console.ReadKey();
        }
    }
}
