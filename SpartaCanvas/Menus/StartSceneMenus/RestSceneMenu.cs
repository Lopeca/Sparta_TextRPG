using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaCanvas
{
        public class RestSceneMenu : Menu
    {
        public override string Name => "휴식하기";

        public override void Execute()
        {
            GameManager.LoadScene(new RestScene());
        }
    }
}
