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
            ListViewItem li = new ListViewItem("1");
            li.SubItems.Add("11:22");
            li.SubItems.Add("0:33");
            li.SubItems.Add("Steak");
            li.SubItems.Add("2");
            listViewToDo.Items.Add(li);
            LoadOrdersToDo(GetOrdersByStatus(OrderStatus.Waiting));
        }
        private List<Order> GetOrdersByStatus(OrderStatus status)
        {
            OrderService orderService = new OrderService();
            return orderService.GetAllByStatus(status);
        }
        private void LoadOrdersToDo(List<Order> orders)
        {
            bool colorState = true;
            foreach (Order order in orders)
            {
                foreach (OrderItem item in order.OrderItems)
                {
                    ListViewItem li = new ListViewItem(item.orderId.ToString());
                    li.SubItems.Add(order.date.ToString("HH:mm"));
                    li.SubItems.Add(order.WaitingTime.ToString(""));
                    li.SubItems.Add(GetMenuItem(item.menuItemId).itemName);
                    li.SubItems.Add(item.amount.ToString());
                    li.BackColor = GetRowColor(colorState);
                    listViewToDo.Items.Add(li);
                }
                colorState = !colorState;
            }
        }
        private Color GetRowColor(bool state)
        {
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
