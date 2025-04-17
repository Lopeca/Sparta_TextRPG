using SpartaCanvas;

namespace SpartaCanvas
{    public class DungeonScene : SceneBase
    {
        public override string Name => "DungeonScene";

        public DungeonScene()
        {
            menus.Add(new DungeonEnterMenu("쉬운 던전\t| 방어력 5 이상 권장", DungeonData.easyDungeon));
            menus.Add(new DungeonEnterMenu("일반 던전\t | 방어력 11 이상 권장", DungeonData.normalDungeon));
            menus.Add(new DungeonEnterMenu("어려운 던전\t | 방어력 17 이상 권장", DungeonData.hardDungeon));
        }
        public override void Init()
        {           
            base.Init();
            PlayScene();
        }

        public override void PlayScene()
        {
            Console.WriteLine("<<던전 입장>>");
            Console.WriteLine("이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다");

            ShowMenus();
            ShowQuitMenu();
            AskMenu(out Menu selectedMenu);

            selectedMenu.Execute();
        }
    }
}
