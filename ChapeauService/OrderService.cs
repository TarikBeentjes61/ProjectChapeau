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
        public Order GetById(int id)
        {
            return orderDao.GetById(id);
        }
        //public Order AddOrder(List<OrderItem> orderItems)
        //{
        //    return orderDao.AddOrder(orderItems);
        //}
    }
}
