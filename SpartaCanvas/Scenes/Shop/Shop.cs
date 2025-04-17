using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaCanvas
{
    public class Shop
    {
        public List<ShopItem> items;

        public Shop()
        {
            items = new List<ShopItem>();

            items.Add(new ShopItem(ItemData.TraineeArmor, PlayerHasItem(ItemData.TraineeArmor)));
            items.Add(new ShopItem(ItemData.IronArmor, PlayerHasItem(ItemData.IronArmor)));

            Console.WriteLine("무쇠갑옷 판매 상태 : " + items.Find(i => i.item.name == "무쇠갑옷").isSold);
            items.Add(new ShopItem(ItemData.SpartaArmor, PlayerHasItem(ItemData.SpartaArmor)));
            items.Add(new ShopItem(ItemData.OldSword, PlayerHasItem(ItemData.OldSword)));
            items.Add(new ShopItem(ItemData.BronzeAx, PlayerHasItem(ItemData.BronzeAx)));
            items.Add(new ShopItem(ItemData.SpartaSpear, PlayerHasItem(ItemData.SpartaSpear)));
        }

        bool PlayerHasItem(Item shopItem)
        {
            Item playerItem = GameManager.player.items.Find(i => i.name == shopItem.name);
            if (playerItem != null)
            {
                return true;
            }
            else return false;
        }
    }
}
