using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Assignment_3
{
    class Item
    {
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }

        public Item(string itemName, double itemPrice)
        {
            ItemName = itemName;
            ItemPrice = itemPrice;
        }
    }
}
