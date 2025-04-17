using SpartaCanvas;

namespace SpartaCanvas
{
    public class DungeonClearScene : SceneBase
    {
        public override string Name => "DungeonClearScene";

        Dungeon dungeon;
        bool hasCleared;
        public DungeonClearScene(Dungeon dungeon)
        {
            this.dungeon = dungeon;

        }
        public override void Init()
        {
            base.Init();
            PlayScene();
        }

        public override void PlayScene()
        {
            if (GameManager.player.GetTotalDef() < dungeon.recommendArmor)
            {
                Random rand = new Random();
                hasCleared = rand.NextDouble() < 0.4;
            }
            else
            {
                hasCleared = true;
            }

            if (hasCleared) // 던전 클리어 시
            {
                Console.WriteLine("<<던전 클리어>>");
                Console.WriteLine("축하합니다!!");
                Console.WriteLine($"{dungeon.name}을 클리어하셨습니다.\n");

                Console.WriteLine("[탐험 결과]");

                int prevHP = GameManager.player.hp;
                GameManager.player.GetDamage(CalculateDamage());
                Console.WriteLine($"체력 : {prevHP} -> {GameManager.player.hp}");
                
                int prevGold = GameManager.player.gold;
                GameManager.player.gold += CalculateReward();
                Console.WriteLine($"Gold : {prevGold} G -> {GameManager.player.gold} G");

                GameManager.player.GetEXP(1);
            }
            else // 던전 실패 시
            {
                Console.WriteLine("<<던전 공략 실패>>");

                int prevHP = GameManager.player.hp;
                GameManager.player.GetDamage(GameManager.player.hp / 2);
                Console.WriteLine($"체력 : {prevHP} -> {GameManager.player.hp}");
            }
            ShowQuitMenu();
            AskMenu(out Menu selectedMenu);

            selectedMenu.Execute();
        }

        private int CalculateDamage()
        {
            Random rand = new Random();
            int damage = rand.Next(20, 35);

            damage -= (int)GameManager.player.GetTotalDef() - dungeon.recommendArmor;

            return damage;
        }

        private int CalculateReward()
        {
            Random rand = new Random();
            int playerAtk = (int)GameManager.player.GetTotalAtk();
            double bonusPercent = playerAtk * ( 1 + rand.NextDouble()); // 플레이어 공격력에 1~2 값 곱하기 (공격력 10이면 10~20)

            bonusPercent /= 100;    // 위에서 구한 값을 100으로 나눔 (0.1~0.2)

            double reward = dungeon.reward * (1 + bonusPercent); // 던전 보상에 1.1~1.2가 곱해지는 식

            return (int)Math.Round(reward);
        }
    }
}
