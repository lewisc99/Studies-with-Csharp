using System;
using System.Collections.Generic;
using System.Text;

namespace teste.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }



        public OrderItem()

        {

        }
        public OrderItem(int quantity, double Price,Product Product)
        {
            this.Quantity = quantity;
            this.Price = Price;
            this.Product = Product;
        }
        public double SubTotal()
        {
            return Price * this.Quantity;
        }
        public override string ToString()
        {
            return  ", $"
                + this.Price.ToString("F2")
                + ", Quantity: "
                + this.Quantity
                + ", Subtotal: $"
                + SubTotal().ToString("F2");
        }
    }
}
