using GamerSystem.Abstract;
using GamerSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GamerSystem.Concrete
{
    public class GamerCheckManager : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            if (gamer.DateOfBirth.Year == 2002 && gamer.FirstName == "Emin" && gamer.LastName == "Tatar" && gamer.NationalityId == "123456789")
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
