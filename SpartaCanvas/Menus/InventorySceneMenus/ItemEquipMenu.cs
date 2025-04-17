using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaCanvas
{
        public class ItemEquipmentMenu : Menu
    {
        public override string Name => "";
        public Item item;

        public ItemEquipmentMenu(Item item)
        {
            this.item = item;
        }

        public override void Execute()
        {
            if(item.isEquiped)      // 장착 중인 아이템은 그냥 해제하면 됨
            {
                item.ToggleEquip();
            }
            // 장착 중이지 않은 아이템은 조건부로 장착
            else
            {       
                Item typeItem = GameManager.player.items.Find(el => el.GetType() == item.GetType() && el.isEquiped);
                if (typeItem != null)
                {
                    GameManager.messageLog = "해당 부위 장비는 이미 장착중입니다.\n";
                    Console.WriteLine(typeItem.name);
                    Console.WriteLine(typeItem.name);
                }
                else
                {
                    item.ToggleEquip();
                }
            }
           
        }
    }
}
