using System;
using System.Collections.Generic;
using System.Text;

namespace _101Simulate
{
    class EDevletVerifyManager : IVerifyService
    {
        public bool CheckAndVerify(Player player)
        {
            if (player.CitizenId=="0000001" && player.FirstName=="Mehmet Ali" && player.LastName=="Summak" && player.BornYear==2001)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
