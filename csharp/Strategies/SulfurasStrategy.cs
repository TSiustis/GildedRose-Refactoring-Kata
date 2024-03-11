using csharp.Models;

namespace csharp.Strategies
{
    public class SulfurasStrategy : ItemStrategy
    {
        public SulfurasStrategy(Item item) : base(item)
        {
        }
        public override void Update()
        {
            // Sulfuras does not change
        }
    }
}