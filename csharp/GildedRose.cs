﻿using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        private readonly IList<Item> _items;
        public GildedRose(IList<Item> items)
        {
            _items = items;
        }

        public void UpdateQuality()
        {
            foreach (var item in _items)
            {
                var strategy = ItemStrategyFactory.GetStrategy(item);
                strategy.Update();
            }
        }
    }
}
