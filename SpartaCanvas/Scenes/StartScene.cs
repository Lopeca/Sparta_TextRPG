using SpartaCanvas;

namespace SpartaCanvas
{    public class StartScene : SceneBase
    {
        public override string Name => "StartScene";

        public StartScene()
        {
            menus.Add(new EnterStatusSceneMenu());
            menus.Add(new EnterInventorySceneMenu());
            menus.Add(new EnterShopSceneMenu());
            menus.Add(new EnterDungeonSceneMenu());
            menus.Add(new EnterRestSceneMenu());
            menus.Add(new SaveDataMenu());
            menus.Add(new ResetDataMenu());
        }
        public override void Init()
        {           

            base.Init();
            PlayScene();
        }

        public override void PlayScene()
        {
            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다.");

            ShowMenus();
            Console.WriteLine("0. 게임 종료\n");
            AskMenu(out Menu selectedMenu);

           

            if (selectedMenu is not QuitMenu)
            {
                selectedMenu.Execute();
            }
            else
            {
                Console.WriteLine("\n게임을 즐겨주셔서 감사합니다.\n");
            }
        }
    }
}
