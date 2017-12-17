using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Player : Character
    {
        public int Gold { get; set; }
        public int ExperiencePts { get; set; }
        public int Level { get; set; }
        public List<Inventory> Inventory { get; set; }
        public List<PlayerQuest> Quests { get; set; }

        
        public Player(int maxHp, int curHP, int gold, int exp, int level) : base(maxHp, curHP)
        {
            Gold = gold;
            ExperiencePts = exp;
            Level = level;

            Inventory = new List<Inventory>();
            Quests = new List<PlayerQuest>();

        }

    }
}
