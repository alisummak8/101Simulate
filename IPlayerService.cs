using System;
using System.Collections.Generic;
using System.Text;

namespace _101Simulate
{
    interface IPlayerService:IPersonService
    {
        void Register(Player player);
        void DeleteAccount(Player player);
    }
}
