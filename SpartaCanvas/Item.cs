namespace SpartaCanvas
{
    public abstract class Item
    {
        public string name;
        public int cost;
        public string Description { get; set; }
        public bool isEquiped;

        public Item(string name, string description, int cost)
        {
            this.name = name;
            Description = description;
            isEquiped = false;
            this.cost = cost;
        }

        public void ToggleEquip()
        {
            isEquiped = !isEquiped;
        }
        public void ShowInfo()
        {
            string equippedMark = isEquiped ? "[E]": "";
            string info = string.Format("{0, -18} | {1, -12} | {2}",
                                        equippedMark + name,
                                        StatToString(),
                                        Description);
            

            Console.WriteLine(info);
        }

        public string CostToString()
        {
            return cost.ToString() + " G\t";
        }
        public abstract string StatToString();
    }

    public class AttackItem : Item
    {
        public int Atk { get; set; }

        public AttackItem(string name, int attackPoint, string description, int cost) : base(name, description, cost)
        {
            Atk = attackPoint;

        }

        public override string StatToString()
        {
            return "공격력 +" + Atk;
        }

    }
    public class ArmorItem : Item
    {
        public int Def { get; set; }

        public ArmorItem(string name, int attackPoint, string description, int cost) : base(name, description, cost)
        {
            Def = attackPoint; 
        }

        public override string StatToString()
        {
            return "방어력 +" + Def;
        }
    }
}
