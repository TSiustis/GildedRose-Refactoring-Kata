using csharp.Constants;
using csharp.Models;
using csharp.Strategies;

namespace csharp.Factories
{
    public static class ItemStrategyFactory
    {
        public static ItemStrategy GetStrategy(Item item)
        {
            return item.Name switch
            {
                string agedBrie when agedBrie.Contains(StrategyConstants.AgedBrie) => new AgedBrieStrategy(item),
                string backstagePass when backstagePass.Contains(StrategyConstants.BackstagePass) => new BackstagePassStrategy(item),
                string conjured when conjured.Contains(StrategyConstants.Conjured) => new ConjuredStrategy(item),
                string sulfuras when sulfuras.Contains(StrategyConstants.Sulfuras) => new SulfurasStrategy(item),
                _ => new NormalItemStrategy(item),
            };
        }
    }
}