using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaCanvas
{
        public class EnterStatusSceneMenu : Menu
    {
        public override string Name => "상태 보기";

        public override void Execute()
        {
            GameManager.LoadScene(new StatusScene());
        }
    }
}
