using System;

namespace ChapeauModel
{
    public class Order
    {
        public int orderId;
        public int employeeId;
        public int tableId;
        public int billId;
        public DateTime date;
        public OrderStatus status;
    }
}
