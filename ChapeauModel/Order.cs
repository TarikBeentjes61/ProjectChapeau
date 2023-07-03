using System;
using System.Collections.Generic;

namespace ChapeauModel
{
    public class Order
    {
        private List<OrderItem> orderItems;
        public Employee employee;
        public Table table;
        public Bill bill;
        public int id;
        public DateTime date;
        public OrderStatus status;

        public Order()
        {
            orderItems = new List<OrderItem>();
        }
        
        public TimeSpan WaitingTime { get { return DateTime.Now.Subtract(date); } }
        public List<OrderItem> GetOrderItems()
        {
            return orderItems;
        }
        public void EmptyOrderItems()
        {
            orderItems.Clear();
        }
    }
}
