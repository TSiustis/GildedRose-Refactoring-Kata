namespace csharp
{
    public class ConjuredStrategy : ItemStrategy
    {
        public ConjuredStrategy(Item item) : base(item)
        {
        }

        public override void Update()
        {
            DecreaseQuality();

            DecreaseQuality();

            DecreaseSellIn();

            if (Item.SellIn < 0)
            {
                DecreaseQuality();
                DecreaseQuality();
            }
        }
    }
}