using csharp.Constants;
using csharp.Factories;
using csharp.Models;
using NUnit.Framework;

namespace csharp.Tests.Strategies
{
    [TestFixture]
    public class ConjuredStrategyTests
    {
        [Test]
        public void UpdateQuality_BeforeSellIn_DecreasesQualityByTwo()
        {
            // Arrange
            var item = GetItem();

            // Act
            ItemStrategyFactory.GetStrategy(item).Update();

            // Assert
            Assert.AreEqual(2, item.SellIn);
            Assert.AreEqual(4, item.Quality);
        }

        [Test]
        public void UpdateQuality_AfterSellIn_DecreasesQualityByFour()
        {
            // Arrange
            var item = GetItem(sellIn: 0, quality: 20);

            // Act
            ItemStrategyFactory.GetStrategy(item).Update();

            // Assert
            Assert.AreEqual(-1, item.SellIn);
            Assert.AreEqual(16, item.Quality);
        }

        private static Item GetItem(string name = StrategyConstants.Conjured, int sellIn = 3, int quality = 6)
        {
            return new Item { Name = name, SellIn = sellIn, Quality = quality };
        }
    }
}