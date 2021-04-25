using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IcelandDev;
using IcelandDev.Models;
using Xunit;

namespace IcelandDevTest
{
    public class AddItemTests
    {
        [Fact]
        public void AddItemToItemsList_ShouldWork()
        {
            ItemModel newItem = new ItemModel { ItemName = "Aged Brie", SellIn = 1, Qty = 1 };
            List<ItemModel> testItems = new List<ItemModel>();

            AddItem.AddItemToItemsList(testItems, newItem);

            Assert.True(testItems.Count == 1);
            Assert.Contains<ItemModel>(newItem, testItems);
        }

        //Would add test to fail + exception if data entered is incoreect eg, 0< qty <50
    }
}
