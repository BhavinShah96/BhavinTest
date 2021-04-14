using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeOOAD.Model
{
    class Player
    {
        public void XorO(int player, int input, char playerSignature, char[] ArrBoard)
        {

            if (player == 1) playerSignature = 'X';
            else if (player == 2) playerSignature = 'O';

            switch (input)
            {
                case 1: ArrBoard[0] = playerSignature; break;
                case 2: ArrBoard[1] = playerSignature; break;
                case 3: ArrBoard[2] = playerSignature; break;
                case 4: ArrBoard[3] = playerSignature; break;
                case 5: ArrBoard[4] = playerSignature; break;
                case 6: ArrBoard[5] = playerSignature; break;
                case 7: ArrBoard[6] = playerSignature; break;
                case 8: ArrBoard[7] = playerSignature; break;
                case 9: ArrBoard[8] = playerSignature; break;
            }
        }
    }
}
