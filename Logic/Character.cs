using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Character
    {

        public int MaxHitPoints { get; set; }
        public int CurHitPoints { get; set; }

        public Character(int maxHP, int curHP)
        {

            MaxHitPoints = maxHP;
            CurHitPoints = curHP;
        }

    }
}
