using SpartaCanvas;

namespace SpartaCanvas
{    public class ManageEquipmentScene : SceneBase
    {
        public override string Name => "StartScene";

        public ManageEquipmentScene()
        {
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
            Console.WriteLine("# 장착하거나 해제할 아이템의 번호를 입력해주세요.");
            List<Item> items = GameManager.player.items;
            ShowItemList(items);
            Utility.DrawDivineLine();

            ShowQuitMenu();

            AskMenu(out Menu selectedMenu);
            selectedMenu.Execute();
            if(selectedMenu != menus[0]) menus[0].Execute(); // menus[0]은 Quit
        }

        private void ShowItemList(List<Item> items)
        {
            Console.WriteLine();

            for (int i = 0; i < items.Count; i++)
            {
                Item item = items[i];
                Console.Write($" - {i+1} ");
                item.ShowInfo();
                menus.Add(new ItemEquipmentMenu(item));
            }

            Console.WriteLine();
        }
    }
}
