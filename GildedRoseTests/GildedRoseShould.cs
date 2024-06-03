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
    
    [Test]
    public void DecreaseQualityInAfterADay()
    {
        var quality = 1;
        var items = new List<Item> { new Item { Name = "foo", SellIn = 2, Quality = quality } };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.That(items[0].Quality, Is.LessThan(quality));
    }
    
    [Test]
    public void NotNegative()
    {
        var quality = 0;
        var items = new List<Item> { new Item { Name = "foo", SellIn = 2, Quality = quality } };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.That(items[0].Quality, Is.EqualTo(quality));
    }
    
}