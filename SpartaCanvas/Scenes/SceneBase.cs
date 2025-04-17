using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SpartaCanvas
{
    public abstract class SceneBase
    {
        public abstract string Name { get; }
        public List<Menu> menus;

        public SceneBase()
        {
            menus = [];
            menus.Add(new QuitMenu());
        }

        public virtual void Init()
        {
            Console.Clear();
            if(GameManager.messageLog != null)
            {
                Console.WriteLine(GameManager.messageLog + "\n");
                GameManager.messageLog = null;
            }
        }
        public abstract void PlayScene();
        public void ShowMenus()
        {
            Console.WriteLine();
            
            for (int i = 1; i < menus.Count; i++)
            {
                Console.WriteLine($"{i}. {menus[i].Name}");
            }

            Console.WriteLine();
        }

        public void ShowQuitMenu()
        {
            Console.WriteLine($"\n{0}. {menus[0].Name}\n");
        }
        public void AskMenu(out Menu menu)
        {
            Menu? chosenMenu = null;

            while (chosenMenu == null)
            {
                Console.WriteLine("원하시는 행동을 입력해주세요.");
                Console.Write(">> ");

                string? input = Console.ReadLine();

                // 공백으로 넘기면 행동 입력 다시 받기
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("입력이 비어있습니다.\n");
                    continue;
                }
          
                bool isOnlyInt = int.TryParse(input, out int result);

                if (!isOnlyInt)
                {
                    Console.WriteLine("숫자만 입력해주세요.\n");
                    continue;
                }

                if (result < 0 || result >= menus.Count)
                {
                    Console.WriteLine("범위 내 숫자를 입력해주세요.\n");
                    continue;
                }

                chosenMenu = menus[result];
            }
            menu = chosenMenu;
        }
    }
}
