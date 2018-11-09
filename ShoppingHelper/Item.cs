using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingHelper
{
    class Item
    {
        private string price;
        private string name;

        public string Price
        {
            get;
            set;
        }
        
        public string Name
        {
            get;
            set;
        }

        public Item(string name, string price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
