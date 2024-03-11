namespace csharp;
public static class ItemStrategyFactory
{
    public static ItemStrategy GetStrategy(Item item)
    {
        return item.Name switch
        {
            string agedBrie when agedBrie.Contains("Aged Brie") => new AgedBrieStrategy(item),
            string backstagePass when backstagePass.Contains("Backstage pass") => new BackstagePassStrategy(item),
            string sulfuras when sulfuras.Contains("Sulfuras") => new SulfurasStrategy(item),
            _ => new NormalItemStrategy(item),
        };
    }
}
