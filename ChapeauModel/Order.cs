using System;
using System.Collections.Generic;

namespace ChapeauModel
{
    public class Order
    {
        private List<OrderItem> orderItems;
        public int employeeId;
        public int tableId;
        public int billId;
        public DateTime date;
        public OrderStatus status;

        public Order()
        {
            orderItems = new List<OrderItem>();
        }

        public List<OrderItem> OrderItems { get { return orderItems; } set { orderItems = value; } }
        
        public TimeSpan WaitingTime { get { return DateTime.Now.Subtract(date); } }

        public void AddOrder()
        {

        }

        public void DeleteOrder()
        {

        }

        public void AddOrderItem(OrderItem orderItem)
        {
            orderItems.Add(orderItem);
        }

        public void StartPreparing()
        {

        }

        private void UpdateOrder()
        {

        }

        public void MarkAsReady()
        {

        }
    }
}
