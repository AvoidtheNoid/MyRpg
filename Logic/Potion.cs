using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Potion : Item
    {
        public int AmountToHeal { get; set; }

        public Potion(int id, string name, string nameplural, int amounttoheal) : base( id, name, nameplural)
        {
            AmountToHeal = amounttoheal;
        }

    }
}
