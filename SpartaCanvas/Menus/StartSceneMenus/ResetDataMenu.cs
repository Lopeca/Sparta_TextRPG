using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaCanvas
{
        public class ResetDataMenu : Menu
    {
        public override string Name => "초기화";

        public override void Execute()
        {
            GameManager.ResetData();
            GameManager.messageLog = "초기화되었습니다. (주의 : 세이브 파일은 이전 저장 상태가 유지됩니다.)";
            GameManager.scenes.Peek().Init();
        }
    }
}
