using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VcsRental
{
    class DVD : Item
    {
        public DVD(string title) : base(title,"DVD")
        {
        }

        public override int GetPrice(int days)
        {
            if (days <= 7)
            {
                return 300;
            }
            else
            {
                return 300 + (days - 7) * 100;
            }

        }
    }
}
