using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaCanvas
{
    public class Dungeon
    {
        public string name;
        public int recommendArmor;
        public int reward;

        public Dungeon(string name, int recommendArmor, int reward)
        {
            this.name = name;
            this.recommendArmor = recommendArmor;
            this.reward = reward;
        }
    }
}
