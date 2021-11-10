using System;

namespace TicTacToeProblem
{
        class TicTacToeGame
        {
            public static void BoardInitialise()
            {
                char[] board = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                foreach (char i in board)
                {
                    Console.WriteLine("Element is: {0} ", i);
                }
            }
            static void Main(string[] args)
            {

                Console.WriteLine("welcome to TicTacToe!");
                BoardInitialise();
            }
        }
}
