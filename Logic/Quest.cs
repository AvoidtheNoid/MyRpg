﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Quest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        public List<QuestCompletion> QuestCompletion { get; set; }

        public Quest(int id, string name, string description, int expreward, int goldreward)
        {
            ID = id;
            Name = name;
            Description = description;
            expreward = RewardExperiencePoints;
            goldreward = RewardGold;
            QuestCompletion = new List<QuestCompletion>();
        }

    }
}