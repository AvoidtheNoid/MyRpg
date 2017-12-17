using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Enemy : Character
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        public List<Loot> LootTable { get; set; }

        public Enemy(int id, string name, int maxHP, int curHP, int maxdmg, int expreward, int goldreward) : base(maxHP, curHP)
        {
            ID = id;
            Name = name;
            MaximumDamage = maxdmg;
            RewardExperiencePoints = expreward;
            RewardGold = goldreward;
            LootTable = new List<Loot>();
        }

    }
}
