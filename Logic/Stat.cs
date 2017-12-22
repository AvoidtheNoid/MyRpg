using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Stat
    {
        public int HP { get; set; }
        public int MP { get; set; }
        public int PAtk { get; set; }
        public int MAtk { get; set; }
        public int PDef { get; set; }
        public int MDef { get; set; }
        public int Crit { get; set; }
        public int Dge { get; set; }
        public int Agi { get; set; }
        public int Str { get; set; }
        public int Wis { get; set; }
        public int Int { get; set; }

        public Stat(int hp, int mp, int patk, int matk, int pdef, int mdef, int crit, int dge, int agi, int str, int wis, int INT)
        {
            HP = hp;
            MP = mp;
            PAtk = patk;
            MAtk = matk;
            PDef = pdef;
            MDef = mdef;
            Crit = crit;
            Dge = dge;
            Agi = agi;
            Str = str;
            Wis = wis;
            Int = INT;
        }

        public void OnLevelUP()
        {

        }

    }
}
