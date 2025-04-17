using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaCanvas
{
        public class BuyMenu : Menu
    {
        public override string Name => "구매하기";

        public override void Execute()
        {
            BuyScene buyScene = new BuyScene();
            ShopScene prevScene = GameManager.scenes.Peek() as ShopScene;
            buyScene.shop = prevScene.shop;
            GameManager.LoadScene(buyScene);
        }
    }
}
