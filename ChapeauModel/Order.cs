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

        public void AddOrder(List<OrderItem> orderItems)
        {
            foreach(OrderItem item in orderItems) 
            {
                item.orderId = orderItems.IndexOf(item);
            }
        }

        public void DeleteOrder(List<OrderItem> orderItems)
        {
            orderItems.Clear();
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
