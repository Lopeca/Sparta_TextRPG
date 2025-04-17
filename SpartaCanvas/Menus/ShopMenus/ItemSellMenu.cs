namespace SpartaCanvas
{
    internal class ItemSellMenu : Menu
    {
        private ShopItem shopItem;
        public override string Name => "";
        public ItemSellMenu(ShopItem shopItem)
        {
            this.shopItem = shopItem;
        }

        public override void Execute()
        {
            GameManager.player.gold += shopItem.item.cost;
            GameManager.player.items.Remove(shopItem.item);
            shopItem.isSold = false;
            shopItem.item.isEquiped = false;
        }
    }
}