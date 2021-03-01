using System;
using System.Collections.Generic;
using System.Text;

namespace _101Simulate
{
    class CampaignManager : ICampaignService
    {
        public void AddCampaign(Player player,Chip chip,Campaign campaign)
        {
            double campaignPercent = campaign.CampaignPercent;
            double chipPrice = chip.ChipPrice;

            double newPrice=chipPrice - (chipPrice * (campaignPercent / 100));

            Console.WriteLine(player.NickName+" için özel kampanya!");
            Console.WriteLine(chip.ChipPrice+" TL olan " + chip.ChipUnit + " çip " + newPrice + " TL oldu!!!" );
        }

        public void DeleteCampaign(Player player, Chip Chip, Campaign campaign)
        {
            Console.WriteLine(player.NickName + " için olan kampanya kaldırıldı!!!" );
        }

        public void UpdateCampaign(Player player, Chip Chip, Campaign campaign)
        {
            Console.WriteLine(player.NickName + " için olan kampanya düzenlendi.");
        }
    }
}
