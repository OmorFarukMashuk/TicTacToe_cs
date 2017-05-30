using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Board b = new Board();
            Player human = new Player();
            Player comp = new Player();

            Console.WriteLine("************************* ");
            Console.WriteLine(" Welcome to my Tic-Tac-Toe!");
            Console.WriteLine("*************************");
            Console.WriteLine("Please enter the column and then row of your move");
            b.printBoard();

            while (true)
            {
                //human player move ;
                while (true)
                {
                    Console.Write("Player Move (X): ");
                    string move = human.getPlayerMove('X',b);
                    if (b.isMoveValid(move) == true)
                    {
                        if (b.submitMove(move, 'X'))
                        {
                            b.printBoard();
                            break;
                        }
                        Console.WriteLine("The space entered is already taken.");

                    }
                    else
                    {
                        Console.WriteLine("Invalid Input: Please enter the column and row of your move (Example: A1).");
                    }

                }

                if (b.isWinner('X') == true)
                {
                    Console.WriteLine("You win !!");
                    break;
                }

                else if (b.isTie())
                {
                    Console.WriteLine("Gome Over ");
                    break;
                }

                //computer move 
                Console.Write("Computer Move (O): ");
                while (true)
                {
                    string move = comp.getPlayerMove('O',b);

                    if (b.isMoveValid(move))
                    {
                        if (b.submitMove(move, 'O'))
                        {
                            Console.WriteLine("{0}", move.ToString());
                            b.printBoard();
                            break;
                        }
                    }
                }



                if (b.isWinner('O') == true)
                {
                    Console.WriteLine("You Lose!!");
                    break;
                }

                else if (b.isTie())
                {
                    Console.WriteLine("Game Over ");
                    break;
                }
            }

        }
    }
}
