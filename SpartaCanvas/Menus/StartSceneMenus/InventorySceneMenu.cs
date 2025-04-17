using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaCanvas
{
        public class InventorySceneMenu : Menu
    {
        public override string Name => "인벤토리";

        public override void Execute()
        {
            GameManager.LoadScene(new InventoryScene());
        }
    }
}
