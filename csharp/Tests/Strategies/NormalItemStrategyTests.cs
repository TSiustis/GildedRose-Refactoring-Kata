using csharp.Constants;
using csharp.Factories;
using csharp.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Tests.Strategies
{
    [TestFixture]
    public class NormalItemStrategyTests
    {
        [Test]
        public void UpdateQuality_WithPositiveSellIn_DecreasesQualityByOne()
        {
            // Arrange
            var item = GetItem();

            // Act
            ItemStrategyFactory.GetStrategy(item).Update();

            // Assert
            Assert.AreEqual(9, item.SellIn);
            Assert.AreEqual(19, item.Quality);
        }

        [Test]
        public void UpdateQuality_WithZeroSellIn_DecreasesQualityByTwo()
        {
            // Arrange
            var item = GetItem(sellIn: 0);

            // Act
            ItemStrategyFactory.GetStrategy(item).Update();

            // Assert
            Assert.AreEqual(-1, item.SellIn);
            Assert.AreEqual(18, item.Quality);
        }

        [Test]
        public void UpdateQuality_WithQualityAtZero_KeepsQualityUnchanged()
        {
            // Arrange
            var item = GetItem(quality: 0);

            // Act
            ItemStrategyFactory.GetStrategy(item).Update();

            // Assert
            Assert.AreEqual(9, item.SellIn);
            Assert.AreEqual(0, item.Quality);
        }

        private static Item GetItem(string name = StrategyConstants.NormalItem, int sellIn = 10, int quality = 20)
        {
            return new Item { Name = name, SellIn = sellIn, Quality = quality };
        }
    }
}
