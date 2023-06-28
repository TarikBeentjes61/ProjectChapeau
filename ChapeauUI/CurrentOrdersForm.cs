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

namespace ChapeauUI
{
    public partial class CurrentOrdersForm : Form
    {
        private OrderItem? lastSelectedItem; //Keep track of the last selected item
        private int lastSelectedIndex;
        public CurrentOrdersForm(Employee employee)
        {
            InitializeComponent();
            servedOrdersPanel.BringToFront();
            ChangeHeaderLabel(employee);
            DisplayLogoutButton(employee);
            CreateTimer(60); //Takes in seconds which are converted to milliseconds
            RefreshData();
        }

        private void CreateTimer(int seconds)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = seconds * 1000; //interval is in milliseconds so multiply by 1000
            timer.Tick += new EventHandler(Timer_Tick); //Takes in the event that needs to be called when time expires
            timer.Start();
        }
        private void ChangeHeaderLabel(Employee employee)
        {
            //Main header name changes depending on the role from the logged in user
            if (employee.role == Role.Barista)
                mainLabel.Text = "Bar Orders";
            else
                mainLabel.Text = "Kitchen Orders";
        }
        private void DisplayLogoutButton(Employee employee)
        {
            logoutButton.Text = employee.name;
        }
        private void RefreshData()
        {
            try
            {
                //Refreshed all the loaded data from list and the selected item
                DisplayOrders(GetAllOrderItems());
                if (lastSelectedItem != null)
                {
                    lastSelectedItem = GetOrderItemById(lastSelectedItem.orderItemId);
                    DisplaySelectedItem(GetSelectedOrderItem());
                }
            }
            catch (Exception e)
            {
                ShowErrorMessageBox(e);
            }
        }
        private OrderItem? GetSelectedOrderItem()
        {
            if(listViewOrders.SelectedItems[0] != null)
                return (OrderItem)listViewOrders.SelectedItems[0].Tag;
            return null;
        }
        private int GetSelectedOrderItemIndex()
        {
            if (listViewOrders.SelectedItems[0] != null)
                return listViewOrders.SelectedItems[0].Index;
            return 0;
        }
        private void RefreshSingle()
        {
            try
            {
                //Remove the changed item and fetch the new one
                listViewOrders.Items.RemoveAt(lastSelectedIndex);
                lastSelectedItem = GetOrderItemById(lastSelectedItem.orderItemId);

                listViewOrders.Items.Add(CreateListViewItem(lastSelectedItem));
                listViewOrders.Sort();
            }
            catch (Exception e)
            {
                ShowErrorMessageBox(e);
            }
        }
        private void ShowErrorMessageBox(Exception e)
        {
            //Display a message box whenever something goes wrong like loading data
            MessageBox.Show("Something went wrong while loading the data " + e.Message);
        }
        private List<OrderItem> GetAllOrderItems()
        {
            //Gets all the orders depending on the current role.
            //Chef only gets items that are from menu 1 or 2
            //Barista only gets items that are from menu 3
            OrderItemService orderItemService = new OrderItemService();
            return orderItemService.GetOrderItemsByIdAndRole(1, Role.Barista);
        }
        private OrderItem GetOrderItemById(int id)
        {
            OrderItemService orderItemService = new OrderItemService();
            return orderItemService.GetById(id);
        }
        private void DisplayOrders(List<OrderItem> orderItems)
        {
            //Loads the orders for the given list
            listViewOrders.Items.Clear();
            foreach (OrderItem item in orderItems) //Loop through all of the items from the order
            {
                listViewOrders.Items.Add(CreateListViewItem(item));
            }
        }
        private ListViewItem CreateListViewItem(OrderItem item)
        {
            //Creates the list item and fills it with orderitem data
            ListViewItem li = new ListViewItem(item.orderItemId.ToString());
            li.Tag = item;
            li.SubItems.Add(item.order.id.ToString());
            li.SubItems.Add(item.amount.ToString());
            li.SubItems.Add(item.menuItem.itemName);
            li.BackColor = GetColourByState(item.status); //Changes the colour of the row on the given state
            return li;
        }
        private Color GetColourByState(OrderStatus status)
        {
            //Gets a colour depending on the given state
            switch (status)
            {
                case OrderStatus.Preparation:
                    return Color.White;
                case OrderStatus.Prepared:
                    return Color.Orange;
                default:
                    return Color.White;
            }
        }
        private void DisplaySelectedItem(OrderItem selectedItem)
        {
            //Fills all the labels with data from the last selected item
            selectedOrderIdLabel.Text = selectedItem.orderItemId.ToString();
            selectedOrderStatusLabel.Text = selectedItem.status.ToString();
            commentLabel.Text = selectedItem.comment.ToString();
            tableLabel.Text = selectedItem.order.table.tableId.ToString();
        }
        private void UpdateSelectedItem(OrderStatus status)
        {
            //Gets called whenever a button click happens, updates the data and refreshes it.
            //The selected item changes it status depending on the button pressed.
            if (lastSelectedItem != null)
            {
                OrderItemService orderItemService = new OrderItemService();
                orderItemService.UpdateStatusById(lastSelectedItem.orderItemId, status);
                RefreshSingle();
            }
        }
        private void listViewOrders_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //Gets called whenever u click on an item within the list
            if (!e.IsSelected)
                return;
            try
            {
                DisplaySelectedItem((OrderItem)e.Item.Tag);
            }
            catch (Exception ex)
            {
                ShowErrorMessageBox(ex);
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            //The event that gets called whenever the timer runs out
            RefreshData();
        }
        //Button events
        private void preperationButton_Click(object sender, EventArgs e)
        {
            UpdateSelectedItem(OrderStatus.Preparation);
        }
        private void preparedButton_Click(object sender, EventArgs e)
        {
            UpdateSelectedItem(OrderStatus.Prepared);
        }
        private void ServedButton_Click(object sender, EventArgs e)
        {
            UpdateSelectedItem(OrderStatus.Served);
        }
        private void showServedButton_Click(object sender, EventArgs e)
        {
            DisplayServedOrders(true);
        }
        public void DisplayServedOrders(bool show)
        {
            if (show)
                servedOrdersPanel.Show();
            else
                servedOrdersPanel.Hide();
        }
        private void logoutButton_Click(object sender, EventArgs e)
        {
            //Close the current form and show the login form
            LoginForm loginForm = new LoginForm();
            this.Close();
            loginForm.Show();
        }

        private void hideServedButton_Click(object sender, EventArgs e)
        {
            DisplayServedOrders(false);
        }
    }
}
