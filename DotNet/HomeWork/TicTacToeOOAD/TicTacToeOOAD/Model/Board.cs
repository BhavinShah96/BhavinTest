using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeOOAD.Model
{
    class Board
    {
        public void DrawBoard(char[] ArrBoard)
        {
            Console.Clear();
            Console.WriteLine("  -------------------------");
            Console.WriteLine("  |       |       |       |");
            Console.WriteLine("  |   {0}   |   {1}   |   {2}   |", ArrBoard[0], ArrBoard[1], ArrBoard[2]);
            Console.WriteLine("  |       |       |       |");
            Console.WriteLine("  -------------------------");
            Console.WriteLine("  |       |       |       |");
            Console.WriteLine("  |   {0}   |   {1}   |   {2}   |", ArrBoard[3], ArrBoard[4], ArrBoard[5]);
            Console.WriteLine("  |       |       |       |");
            Console.WriteLine("  -------------------------");
            Console.WriteLine("  |       |       |       |");
            Console.WriteLine("  |   {0}   |   {1}   |   {2}   |", ArrBoard[6], ArrBoard[7], ArrBoard[8]);
            Console.WriteLine("  |       |       |       |");
            Console.WriteLine("  -------------------------");
        }

        public void BoardReset(char[] ArrBoard, int turns)
        {
            char[] ArrBoardInitialize =
            {
                '1', '2', '3','4', '5', '6','7', '8', '9'
            };

            ArrBoard = ArrBoardInitialize;
            DrawBoard(ArrBoard);
            turns = 0;
        }
    }
}
