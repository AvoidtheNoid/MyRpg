using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
     public class Player
    {
        public int CurHitPoints { get; set; }
        public int MaxHitPoints { get; set; }
        public int Gold { get; set; }
        public int ExperiencePts { get; set; }
        public int Level { get; set; }

        public Player()
        {
            //set base values
        }
    }
}
