using ChapeauModel;
using ChapeauService;
using System.Windows.Forms;
using System.Xml;

namespace ChapeauUI
{
    public partial class CreateOrderForm : Form
    {
        List<OrderItem> orderItems = new List<OrderItem>();

        public CreateOrderForm(/*int table, Employee employee*/)
        {
            InitializeComponent();

            //Hide other panels
            pnlCreateOrderDinner.Hide();
            pnlCreateOrderDrinks.Hide();
            pnlCreateOrderLunch.Hide();
            pnlComment.Hide();

            //Disable All Necessary Buttons
            btnLunchUnavailable.Enabled = false;
            btnDinnerUnavailable.Enabled = false;
            btnDrinksUnavailable.Enabled = false;

            //Change Necessary Button Colors
            btnLunchUnavailable.BackColor = Color.FromArgb(189, 242, 217);
            btnDinnerUnavailable.BackColor = Color.FromArgb(189, 242, 217);
            btnDrinksUnavailable.BackColor = Color.FromArgb(189, 242, 217);

            //Show this panel
            pnlOrderOverview.Show();
        }
        private void CreateOrderForm_Load(object sender, EventArgs e)
        {
            try
            {
                //LUNCH
                //STARTERS LISTVIEW
                MenuItemService menuItemService = new MenuItemService();
                ItemType startersLunch = ItemType.Starters;
                List<MenuItem> menuItemsStartersLunch = menuItemService.GetByItemType(startersLunch, 1);

                listViewStartersLunch.Clear();
                listViewStartersLunch.View = View.Details;

                listViewStartersLunch.Columns.Add("Id", 25);
                listViewStartersLunch.Columns.Add("Name", 370);
                listViewStartersLunch.Columns.Add("Price", 45);

                foreach (MenuItem m in menuItemsStartersLunch)
                {
                    ListViewItem item = new ListViewItem(m.menuItemId.ToString());

                    item.SubItems.Add(m.itemName);
                    item.SubItems.Add(m.price.ToString());
                    listViewStartersLunch.Items.Add(item);
                }

                //MAINS LISTVIEW
                ItemType mainsLunch = ItemType.Mains;
                List<MenuItem> menuItemsMainsLunch = menuItemService.GetByItemType(mainsLunch, 1);

                listViewMainsLunch.Clear();
                listViewMainsLunch.View = View.Details;

                listViewMainsLunch.Columns.Add("Id", 25);
                listViewMainsLunch.Columns.Add("Name", 370);
                listViewMainsLunch.Columns.Add("Price", 45);

                foreach (MenuItem m in menuItemsMainsLunch)
                {
                    ListViewItem item = new ListViewItem(m.menuItemId.ToString());

                    item.SubItems.Add(m.itemName);
                    item.SubItems.Add(m.price.ToString());
                    listViewMainsLunch.Items.Add(item);
                }

                //DESERTS LISTVIEW
                ItemType desertsLunch = ItemType.Deserts;
                List<MenuItem> menuItemsDesertsLunch = menuItemService.GetByItemType(desertsLunch, 1);

                listViewDesertsLunch.Clear();
                listViewDesertsLunch.View = View.Details;

                listViewDesertsLunch.Columns.Add("Id", 25);
                listViewDesertsLunch.Columns.Add("Name", 370);
                listViewDesertsLunch.Columns.Add("Price", 45);

                foreach (MenuItem m in menuItemsDesertsLunch)
                {
                    ListViewItem item = new ListViewItem(m.menuItemId.ToString());

                    item.SubItems.Add(m.itemName);
                    item.SubItems.Add(m.price.ToString());
                    listViewDesertsLunch.Items.Add(item);
                }

                //DINNER
                //STARTERS LISTVIEW
                ItemType startersDinner = ItemType.Starters;
                List<MenuItem> menuItemsStartersDinner = menuItemService.GetByItemType(startersDinner, 2);

                listViewStartersDinner.Clear();
                listViewStartersDinner.View = View.Details;

                listViewStartersDinner.Columns.Add("Id", 25);
                listViewStartersDinner.Columns.Add("Name", 370);
                listViewStartersDinner.Columns.Add("Price", 45);

                foreach (MenuItem m in menuItemsStartersDinner)
                {
                    ListViewItem item = new ListViewItem(m.menuItemId.ToString());

                    item.SubItems.Add(m.itemName);
                    item.SubItems.Add(m.price.ToString());
                    listViewStartersDinner.Items.Add(item);
                }

                //ENTREES LISTVIEW
                ItemType entres = ItemType.Entres;
                List<MenuItem> menuItemsEntres = menuItemService.GetByItemType(entres, 2);

                listViewEntresDinner.Clear();
                listViewEntresDinner.View = View.Details;

                listViewEntresDinner.Columns.Add("Id", 25);
                listViewEntresDinner.Columns.Add("Name", 370);
                listViewEntresDinner.Columns.Add("Price", 45);

                foreach (MenuItem m in menuItemsEntres)
                {
                    ListViewItem item = new ListViewItem(m.menuItemId.ToString());

                    item.SubItems.Add(m.itemName);
                    item.SubItems.Add(m.price.ToString());
                    listViewEntresDinner.Items.Add(item);
                }

                //MAINS LISTVIEW
                ItemType mainsDinner = ItemType.Mains;
                List<MenuItem> menuItemsMainsDinner = menuItemService.GetByItemType(mainsDinner, 2);

                listViewMainsDinner.Clear();
                listViewMainsDinner.View = View.Details;

                listViewMainsDinner.Columns.Add("Id", 25);
                listViewMainsDinner.Columns.Add("Name", 370);
                listViewMainsDinner.Columns.Add("Price", 45);

                foreach (MenuItem m in menuItemsMainsDinner)
                {
                    ListViewItem item = new ListViewItem(m.menuItemId.ToString());

                    item.SubItems.Add(m.itemName);
                    item.SubItems.Add(m.price.ToString());
                    listViewMainsDinner.Items.Add(item);
                }

                //DESERTS LISTVIEW
                ItemType desertsDinner = ItemType.Deserts;
                List<MenuItem> menuItemsDesertsDinner = menuItemService.GetByItemType(desertsDinner, 2);

                listViewDesertsDinner.Clear();
                listViewDesertsDinner.View = View.Details;

                listViewDesertsDinner.Columns.Add("Id", 25);
                listViewDesertsDinner.Columns.Add("Name", 370);
                listViewDesertsDinner.Columns.Add("Price", 45);

                foreach (MenuItem m in menuItemsDesertsDinner)
                {
                    ListViewItem item = new ListViewItem(m.menuItemId.ToString());

                    item.SubItems.Add(m.itemName);
                    item.SubItems.Add(m.price.ToString());
                    listViewDesertsDinner.Items.Add(item);
                }

                //DRINKS
                //SOFT DRINKS LISTVIEW
                ItemType softDrinks = ItemType.SoftDrinks;
                List<MenuItem> menuItemsSoftDrinks = menuItemService.GetByItemType(softDrinks, 3);

                listViewSoftDrinks.Clear();
                listViewSoftDrinks.View = View.Details;

                listViewSoftDrinks.Columns.Add("Id", 25);
                listViewSoftDrinks.Columns.Add("Name", 349);
                listViewSoftDrinks.Columns.Add("Price", 45);

                foreach (MenuItem m in menuItemsSoftDrinks)
                {
                    ListViewItem item = new ListViewItem(m.menuItemId.ToString());

                    item.SubItems.Add(m.itemName);
                    item.SubItems.Add(m.price.ToString());
                    listViewSoftDrinks.Items.Add(item);
                }

                //BEERS LISTVIEW
                ItemType beers = ItemType.Beers;
                List<MenuItem> menuItemsBeers = menuItemService.GetByItemType(beers, 3);

                listViewBeers.Clear();
                listViewBeers.View = View.Details;

                listViewBeers.Columns.Add("Id", 25);
                listViewBeers.Columns.Add("Name", 349);
                listViewBeers.Columns.Add("Price", 45);

                foreach (MenuItem m in menuItemsBeers)
                {
                    ListViewItem item = new ListViewItem(m.menuItemId.ToString());

                    item.SubItems.Add(m.itemName);
                    item.SubItems.Add(m.price.ToString());
                    listViewBeers.Items.Add(item);
                }

                //WINES LISTVIEW
                ItemType wines = ItemType.Wines;
                List<MenuItem> menuItemsWines = menuItemService.GetByItemType(wines, 3);

                listViewWines.Clear();
                listViewWines.View = View.Details;

                listViewWines.Columns.Add("Id", 25);
                listViewWines.Columns.Add("Name", 349);
                listViewWines.Columns.Add("Price", 45);

                foreach (MenuItem m in menuItemsWines)
                {
                    ListViewItem item = new ListViewItem(m.menuItemId.ToString());

                    item.SubItems.Add(m.itemName);
                    item.SubItems.Add(m.price.ToString());
                    listViewWines.Items.Add(item);
                }

                //SPIRITS LISTVIEW
                ItemType spirits = ItemType.Spirits;
                List<MenuItem> menuItemsSpirits = menuItemService.GetByItemType(spirits, 3);

                listViewSpirits.Clear();
                listViewSpirits.View = View.Details;

                listViewSpirits.Columns.Add("Id", 25);
                listViewSpirits.Columns.Add("Name", 349);
                listViewSpirits.Columns.Add("Price", 45);

                foreach (MenuItem m in menuItemsSpirits)
                {
                    ListViewItem item = new ListViewItem(m.menuItemId.ToString());

                    item.SubItems.Add(m.itemName);
                    item.SubItems.Add(m.price.ToString());
                    listViewSpirits.Items.Add(item);
                }

                //HOT DRINKS LISTVIEW
                ItemType hotDrinks = ItemType.HotDrinks;
                List<MenuItem> menuItemsHotDrinks = menuItemService.GetByItemType(hotDrinks, 3);

                listViewHotDrinks.Clear();
                listViewHotDrinks.View = View.Details;

                listViewHotDrinks.Columns.Add("Id", 25);
                listViewHotDrinks.Columns.Add("Name", 349);
                listViewHotDrinks.Columns.Add("Price", 45);


                foreach (MenuItem m in menuItemsHotDrinks)
                {
                    ListViewItem item = new ListViewItem(m.menuItemId.ToString());

                    item.SubItems.Add(m.itemName);
                    item.SubItems.Add(m.price.ToString());
                    listViewHotDrinks.Items.Add(item);
                }

                //ORDER OVERVIEW LUNCH
                listViewOrderLunch.Clear();
                listViewOrderLunch.View = View.Details;

                listViewOrderLunch.Columns.Add("Id", 25);
                listViewOrderLunch.Columns.Add("Name", 250);
                listViewOrderLunch.Columns.Add("Amount", 65);


                foreach (OrderItem o in orderItems)
                {
                    MenuItem menuItem = menuItemService.GetById(o.menuItemId);

                    ListViewItem item = new ListViewItem(o.menuItemId.ToString());

                    item.SubItems.Add(menuItem.itemName);
                    item.SubItems.Add(o.amount.ToString());
                    listViewOrderLunch.Items.Add(item);
                }

                //ORDER OVERVIEW DINNER
                listViewOrderDinner.Clear();
                listViewOrderDinner.View = View.Details;

                listViewOrderDinner.Columns.Add("Id", 25);
                listViewOrderDinner.Columns.Add("Name", 250);
                listViewOrderDinner.Columns.Add("Amount", 65);


                foreach (OrderItem o in orderItems)
                {
                    MenuItem menuItem = menuItemService.GetById(o.menuItemId);

                    ListViewItem item = new ListViewItem(o.menuItemId.ToString());

                    item.SubItems.Add(menuItem.itemName);
                    item.SubItems.Add(o.amount.ToString());
                    listViewOrderDinner.Items.Add(item);
                }

                //ORDER OVERVIEW DRINKS
                listViewOrderDrinks.Clear();
                listViewOrderDrinks.View = View.Details;

                listViewOrderDrinks.Columns.Add("Id", 25);
                listViewOrderDrinks.Columns.Add("Name", 250);
                listViewOrderDrinks.Columns.Add("Amount", 65);


                foreach (OrderItem o in orderItems)
                {
                    MenuItem menuItem = menuItemService.GetById(o.menuItemId);

                    ListViewItem item = new ListViewItem(o.menuItemId.ToString());

                    item.SubItems.Add(menuItem.itemName);
                    item.SubItems.Add(o.amount.ToString());
                    listViewOrderDrinks.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong {ex.Message}");
            }
        }

        //LUNCH ORDER OVERVIEW
        private void btnLunchOrderOverview_Click(object sender, EventArgs e)
        {
            //Hide other panels
            pnlOrderOverview.Hide();
            pnlCreateOrderDinner.Hide();
            pnlCreateOrderDrinks.Hide();
            pnlComment.Hide();

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
            pnlComment.Hide();

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
            pnlComment.Hide();

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
            pnlComment.Hide();

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
            pnlComment.Hide();

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
            pnlComment.Hide();

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
            pnlComment.Hide();

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
            pnlComment.Hide();

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
            pnlComment.Hide();

            //Show this panel
            pnlCreateOrderDinner.Show();
        }

        //MAKE LUNCH ORDER
        private void listViewStartersLunch_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewEditor listview = new ListViewEditor();
            string value = "";

            foreach (ListViewItem selectedItem in listViewStartersLunch.SelectedItems)
            {
                value = selectedItem.SubItems[0].Text;
            }

            OrderItem orderItem = listview.LoadListview(value, orderItems);

            if (orderItem.amount == 1)
            {
                orderItems.Add(orderItem);
            }

            CreateOrderForm_Load(sender, e);
        }

        private void listViewMainsLunch_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewEditor listview = new ListViewEditor();
            string value = "";

            foreach (ListViewItem selectedItem in listViewMainsLunch.SelectedItems)
            {
                value = selectedItem.SubItems[0].Text;
            }

            OrderItem orderItem = listview.LoadListview(value, orderItems);

            if (orderItem.amount == 1)
            {
                orderItems.Add(orderItem);
            }

            CreateOrderForm_Load(sender, e);
        }

        private void listViewDesertsLunch_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewEditor listview = new ListViewEditor();
            string value = "";

            foreach (ListViewItem selectedItem in listViewDesertsLunch.SelectedItems)
            {
                value = selectedItem.SubItems[0].Text;
            }

            OrderItem orderItem = listview.LoadListview(value, orderItems);

            if (orderItem.amount == 1)
            {
                orderItems.Add(orderItem);
            }

            CreateOrderForm_Load(sender, e);
        }

        //MAKE DINNER ORDER
        private void listViewStartersDinner_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewEditor listview = new ListViewEditor();
            string value = "";

            foreach (ListViewItem selectedItem in listViewStartersDinner.SelectedItems)
            {
                value = selectedItem.SubItems[0].Text;
            }

            OrderItem orderItem = listview.LoadListview(value, orderItems);

            if (orderItem.amount == 1)
            {
                orderItems.Add(orderItem);
            }

            CreateOrderForm_Load(sender, e);
        }

        private void listViewEntresDinner_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewEditor listview = new ListViewEditor();
            string value = "";

            foreach (ListViewItem selectedItem in listViewEntresDinner.SelectedItems)
            {
                value = selectedItem.SubItems[0].Text;
            }

            OrderItem orderItem = listview.LoadListview(value, orderItems);

            if (orderItem.amount == 1)
            {
                orderItems.Add(orderItem);
            }

            CreateOrderForm_Load(sender, e);
        }

        private void listViewMainsDinner_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewEditor listview = new ListViewEditor();
            string value = "";

            foreach (ListViewItem selectedItem in listViewMainsDinner.SelectedItems)
            {
                value = selectedItem.SubItems[0].Text;
            }

            OrderItem orderItem = listview.LoadListview(value, orderItems);

            if (orderItem.amount == 1)
            {
                orderItems.Add(orderItem);
            }

            CreateOrderForm_Load(sender, e);
        }

        private void listViewDesertsDinner_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewEditor listview = new ListViewEditor();
            string value = "";

            foreach (ListViewItem selectedItem in listViewDesertsDinner.SelectedItems)
            {
                value = selectedItem.SubItems[0].Text;
            }

            OrderItem orderItem = listview.LoadListview(value, orderItems);

            if (orderItem.amount == 1)
            {
                orderItems.Add(orderItem);
            }

            CreateOrderForm_Load(sender, e);
        }

        //MAKE DRINKS ORDER
        private void listViewSoftDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewEditor listview = new ListViewEditor();
            string value = "";

            foreach (ListViewItem selectedItem in listViewSoftDrinks.SelectedItems)
            {
                value = selectedItem.SubItems[0].Text;
            }

            OrderItem orderItem = listview.LoadListview(value, orderItems);

            if (orderItem.amount == 1)
            {
                orderItems.Add(orderItem);
            }

            CreateOrderForm_Load(sender, e);
        }

        private void listViewBeers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewEditor listview = new ListViewEditor();
            string value = "";

            foreach (ListViewItem selectedItem in listViewBeers.SelectedItems)
            {
                value = selectedItem.SubItems[0].Text;
            }

            OrderItem orderItem = listview.LoadListview(value, orderItems);

            if (orderItem.amount == 1)
            {
                orderItems.Add(orderItem);
            }

            CreateOrderForm_Load(sender, e);
        }

        private void listViewWines_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewEditor listview = new ListViewEditor();
            string value = "";

            foreach (ListViewItem selectedItem in listViewWines.SelectedItems)
            {
                value = selectedItem.SubItems[0].Text;
            }

            OrderItem orderItem = listview.LoadListview(value, orderItems);

            if (orderItem.amount == 1)
            {
                orderItems.Add(orderItem);
            }

            CreateOrderForm_Load(sender, e);
        }

        private void listViewSpirits_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewEditor listview = new ListViewEditor();
            string value = "";

            foreach (ListViewItem selectedItem in listViewSpirits.SelectedItems)
            {
                value = selectedItem.SubItems[0].Text;
            }

            OrderItem orderItem = listview.LoadListview(value, orderItems);

            if (orderItem.amount == 1)
            {
                orderItems.Add(orderItem);
            }

            CreateOrderForm_Load(sender, e);
        }

        private void listViewHotDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewEditor listview = new ListViewEditor();
            string value = "";

            foreach (ListViewItem selectedItem in listViewHotDrinks.SelectedItems)
            {
                value = selectedItem.SubItems[0].Text;
            }

            OrderItem orderItem = listview.LoadListview(value, orderItems);

            if (orderItem.amount == 1)
            {
                orderItems.Add(orderItem);
            }

            CreateOrderForm_Load(sender, e);
        }

        private void btnAddLunch_Click(object sender, EventArgs e)
        {
            //Bestelling weergeven
            OrderService orderService = new OrderService();
            //orderService.AddOrder(orderItems);

            listViewOrderOverview.Clear();
            listViewOrderOverview.View = View.Details;

            listViewOrderOverview.Columns.Add("Amount");
            listViewOrderOverview.Columns.Add("Name");
            listViewOrderOverview.Columns.Add("Price");

            foreach (OrderItem o in orderItems)
            {
                MenuItemService menuItemService = new MenuItemService();
                MenuItem menuItem = menuItemService.GetById(o.menuItemId);

                ListViewItem item = new ListViewItem(o.amount.ToString());

                item.SubItems.Add(menuItem.itemName);
                item.SubItems.Add(menuItem.price.ToString());
                listViewOrderOverview.Items.Add(item);
            }

            pnlOrderOverview.Show();
        }

        //COMMENT
        private void listViewOrderLunch_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrderItem orderItem = new OrderItem();
            orderItem.comment = txtBoxComment.Text;

            CreateOrderForm_Load(sender, e);
        }
        private void btnCommentLunch_Click(object sender, EventArgs e)
        {
            //Show this panel
            pnlComment.Show();

            //Hide other panels
            pnlOrderOverview.Hide();
            pnlCreateOrderLunch.Hide();
            pnlCreateOrderDinner.Hide();
            pnlCreateOrderDrinks.Hide();
        }
        private void btnAddComment_Click(object sender, EventArgs e)
        {
            listViewOrderLunch_SelectedIndexChanged(sender, e);
        }

        //REMOVE
        private void btnRemoveLunch_Click(object sender, EventArgs e)
        {
            ListViewEditor listview = new ListViewEditor();
            string value = "";

            foreach (ListViewItem selectedItem in listViewHotDrinks.SelectedItems)
            {
                value = selectedItem.SubItems[0].Text;
            }

            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //orderItems.Remove();
            CreateOrderForm_Load(sender, e);
        }

        //BACK
        private void btnBack_Click(object sender, EventArgs e)
        {
            //Show this panel
            pnlCreateOrderLunch.Show();

            //Hide other panels
            pnlOrderOverview.Hide();
            pnlCreateOrderDinner.Hide();
            pnlCreateOrderDrinks.Hide();
            pnlComment.Hide();
        }
    }
}