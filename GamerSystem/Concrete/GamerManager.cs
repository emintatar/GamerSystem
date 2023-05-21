using GamerSystem.Abstract;
using GamerSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerSystem.Concrete
{
    public class GamerManager : IGamerService
    {
        IGamerCheckService _checkService;

        public GamerManager(IGamerCheckService checkService)
        {
            _checkService = checkService;
        }

        public void Register(Gamer gamer)
        {
            if (_checkService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine("Registration Successful!");
            }
            else
            {
                Console.WriteLine("Registration failed!");
            }
        }

        public void UpdateGamer(Gamer gamer)
        {
            Console.WriteLine("Gamer updated!");
        }

        public void DeleteGamer(Gamer gamer)
        {
            Console.WriteLine("Gamer deleted!");
        }
    }
}
