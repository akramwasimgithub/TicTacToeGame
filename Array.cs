using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeFame
{

   public class TicTacToeGame
    {

        public const char X = 'X';
        public const char O = 'O';
        char[] Board = new char[10]; //declaration of array name Board of size 10
        public void gameBoard()
        {

            for (int i = 1; i < 9; i++)
            {
                Board[i] = ' ';
                Console.WriteLine( Board[i]);
            }
        }

        public void Choose_X_or_O_()
        {
            Console.WriteLine("Enter you Choice from O/X :");
            char playerSelect = Convert.ToChar(Console.ReadLine());
            if (playerSelect == 'X')
            {
                Console.WriteLine("Player Choose " + playerSelect);
                Console.WriteLine("Computer Choose " + O);
            }
            else if (playerSelect == 'O')
            {
                Console.WriteLine("Player Choose " + playerSelect);
                Console.WriteLine(" Computer Choose " + X);
            }
            else
            {
                Console.WriteLine("Select invalid input  ");
            }
        }
    }
}
