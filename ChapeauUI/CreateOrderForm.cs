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
        ChapeauModel.Menu menu = new ChapeauModel.Menu();
        MenuItemService menuItemService = new MenuItemService();
        OrderItemService orderItemService = new OrderItemService();
        bool btnRemoveWasClicked = false;
        double totalPrice = 0;
        Employee employee;
        Table table;
        Bill bill = new Bill();
        int tableId;

        public CreateOrderForm(Table table, Employee employee)
        {
            InitializeComponent();

            this.employee = employee;
            tableId = table.tableId;

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

            //LUNCH
            //Starters listview
            FillListviewMenuItems(listViewStartersLunch, ItemType.Starters, 1);

            //Mains listview
            FillListviewMenuItems(listViewMainsLunch, ItemType.Mains, 1);

            //Deserts listview
            FillListviewMenuItems(listViewDesertsLunch, ItemType.Deserts, 1);

            //DINNER
            //Starters listview
            FillListviewMenuItems(listViewStartersDinner, ItemType.Starters, 2);

            //Entres listview
            FillListviewMenuItems(listViewEntresDinner, ItemType.Entres, 2);

            //Mains listview
            FillListviewMenuItems(listViewMainsDinner, ItemType.Mains, 2);

            //Deserts listview
            FillListviewMenuItems(listViewDesertsDinner, ItemType.Deserts, 2);

            //DRINKS
            //Soft drinks listview
            FillListviewMenuItems(listViewSoftDrinks, ItemType.SoftDrinks, 3);

            //Beers listview
            FillListviewMenuItems(listViewBeers, ItemType.Beers, 3);

            //wines listview
            FillListviewMenuItems(listViewWines, ItemType.Wines, 3);

            //Spirits listview
            FillListviewMenuItems(listViewSpirits, ItemType.Spirits, 3);

            //Hot drinks listview
            FillListviewMenuItems(listViewHotDrinks, ItemType.HotDrinks, 3);
        }

        private void CreateOrderForm_Load(object sender, EventArgs e)
        {
            try
            {
                //ORDER LUNCH PANEL
                FillListviewOrder(listViewOrderLunch, order.GetOrderItems());

                //ORDER DINNER PANEL
                FillListviewOrder(listViewOrderDinner, order.GetOrderItems());

                //ORDER DRINKS PANEL
                FillListviewOrder(listViewOrderDrinks, order.GetOrderItems());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong {ex.Message}");
            }
        }

        //Add lunch item to order
        private void listViewStartersLunch_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddItemsToOrderListview(listViewStartersLunch, order.GetOrderItems());
            CreateOrderForm_Load(sender, e);
        }
        private void listViewMainsLunch_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddItemsToOrderListview(listViewMainsLunch, order.GetOrderItems());
            CreateOrderForm_Load(sender, e);
        }
        private void listViewDesertsLunch_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddItemsToOrderListview(listViewDesertsLunch, order.GetOrderItems());
            CreateOrderForm_Load(sender, e);
        }

        //Add dinner item to order
        private void listViewStartersDinner_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddItemsToOrderListview(listViewStartersDinner, order.GetOrderItems());
            CreateOrderForm_Load(sender, e);
        }
        private void listViewEntresDinner_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddItemsToOrderListview(listViewEntresDinner, order.GetOrderItems());
            CreateOrderForm_Load(sender, e);
        }
        private void listViewMainsDinner_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddItemsToOrderListview(listViewMainsDinner, order.GetOrderItems());
            CreateOrderForm_Load(sender, e);
        }
        private void listViewDesertsDinner_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddItemsToOrderListview(listViewDesertsDinner, order.GetOrderItems());
            CreateOrderForm_Load(sender, e);
        }

        //Add drinks item to order
        private void listViewSoftDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddItemsToOrderListview(listViewSoftDrinks, order.GetOrderItems());
            CreateOrderForm_Load(sender, e);
        }
        private void listViewBeers_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddItemsToOrderListview(listViewBeers, order.GetOrderItems());
            CreateOrderForm_Load(sender, e);
        }
        private void listViewWines_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddItemsToOrderListview(listViewWines, order.GetOrderItems());
            CreateOrderForm_Load(sender, e);
        }
        private void listViewSpirits_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddItemsToOrderListview(listViewSpirits, order.GetOrderItems());
            CreateOrderForm_Load(sender, e);
        }
        private void listViewHotDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddItemsToOrderListview(listViewHotDrinks, order.GetOrderItems());
            CreateOrderForm_Load(sender, e);
        }

        //Remove items from order
        private void listViewOrderLunch_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveItemsFromListview(listViewOrderLunch, order.GetOrderItems()   );
            CreateOrderForm_Load(sender, e);
        }
        private void listViewOrderDinner_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveItemsFromListview(listViewOrderDinner, order.GetOrderItems());
            CreateOrderForm_Load(sender, e);
        }
        private void listViewOrderDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveItemsFromListview(listViewOrderDrinks, order.GetOrderItems());
            CreateOrderForm_Load(sender, e);
        }

        //Lunch order overview
        private void btnLunchOrderOverview_Click(object sender, EventArgs e)
        {
            //Hide other panels
            pnlOrderOverview.Hide();
            pnlCreateOrderDinner.Hide();
            pnlCreateOrderDrinks.Hide();

            //Show this panel
            pnlCreateOrderLunch.Show();
        }

        //Dinner order overview
        private void btnDinnerOrderOverview_Click(object sender, EventArgs e)
        {
            //Hide other panels
            pnlOrderOverview.Hide();
            pnlCreateOrderLunch.Hide();
            pnlCreateOrderDrinks.Hide();

            //Show this panel
            pnlCreateOrderDinner.Show();
        }

        //Drinks order overview
        private void btnDrinksOrderOverview_Click(object sender, EventArgs e)
        {
            //Hide other panels
            pnlOrderOverview.Hide();
            pnlCreateOrderLunch.Hide();
            pnlCreateOrderDinner.Hide();

            //Show this panel
            pnlCreateOrderDrinks.Show();
        }

        //Dinner button from lunch overview
        private void btnDinner_Click(object sender, EventArgs e)
        {
            //Hide other panels
            pnlOrderOverview.Hide();
            pnlCreateOrderLunch.Hide();
            pnlCreateOrderDrinks.Hide();

            //Show this panel
            pnlCreateOrderDinner.Show();
        }

        //Drinks button from lunch overview
        private void btnDrinksFromLunchOverview_Click(object sender, EventArgs e)
        {
            //Hide other panels
            pnlOrderOverview.Hide();
            pnlCreateOrderLunch.Hide();
            pnlCreateOrderDinner.Hide();

            //Show this panel
            pnlCreateOrderDrinks.Show();
        }

        //Lunch button from dinner overview
        private void btnLunchFromDinnerOverview_Click(object sender, EventArgs e)
        {
            //Hide other panels
            pnlOrderOverview.Hide();
            pnlCreateOrderDrinks.Hide();
            pnlCreateOrderDinner.Hide();

            //Show this panel
            pnlCreateOrderLunch.Show();
        }

        //Drinks button from dinner overview
        private void btnDrinksFromDinnerOverview_Click(object sender, EventArgs e)
        {
            //Hide other panels
            pnlOrderOverview.Hide();
            pnlCreateOrderLunch.Hide();
            pnlCreateOrderDinner.Hide();

            //Show this panel
            pnlCreateOrderDrinks.Show();
        }

        //Lunch button from drinks overview
        private void btnLunchFromDrinksOverview_Click(object sender, EventArgs e)
        {
            //Hide other panels
            pnlOrderOverview.Hide();
            pnlCreateOrderDrinks.Hide();
            pnlCreateOrderDinner.Hide();

            //Show this panel
            pnlCreateOrderLunch.Show();
        }

        //Dinner button from lunch overview
        private void btnDinnerFromDrinksOverview_Click(object sender, EventArgs e)
        {
            //Hide other panels
            pnlOrderOverview.Hide();
            pnlCreateOrderDrinks.Hide();
            pnlCreateOrderLunch.Hide();

            //Show this panel
            pnlCreateOrderDinner.Show();
        }

        //Add and show order
        private void btnAddLunch_Click(object sender, EventArgs e)
        {
            AddOrder(listViewOrderLunch);
            ShowOrder();
            pnlCreateOrderLunch.Hide();
            pnlOrderOverview.Show();
            CreateOrderForm_Load(sender, e);
        }
        private void btnAddDinner_Click(object sender, EventArgs e)
        {
            AddOrder(listViewOrderDinner);
            ShowOrder();
            pnlCreateOrderDinner.Hide();
            pnlOrderOverview.Show();
            CreateOrderForm_Load(sender, e);
        }

        private void btnAddDrinks_Click(object sender, EventArgs e)
        {
            AddOrder(listViewOrderDrinks);
            ShowOrder();
            pnlCreateOrderDrinks.Hide();
            pnlOrderOverview.Show();
            CreateOrderForm_Load(sender, e);
        }

        //Remove buttons
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

        //Go to overview buttons
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

        //Pay button
        private void btnPay_Click(object sender, EventArgs e)
        {
            BillViewForm paymentForm = new BillViewForm(table, employee);
            paymentForm.Show();
        }

        //Button back to table overview
        private void lblImageChapeau2_Click(object sender, EventArgs e)
        {
            TableForm tableForm = new TableForm(employee);
            tableForm.Show();
        }

        //METHODS
        //Method to fill listview with menuItems
        private void FillListviewMenuItems(System.Windows.Forms.ListView listView, ItemType itemType, int menuId)
        {
            MenuItemService menuItemService = new MenuItemService();
            menu.MenuItems = menuItemService.GetByItemType(itemType,/*menu.*/menuId);

            listView.Clear();
            listView.View = View.Details;

            listView.Columns.Add("Id", 25);
            listView.Columns.Add("Name", 349);
            listView.Columns.Add("Price", 45);

            foreach (MenuItem m in menu.MenuItems)
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
            MenuItemService menuItemService = new MenuItemService();

            listView.Clear();
            listView.View = View.Details;

            listView.Columns.Add("Id", 25);
            listView.Columns.Add("Name", 350);
            listView.Columns.Add("Amount", 65);

            foreach (OrderItem o in orderItems)
            {
                MenuItem menuItem = menuItemService.GetById(o.menuItem.menuItemId);

                ListViewItem item = new ListViewItem(o.menuItem.menuItemId.ToString());

                item.SubItems.Add(menuItem.itemName);
                item.SubItems.Add(o.amount.ToString());
                listView.Items.Add(item);
            }
        }

        //Method to add items to orderview
        private void AddItemsToOrderListview(System.Windows.Forms.ListView listView, List<OrderItem> orderItems)
        {
            ListViewEditor listviewEditor = new ListViewEditor();
            string value;
            OrderItem orderItem = new OrderItem();

            foreach (ListViewItem selectedItem in listView.SelectedItems)
            {
                value = selectedItem.SubItems[0].Text;
                orderItem = listviewEditor.LoadListview(value, orderItems);
            }

            if (orderItem.amount == 1)
            {
                orderItems.Add(orderItem);
            }
        }

        //Method to remove items from orderview
        private void RemoveItemsFromListview(System.Windows.Forms.ListView listView, List<OrderItem> orderItems)
        {
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

        //Add order
        private void AddOrder(System.Windows.Forms.ListView listView)
        {
            OrderService orderService = new OrderService();
            OrderItemService orderItemService = new OrderItemService();
            int orderId = orderService.AddOrder(tableId, employee.employeeId, bill.billId, DateTime.Now, OrderStatus.Preparation);

            listViewOrderOverview.Clear();
            listViewOrderOverview.View = View.Details;

            listViewOrderOverview.Columns.Add("Amount", 25);
            listViewOrderOverview.Columns.Add("Name", 370);
            listViewOrderOverview.Columns.Add("Price", 45);

            foreach (OrderItem o in order.GetOrderItems())
            {
                MenuItem menuItem = menuItemService.GetById(o.menuItem.menuItemId);

                totalPrice += menuItem.price;
                o.order.id = orderId;
                orderItemService.AddOrderItems(orderId, o.menuItem.menuItemId, o.amount, o.comment, o.status);
            }
            listView.Clear();
        }
        //Show order
        public void ShowOrder()
        {
            listViewOrderOverview.Clear();
            listViewOrderOverview.View = View.Details;

            listViewOrderOverview.Columns.Add("Id", 25);
            listViewOrderOverview.Columns.Add("Name", 350);
            listViewOrderOverview.Columns.Add("Amount", 65);

            foreach (OrderItem o in order.GetOrderItems())
            {
                MenuItem menuItem = menuItemService.GetById(o.menuItem.menuItemId);

                ListViewItem item = new ListViewItem(o.menuItem.menuItemId.ToString());

                item.SubItems.Add(menuItem.itemName);
                item.SubItems.Add(o.amount.ToString());
                listViewOrderOverview.Items.Add(item);
            }

            List<OrderItem> orderItems = orderItemService.GetByTableId(tableId, bill.billId);
            foreach (OrderItem o in orderItems)
            {
                //if (bill.billId == billId)
                //{
                    MenuItem menuItem = menuItemService.GetById(o.menuItem.menuItemId);

                    ListViewItem item = new ListViewItem(o.menuItem.menuItemId.ToString());

                    item.SubItems.Add(menuItem.itemName);
                    item.SubItems.Add(o.amount.ToString());
                    listViewOrderOverview.Items.Add(item);
                //}
            }

            lblTotal.Text = "Total: " + totalPrice.ToString();
            btnPay.Enabled = true;
        }

        //Hide panels
        private void HidePanels()
        {
            pnlCreateOrderDinner.Hide();
            pnlCreateOrderDrinks.Hide();
            pnlCreateOrderLunch.Hide();
        }

        //Disable button
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