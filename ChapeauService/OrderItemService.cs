using ChapeauDAL;
using ChapeauModel;
using System.Collections.Generic;

namespace ChapeauService
{
    public class OrderItemService
    {
        private OrderItemDao orderItemDao;

        public OrderItemService()
        {
            orderItemDao = new OrderItemDao();  
        }
        public List<OrderItem> GetAll()
        {
            return orderItemDao.GetAll();
        }
        public List<OrderItem> GetOrderItemsByIdAndRole(int orderId, Role role)
        {
            return orderItemDao.GetOrderItemsByIdAndRole(orderId, role);
        }
        public List<OrderItem> GetByTableId(int tableId)
        {
            return orderItemDao.GetByTableId(tableId);
        }
        public OrderItem GetById(int id)
        {
            return orderItemDao.GetById(id);
        }
        public List<OrderItem> GetByOrderId(int orderId)
        {
            return orderItemDao.GetByOrderId(orderId);
        }
        public void AddOrderItems(int orderId, int menuitemId, int amount, string comment, OrderStatus status)
        {
            orderItemDao.AddOrderItems(orderId, menuitemId, amount, comment, status);
        }
        public void UpdateStatusById(int id, OrderStatus status)
        {
            orderItemDao.UpdateStatusById(id, status);
        }
    }
}
