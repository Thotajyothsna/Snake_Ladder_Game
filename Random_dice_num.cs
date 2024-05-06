using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKEandLADDER
{
    public class Random_dice_num
    {  
        public int dice;
        public int roll()
        {
            var rand=new Random();
            dice=rand.Next(1,7);
            return dice;
        }
    }
}
