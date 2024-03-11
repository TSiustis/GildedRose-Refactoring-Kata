using csharp.Constants;
using csharp.Models;
using NUnit.Framework;
using System.Collections.Generic;

namespace csharp.Tests.Models
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void UpdateQuality_WithNormalItemBeforeSellDate_DecreasesSellInAndQualityByOne()
        {
            // Arrange
            var items = new List<Item> { new() { Name = ItemConstants.DexterityVest, SellIn = 10, Quality = 20 } };
            var app = new GildedRose(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.AreEqual(9, items[0].SellIn);
            Assert.AreEqual(19, items[0].Quality);
        }

        [Test]
        public void UpdateQuality_WithAgedBrieBeforeSellDate_IncreasesQualityByOne()
        {
            // Arrange
            var items = new List<Item> { new() { Name = ItemConstants.AgedBrie, SellIn = 2, Quality = 0 } };
            var app = new GildedRose(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.AreEqual(1, items[0].SellIn);
            Assert.AreEqual(1, items[0].Quality);
        }

        [Test]
        public void UpdateQuality_WithSulfuras_SellInAndQualityRemainUnchanged()
        {
            // Arrange
            var items = new List<Item> { new() { Name = ItemConstants.Sulfuras, SellIn = 0, Quality = 80 } };
            var app = new GildedRose(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.AreEqual(0, items[0].SellIn);
            Assert.AreEqual(80, items[0].Quality);
        }

        [Test]
        public void UpdateQuality_WithBackstagePassesMoreThan10Days_IncreasesQualityByOne()
        {
            // Arrange
            var items = new List<Item> { new() { Name = ItemConstants.BackstagePass, SellIn = 11, Quality = 20 } };
            var app = new GildedRose(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.AreEqual(10, items[0].SellIn);
            Assert.AreEqual(21, items[0].Quality);
        }

        [Test]
        public void UpdateQuality_WithBackstagePasses10DaysOrLess_IncreasesQualityByTwo()
        {
            // Arrange
            var items = new List<Item> { new() { Name = ItemConstants.BackstagePass, SellIn = 10, Quality = 20 } };
            var app = new GildedRose(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.AreEqual(9, items[0].SellIn);
            Assert.AreEqual(22, items[0].Quality);
        }

        [Test]
        public void UpdateQuality_WithBackstagePasses5DaysOrLess_IncreasesQualityByThree()
        {
            // Arrange
            var items = new List<Item> { new() { Name = ItemConstants.BackstagePass, SellIn = 5, Quality = 20 } };
            var app = new GildedRose(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.AreEqual(4, items[0].SellIn);
            Assert.AreEqual(23, items[0].Quality);
        }

        [Test]
        public void UpdateQuality_WithBackstagePassesAfterConcert_DropsQualityToZero()
        {
            // Arrange
            var items = new List<Item> { new() { Name = ItemConstants.BackstagePass, SellIn = 0, Quality = 20 } };
            var app = new GildedRose(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.AreEqual(-1, items[0].SellIn);
            Assert.AreEqual(0, items[0].Quality);
        }

        [Test]
        public void UpdateQuality_WithConjuredItemsBeforeSellDate_DecreasesQualityTwiceAsFast()
        {
            // Arrange
            var items = new List<Item> { new() { Name = ItemConstants.ConjuredManaCake, SellIn = 3, Quality = 6 } };
            var app = new GildedRose(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.AreEqual(2, items[0].SellIn);
            Assert.AreEqual(4, items[0].Quality);
        }
    }
}
