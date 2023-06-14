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

        private void btnLunch_Click(object sender, EventArgs e)
        {
            //How to make it appear only once? And hide the CreateOrderForm
            CreateOrderForm form = new CreateOrderForm();
            form.Show();
            form.btnLunch.BackColor = Color.FromArgb(189, 242, 217);

            //STARTERS LISTVIEW
            MenuItemService menuItemService = new MenuItemService();
            ItemType starters = ItemType.Starters;
            List<MenuItem> menuItemsStarters = menuItemService.GetByItemType(starters, 1);

            form.listViewStarters.Clear();
            form.listViewStarters.View = View.Details;

            form.listViewStarters.Columns.Add("Name");
            form.listViewStarters.Columns.Add("Price");

            foreach (MenuItem m in menuItemsStarters)
            {
                ListViewItem item = new ListViewItem();

                item.SubItems.Add(m.itemName);
                item.SubItems.Add(m.price.ToString());
                form.listViewStarters.Items.Add(item);
            }

            //MAINS LISTVIEW
            ItemType mains = ItemType.Mains;
            List<MenuItem> menuItemsMains = menuItemService.GetByItemType(mains, 1);

            form.listViewMains.Clear();
            form.listViewMains.View = View.Details;

            form.listViewMains.Columns.Add("Name");
            form.listViewMains.Columns.Add("Price");

            foreach (MenuItem m in menuItemsMains)
            {
                ListViewItem item = new ListViewItem();

                item.SubItems.Add(m.itemName);
                item.SubItems.Add(m.price.ToString());
                form.listViewMains.Items.Add(item);
            }

            //DESERTS LISTVIEW

            ItemType deserts = ItemType.Deserts;
            List<MenuItem> menuItemsDeserts = menuItemService.GetByItemType(deserts, 1);

            form.listViewDeserts.Clear();
            form.listViewDeserts.View = View.Details;

            form.listViewDeserts.Columns.Add("Name");
            form.listViewDeserts.Columns.Add("Price");

            foreach (MenuItem m in menuItemsDeserts)
            {
                ListViewItem item = new ListViewItem();

                item.SubItems.Add(m.itemName);
                item.SubItems.Add(m.price.ToString());
                form.listViewDeserts.Items.Add(item);
            }
        }

        private void btnDinner_Click(object sender, EventArgs e)
        {
            CreateOrderForm form = new CreateOrderForm();
            form.Show();
            form.btnDinner.BackColor = Color.FromArgb(189, 242, 217);
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            CreateOrderForm form = new CreateOrderForm();
            form.Show();
            form.btnDrinks.BackColor = Color.FromArgb(189, 242, 217);
        }
    }
}
