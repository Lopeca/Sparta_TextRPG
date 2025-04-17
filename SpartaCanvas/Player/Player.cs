using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaCanvas
{
    public class Player
    {
        public int level;
        public string chad;
        public float atk;
        public float def;
        public int hp;
        public int gold;

        public int exp;

        public List<Item> items;
        public Player()
        {
            level = 1;
            chad = "전사";
            atk = 10;
            def = 5;
            hp = 100;
            gold = 1500;
            exp = 0;

            items = new List<Item>();
        }
        public void ShowStats()
        {
            int itemATK = 0;
            int itemDEF = 0;

            foreach (Item item in items)
            {
                if(item is AttackItem && item.isEquiped)
                {
                    
                    AttackItem attackItem = (AttackItem)item;
                    itemATK += attackItem.Atk;
                }
                if (item is ArmorItem && item.isEquiped)
                {
                    ArmorItem armorItem = (ArmorItem)item;
                    itemDEF += armorItem.Def;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Lv. {level:D2}");
            Console.WriteLine($"Chad ({chad})");
            Console.WriteLine($"공격력 : {atk.ToString("0.#")}" + (itemATK != 0 ? $" (+{itemATK})" : ""));
            Console.WriteLine($"방어력 : {def.ToString("0.#")}" + (itemDEF != 0 ? $" (+{itemDEF})" : ""));
            Console.WriteLine($"체력 : {hp}");
            Console.WriteLine($"Gold : {gold} G");
            Console.WriteLine($"EXP : {exp} / {level}");
            Console.WriteLine();
        }   

        public void Obtain(Item item)
        {
            items.Add(item);
        }

        public void Recovery()
        {
            hp = 100;
        }

        public int GetItemDef()
        {
            int itemDEF = 0;
            foreach (Item item in items)
            {
                if (item is ArmorItem && item.isEquiped)
                {
                    ArmorItem armorItem = (ArmorItem)item;
                    itemDEF += armorItem.Def;
                }
            }
            return itemDEF;
        }

        public int GetItemAtk()
        {
            int itemATK = 0;
            foreach (Item item in items)
            {
                if (item is AttackItem && item.isEquiped)
                {
                    AttackItem attackItem = (AttackItem)item;
                    itemATK += attackItem.Atk;
                }
            }
            return itemATK;
        }
        
        public float GetTotalDef()
        {
            return def + GetItemDef();
        }

        public float GetTotalAtk()
        {
            return atk + GetItemAtk();
        }

        public void GetEXP(int exp)
        {
            this.exp += exp;

            if (this.exp >= level)
            {
                this.exp -= level;
                level++;
                atk += 0.5f;
                def += 1;
                
            }
        }

        internal void GetDamage(int damage)
        {
            hp -= damage;
            if(hp < 0) { hp = 0; }
        }
    }
}
