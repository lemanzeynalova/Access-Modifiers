using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    internal class Notebook:Product
    {
        string brand;
        string model;
        int ram;
        int storage;
        int price;
        public string Brand;
        {
            get
            {
                return brand;
            }
            set
            {
               if(value.Length>=3 && value.Length<=30)
                {
                    brand = value;
                }
            }
        }
        public string Model;
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public int Ram;
        {
            get
            {
                return ram; 
            }
            set
            {
                if(ram>0 && ram < 128)
                {
                    ram = value;
                }
            }
        }
        public int Storage;
        {
            get
            {
                return storage;
            }
            set
            {
                if (storage > 0)
                {
                    storage = value;
                }
            }
        }
        public decimal Price;
        {
            get
            {
                return price;
            }
            set
            { 
                if(price > 0)
                {
                    price = (int)value;
                }
            }
        }
    }
}
