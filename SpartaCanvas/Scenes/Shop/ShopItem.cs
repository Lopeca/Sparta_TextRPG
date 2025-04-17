namespace SpartaCanvas
{
    public class ShopItem
    {
        public Item item;
        public bool isSold;

      
        public ShopItem(Item item, bool sold = false)
        {
            this.item = item;
            isSold = sold;
        }
    }
}