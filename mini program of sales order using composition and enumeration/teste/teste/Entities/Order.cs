using System;
using System.Collections.Generic;
using System.Text;
using teste.Entities;

namespace teste.Entities.enums
{
    class Order
    {
        public DateTime Moment { get; set; }
        public orderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order(DateTime moment, orderStatus status)
        {
            this.Moment = DateTime.Now;
            this.Status = Status;
        }
        public void addItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void removeItem(OrderItem item)
        {
            Items.Remove(item);
        }
        public double Total()
        {
            double sum = 0.0;
            foreach(OrderItem item in Items)
            {
                sum += Item.Subtotal();
            }
        }
    }
   
}
