using System;
using System.Collections.Generic;


namespace VcsRental
{
    class RentalList
    {
        public List<Item> Items { get; private set; }

        public RentalList()
        {
            Items = new List<Item>();
        }

        public void Load()
        {
            var lines = RentalFile.Read();

            foreach( string line in lines)
            {
                string[] values = line.Split(',');

                switch (values[0])
                {
                    case "Book":
                        Items.Add(new Book(values[1]));
                        break;
                    case "CD":
                        Items.Add(new CD(values[1]));
                        break;
                    case "DVD":
                        Items.Add(new DVD(values[1]));
                        break;
                }
            }
        }



        public int getTotal(int days)
        {
            int sum = 0;
            foreach (Item item in Items)
            {
                sum += item.GetPrice(days);
            }
            return sum;
        }

    }
}
