using SpartaCanvas;

namespace SpartaCanvas
{    
    public class ShopScene : SceneBase
    {
        public override string Name => "InventoryScene";
        public Shop shop;
        public ShopScene()
        {
            shop = new Shop();
            menus.Add(new BuyMenu());
            menus.Add(new SellMenu());
        }
        public override void Init()
        {           
            base.Init();
            PlayScene();
        }

        public override void PlayScene()
        {
            Console.WriteLine("<<상점>>");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.\n");

            Console.WriteLine("[보유 골드]");
            Console.WriteLine(GameManager.player.gold.ToString() + " G\n");
            Utility.DrawDivineLine();
            Console.WriteLine("[아이템 목록]");

            List<ShopItem> items = shop.items;

            ShowItemList(items);

            Utility.DrawDivineLine();

            ShowMenus();
            ShowQuitMenu();

            AskMenu(out Menu selectedMenu);
            selectedMenu.Execute();
        }

        private void ShowItemList(List<ShopItem> items)
        {
            Console.WriteLine();

            for (int i = 0; i < items.Count; i++)
            {
                Item item = items[i].item;

                string costMark = items[i].isSold ? "[구매 완료]" : item.CostToString();
                Console.Write(" - "+ costMark + "| ");
                
                item.ShowInfo();
            }

            Console.WriteLine();
        }
    }
}
