using ChapeauModel;
using ChapeauService;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChapeauUI
{
    public partial class CreateOrderForm : Form
    {
        Order order = new Order();
        List<OrderItem> orderItems;
        bool btnRemoveWasClicked = false;
        double totalPrice = 0;
        Employee employee;
        int tableId;

        public CreateOrderForm(int table, Employee employee)
        {
            InitializeComponent();

            this.employee = employee;
            tableId = table;

            //NAME EMPLOYEE
            EmployeeLabels(employee);

            //TABLE
            TableLabels();

            //Hide other panels
            HidePanels();

            //Disable All Necessary Buttons
            DisableButtons();

            //Change Necessary Button Colors
            ButtonColors();

            //Show this panel
            pnlOrderOverview.Show();
        }

        

        private void CreateOrderForm_Load(object sender, EventArgs e)
        {
            try
            {
                MenuItem menuItem = new MenuItem();


                //LUNCH
                //STARTERS LISTVIEW
                FillListviewMenuItems(listViewStartersLunch, ItemType.Starters, 1);

                //MAINS LISTVIEW
                FillListviewMenuItems(listViewMainsLunch, ItemType.Mains, 1);

                //DESERTS LISTVIEW
                FillListviewMenuItems(listViewDesertsLunch, ItemType.Deserts, 1);

                //DINNER
                //STARTERS LISTVIEW
                FillListviewMenuItems(listViewStartersDinner, ItemType.Starters, 2);

                //ENTRES LISTVIEW
                FillListviewMenuItems(listViewEntresDinner, ItemType.Entres, 2);

                //MAINS LISTVIEW
                FillListviewMenuItems(listViewMainsDinner, ItemType.Mains, 2);

                ////DESERTS LISTVIEW
                FillListviewMenuItems(listViewDesertsDinner, ItemType.Deserts, 2);

                //DRINKS
                //SOFT DRINKS LISTVIEW
                FillListviewMenuItems(listViewSoftDrinks, ItemType.SoftDrinks, 3);

                //BEERS LISTVIEW
                FillListviewMenuItems(listViewBeers, ItemType.Beers, 3);

                //WINES LISTVIEW
                FillListviewMenuItems(listViewWines, ItemType.Wines, 3);

                //SPIRITS LISTVIEW
                FillListviewMenuItems(listViewSpirits, ItemType.Spirits, 3);

                //HOT DRINKS LISTVIEW
                FillListviewMenuItems(listViewHotDrinks, ItemType.HotDrinks, 3);

                //ORDER LUNCH PANEL
                FillListviewOrder(listViewOrderLunch, orderItems);

                //ORDER DINNER PANEL
                FillListviewOrder(listViewOrderDinner, orderItems);

                //ORDER DRINKS PANEL
                FillListviewOrder(listViewOrderDrinks, orderItems);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong {ex.Message}");
            }
        }

        //MAKE LUNCH ORDER
        private void listViewStartersLunch_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddItemsToOrderListview(listViewStartersLunch, orderItems);
            CreateOrderForm_Load(sender, e);
        }

        private void listViewMainsLunch_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddItemsToOrderListview(listViewMainsLunch, orderItems);
            CreateOrderForm_Load(sender, e);
        }

        private void listViewDesertsLunch_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddItemsToOrderListview(listViewDesertsLunch, orderItems);
            CreateOrderForm_Load(sender, e);
        }

        //MAKE DINNER ORDER
        private void listViewStartersDinner_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddItemsToOrderListview(listViewStartersDinner, orderItems);
            CreateOrderForm_Load(sender, e);
        }

        private void listViewEntresDinner_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddItemsToOrderListview(listViewEntresDinner, orderItems);
            CreateOrderForm_Load(sender, e);
        }

        private void listViewMainsDinner_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddItemsToOrderListview(listViewMainsDinner, orderItems);
            CreateOrderForm_Load(sender, e);
        }

        private void listViewDesertsDinner_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddItemsToOrderListview(listViewDesertsDinner, orderItems);
            CreateOrderForm_Load(sender, e);
        }

        //MAKE DRINKS ORDER
        private void listViewSoftDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddItemsToOrderListview(listViewSoftDrinks, orderItems);
            CreateOrderForm_Load(sender, e);
        }

        private void listViewBeers_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddItemsToOrderListview(listViewBeers, orderItems);
            CreateOrderForm_Load(sender, e);
        }

        private void listViewWines_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddItemsToOrderListview(listViewWines, orderItems);
            CreateOrderForm_Load(sender, e);
        }

        private void listViewSpirits_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddItemsToOrderListview(listViewSpirits, orderItems);
            CreateOrderForm_Load(sender, e);
        }

        private void listViewHotDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddItemsToOrderListview(listViewHotDrinks, orderItems);
            CreateOrderForm_Load(sender, e);
        }

        private void listViewOrderLunch_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveItemsFromListview(listViewOrderLunch, orderItems);
            CreateOrderForm_Load(sender, e);
        }

        private void listViewOrderDinner_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveItemsFromListview(listViewOrderDinner, orderItems);
            CreateOrderForm_Load(sender, e);
        }

        private void listViewOrderDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveItemsFromListview(listViewOrderDrinks, orderItems);
            CreateOrderForm_Load(sender, e);
        }

        //LUNCH ORDER OVERVIEW
        private void btnLunchOrderOverview_Click(object sender, EventArgs e)
        {
            //Hide other panels
            pnlOrderOverview.Hide();
            pnlCreateOrderDinner.Hide();
            pnlCreateOrderDrinks.Hide();

            //Show this panel
            pnlCreateOrderLunch.Show();
        }

        //DINNER ORDER OVERVIEW
        private void btnDinnerOrderOverview_Click(object sender, EventArgs e)
        {
            //Hide other panels
            pnlOrderOverview.Hide();
            pnlCreateOrderLunch.Hide();
            pnlCreateOrderDrinks.Hide();

            //Show this panel
            pnlCreateOrderDinner.Show();
        }

        //DRINKS ORDER OVERVIEW
        private void btnDrinksOrderOverview_Click(object sender, EventArgs e)
        {
            //Hide other panels
            pnlOrderOverview.Hide();
            pnlCreateOrderLunch.Hide();
            pnlCreateOrderDinner.Hide();

            //Show this panel
            pnlCreateOrderDrinks.Show();
        }

        //DINNER BUTTON FROM LUNCH OVERVIEW
        private void btnDinner_Click(object sender, EventArgs e)
        {
            //Hide other panels
            pnlOrderOverview.Hide();
            pnlCreateOrderLunch.Hide();
            pnlCreateOrderDrinks.Hide();

            //Show this panel
            pnlCreateOrderDinner.Show();
        }

        //DRINKS BUTTON FROM LUNCH OVERVIEW
        private void btnDrinksFromLunchOverview_Click(object sender, EventArgs e)
        {
            //Hide other panels
            pnlOrderOverview.Hide();
            pnlCreateOrderLunch.Hide();
            pnlCreateOrderDinner.Hide();

            //Show this panel
            pnlCreateOrderDrinks.Show();
        }

        //LUNCH BUTTON FROM DINNER OVERVIEW
        private void btnLunchFromDinnerOverview_Click(object sender, EventArgs e)
        {
            //Hide other panels
            pnlOrderOverview.Hide();
            pnlCreateOrderDrinks.Hide();
            pnlCreateOrderDinner.Hide();

            //Show this panel
            pnlCreateOrderLunch.Show();
        }

        //DRINKS BUTTON FROM DINNER OVERVIEW
        private void btnDrinksFromDinnerOverview_Click(object sender, EventArgs e)
        {
            //Hide other panels
            pnlOrderOverview.Hide();
            pnlCreateOrderLunch.Hide();
            pnlCreateOrderDinner.Hide();

            //Show this panel
            pnlCreateOrderDrinks.Show();
        }

        //LUNCH BUTTON FROM DRINKS OVERVIEW
        private void btnLunchFromDrinksOverview_Click(object sender, EventArgs e)
        {
            //Hide other panels
            pnlOrderOverview.Hide();
            pnlCreateOrderDrinks.Hide();
            pnlCreateOrderDinner.Hide();

            //Show this panel
            pnlCreateOrderLunch.Show();
        }

        //DINNER BUTTON FROM LUNCH OVERVIEW
        private void btnDinnerFromDrinksOverview_Click(object sender, EventArgs e)
        {
            //Hide other panels
            pnlOrderOverview.Hide();
            pnlCreateOrderDrinks.Hide();
            pnlCreateOrderLunch.Hide();

            //Show this panel
            pnlCreateOrderDinner.Show();
        }

        private void btnAddLunch_Click(object sender, EventArgs e)
        {
            AddAndShowOrder();
            pnlCreateOrderLunch.Hide();
            pnlOrderOverview.Show();
            CreateOrderForm_Load(sender, e);
        }
        private void btnAddDinner_Click(object sender, EventArgs e)
        {
            AddAndShowOrder();
            pnlCreateOrderDinner.Hide();
            pnlOrderOverview.Show();
            CreateOrderForm_Load(sender, e);
        }

        private void btnAddDrinks_Click(object sender, EventArgs e)
        {
            AddAndShowOrder();
            pnlCreateOrderDrinks.Hide();
            pnlOrderOverview.Show();
            CreateOrderForm_Load(sender, e);
        }

        private void AddAndShowOrder()
        {
            OrderService orderService = new OrderService();
            OrderItemService orderItemService = new OrderItemService();
            MenuItemService menuItemService = new MenuItemService();
            orderItems = order.OrderItems;

            int orderId = orderService.AddOrder(tableId, employee.employeeId, 1, DateTime.Now, OrderStatus.Preparation);

            listViewOrderOverview.Clear();
            listViewOrderOverview.View = View.Details;

            listViewOrderOverview.Columns.Add("Amount", 25);
            listViewOrderOverview.Columns.Add("Name", 370);
            listViewOrderOverview.Columns.Add("Price", 45);

            foreach (OrderItem o in orderItems)
            {
                MenuItem menuItem = menuItemService.GetById(o.menuItemId);

                o.comment = "";
                o.status = OrderStatus.Preparation;
                totalPrice += menuItem.price;
                o.orderId = orderId;
                orderItemService.AddOrderItems(orderId, o.menuItemId, o.amount, o.comment, o.status);

                ListViewItem item = new ListViewItem(o.amount.ToString());
                item.SubItems.Add(menuItem.itemName);
                item.SubItems.Add(menuItem.price.ToString());
                listViewOrderOverview.Items.Add(item);
            }

            lblTotal.Text = "Total: " + totalPrice.ToString();
            btnPay.Enabled = true;
        }

        //REMOVE
        private void btnRemoveLunch_Click(object sender, EventArgs e)
        {
            btnRemoveWasClicked = true;
        }
        private void btnRemoveDinner_Click(object sender, EventArgs e)
        {
            btnRemoveWasClicked = true;
        }
        private void btnRemoveDrinks_Click(object sender, EventArgs e)
        {
            btnRemoveWasClicked = true;
        }
        private void btnGoToOverviewLunch_Click(object sender, EventArgs e)
        {
            //Show this panel
            pnlOrderOverview.Show();

            //Hide other panels
            pnlCreateOrderDrinks.Hide();
            pnlCreateOrderLunch.Hide();
            pnlCreateOrderDinner.Hide();
        }

        private void btnGoToOverviewDinner_Click(object sender, EventArgs e)
        {
            //Show this panel
            pnlOrderOverview.Show();

            //Hide other panels
            pnlCreateOrderDrinks.Hide();
            pnlCreateOrderLunch.Hide();
            pnlCreateOrderDinner.Hide();
        }
        private void btnGoToOverviewDrinks_Click(object sender, EventArgs e)
        {
            //Show this panel
            pnlOrderOverview.Show();

            //Hide other panels
            pnlCreateOrderDrinks.Hide();
            pnlCreateOrderLunch.Hide();
            pnlCreateOrderDinner.Hide();
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            BillViewForm paymentForm = new BillViewForm(tableId, employee);
            paymentForm.Show();
        }

        private void lblImageChapeau2_Click(object sender, EventArgs e)
        {
            TableForm tableForm = new TableForm(employee);
            tableForm.Show();
        }

        //METHODS
        //Method to fill listview with menuItems
        private void FillListviewMenuItems(System.Windows.Forms.ListView listView, ItemType itemType, int menuId/*MenuItem menu*/)
        {
            MenuItemService menuItemService = new MenuItemService();
            List<MenuItem> menuItems = menuItemService.GetByItemType(itemType, menuId/*menu.menuId*/);

            listView.Clear();
            listView.View = View.Details;

            listView.Columns.Add("Id", 25);
            listView.Columns.Add("Name", 349);
            listView.Columns.Add("Price", 45);

            foreach (MenuItem m in menuItems)
            {
                ListViewItem item = new ListViewItem(m.menuItemId.ToString());

                item.SubItems.Add(m.itemName);
                item.SubItems.Add(m.price.ToString());
                listView.Items.Add(item);
            }
        }

        //Method to fill listview with orders
        private void FillListviewOrder(System.Windows.Forms.ListView listView, List<OrderItem> orderItems)
        {
            orderItems = order.OrderItems;

            MenuItemService menuItemService = new MenuItemService();

            listView.Clear();
            listView.View = View.Details;

            listView.Columns.Add("Id", 25);
            listView.Columns.Add("Name", 350);
            listView.Columns.Add("Amount", 65);

            foreach (OrderItem o in orderItems)
            {
                MenuItem menuItem = menuItemService.GetById(o.menuItemId);

                ListViewItem item = new ListViewItem(o.menuItemId.ToString());

                item.SubItems.Add(menuItem.itemName);
                item.SubItems.Add(o.amount.ToString());
                listView.Items.Add(item);
            }
        }

        //Method to add items to orderview
        private void AddItemsToOrderListview(System.Windows.Forms.ListView listView, List<OrderItem> orderItems)
        {
            orderItems = order.OrderItems;

            ListViewEditor listviewEditor = new ListViewEditor();
            string value = "";

            foreach (ListViewItem selectedItem in listView.SelectedItems)
            {
                value = selectedItem.SubItems[0].Text;
            }

            OrderItem orderItem = listviewEditor.LoadListview(value, orderItems);

            if (orderItem.amount == 1)
            {
                orderItems.Add(orderItem);
            }
        }

        //Method to remove items from orderview
        private void RemoveItemsFromListview(System.Windows.Forms.ListView listView, List<OrderItem> orderItems)
        {
            orderItems = order.OrderItems;

            ListViewEditor listviewEditor = new ListViewEditor();
            string value = "";

            foreach (ListViewItem selectedItem in listView.SelectedItems)
            {
                value = selectedItem.SubItems[0].Text;
            }

            if (btnRemoveWasClicked)
            {
                listviewEditor.RemoveListviewItem(value, orderItems);
            }
        }
        private void HidePanels()
        {
            pnlCreateOrderDinner.Hide();
            pnlCreateOrderDrinks.Hide();
            pnlCreateOrderLunch.Hide();
        }

        private void DisableButtons()
        {
            btnLunchUnavailable.Enabled = false;
            btnDinnerUnavailable.Enabled = false;
            btnDrinksUnavailable.Enabled = false;
            btnPay.Enabled = false;
        }

        private void ButtonColors()
        {
            btnLunchUnavailable.BackColor = Color.FromArgb(189, 242, 217);
            btnDinnerUnavailable.BackColor = Color.FromArgb(189, 242, 217);
            btnDrinksUnavailable.BackColor = Color.FromArgb(189, 242, 217);
        }

        private void EmployeeLabels(Employee employee)
        {
            lblEmployee.Text = employee.name;
            lblEmployee2.Text = employee.name;
            lblEmployee3.Text = employee.name;
            lblEmployee4.Text = employee.name;
        }

        private void TableLabels()
        {
            lblTableOrderOverview.Text = "Table " + tableId.ToString();
            lblTableLunchOverview.Text = "Table " + tableId.ToString();
            lblTableDinnerOverview.Text = "Table " + tableId.ToString();
            lblTableDrinksOverview.Text = "Table " + tableId.ToString();
        }
    }
}