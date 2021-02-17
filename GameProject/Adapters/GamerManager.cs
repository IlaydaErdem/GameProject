using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Adapters
{
    public class GamerManager : IGamerService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Üye Eklendi : " + gamer.FirstName + " " + gamer.LastName);
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Üye Silindi : " + gamer.FirstName + " " + gamer.LastName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Üye Güncellendi : " + gamer.FirstName + " " + gamer.LastName);
        }
    }
}
