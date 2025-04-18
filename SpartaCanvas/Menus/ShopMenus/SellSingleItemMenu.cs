namespace SpartaCanvas
{
    internal class SellSingleItemMenu : Menu
    {
        private ShopItem shopItem;
        public override string Name => "";
        public SellSingleItemMenu(ShopItem shopItem)
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