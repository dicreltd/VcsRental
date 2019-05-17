using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VcsRental
{
    class Book : Item
    {
        public Book(string title) : base(title,"本")
        {
        }

        public override int GetPrice(int days)
        {
            return days * 50;
        }
    }
}
