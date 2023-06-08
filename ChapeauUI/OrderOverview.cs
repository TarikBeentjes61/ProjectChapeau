using ChapeauModel;
using ChapeauService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace ChapeauUI
{
    public partial class OrderOverview : Form
    {
        public OrderOverview()
        {
            InitializeComponent();

            OrderItemService orderItemService = new OrderItemService();
            List<OrderItem> orderItems = orderItemService.GetAll();

            listViewOrderOverview.Clear();
            listViewOrderOverview.View = View.Details;

            listViewOrderOverview.Columns.Add("Amount");
            listViewOrderOverview.Columns.Add("Name");
            listViewOrderOverview.Columns.Add("Price");

            foreach (OrderItem o in orderItems)
            {
                ListViewItem item = new ListViewItem();

                MenuItemService menuItemService = new MenuItemService();
                MenuItem menuItem = menuItemService.GetById(o.menuItemId);

                item.SubItems.Add(o.amount.ToString());
                item.SubItems.Add(menuItem.ToString());
                listViewOrderOverview.Items.Add(item);
            }
        }
    }
}
