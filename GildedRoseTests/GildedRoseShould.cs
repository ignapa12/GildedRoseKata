using System.Collections.Generic;
using GildedRoseKata;
using NUnit.Framework;

namespace GildedRoseTests;

public class GildedRoseShould
{
    [Test]
    public void DecreaseSellInAfterADay()
    {
        var sellIn = 2;
        var items = new List<Item> { new Item { Name = "foo", SellIn = sellIn, Quality = 0 } };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.That(items[0].SellIn, Is.LessThan(sellIn));
    }
}