using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_2
{
    class Item
    {
        public string name;
        public int amount;
        public Item(string name, int amount)
        {
            this.name = name;
            this.amount = amount;
        }
    }
}
