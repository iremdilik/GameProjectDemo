using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GamerCheckManager : IGamerCheckService
    {
        public bool Check(Gamer gamer)
        {
            if (gamer.BirthYear == 2001 && gamer.FirstName == "İREM" &&
                gamer.LastName == "DİLİK" && gamer.IdentityNumber == 12345678910)
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