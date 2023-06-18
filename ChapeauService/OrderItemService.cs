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
        public OrderItem GetById(int id)
        {
            return orderItemDao.GetById(id);
        }
        public void UpdateStatusById(int id, OrderStatus status)
        {
            orderItemDao.UpdateStatusById(id, status);
        }
    }
}
