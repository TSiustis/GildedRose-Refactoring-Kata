using csharp.Models;

namespace csharp.Strategies
{
    public class NormalItemStrategy : ItemStrategy
    {
        public NormalItemStrategy(Item item) : base(item)
        {
        }
        public override void Update()
        {
            DecreaseQuality();

            DecreaseSellIn();

            if (Item.SellIn < 0)
            {
                DecreaseQuality();
            }
        }
    }
}