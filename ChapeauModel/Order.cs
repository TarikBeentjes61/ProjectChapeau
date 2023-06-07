using System;
using System.Collections.Generic;

namespace ChapeauModel
{
    public class Order
    {
        private List<OrderItem> orderItems;
        public int orderId;
        public int employeeId;
        public int tableId;
        public int billId;
        public DateTime date;
        public OrderStatus status;

        public void PayOrder()
        {

        }
        public void CancelOrder()
        {

        }
        public void AddOrderItem(OrderItem item)
        {
            orderItems.Add(item);
        }
    }
}
