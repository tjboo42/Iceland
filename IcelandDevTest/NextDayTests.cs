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
    public class NextDayTests
    {
        [Fact]
        public void QtyDegradeDaysAgedBrie_ShouldWork()
        {
            ItemModel newItemWithinSellIn = new ItemModel { ItemName = "Aged Brie", SellIn = 1, Qty = 10 };
            ItemModel newItemOutsideSellIn = new ItemModel { ItemName = "Aged Brie", SellIn = -1, Qty = 10 };

            Assert.True(NextDay.QtyDegradeDays(newItemWithinSellIn) == 1);
            Assert.True(NextDay.QtyDegradeDays(newItemOutsideSellIn) == 2);
        }

        //Would add test to fail + test if list is updated for next day correctly
    }
}
