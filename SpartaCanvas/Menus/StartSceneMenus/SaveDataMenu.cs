using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaCanvas
{
        public class SaveDataMenu : Menu
    {
        public override string Name => "저장";

        public override void Execute()
        {
            GameManager.SaveData();
            GameManager.messageLog = "저장되었습니다.";
            GameManager.scenes.Peek().Init();
        }
    }
}
