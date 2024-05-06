using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKEandLADDER
{
    public class Repeat_till_100

    {
        public void play_till_reach_100()
        {
            int player_pos = 0;
            int no_of_times_dice_rolled=0;
            List<int> player_pos_at_each_move=new List<int>();
            Random_dice_num obj1 = new Random_dice_num();
            Position_move obj = new Position_move();
            while (player_pos!=100)
            {
                
                int dice_num = obj1.roll();
                no_of_times_dice_rolled++;
                player_pos=obj.move(dice_num,player_pos);
                player_pos_at_each_move.Add(player_pos);
            }
        }
    }
}
