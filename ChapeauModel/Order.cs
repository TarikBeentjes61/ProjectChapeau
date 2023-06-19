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
        public int id;
        public DateTime date;
        public OrderStatus status;

        public Order()
        {
            orderItems = new List<OrderItem>();
        }

        public void DeleteOrder(List<OrderItem> orderItems)
        {
            orderItems.Clear();
        }

        public void StartPreparing()
        {

        }

        public void MarkAsReady()
        {

        }
    }
}
