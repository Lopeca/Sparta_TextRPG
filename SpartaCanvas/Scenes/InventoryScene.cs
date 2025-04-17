using SpartaCanvas;

namespace SpartaCanvas
{    public class InventoryScene : SceneBase
    {
        public override string Name => "InventoryScene";

        public InventoryScene()
        {
            menus.Add(new ManageEquipmentMenu());            
        }
        public override void Init()
        {           

            base.Init();
            PlayScene();
        }

        public override void PlayScene()
        {
            Console.WriteLine("<<인벤토리>>");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.\n");

            Utility.DrawDivineLine();
            Console.WriteLine("[아이템 목록]");

            List<Item> items = GameManager.player.items;

            ShowItemList(items);

            Utility.DrawDivineLine();

            ShowMenus();
            ShowQuitMenu();

            AskMenu(out Menu selectedMenu);
            selectedMenu.Execute();
        }

        private void ShowItemList(List<Item> items)
        {
            Console.WriteLine();

            foreach (Item item in items)
            {
                Console.Write(" - ");
                item.ShowInfo();
            }

            Console.WriteLine();
        }
    }
}
