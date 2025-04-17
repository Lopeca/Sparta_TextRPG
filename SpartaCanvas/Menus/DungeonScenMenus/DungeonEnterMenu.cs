using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaCanvas
{
    public class DungeonEnterMenu : Menu
    {
        Dungeon selectedDungeon;

        public DungeonEnterMenu(string name, Dungeon dungeon)
        {
            Name = name;
            selectedDungeon = dungeon;
        }

        public override void Execute()
        {
            GameManager.LoadScene(new DungeonClearScene(selectedDungeon));
        }
    }
}
