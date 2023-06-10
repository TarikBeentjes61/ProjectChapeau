using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private readonly Color Green = Color.FromArgb(128, 255, 128);
        private readonly Color Orange = Color.FromArgb(255, 179, 71);
        private readonly ItemType[] BarItems = { ItemType.SoftFrinks, ItemType.Wines, ItemType.Beers };
        private OrderItem LastSelectedItem; //Keep track of the last selected item from the list
        private Employee LoggedInEmployee;
        public CurrentOrdersForm()
        {
            InitializeComponent();
            Start();
        }
        public void Start()
        {
            EmployeeService employeeService = new EmployeeService();

            LoggedInEmployee = employeeService.GetById(1);
            LoadOrders(GetOrdersByStatus(OrderStatus.Waiting), listViewWaiting);
            LoadOrders(GetOrdersByStatus(OrderStatus.Doing), listViewDoing);
        }
        private List<Order> GetOrdersByStatus(OrderStatus status)
        {
            //SELECT * FROM OrderItem JOIN MenuItem ON OrderItem.MenuItem_id = MenuItem.id WHERE MenuItem.itemType < 4 AND [status] = @status
            OrderService orderService = new OrderService();
            return orderService.GetAllByStatus(status);
        }

        private void LoadOrders(List<Order> orders, ListView list)
        {
            //Loads the orders for the given list, both lists have the same columns so it works in a single method.
            list.Items.Clear();
            bool colorState = false;
            foreach (Order order in orders)
            {
                foreach (OrderItem item in order.OrderItems)
                {
                    ListViewItem li = new ListViewItem(order.tableId.ToString());
                    li.Tag = item;
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
        private void LoadFinishedOrders(List<Order> orders)
        {
            listViewFinished.Items.Clear();
            //Looping through all the orders and orderitems to fill the rows
            bool colorState = false;
            foreach (Order order in orders)
            {
                foreach (OrderItem item in order.OrderItems)
                {
                    ListViewItem li = new ListViewItem(order.tableId.ToString());
                    li.Tag = item;
                    li.SubItems.Add(order.date.ToString("HH:mm"));
                    li.SubItems.Add(GetMenuItem(item.menuItemId).itemName);
                    li.SubItems.Add(item.amount.ToString());
                    li.BackColor = GetRowColor(colorState);
                    listViewFinished.Items.Add(li);
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
        private void ClearSelectedMainLists()
        {
            listViewWaiting.SelectedItems.Clear();
            listViewDoing.SelectedItems.Clear();
        }
        private void ChangeMainListState()
        {
            listViewWaiting.Enabled = !listViewWaiting.Enabled;
            listViewDoing.Enabled = !listViewDoing.Enabled;
        }
        private void ShowChangeStatusPanel(OrderStatus status)
        {
            //Change the color and text of the change status button depending on the status of the last selected item
            ChangeMainListState();
            if(status == OrderStatus.Waiting)
            {
                changeStatusButton.BackColor = Green;
                changeStatusButton.Text = "Change to Doing";
            }
            else
            {
                changeStatusButton.BackColor = Orange;
                changeStatusButton.Text = "Change to Finished";
            }
            changeStatusPanel.Show();
        }
        private void listViewWaiting_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                LastSelectedItem = (OrderItem)e.Item.Tag;
                ShowChangeStatusPanel(OrderStatus.Waiting);
            }
        }
        private void listViewDoing_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if(e.IsSelected)
            {
                LastSelectedItem = (OrderItem)e.Item.Tag;
                ShowChangeStatusPanel(OrderStatus.Doing);
            }
        }

        private void FinishedOrdersButton_Click(object sender, EventArgs e)
        {
            LoadFinishedOrders(GetOrdersByStatus(OrderStatus.Finished));
            ChangeMainListState();
            finishedPanel.BringToFront();
            finishedPanel.Show();
        }
        private void finishedBackButton_Click(object sender, EventArgs e)
        {
            ClearSelectedMainLists();
            ChangeMainListState();
            finishedPanel.Hide();
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            ClearSelectedMainLists();
            ChangeMainListState();
            changeStatusPanel.Hide();
        }
        private void changeStatusButton_Click(object sender, EventArgs e)
        {
            OrderItemService orderItemService = new OrderItemService();
            orderItemService.UpdateStatusById(LastSelectedItem.menuItemId, OrderStatus.Waiting);
            LoadOrders(GetOrdersByStatus(OrderStatus.Waiting), listViewWaiting);
            LoadOrders(GetOrdersByStatus(OrderStatus.Doing), listViewDoing);
            changeStatusPanel.Hide();
            ChangeMainListState();
        }
    }
}
