using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKEandLADDER
{
    public class stay_same_pos_if_above_100
    {
        public void repeat(int playerposition,int dice)
        {
            while (playerposition < 100)
            {
                if (playerposition + dice <= 100)
                    playerposition += dice;

            }
        }
    }
}
