using ChapeauDAL;
using ChapeauModel;
using System.Collections.Generic;

namespace ChapeauService
{
    public class OrderItemService
    {
        private OrderItemDao orderItemDao;
        private double totalVAT;

        public OrderItemService()
        {
            orderItemDao = new OrderItemDao();  
        }
        public List<OrderItem> GetByTableIdAndBillId(int tableId, int billId)
        {
            return orderItemDao.GetByTableIdAndBillId(tableId, billId);
        }
        public List<OrderItem> GetOrderItemsByRole(Role role)
        {
            return orderItemDao.GetOrderItemsByRole(role);
        }
        public List<OrderItem> GetServedOrderItemsByRole(Role role)
        {
            return orderItemDao.GetServedOrderItemsByRole(role);
        }
        public void AddOrderItems(int orderId, int menuitemId, int amount, string comment, OrderStatus status)
        {
            orderItemDao.AddOrderItems(orderId, menuitemId, amount, comment, status);
        }
        public void UpdateStatusById(int id, OrderStatus status)
        {
            orderItemDao.UpdateStatusById(id, status);
        }
        public List<OrderItem> GetAllByBillId(int billId)
        {
            return orderItemDao.GetAllByBillId(billId);
        }
    }
}
