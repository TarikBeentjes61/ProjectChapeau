using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class ListViewEditor
    {
        public OrderItem LoadListview(string value, List<OrderItem> orderItems)
        {
            bool exists = false;
            OrderItem orderItem = new OrderItem();
            orderItem.menuItem = new MenuItem();
            orderItem.order = new Order();

            int menuItemId = int.Parse(value);

            foreach (OrderItem o in orderItems)
            {
                if (o.menuItem.menuItemId == menuItemId)
                {
                    exists = true;
                    o.amount++;
                }
            }

            if (!exists)
            {
                orderItem.menuItem.menuItemId = menuItemId;
                orderItem.order.id = 1;
                orderItem.amount = 1;
                orderItem.comment = "";
            }

            return orderItem;
        }

        public void RemoveListviewItem(string value, List<OrderItem> orderItems)
        {
            int menuItemId = int.Parse(value);

            foreach (OrderItem o in orderItems)
            {
                if (o.menuItem.menuItemId == menuItemId)
                {
                    if(o.amount > 1)
                    {
                        o.amount--;
                    }
                    else
                    {
                        orderItems.Remove(o);
                    }
                    break;
                }
                
            }
        }
    }
}
