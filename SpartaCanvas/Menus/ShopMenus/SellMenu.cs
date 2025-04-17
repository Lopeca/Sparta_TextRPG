using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaCanvas
{
        public class SellMenu : Menu
    {
        public override string Name => "판매하기";

        public override void Execute()
        {
            SellScene sellScene = new SellScene();
            ShopScene prevScene = GameManager.scenes.Peek() as ShopScene;
            sellScene.shop = prevScene.shop;
            GameManager.LoadScene(sellScene);
        }
    }
}
