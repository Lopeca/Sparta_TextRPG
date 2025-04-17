using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaCanvas
{
    internal static class Utility
    {
        public static void DrawDivineLine()
        {
            Console.WriteLine("====================================================");
        }

        public static readonly string SavePath = "savedata.txt";
        internal static List<Item> LoadItemsFromSaveData(string itemStr)
        {
            List<Item> items = new List<Item>();

            string[] itemNames = itemStr.Split('|', StringSplitOptions.RemoveEmptyEntries);

            foreach (string itemName in itemNames)
            {
                bool isEquipped = false;
                string itemNameOnly = itemName;
                if (itemName.EndsWith("[E]"))
                {
                    isEquipped = true;
                    itemNameOnly = itemName.Replace("[E]", "");
                }
                Item foundItem = FindItem(itemNameOnly);
                foundItem.isEquiped = isEquipped;

                items.Add(foundItem);

            }
            return items;
        }

        private static Item FindItem(string itemName)
        {
            return ItemData.ItemLookup[itemName];
        }
    }
}
