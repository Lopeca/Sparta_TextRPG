using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SpartaCanvas
{
    internal static class GameManager
    {
        public static Stack<SceneBase> scenes = new Stack<SceneBase>();
        public static Player? player;
        public static string? messageLog;
        public static void LoadScene(SceneBase scene)
        {
            scenes.Push(scene);
            scenes.Peek().Init();
        }

        public static void SaveData()
        {
            string path = Utility.SavePath;

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(player.level.ToString());
                writer.WriteLine(player.chad);
                writer.WriteLine(player.atk.ToString());
                writer.WriteLine(player.def.ToString());
                writer.WriteLine(player.hp.ToString());
                writer.WriteLine(player.gold.ToString());
                writer.WriteLine(player.exp.ToString());

                foreach (var item in player.items)
                {
                    string itemNameToWrite = item.name;
                    if (item.isEquiped) itemNameToWrite += "[E]";
                    writer.Write(itemNameToWrite + "|");
                }
            }
        }
    }
}
