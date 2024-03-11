namespace csharp;
public class AgedBrieStrategy : ItemStrategy
{
    public AgedBrieStrategy(Item item) : base(item)
    {
    }

    public override void Update()
    {
        IncreaseQuality();

        DecreaseSellIn();

        if (Item.SellIn < 0)
        {
            IncreaseQuality();
        }
    }
}