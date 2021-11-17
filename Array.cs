using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeFame
{

   public class TicTacToeGame
    {

        
        char[] Board = new char[10]; //declaration of array name Board of size 10
        public void gameBoard()
        {

            for (int i = 1; i < 9; i++)
            {
                Board[i] = ' ';
                Console.WriteLine( Board[i]);
            }
        }
        public const char X = 'X';
        public const char O = 'O';
        public void Choose_X_or_O_()
        {
            Console.WriteLine("Enter  Choice from O/X :");
            char playerSelect = Convert.ToChar(Console.ReadLine());
            if (playerSelect == 'X')
            {
                Console.WriteLine("Player Choose " + playerSelect);
                Console.WriteLine("Computer got: " + O);
            }
            else if (playerSelect == 'O')
            {
                Console.WriteLine("Player Choose " + playerSelect);
                Console.WriteLine("Computer got " + X);
            }
            else
            {
                Console.WriteLine("Selected invalid input  ");
            }



           
              
                Console.WriteLine(" "+ Board[1] + " | " + Board[2] + " | " + Board[3] + "   ");
                Console.WriteLine("---|---|---");
                Console.WriteLine(" "+ Board[4] + " | " + Board[5] + " | " + Board[6] + "   ");
                Console.WriteLine("---|---|---");
                Console.WriteLine(" " + Board[7] + " | " + Board[8] + " | " + Board[9] + "  ");
                
           


        }
    }
}
