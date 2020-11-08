using NUnit.Framework;
using SDS_Inn;
using System.Collections.Generic;

namespace SDS_Inn_Test
{
    public class QualityUpdateTests
    {
        private IList<Item>[] ItemByDayDexVest;


        private Item DexVestDay0;
        private Item DexVestDay5;

        private Item AgedBrieDay0;
        private Item AgedBrieDay5;

        private Item ElixirDay0;
        private Item ElixirDay5;

        private Item SulfurasDay0;
        private Item SulfurasDay5;

        private Item BackstagePassesDay0;
        private Item BackstagePassesDay5;

        private Item NormalItemDay0;
        private Item NormalItemDay5;

        private Item ConjuredDay0;
        private Item ConjuredDay1;
        private Item ConjuredDay2;
        private Item ConjuredDay5;

        [SetUp]
        public void Setup()
        {
            //Set up for smoke test
            DexVestDay0 = new Item { Name = "+5 Dexterity Vest", Quality = 20, SellIn = 10 };
            DexVestDay5 = new Item { Name = "+5 Dexterity Vest", Quality = 15, SellIn = 5 };

            AgedBrieDay0 = new Item { Name = "Aged Brie", Quality = 0, SellIn = 2 };
            AgedBrieDay5 = new Item { Name = "Aged Brie", Quality = 8, SellIn = -3 };

            ElixirDay0 = new Item { Name = "Elixir of the Mongoose", Quality = 7, SellIn = 5 };
            ElixirDay5 = new Item { Name = "Elixir of the Mongoose", Quality = 2, SellIn = 0 };

            SulfurasDay0 = new Item { Name = "Sulfuras", Quality = 80, SellIn = 0 };
            SulfurasDay5 = new Item { Name = "Sulfuras", Quality = 80, SellIn = 0 };

            BackstagePassesDay0 = new Item { Name = "Backstage passes", Quality = 20, SellIn = 15 };
            BackstagePassesDay5 = new Item { Name = "Backstage passes", Quality = 15, SellIn = 10 };

            NormalItemDay0 = new Item { Name = "Normal Item", Quality = 10, SellIn = 10 };
            NormalItemDay5 = new Item { Name = "Normal Item", Quality = 5, SellIn = 5 };

            ConjuredDay0 = new Item { Name = "Conjured", Quality = 6, SellIn = 3 };
            ConjuredDay1 = new Item { Name = "Conjured", Quality = 4, SellIn = 2 };
            ConjuredDay2 = new Item { Name = "Conjured", Quality = 2, SellIn = 1 };
            ConjuredDay5 = new Item { Name = "Conjured", Quality = 0, SellIn = -2 };

        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void SmokeTest_DexVest()
        {

            var expected = DexVestDay5;
            var actual = (AdvanceDays(DexVestDay0, 5));

            Assert.AreEqual(expected.Quality, actual.Quality);
            Assert.AreEqual(expected.SellIn, actual.SellIn);

        }

        [Test]
        public void SmokeTest_AgedBrie()
        {

            var expected = AgedBrieDay5;
            var actual = (AdvanceDays(AgedBrieDay0, 5));

            Assert.AreEqual(expected.Quality, actual.Quality);
            Assert.AreEqual(expected.SellIn, actual.SellIn);

        }

        [Test]
        public void SmokeTest_Elixir()
        {

            var expected = ElixirDay5;
            var actual = (AdvanceDays(ElixirDay0, 5));

            Assert.AreEqual(expected.Quality, actual.Quality);
            Assert.AreEqual(expected.SellIn, actual.SellIn);

        }

        [Test]
        public void SmokeTest_Sulfuras()
        {

            var expected = SulfurasDay5;
            var actual = (AdvanceDays(SulfurasDay0, 5));

            Assert.AreEqual(expected.Quality, actual.Quality);
            Assert.AreEqual(expected.SellIn, actual.SellIn);

        }

        [Test]
        public void SmokeTest_BackstagePasses()
        {

            var expected = BackstagePassesDay5;
            var actual = (AdvanceDays(BackstagePassesDay0, 5));

            Assert.AreEqual(expected.Quality, actual.Quality);
            Assert.AreEqual(expected.SellIn, actual.SellIn);
        }

        [Test]
        public void SmokeTest_NormalItem()
        {
            var expected = NormalItemDay5;
            var actual = (AdvanceDays(NormalItemDay0, 5));

            Assert.AreEqual(expected.Quality, actual.Quality);
            Assert.AreEqual(expected.SellIn, actual.SellIn);
        }

        [Test]
        public void ConjuredItem_Day1()
        {
            var expected = ConjuredDay1;
            var actual = (AdvanceDays(ConjuredDay0, 1));

            Assert.AreEqual(expected.Quality, actual.Quality);
            Assert.AreEqual(expected.SellIn, actual.SellIn);
        }

        [Test]
        public void ConjuredItem_Day2()
        {
            var expected = ConjuredDay2;
            var actual = (AdvanceDays(ConjuredDay0, 2));

            Assert.AreEqual(expected.Quality, actual.Quality);
            Assert.AreEqual(expected.SellIn, actual.SellIn);
        }

        [Test]
        public void ConjuredItem_Day5()
        {
            var expected = ConjuredDay5;
            var actual = (AdvanceDays(ConjuredDay0, 5));

            Assert.AreEqual(expected.Quality, actual.Quality);
            Assert.AreEqual(expected.SellIn, actual.SellIn);
        }


        private Item AdvanceDays(Item item, int days)
        {
            for (var i = 0; i < days; i++)
            {
                item = SdsInn.UpdateItemQuality(item);
            }
            return item;
        }

    }
}