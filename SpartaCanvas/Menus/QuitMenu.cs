namespace SpartaCanvas
{
    internal class QuitMenu : Menu
    {
        public override string Name => "나가기";

        public override void Execute()
        {
            GameManager.scenes.Pop();
            GameManager.scenes.Peek().Init();
        }
    }
}
