using System;
using System.Collections.Generic;
using System.Text;

namespace _101Simulate
{
    class PlayerManager : IPlayerService
    {

        IVerifyService _playerVerifyService;

        public PlayerManager(IVerifyService playerVerifyService)
        {
            _playerVerifyService = playerVerifyService;
        }
        public void Register(Player player)
        {
            if (_playerVerifyService.CheckAndVerify(player)==true)
            {
                Console.WriteLine("Oyuncu kayıt oldu.");
            }

            else
            {
                Console.WriteLine("e-Devlet kaydı hatalı !");
            }
        }
        public void DeleteAccount(Player player)
        {
            Console.WriteLine("Oyuncu silindi.");
        }

        public void Update(Person person)
        {
            Console.WriteLine("Oyuncu güncellendi.");
        }
    }
}
