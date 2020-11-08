using System.Collections.Generic;

namespace SDS_Inn
{
    public static class SdsInn
    {
        static void Main(string[] args)
        {

            UpdateQuality(Items); // Day 1
            UpdateQuality(Items); // Day 2
            UpdateQuality(Items); // Day 3
            UpdateQuality(Items); // Day 4
            UpdateQuality(Items); // Day 5

        }

        public static void UpdateQuality(IList<Item> items)
        {
            for (var i = 0; i < Items.Count; i++)
            {
                Items[i] = UpdateItemQuality(Items[i]);
            }
        }

        public static Item UpdateItemQuality(Item item)
        {
            if (item.Name != "Aged Brie" && item.Name != "Backstage Passes")
            {
                if (item.Quality > 0)
                {
                    if (item.Name != "Sulfuras")
                    {
                        item.Quality = item.Quality - 1;
                    }
                }
            }
            else //Either Aged Brie or Backstage Passes
            {
                if (item.Quality < 50)
                {
                    item.Quality = item.Quality + 1;
                    if (item.Name == "Backstage Passes")
                    {
                        if (item.SellIn < 11)
                        {
                            if (item.Quality < 50)
                            {
                                item.Quality = item.Quality + 1;
                            }
                        }
                        if (item.SellIn < 6)
                        {
                            if (item.Quality < 50)
                            {
                                item.Quality = item.Quality + 1;
                            }
                        }

                    }
                }
            }
            if (item.Name != "Sulfuras")
            {
                item.SellIn = item.SellIn - 1;
            }
            if (item.SellIn < 0)
            {
                if (item.Name != "Aged Brie")
                {
                    if (item.Name != "Backstage passes")
                    {
                        if (item.Quality > 0)
                        {
                            if (item.Name != "Sulfuras")
                            {
                                item.Quality = item.Quality - 1;
                            }
                        }
                    }
                    else // Item is Backstage passes
                    {
                        item.Quality = item.Quality - item.Quality;
                    }
                }
                else // Item is Aged Brie
                {
                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;
                    }
                }
            }
            return item;
        }


        public static IList<Item> Items = new List<Item>
            {
                new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 },
                new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 },
                new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 },
                new Item { Name = "Sulfuras", SellIn = 0, Quality = 80 },
                new Item { Name = "Backstage passes", SellIn = 15, Quality = 20 },
                new Item { Name = "Conjured", SellIn = 3, Quality = 6 }
            };
    }
}
