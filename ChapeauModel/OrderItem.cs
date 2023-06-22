using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class OrderItem
    {
        public int orderItemId;
        public MenuItem menuItem;
        public Order order = new Order();
        //!!!!!!CHANGE THIS^^^^^^^^^^^^^^

        public int amount;
        public string comment = "";
        public OrderStatus status = OrderStatus.Preparation;

        public void AddComment()
        {

        }

    }
}
