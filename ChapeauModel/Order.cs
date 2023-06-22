using System;
using System.Collections.Generic;

namespace ChapeauModel
{
    public class Order
    {
        private List<OrderItem> orderItems;
        //public int employeeId;
        //public int tableId;
        //public int billId;
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

        public List<OrderItem> OrderItems { get { return orderItems; } set { orderItems = value; } }
        
        public TimeSpan WaitingTime { get { return DateTime.Now.Subtract(date); } }

        public void AddOrder(List<OrderItem> orderItems)
        {
            Order order = new Order();
            foreach (OrderItem o in orderItems)
            {
                order.OrderItems.Add(o);
            }
            this.orderItems = orderItems;
        }

        public void StartPreparing()
        {

        }

        public void MarkAsReady()
        {

        }
    }
}
