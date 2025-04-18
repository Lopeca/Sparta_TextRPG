using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaCanvas
{
    public class EnterShopSceneMenu : Menu
    {
        public override string Name => "상점";

        public override void Execute()
        {
            GameManager.LoadScene(new ShopScene());
        }
    }
}
