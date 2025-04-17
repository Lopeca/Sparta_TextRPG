using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaCanvas
{
        public class ManageEquipmentMenu : Menu
    {
        public override string Name => "장착 관리";

        public override void Execute()
        {
            GameManager.LoadScene(new ManageEquipmentScene());
        }
    }
}
