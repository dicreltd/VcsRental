using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VcsRental
{
    class CD : Item
    {
        public CD(string title) : base(title,"CD")
        {
        }

        public override int GetPrice(int days)
        {
            if (days <= 1)
            {
                return 300;
            }
            else
            {
                return 300 + (days - 1) * 100;
            }
        }
    }
}
