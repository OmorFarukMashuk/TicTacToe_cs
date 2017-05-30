using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_cs
{
    class Board
    {
        public char[,] gameBoard = new char[3, 3];
        int i, j;

        public Board()
        {

        }

        public char[,] getgameBoard()
        {
            return gameBoard;
        }
        public void printBoard()
        {
            Console.Out.WriteLine("  A\tB\tC");
            for (i = 0; i < 3; i++)
            {
                Console.Out.Write(i + 1 + " |");
                for (j = 0; j < 3; j++)
                    Console.Out.Write("  " + gameBoard[i, j] + " \t|");
                Console.Out.WriteLine("\n-------------------------");

            }
        }

        public bool submitMove(string move, char player)
        {
            if (move.Equals("A1") || move.Equals("A2") || move.Equals("A3"))
            {
                j = 0;
            }

            else if (move.Equals("B1") || move.Equals("B2") || move.Equals("B3"))
            {
                j = 1;
            }

            else if (move.Equals("C1") || move.Equals("C2") || move.Equals("C3"))
            {
                j = 2;
            }

            i = Convert.ToInt32(Char.GetNumericValue(move, 1));
            i--;

            if (gameBoard[i, j] != 0)
            {
                return false;
            }

            else
            {
                gameBoard[i, j] = player;
                return true;
            }
        }

        public bool isWinner(char player)
        {
            if (gameBoard[0, 0] == player && gameBoard[1, 1] == player && gameBoard[2, 2] == player)
                return true;
            else if (gameBoard[0, 0] == player && gameBoard[0, 1] == player && gameBoard[0, 2] == player)
                return true;
            else if (gameBoard[0, 0] == player && gameBoard[1, 0] == player && gameBoard[2, 0] == player)
                return true;
            else if (gameBoard[1, 0] == player && gameBoard[1, 1] == player && gameBoard[1, 2] == player)
                return true;
            else if (gameBoard[2, 0] == player && gameBoard[2, 1] == player && gameBoard[2, 2] == player)
                return true;
            else if (gameBoard[0, 1] == player && gameBoard[1, 1] == player && gameBoard[2, 1] == player)
                return true;
            else if (gameBoard[0, 2] == player && gameBoard[1, 1] == player && gameBoard[2, 0] == player)
                return true;
            else if (gameBoard[0, 2] == player && gameBoard[1, 2] == player && gameBoard[2, 2] == player)
                return true;
            else
                return false;

        }

        public bool isTie()
        {
            int p, q;

            for (p = 0; p < 3; p++)
            {
                for (q = 0; q < 3; q++)
                {
                    if (gameBoard[p, q] == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool isMoveValid(string move)
        {
            if (move.Equals("A1") || move.Equals("A2") || move.Equals("A3") || 
                move.Equals("B1") || move.Equals("B2") || move.Equals("B3") || 
                move.Equals("C1") || move.Equals("C2") || move.Equals("C3"))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

    }

}
