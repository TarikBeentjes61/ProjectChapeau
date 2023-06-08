using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel;
using ChapeauService;

namespace ChapeauUI
{
    public partial class CurrentOrdersForm : Form
    {
        public CurrentOrdersForm()
        {
            InitializeComponent();
            LoadOrders(GetOrdersByStatus(OrderStatus.Waiting), listViewToDo);
            LoadOrders(GetOrdersByStatus(OrderStatus.ToDo), listViewDoing);
        }
        
        private List<Order> GetOrdersByStatus(OrderStatus status)
        {
            OrderService orderService = new OrderService();
            return orderService.GetAllByStatus(status);
        }

        private void LoadOrders(List<Order> orders, ListView list)
        {
            //Looping through all the orders and orderitems to fill the rows
            bool colorState = false;
            foreach (Order order in orders)
            {
                foreach (OrderItem item in order.OrderItems)
                {
                    ListViewItem li = new ListViewItem(order.tableId.ToString());
                    li.SubItems.Add(order.date.ToString("HH:mm"));
                    li.SubItems.Add(order.WaitingTime.ToString("hh':'mm"));
                    li.SubItems.Add(GetMenuItem(item.menuItemId).itemName);
                    li.SubItems.Add(item.amount.ToString());
                    li.BackColor = GetRowColor(colorState);
                    list.Items.Add(li);
                }
                colorState = !colorState;
            }
        }
        private Color GetRowColor(bool state) 
        {
            //Gets a color depending on the state which changes everytime a different order enters the table
            if (state)
                return Color.White;
            return Color.LightGray;
        }
        private MenuItem GetMenuItem(int id)
        {
            MenuItemService menuItemService = new MenuItemService();
            return menuItemService.GetById(id);
        }
    }
}
