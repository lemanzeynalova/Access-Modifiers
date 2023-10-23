using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    internal class Product
    {
        decimal price;
        int count;
        public decimal Price
        {
            get
            {
                return price;   
            }
            set
            {
                price = value;
            }
        }
        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }
    }
}
