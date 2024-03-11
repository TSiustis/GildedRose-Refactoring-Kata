namespace csharp;
public class BackstagePassStrategy : ItemStrategy
{
    public BackstagePassStrategy(Item item) : base(item)
    {
    }

    public override void Update()
    {
        IncreaseQuality();

        if (Item.SellIn <= 10)
        {
            IncreaseQuality();
        }

        if (Item.SellIn <= 5)
        {
            IncreaseQuality();
        }

        DecreaseSellIn();

        if (Item.SellIn < 0)
        {
            Item.Quality = 0;
        }
    }
}
