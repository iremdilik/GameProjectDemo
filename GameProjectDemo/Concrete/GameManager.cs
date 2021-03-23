using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Oyun eklendi: " + game.Name);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Oyun silindi : " + game.Name);
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun güncellendi : " + game.Name);
        }
    }

}
