using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaCanvas
{
    public static class DungeonData
    {
        public static readonly Dungeon easyDungeon = new("쉬운 던전", 5, 1000);
        public static readonly Dungeon normalDungeon = new("일반 던전", 11, 1700);
        public static readonly Dungeon hardDungeon = new("어려운 던전", 17, 2500);
    }
}
