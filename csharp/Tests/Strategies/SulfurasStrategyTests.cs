using csharp.Constants;
using csharp.Factories;
using csharp.Models;
using NUnit.Framework;

namespace csharp.Tests.Strategies
{
    [TestFixture]
    public class SulfurasStrategyTests
    {
        [Test]
        public void UpdateQuality_WithAnySellIn_KeepsQualityAndSellInUnchanged()
        {
            // Arrange
            var item = new Item { Name = StrategyConstants.Sulfuras, SellIn = 0, Quality = 80 };

            // Act
            ItemStrategyFactory.GetStrategy(item).Update();

            // Assert
            Assert.AreEqual(0, item.SellIn);
            Assert.AreEqual(80, item.Quality);
        }
    }
}
