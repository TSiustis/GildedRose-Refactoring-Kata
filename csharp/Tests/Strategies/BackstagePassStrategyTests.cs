using csharp.Constants;
using csharp.Factories;
using csharp.Models;
using NUnit.Framework;

namespace csharp.Tests.Strategies
{
    [TestFixture]
    public class BackstagePassStrategyTests
    {
        [Test]
        public void UpdateQuality_MoreThanTenDaysBeforeConcert_IncreasesQualityByOne()
        {
            // Arrange
            var item = GetItem();

            // Act
            ItemStrategyFactory.GetStrategy(item).Update();

            // Assert
            Assert.AreEqual(10, item.SellIn);
            Assert.AreEqual(21, item.Quality);
        }

        [Test]
        public void UpdateQuality_TenDaysOrLessBeforeConcert_IncreasesQualityByTwo()
        {
            // Arrange
            var item = GetItem(sellIn: 10);

            // Act
            ItemStrategyFactory.GetStrategy(item).Update();

            // Assert
            Assert.AreEqual(9, item.SellIn);
            Assert.AreEqual(22, item.Quality);
        }

        [Test]
        public void UpdateQuality_FiveDaysOrLessBeforeConcert_IncreasesQualityByThree()
        {
            // Arrange
            var item = GetItem(sellIn: 5);

            // Act
            ItemStrategyFactory.GetStrategy(item).Update();

            // Assert
            Assert.AreEqual(4, item.SellIn);
            Assert.AreEqual(23, item.Quality);
        }

        [Test]
        public void UpdateQuality_AfterConcert_DropsQualityToZero()
        {
            // Arrange
            var item = GetItem(sellIn: 0);

            // Act
            ItemStrategyFactory.GetStrategy(item).Update();

            // Assert
            Assert.AreEqual(-1, item.SellIn);
            Assert.AreEqual(0, item.Quality);
        }

        private static Item GetItem(string name = StrategyConstants.BackstagePass, int sellIn = 11, int quality = 20)
        {
            return new Item { Name = name, SellIn = sellIn, Quality = quality };
        }
    }
}
