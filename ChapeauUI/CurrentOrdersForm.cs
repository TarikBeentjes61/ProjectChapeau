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
        private Employee loggedInEmployee;
        public CurrentOrdersForm(Employee employee)
        {
            InitializeComponent();
            servedOrdersPanel.BringToFront();
            ChangeHeaderLabel(employee);
            DisplayLogoutButton(employee);
            DisplayOrders(GetAllOrderItems(employee), listViewOrders);
            loggedInEmployee = employee;
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
        private OrderItem? GetSelectedOrderItem()
        {
            return listViewOrders.SelectedItems.Count > 0 ? (OrderItem)listViewOrders.SelectedItems[0].Tag : null;
        }
        private int GetSelectedOrderItemIndex()
        {
            return listViewOrders.SelectedItems.Count > 0 ? listViewOrders.SelectedItems[0].Index : 0;
        }
        private void RefreshSingle()
        {
            OrderItem? selectedItem = GetSelectedOrderItem();
            if(selectedItem is not null)
            {
                int index = GetSelectedOrderItemIndex();
                OrderItem item = GetOrderItemById(selectedItem.orderItemId);

                listViewOrders.Items.RemoveAt(index);
                if (item.status != OrderStatus.Served)
                    listViewOrders.Items.Insert(index, CreateListViewItem(item));
            }
        }
        private List<OrderItem> GetAllOrderItems(Employee employee)
        {
            //Gets all the orderitems depending on the current role.
            OrderItemService orderItemService = new OrderItemService();
            return orderItemService.GetOrderItemsByRole(employee.role);
        }
        private List<OrderItem> GetAllServedOrderItems(Employee employee)
        {
            //Gets all the served orderitems depending on the current role.
            OrderItemService orderItemService = new OrderItemService();
            return orderItemService.GetServedOrderItemsByRole(employee.role);
        }
        private OrderItem GetOrderItemById(int id)
        {
            //Get a specific orderItem by id
            OrderItemService orderItemService = new OrderItemService();
            return orderItemService.GetById(id);
        }
        private void DisplayOrders(List<OrderItem> orderItems, ListView listView)
        {
            //Loads the orders for the given list
            listView.Items.Clear();
            foreach (OrderItem item in orderItems)
            {
                listView.Items.Add(CreateListViewItem(item));
            }
        }
        private ListViewItem CreateListViewItem(OrderItem item)
        {
            //Creates the list item and fills it with orderitem data
            ListViewItem li = new ListViewItem(item.order.WaitingTime.ToString("hh\\:mm"));
            li.Tag = item;
            li.SubItems.Add(item.orderItemId.ToString());
            li.SubItems.Add(item.amount.ToString() + 'x');
            li.SubItems.Add(item.menuItem.itemName);
            if (item.status != OrderStatus.Served)
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
            if (selectedItem.status == OrderStatus.Served)
            {
                selectedOrderIdLabel.Text = "";
                selectedOrderStatusLabel.Text = "";
                commentLabel.Text = "";
                tableLabel.Text = "";
            }
            else
            {
                selectedOrderIdLabel.Text = selectedItem.orderItemId.ToString();
                selectedOrderStatusLabel.Text = selectedItem.status.ToString();
                commentLabel.Text = selectedItem.comment.ToString();
                tableLabel.Text = selectedItem.order.table.tableId.ToString();
            }
        }
        public void DisplayServedOrders(bool show)
        {
            DisplayOrders(GetAllServedOrderItems(loggedInEmployee), servedOrderListview);
            if (show)
                servedOrdersPanel.Show();
            else
                servedOrdersPanel.Hide();
        }
        private void UpdateSelectedItem(OrderStatus status)
        {
            //Gets called whenever a button click happens, updates the data and refreshes it.
            //The selected item changes it status depending on the button pressed.
            OrderItem? selectedItem = GetSelectedOrderItem();
            if (selectedItem is not null && selectedItem.status != OrderStatus.Served)
            {
                OrderItemService orderItemService = new OrderItemService();
                orderItemService.UpdateStatusById(selectedItem.orderItemId, status);
                DisplaySelectedItem(orderItemService.GetById(selectedItem.orderItemId));
                RefreshSingle();
            }
        }
        private void ChangeStateBackgroundControls(bool state)
        {
            listViewOrders.Enabled = state;
            ServedButton.Enabled = state;
            preparedButton.Enabled = state;
            logoutButton.Enabled = state;
            showServedButton.Enabled = state;
            preperationButton.Enabled = state;
        }
        private void listViewOrders_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //Gets called whenever u click on an item within the list
            if (e.IsSelected)
                DisplaySelectedItem((OrderItem)e.Item.Tag);
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            //The event that gets called whenever the timer runs out
            DisplayOrders(GetAllOrderItems(loggedInEmployee), listViewOrders);
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
        private void logoutButton_Click(object sender, EventArgs e)
        {
            //Close the current form and show the login form
            LoginForm loginForm = new LoginForm();
            this.Close();
            loginForm.Show();
        }
        private void showServedButton_Click(object sender, EventArgs e)
        {
            DisplayServedOrders(true);
            ChangeStateBackgroundControls(false);
        }
        private void hideServedButton_Click(object sender, EventArgs e)
        {
            DisplayServedOrders(false);
            ChangeStateBackgroundControls(true);
        }
    }
}
