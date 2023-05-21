using GamerSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerSystem.Abstract
{
    public interface IGamerService
    {
        void Register(Gamer gamer);
        void UpdateGamer(Gamer gamer);
        void DeleteGamer(Gamer gamer);
    }
}
