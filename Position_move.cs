using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKEandLADDER
{
    public class Position_move
    {
        private int[] snakehead = new int[11] { 27, 35, 39, 50, 59, 66, 73, 76, 89, 97, 99 };
        private int[] snaketail = new int[11] { 7,5,39,34,46,24,12,63,67,86,26};
        private int[] ladderstart = new int[10] { 2, 7, 22, 28, 30, 44, 54, 70, 80, 87 };
        private int[] ladderend = new int[10] { 23, 29, 41, 77, 32, 58, 69, 90, 83, 93 };
        public int move(int dice,int playerposition)
        {  
            if (playerposition+dice<=100)
                playerposition = playerposition + dice;
            for (int i = 0; i < snakehead.Length; i++)
            {
                if (snakehead[i] == playerposition)
                {
                    playerposition = snaketail[i];
                }
                    break;
            }

            for (int j = 0; j < ladderstart.Length; j++)
            {
                if (ladderstart[j]==playerposition)
                { 
                    playerposition= ladderend[j];
                    Console.WriteLine("play the game again");
                  
                    break;
                }
            }
            return playerposition;

        }
    }
}
