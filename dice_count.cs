using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKEandLADDER
{
    public class dice_count
    {
        public static int dice_cnt;
        public int[] playerpositions=new int[dice_cnt];
        public void display()
        {
            Console.WriteLine("no of time the player played the dice{0}",dice_cnt);
            Console.WriteLine("player position after each dice roll is");
            for (int i = 0; i < dice_cnt; i++)
            {
                Console.WriteLine(playerpositions[i]);
            }
        }
    }
}
