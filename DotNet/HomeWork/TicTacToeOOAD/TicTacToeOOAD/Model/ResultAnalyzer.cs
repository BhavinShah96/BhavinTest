using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeOOAD.Model
{
    class ResultAnalyzer
    {
        Board b = new Board();
        public void HorizontalWin(char[] ArrBoard, int turns)
        {
            char[] playerSignatures = { 'X', 'O' };

            foreach (char playerSignatue in playerSignatures)
            {
                if (((ArrBoard[0] == playerSignatue) && (ArrBoard[1] == playerSignatue) && (ArrBoard[2] == playerSignatue))
                    || ((ArrBoard[3] == playerSignatue) && (ArrBoard[4] == playerSignatue) && (ArrBoard[5] == playerSignatue))
                    || ((ArrBoard[6] == playerSignatue) && (ArrBoard[7] == playerSignatue) && (ArrBoard[8] == playerSignatue)))
                {
                    Console.Clear();
                    if (playerSignatue == 'X')
                    {
                        Console.WriteLine("Congratulations Player 1.\nYou have a achieved a horizontal win! " +
                                          "\nTurns taken{0}", turns);
                    }
                    else if (playerSignatue == 'O')
                    {
                        Console.WriteLine("Congratulations Player 2.\nYou have a achieved a horizontal win! " +
                                          "\nTurns taken{0}", turns);
                    }

                    Console.WriteLine("Please press any key to reset the game");
                    Console.ReadKey();
                    b.BoardReset(ArrBoard,turns);

                    break;
                }
            }
        }

        public void VerticalWin(char[] ArrBoard, int turns)
        {
            char[] playerSignatures = { 'X', 'O' };

            foreach (char playerSignatue in playerSignatures)
            {
                if (((ArrBoard[0] == playerSignatue) && (ArrBoard[3] == playerSignatue) && (ArrBoard[6] == playerSignatue))
                    || ((ArrBoard[1] == playerSignatue) && (ArrBoard[4] == playerSignatue) && (ArrBoard[7] == playerSignatue))
                    || ((ArrBoard[2] == playerSignatue) && (ArrBoard[5] == playerSignatue) && (ArrBoard[8] == playerSignatue)))
                {
                    Console.Clear();
                    if (playerSignatue == 'X')
                    {
                        Console.WriteLine("Player 1, \nA vertical win!\n");
                    }
                    else
                    {
                        Console.WriteLine("Player 2, \nA vertical win!\n");
                    }

                    Console.WriteLine("Please press any key to reset the game");
                    Console.ReadKey();
                    b.BoardReset(ArrBoard, turns);

                    break;
                }
            }
        }

        public void DiagonalWin(char[] ArrBoard, int turns)
        {
            char[] playerSignatures = { 'X', 'O' };

            foreach (char playerSignatue in playerSignatures)
            {
                if (((ArrBoard[0] == playerSignatue) && (ArrBoard[4] == playerSignatue) && (ArrBoard[8] == playerSignatue))
                    || ((ArrBoard[6] == playerSignatue) && (ArrBoard[4] == playerSignatue) && (ArrBoard[2] == playerSignatue)))
                {
                    Console.Clear();
                    if (playerSignatue == 'X')
                    {
                        Console.WriteLine("player 1, A diagonal win!\n");
                    }
                    else
                    {
                        Console.WriteLine("player 2, A diagonal win!\n");
                    }

                    Console.WriteLine("Please press any key to reset the game");
                    Console.ReadKey();
                    b.BoardReset(ArrBoard, turns);

                    break;
                }
            }
        }
    }
}
