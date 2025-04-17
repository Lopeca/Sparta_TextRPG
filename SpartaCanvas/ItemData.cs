using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaCanvas
{
    public static class ItemData
    {
        public static readonly ArmorItem TraineeArmor = new("수련자 갑옷", 5, "수련에 도움을 주는 갑옷입니다.", 1000);
        public static readonly ArmorItem IronArmor = new("무쇠갑옷", 9, "무쇠로 만들어져 튼튼한 갑옷입니다.", 1800);
        public static readonly ArmorItem SpartaArmor = new("스파르타의 갑옷", 15, "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.", 3500);
        public static readonly AttackItem OldSword = new("낡은 검", 2, "쉽게 볼 수 있는 낡은 검입니다.", 600);
        public static readonly AttackItem BronzeAx = new("청동 도끼", 5, "어디선가 사용됐던거 같은 도끼입니다.", 1500);
        public static readonly AttackItem SpartaSpear = new("스파르타의 창", 7, "스파르타의 전사들이 사용했다는 전설의 창입니다.", 2700);

        public static Dictionary<string, Item> ItemLookup;
        static ItemData()
        {
            ItemLookup = new Dictionary<string, Item>();

            var fields = typeof(ItemData).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);

            foreach (var field in fields )
            {
                if(field.GetValue(null) is Item item)
                {
                    ItemLookup[item.name] = item;
                }
            }
        }
    }
}
