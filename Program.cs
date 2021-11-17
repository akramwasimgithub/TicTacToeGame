using System;

namespace TicTacToeFame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TicTacToeGame obj = new TicTacToeGame();
            obj.gameBoard();

            Console.ReadKey();
        }
    }
}
