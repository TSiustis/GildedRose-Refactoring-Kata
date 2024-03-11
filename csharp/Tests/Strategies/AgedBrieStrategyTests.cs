using csharp.Constants;
using csharp.Factories;
using csharp.Models;
using NUnit.Framework;

namespace csharp.Tests.Strategies
{
    [TestFixture]
    public class AgedBrieStrategyTests
    {
        [Test]
        public void UpdateQuality_BeforeSellInDate_IncreasesQualityByOne()
        {
            // Arrange
            var item = GetItem();

            // Act
            ItemStrategyFactory.GetStrategy(item).Update();

            // Assert
            Assert.AreEqual(1, item.SellIn);
            Assert.AreEqual(1, item.Quality);
        }

        [Test]
        public void UpdateQuality_OnSellInDate_IncreasesQualityByTwo()
        {
            // Arrange
            var item = GetItem(sellIn: 0);

            // Act
            ItemStrategyFactory.GetStrategy(item).Update();

            // Assert
            Assert.AreEqual(-1, item.SellIn);
            Assert.AreEqual(2, item.Quality);
        }

        [Test]
        public void UpdateQuality_WithMaxQuality_KeepsQualityAtFifty()
        {
            // Arrange
            var item = GetItem(quality: 50);

            // Act
            ItemStrategyFactory.GetStrategy(item).Update();

            // Assert
            Assert.AreEqual(1, item.SellIn);
            Assert.AreEqual(50, item.Quality);
        }

        private static Item GetItem(string name = StrategyConstants.AgedBrie, int sellIn = 2, int quality = 0)
        {
            return new Item { Name = name, SellIn = sellIn, Quality = quality };
        }
    }
}