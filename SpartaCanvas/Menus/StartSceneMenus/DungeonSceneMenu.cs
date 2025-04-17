using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaCanvas
{
        public class DungeonSceneMenu : Menu
    {
        public override string Name => "던전 입장";

        public override void Execute()
        {
            GameManager.LoadScene(new DungeonScene());
        }
    }
}
