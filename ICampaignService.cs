using System;
using System.Collections.Generic;
using System.Text;

namespace _101Simulate
{
    interface ICampaignService
    {
        void AddCampaign(Player player,Chip Chip,Campaign campaign);
        void DeleteCampaign(Player player, Chip Chip, Campaign campaign);
        void UpdateCampaign(Player player, Chip Chip, Campaign campaign);
    }
}
