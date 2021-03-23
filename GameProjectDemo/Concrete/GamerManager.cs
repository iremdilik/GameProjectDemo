using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class GamerManager : IGamerService
    {
        IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.Check(gamer) == true)
            {
                Console.WriteLine("Hesap oluşturuldu");
            }
            else
            {
                Console.WriteLine("Hesap oluşturulamadı.Geçersiz bilgi girişi");
            }

        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Hesap silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Hesap güncellendi");
        }
    }
}
