using TicTacToeOOAD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeOOAD
{
    class Program
    {
        static void Main(string[] args)
        {
            Board b = new Board();
            Player p = new Player();
            ResultAnalyzer r = new ResultAnalyzer();

            int player = 2, turns = 0, input = 0;
            bool inputCorrect = true;
            char playerSignature = ' ';

            char[] ArrBoard =
            {
                '1', '2', '3','4', '5', '6','7', '8', '9'
            };

            Introduction();

            do
            {
                if (player == 2)
                {
                    player = 1;
                    p.XorO(player, input, playerSignature, ArrBoard);
                }
                else if (player == 1)
                {
                    player = 2;
                    p.XorO(player, input, playerSignature, ArrBoard);
                }

                b.DrawBoard(ArrBoard);
                turns++;

                r.HorizontalWin(ArrBoard, turns);
                r.VerticalWin(ArrBoard, turns);
                r.DiagonalWin(ArrBoard, turns);

                if (turns == 10)
                {
                    Console.WriteLine("It's a draw." + "\nPlease press any key to reset the game and try again!");
                    Console.ReadKey();
                    b.BoardReset(ArrBoard, turns);
                }

                do
                {
                    Console.WriteLine("\nReady Player {0}: It's your move!", player);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a number!");
                    }

                    if ((input == 1) && (ArrBoard[0] == '1'))
                        inputCorrect = true;
                    else if ((input == 2) && (ArrBoard[1] == '2'))
                        inputCorrect = true;
                    else if ((input == 3) && (ArrBoard[2] == '3'))
                        inputCorrect = true;
                    else if ((input == 4) && (ArrBoard[3] == '4'))
                        inputCorrect = true;
                    else if ((input == 5) && (ArrBoard[4] == '5'))
                        inputCorrect = true;
                    else if ((input == 6) && (ArrBoard[5] == '6'))
                        inputCorrect = true;
                    else if ((input == 7) && (ArrBoard[6] == '7'))
                        inputCorrect = true;
                    else if ((input == 8) && (ArrBoard[7] == '8'))
                        inputCorrect = true;
                    else if ((input == 9) && (ArrBoard[8] == '9'))
                        inputCorrect = true;
                    else
                    {
                        Console.WriteLine("Already Entered there \nPlease try again...");
                        inputCorrect = false;
                    }
                } while (!inputCorrect);
            } while (true);
        }
        public static void Introduction()
        {
            Console.WriteLine("Players are represented with a unique signature" +
                              "\nPlayer 1 = O.  Player 2 = X");
            Console.WriteLine("\nNow press any key to begin...");
            Console.ReadKey();
        }
    }
}
