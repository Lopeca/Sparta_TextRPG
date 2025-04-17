using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaCanvas
{
    internal class Game
    {
        public string GameName { get; set; }
        public Game(string gameName)
        {
            GameManager.scenes.Push(new StartScene());
            GameName = gameName;
        }
        internal void Play()
        {
            GameManager.player = new Player();

            if (!File.Exists(Utility.SavePath))
            {                              
                GameManager.player.Obtain(ItemData.IronArmor);
                GameManager.player.Obtain(ItemData.SpartaSpear);
                GameManager.player.Obtain(ItemData.OldSword);
            }
            else
            {
                // 세이브 파일 로드
                string[] lines = File.ReadAllLines(Utility.SavePath);

                GameManager.player.level = int.Parse(lines[0]);
                GameManager.player.chad = lines[1];
                GameManager.player.atk = float.Parse(lines[2]);
                GameManager.player.def = float.Parse(lines[3]);
                GameManager.player.hp = int.Parse(lines[4]);
                GameManager.player.gold = int.Parse(lines[5]);
                GameManager.player.exp = int.Parse(lines[6]);

                GameManager.player.items = Utility.LoadItemsFromSaveData(lines[7]);
                GameManager.scenes.Peek().Init();
            }
        }

    }
}
