using ChapeauDAL;
using ChapeauModel;
using System.Collections.Generic;

namespace ChapeauService
{
    public class OrderService
    {
        private OrderDao orderDao;

        public OrderService()
        {
            orderDao = new OrderDao();
        }
        public List<Order> GetAll()
        {
            return orderDao.GetAll();  
        }
        public List<Order> GetAll(Role role, bool showServed)
        {
            return orderDao.GetAll(role, showServed);  
        }
        public Order GetById(int id)
        {
            return orderDao.GetById(id);
        }
        public List<Order> GetAllByStatus(OrderStatus status)
        {
            return orderDao.GetAllByState(status);
        }
        //public Order AddOrder(List<OrderItem> orderItems)
        //{
        //    orderDao.AddOrder(orderItems);
        //}
    }
}
