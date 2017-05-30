using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_cs
{
    class Player
    {
        char marker;
        bool isHuman;

        public Player()
        {
            marker = 'X';
            isHuman = true;
        }

        public Player(bool inIsHuman)
        {
            this.isHuman = inIsHuman;

            if (inIsHuman == true)
            {
                marker = 'X';
            }
            else
            {
                marker = 'O';
            }
        }

        public char getMarker()
        {
            return marker;
        }
        public bool getisHuman()
        {
            return isHuman;
        }

        public string getPlayerMove(char player, Board b)
        {
            if (player == 'X')
                return getHumanMove();
            else
                return generateComputerMove(b);

        }

        public string getHumanMove()
        {
            string move = Console.ReadLine();
            return move;
        }

        public string generateComputerMove(Board b)
        {

      
            if ((b.gameBoard[0, 0] == 'X' && b.gameBoard[0, 1] == 'X' && b.gameBoard[0, 2] == 0) || (b.gameBoard[0, 0] == 'O' && b.gameBoard[0, 1] == 'O' && b.gameBoard[0, 2] == 0))
                return "C1";
            else if ((b.gameBoard[0, 1] == 'X' && b.gameBoard[0, 2] == 'X' && b.gameBoard[0, 0] == 0) || (b.gameBoard[0, 1] == 'O' && b.gameBoard[0, 2] == 'O' && b.gameBoard[0, 0] == 0))
                return "A1";
            else if ((b.gameBoard[0, 0] == 'X' && b.gameBoard[0, 2] == 'X' && b.gameBoard[0, 1] == 0) || (b.gameBoard[0, 0] == 'O' && b.gameBoard[0, 2] == 'O' && b.gameBoard[0, 1] == 0))
                return "B1";
            else if ((b.gameBoard[1, 0] == 'X' && b.gameBoard[1, 1] == 'X' && b.gameBoard[1, 2] == 0) || (b.gameBoard[1, 0] == 'O' && b.gameBoard[1, 1] == 'O' && b.gameBoard[1, 2] == 0))
                return "C2";
            else if ((b.gameBoard[1, 1] == 'X' && b.gameBoard[1, 2] == 'X' && b.gameBoard[1, 0] == 0) || (b.gameBoard[1, 1] == 'O' && b.gameBoard[1, 2] == 'O' && b.gameBoard[1, 0] == 0))
                return "A2";
            else if ((b.gameBoard[1, 0] == 'X' && b.gameBoard[1, 2] == 'X' && b.gameBoard[1, 1] == 0) || (b.gameBoard[1, 0] == 'O' && b.gameBoard[1, 2] == 'O' && b.gameBoard[1, 1] == 0))
                return "B2";
            else if ((b.gameBoard[2, 0] == 'X' && b.gameBoard[2, 1] == 'X' && b.gameBoard[2, 2] == 0) || (b.gameBoard[2, 0] == 'O' && b.gameBoard[2, 1] == 'O' && b.gameBoard[2, 2] == 0))
                return "C3";
            else if ((b.gameBoard[2, 1] == 'X' && b.gameBoard[2, 2] == 'X' && b.gameBoard[2, 0] == 0) || (b.gameBoard[2, 1] == 'O' && b.gameBoard[2, 2] == 'O' && b.gameBoard[2, 0] == 0))
                return "A3";
            else if ((b.gameBoard[2, 0] == 'X' && b.gameBoard[2, 2] == 'X' && b.gameBoard[2, 1] == 0) || (b.gameBoard[2, 0] == 'O' && b.gameBoard[2, 2] == 'O' && b.gameBoard[2, 1] == 0))
                return "B3";
            else if ((b.gameBoard[0, 0] == 'X' && b.gameBoard[1, 0] == 'X' && b.gameBoard[2, 0] == 0) || (b.gameBoard[0, 0] == 'O' && b.gameBoard[1, 0] == 'O' && b.gameBoard[2, 0] == 0))
                return "A3";
            else if ((b.gameBoard[1, 0] == 'X' && b.gameBoard[2, 0] == 'X' && b.gameBoard[0, 0] == 0) || (b.gameBoard[1, 0] == 'O' && b.gameBoard[2, 0] == 'O' && b.gameBoard[0, 0] == 0))
                return "A1";
            else if ((b.gameBoard[0, 0] == 'X' && b.gameBoard[2, 0] == 'X' && b.gameBoard[1, 0] == 0) || (b.gameBoard[0, 0] == 'O' && b.gameBoard[2, 0] == 'O' && b.gameBoard[1, 0] == 0))
                return "A2";
            else if ((b.gameBoard[0, 1] == 'X' && b.gameBoard[1, 1] == 'X' && b.gameBoard[2, 1] == 0) || (b.gameBoard[0, 1] == 'O' && b.gameBoard[1, 1] == 'O' && b.gameBoard[2, 1] == 0))
                return "B3";
            else if ((b.gameBoard[1, 1] == 'X' && b.gameBoard[2, 1] == 'X' && b.gameBoard[0, 1] == 0) || (b.gameBoard[1, 1] == 'O' && b.gameBoard[2, 1] == 'O' && b.gameBoard[0, 1] == 0))
                return "B1";
            else if ((b.gameBoard[0, 1] == 'X' && b.gameBoard[2, 1] == 'X' && b.gameBoard[1, 1] == 0) || (b.gameBoard[0, 1] == 'O' && b.gameBoard[2, 1] == 'O' && b.gameBoard[1, 1] == 0))
                return "B2";
            else if ((b.gameBoard[0, 2] == 'X' && b.gameBoard[1, 2] == 'X' && b.gameBoard[2, 2] == 0) || (b.gameBoard[0, 2] == 'O' && b.gameBoard[1, 2] == 'O' && b.gameBoard[2, 2] == 0))
                return "C3";
            else if ((b.gameBoard[1, 2] == 'X' && b.gameBoard[2, 2] == 'X' && b.gameBoard[0, 2] == 0) || (b.gameBoard[1, 2] == 'O' && b.gameBoard[2, 2] == 'O' && b.gameBoard[0, 2] == 0))
                return "C1";
            else if ((b.gameBoard[0, 2] == 'X' && b.gameBoard[2, 2] == 'X' && b.gameBoard[1, 2] == 0) || (b.gameBoard[0, 2] == 'O' && b.gameBoard[2, 2] == 'O' && b.gameBoard[1, 2] == 0))
                return "C2";
            else if ((b.gameBoard[0, 0] == 'X' && b.gameBoard[1, 1] == 'X' && b.gameBoard[2, 2] == 0) || (b.gameBoard[0, 0] == 'O' && b.gameBoard[1, 1] == 'O' && b.gameBoard[2, 2] == 0))
                return "C3";
            else if ((b.gameBoard[1, 1] == 'X' && b.gameBoard[2, 2] == 'X' && b.gameBoard[0, 0] == 0) || (b.gameBoard[1, 1] == 'O' && b.gameBoard[2, 2] == 'O' && b.gameBoard[0, 0] == 0))
                return "A1";
            else if ((b.gameBoard[0, 0] == 'X' && b.gameBoard[2, 2] == 'X' && b.gameBoard[1, 1] == 0) || (b.gameBoard[0, 0] == 'O' && b.gameBoard[2, 2] == 'O' && b.gameBoard[1, 1] == 0))
                return "B2";
            else if ((b.gameBoard[0, 2] == 'X' && b.gameBoard[1, 1] == 'X' && b.gameBoard[2, 0] == 0) || (b.gameBoard[0, 2] == 'O' && b.gameBoard[1, 1] == 'O' && b.gameBoard[2, 0] == 0))
                return "A3";
            else if ((b.gameBoard[1, 1] == 'X' && b.gameBoard[2, 0] == 'X' && b.gameBoard[0, 2] == 0) || (b.gameBoard[1, 1] == 'O' && b.gameBoard[2, 0] == 'O' && b.gameBoard[0, 2] == 0))
                return "C1";
            else if ((b.gameBoard[0, 2] == 'X' && b.gameBoard[2, 0] == 'X' && b.gameBoard[1, 1] == 0) || (b.gameBoard[0, 2] == 'O' && b.gameBoard[2, 0] == 'O' && b.gameBoard[1, 1] == 0))
                return "B2";

            else if (b.gameBoard[1, 1] == 0)
            {
                return "B2";
            }


            ////////////////////////////////////////////////////
            else if (b.gameBoard[1, 1] == 'O' && (b.gameBoard[0, 0] == 'X' && b.gameBoard[2, 2] == 'X') || (b.gameBoard[0, 2] == 'X' && b.gameBoard[2, 0] == 'X'))
            {
                if (b.gameBoard[0, 1] == 0 && b.gameBoard[2, 1] == 0)
                {
                    if (b.gameBoard[0, 1] == 0)
                        return "B1";
                    else
                        return "B3";

                }

                else
                {
                    if (b.gameBoard[1, 0] == 0)
                        return "A2";
                    else
                        return "C2";
                }

            }




            //////////////////////////////////////////////////////////////////////////////
            else if (b.gameBoard[1, 1] == 'O')
            {
                if ((b.gameBoard[2, 1] == 'X' || b.gameBoard[0, 1] == 'X') && (b.gameBoard[0, 0] == 0 && b.gameBoard[2, 2] == 0 || b.gameBoard[0, 2] == 0 && b.gameBoard[2, 0] == 0))
                {
                    if (b.gameBoard[0, 0] == 0 && b.gameBoard[2, 2] == 0)
                    {
                        if (b.gameBoard[0, 2] == 'X' || b.gameBoard[1, 2] == 'X') 
                        {
                            return "C3";
                        }
                        else
                            return "A1";
                    }
                    else if (b.gameBoard[1, 2] == 0 && b.gameBoard[2, 0] == 0)
                    {
                        if (b.gameBoard[0, 0] == 'X' || b.gameBoard[1, 0] == 'X')      //
                        {
                            return "A3";
                        }
                        else
                            return "C1";

                    }

                    else
                        goto final;
                }
                else if (b.gameBoard[1, 2] == 'X' && (b.gameBoard[0, 0] == 0 && b.gameBoard[2, 2] == 0 || b.gameBoard[0, 2] == 0 && b.gameBoard[2, 0] == 0))
                {
                    if (b.gameBoard[0, 0] == 0 && b.gameBoard[2, 2] == 0)
                    {
                        if (b.gameBoard[2, 0] == 'X' || b.gameBoard[2, 1] == 'X')       //  
                        {
                            return "C3";
                        }
                        else
                            return "A1";
                    }
                    else
                    {
                        if (b.gameBoard[2, 1] == 'X' || b.gameBoard[2, 2] == 'X')  //  
                        {
                            return "A3";
                        }
                        else
                            return "C1";

                    }
                }

                else
                    goto final;


            }

            ///////////////////////////////////////////////////////////


            else if (b.gameBoard[1, 1] == 'X' && b.gameBoard[0, 0] == 0)
            {
                return "A1";

            }

            else if (b.gameBoard[1, 1] == 'X' && b.gameBoard[0, 2] == 0)
            {
                return "C1";

            }

            else if (b.gameBoard[1, 1] == 'X' && b.gameBoard[2, 0] == 0)
            {
                return "A3";

            }
            else if (b.gameBoard[1, 1] == 'X' && b.gameBoard[2, 2] == 0)
            {
                return "C3";

            }

                ///////////////////////////////////



            else if (b.gameBoard[0, 0] != 0 || b.gameBoard[0, 2] != 0 || b.gameBoard[2, 0] != 0 || b.gameBoard[2, 2] != 0)
           // else if (b.gameBoard[0, 0] != 'O' || b.gameBoard[0, 2] != 'O' || b.gameBoard[2, 0] != 'O' || b.gameBoard[2, 2] != 'O')
            {
                if (b.gameBoard[1, 1] == 0)
                    return "B2";
                else if (b.gameBoard[0, 1] == 0)
                    return "B1";
                else if (b.gameBoard[1, 0] == 0)
                    return "A2";
                else if (b.gameBoard[2, 1] == 0)
                    return "B3";
                else
                    return "C2";

            }
            
            final:
            if (b.gameBoard[0, 0] == 0)
                return "A1";
            else if (b.gameBoard[0, 1] == 0)
                return "B1";
            else if (b.gameBoard[0, 2] == 0)
                return "C1";
            else if (b.gameBoard[1, 0] == 0)
                return "A2";
            else if (b.gameBoard[1, 1] == 0)
                return "B2";
            else if (b.gameBoard[1, 2] == 0)
                return "C2";
            else if (b.gameBoard[2, 0] == 0)
                return "A3";
            else if (b.gameBoard[2, 1] == 0)
                return "B3";
            else
                return "C3";

        }

        





    }
}
