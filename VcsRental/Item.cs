using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VcsRental
{
    abstract class Item
    {
        public Item(string title,string category)
        {
            this.Title = title;
            this.Category = category;
        }

        public string Title { get; }
        public string Category { get; }

        public abstract int GetPrice(int days);
    }
}
