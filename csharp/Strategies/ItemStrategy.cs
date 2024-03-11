using csharp.Models;

namespace csharp.Strategies
{
    public abstract class ItemStrategy
    {
        protected Item Item;
        public ItemStrategy(Item item)
        {
            Item = item;
        }

        public abstract void Update();

        protected void DecreaseSellIn()
        {
            Item.SellIn--;
        }

        protected void IncreaseQuality()
        {
            if (Item.Quality < 50)
            {
                Item.Quality++;
            }
        }

        protected void DecreaseQuality()
        {
            if (Item.Quality > 0)
            {
                Item.Quality--;
            }
        }
    }
}