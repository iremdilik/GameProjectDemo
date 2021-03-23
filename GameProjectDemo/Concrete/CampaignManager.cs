﻿using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi : " + campaign.Name);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi : " + campaign.Name);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi : " + campaign.Name);
        }
    }
}
