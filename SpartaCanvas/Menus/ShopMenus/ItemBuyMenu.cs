namespace SpartaCanvas
{
    internal class ItemBuyMenu : Menu
    {
        public override string Name => "";
        private ShopItem shopItem;

        public ItemBuyMenu(ShopItem shopItem)
        {
            this.shopItem = shopItem;
        }

        public override void Execute()
        {
            if (GameManager.player.gold > shopItem.item.cost)
            {
                GameManager.player.items.Add(shopItem.item);
                shopItem.isSold = true;
                GameManager.player.gold -= shopItem.item.cost;

                GameManager.messageLog = "(구매 성공) 구매를 완료했습니다.\n";
            }
            else
            {
                GameManager.messageLog = "(구매 실패) 잔액이 부족합니다.\n";
            }
        }
    }
}