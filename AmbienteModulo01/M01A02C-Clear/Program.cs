using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A02C_Clear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(20, 3); // Modifica a posição inicial do Cursor
            Console.WriteLine("Ola alunos!");
            Console.ReadKey();
            Console.Clear(); // Limpa a Tela
            Console.WriteLine("Tudo bem contigo?");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Black; // Muda a Cor da Letra
            Console.BackgroundColor = ConsoleColor.White; // Muda a Cor de Fundo
            Console.Clear();
            Console.WriteLine("White is the new Black!");
            Console.ReadKey();
            Console.ResetColor(); //Volta as cores para o estado default
            Console.Clear();
            Console.WriteLine("Finalizando Testes. Tecle qualquer coisa para fechar.");
            Console.ReadKey();

        }
    }
}
