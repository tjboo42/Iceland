using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcelandDev.Models
{
    public class ItemModel
    {
        public string ItemName { get; set; }

        public int? SellIn { get; set; }
        public int? Qty { get; set; }
    }
}
