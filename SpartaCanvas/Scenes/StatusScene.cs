using SpartaCanvas;

namespace SpartaCanvas
{    public class StatusScene : SceneBase
    {
        public override string Name => "StatusScene";

        public override void Init()
        {           
            base.Init();
            PlayScene();
        }

        public override void PlayScene()
        {
            Console.WriteLine("<<상태 보기>>");
            Console.WriteLine("캐릭터의 정보가 표시됩니다.");
            
            GameManager.player.ShowStats();
            ShowQuitMenu();
            AskMenu(out Menu selectedMenu);

            selectedMenu.Execute();
        }
    }
}
