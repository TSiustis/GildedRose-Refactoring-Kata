﻿using System;
using System.Collections.Generic;
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
                    Name = "+5 Dexterity Vest",
                    SellIn = 10,
                    Quality = 20
                },
                new() {
                    Name = "Aged Brie", 
                    SellIn = 2,
                    Quality = 0
                },
                new() {
                    Name = "Elixir of the Mongoose",
                    SellIn = 5,
                    Quality = 7
                },
                new() {
                    Name = "Sulfuras, Hand of Ragnaros",
                    SellIn = 0,
                    Quality = 80
                },
                new() {
                    Name = "Sulfuras, Hand of Ragnaros", 
                    SellIn = -1,
                    Quality = 80
                },
                new() {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                },
                new() {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 49
                },
                new() {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 49
                },
				new() {
                    Name = "Conjured Mana Cake",
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
