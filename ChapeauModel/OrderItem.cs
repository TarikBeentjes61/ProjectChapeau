using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class OrderItem
    {
        private MenuItem menuItem;
        private Order order;
        private int amount;
        private string comment;

        public OrderItem(int amount)
        {
            this.amount = amount;
        }

        public void AddComment()
        {

        }

    }
}
