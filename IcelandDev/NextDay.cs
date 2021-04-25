using IcelandDev.Models;
using IcelandDev;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcelandDev
{
    public class NextDay
    {
        public static List<ItemModel> UpdateSellInAndQty (List<ItemModel> originalItems, List<string> products)
        {
            List<ItemModel> updatedItems = originalItems;
            for (int i = 0; i < originalItems.Count; i++)
            {
                if (products.Contains(originalItems[i].ItemName))
                {
                    if (originalItems[i].ItemName != "Soap") //No change for Soap
                    {
                        updatedItems[i].SellIn = originalItems[i].SellIn - 1;
                        updatedItems[i].Qty = originalItems[i].Qty + QtyDegradeDays(originalItems[i]);

                        //Limits to Quality
                        if (updatedItems[i].Qty > 50) { updatedItems[i].Qty = 50; }
                        else if (updatedItems[i].Qty < 0) { updatedItems[i].Qty = 0; }
                    }
                }
                else //Not valid product
                {
                    updatedItems[i].ItemName = "NO SUCH ITEM";
                    updatedItems[i].SellIn = null;
                    updatedItems[i].Qty = null;
                }
            }

            return updatedItems;
        }

        //Next Day Difference in Quality based on ItemName and SellIn
        public static int QtyDegradeDays(ItemModel item)
        {
            bool pastSellIn = false;
            if (item.SellIn < 0) { pastSellIn = true; }
            switch (item.ItemName)
            {
                case "Aged Brie":
                    if (pastSellIn)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                case "Frozen Item":
                    if (pastSellIn)
                    {
                        return -2;
                    }
                    else
                    {
                        return -1;
                    }
                case "Christmas Crackers":
                    if (pastSellIn)
                    {
                        return (int)-item.Qty;
                    }
                    else
                    {
                        if(item.SellIn <= 5)
                        {
                            return 3;
                        }
                        else if(item.SellIn <= 10)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                case "Fresh Item":
                    if (pastSellIn)
                    {
                        return -4;
                    }
                    else
                    {
                        return -2;
                    }
                default:
                    return 0;// If No Item Name matches return no change

            }
        }
    }
}
