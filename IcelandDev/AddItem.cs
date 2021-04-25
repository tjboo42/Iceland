using IcelandDev;
using IcelandDev.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcelandDev
{
    public class AddItem
    {
        public static List<ItemModel> AddNewItem(ItemModel item, List<ItemModel> items)
        {
            AddItemToItemsList(items, item);

            return items;
        }


        public static void AddItemToItemsList(List<ItemModel> items, ItemModel item)
        {
            items.Add(item);
        }

        public static List<string> ConvertModelsToCSV(List<ItemModel> items)
        {
            List<string> output = new List<string>();

            foreach (ItemModel item in items)
            {
                output.Add($"{ item.ItemName },{ item.SellIn },{ item.Qty }");
            }

            return output;
        }

    }
}
