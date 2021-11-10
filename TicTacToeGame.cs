using System;

namespace TicTacToeProblem
{
        class TicTacToeGame
        {
            public static void BoardInitialise()
            {
            char[] board = new char[10];
            for (int i = 1; i < board.Length; i++)
            {
                board[i] = ' ';
                Console.WriteLine("Element is: {0}\t", board[i]);
            }

        }

            static void Main(string[] args)
            {

                Console.WriteLine("welcome to TicTacToe!");
                BoardInitialise();
            }
        }
}
