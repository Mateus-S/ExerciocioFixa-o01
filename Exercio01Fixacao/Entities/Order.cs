using Exercio01Fixacao.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercio01Fixacao.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public  OrderStatus Status { get; set; }
        public List<OrderItem> orderItems = new List<OrderItem>();


        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
        }

        public void AddItem(OrderItem item)
        {
            orderItems.Add(item);
        }

        public void RemoveItem (OrderItem item)
        {
            orderItems.Remove(item);
        }

        public double Total()
        {
            foreach (OrderItem item in orderItems)
            {
            }

            return 0;

        }

    }
}
