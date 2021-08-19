using System;
using System.Collections.Generic;
using System.Text;

namespace teste.Entities
{
    class Product
    {
        public string name { get; set; }
        public double price { get; set; }

        public Product()
        {

        }

        public Product(string nome, double price)
        {
            this.name = nome;
            this.price = price;
        }
    }
}
