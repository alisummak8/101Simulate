using System;

namespace _101Simulate
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.CitizenId = "0000001";
            player1.FirstName ="Mehmet Ali";
            player1.LastName ="Summak";
            player1.BornYear =2001;
            player1.NickName ="VurduKacti101";

            IPlayerService playerManager = new PlayerManager(new EDevletVerifyManager());

            playerManager.Register(player1);

            Chip chip1 = new Chip();
            chip1.ChipPrice = 15;
            chip1.ChipUnit ="1500";

            IChipService chipManager = new ChipManager();
            chipManager.Buy(player1,chip1);

            Console.WriteLine();

            ICampaignService campaignManager = new CampaignManager();
            campaignManager.AddCampaign(player1,chip1, new Campaign {CampaignName="Doğum Günü İndirimi",CampaignPercent=47});

        }
    }
}
