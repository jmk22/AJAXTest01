using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJAXTest01.Models
{
    public class Product
    {
        private string _id;
        private string _name;
        private decimal _price;

        public Product() { }

        public Product(string id, string name, decimal price)
        {
            _id = id;
            _name = name;
            _price = price;
        }

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }


    }
}
