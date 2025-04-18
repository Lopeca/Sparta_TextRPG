namespace SpartaCanvas
{
    internal class SellScene : SceneBase
    {
        public override string Name => "상점/판매";
        public Shop shop;

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
            Console.WriteLine("[구매 가능한 아이템 목록]");
            Console.WriteLine("# 판매할 아이템의 번호를 입력해주세요.");

            ShowItemListToSell();
            Utility.DrawDivineLine();

            ShowQuitMenu();

            AskMenu(out Menu selectedMenu);
            selectedMenu.Execute();
            if (selectedMenu != menus[0]) menus[0].Execute(); // menus[0]은 Quit

        }

        private void ShowItemListToSell()
        {
            List<ShopItem> items = shop.items;

            int index = 0;
            foreach (ShopItem shopItem in items)
            {
                if (!shopItem.isSold) continue;
                index++;

                Console.Write($" - {index} {shopItem.item.CostToString()} ");
                shopItem.item.ShowInfo();

                menus.Add(new SellSingleItemMenu(shopItem));
            }


        }
    }
}