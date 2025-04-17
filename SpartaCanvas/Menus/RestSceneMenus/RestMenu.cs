using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaCanvas
{
    public class RestMenu : Menu
    {
        public override string Name => "휴식하기";
        public int restCost;

        public RestMenu(int restCost)
        {
            this.restCost = restCost;
        }
        public override void Execute()
        {
            if (GameManager.player.gold >= restCost)
            {
                GameManager.messageLog = "체력을 회복했습니다.\n";

                GameManager.player.gold -= restCost;
                GameManager.player.Recovery();
            }
            else
            {
                GameManager.messageLog = "골드가 필요합니다. \n";
            }

            GameManager.scenes.Peek().Init();
        }
    }
}
