using System;
using System.Collections.Generic;
using csharp.Constants;
using csharp.Models;

namespace csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            var items = new List<Item>{
                new() {
                    Name = ItemConstants.DexterityVest,
                    SellIn = 10,
                    Quality = 20
                },
                new() {
                    Name = ItemConstants.AgedBrie,
                    SellIn = 2,
                    Quality = 0
                },
                new() {
                    Name = ItemConstants.ElixirOfTheMongoose,
                    SellIn = 5,
                    Quality = 7
                },
                new() {
                    Name = ItemConstants.Sulfuras,
                    SellIn = 0,
                    Quality = 80
                },
                new() {
                    Name = ItemConstants.Sulfuras,
                    SellIn = -1,
                    Quality = 80
                },
                new() {
                    Name = ItemConstants.BackstagePass,
                    SellIn = 15,
                    Quality = 20
                },
                new() {
                    Name = ItemConstants.BackstagePass,
                    SellIn = 10,
                    Quality = 49
                },
                new() {
                    Name = ItemConstants.BackstagePass,
                    SellIn = 5,
                    Quality = 49
                },
                new() {
                    Name = ItemConstants.ConjuredManaCake,
                    SellIn = 3,
                    Quality = 6
                }
            };

            var app = new GildedRose(items);

            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < items.Count; j++)
                {
                    Console.WriteLine(items[j]);
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }
        }
    }
}