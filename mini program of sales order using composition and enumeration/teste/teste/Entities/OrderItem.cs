using System;
using System.Collections.Generic;
using System.Text;

namespace teste.Entities
{
    class OrderItem
    {
        public int quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }



        public OrderItem()

        {

        }
        public OrderItem(int quantity, double Price)
        {
            this.quantity = quantity;
            this.Price = Price;
        }
        public double Subtotal()
        {

        }
        
    }
}
