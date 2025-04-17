using SpartaCanvas;

namespace SpartaCanvas
{    public class RestScene : SceneBase
    {
        public override string Name => "RestScene";
        public int restCost = 500;
        public RestScene()
        {
            menus.Add(new RestMenu(restCost));
        }
        public override void Init()
        {           
            base.Init();
            PlayScene();
        }

        public override void PlayScene()
        {
            Console.WriteLine("<<휴식하기>>");
            Console.WriteLine($"500G 를 내면 체력을 회복할 수 있습니다. (보유 골드 : {GameManager.player.gold.ToString()} G)");

            ShowMenus();

            ShowQuitMenu();
            AskMenu(out Menu selectedMenu);

            selectedMenu.Execute();
        }
    }
}
