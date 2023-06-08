using ChapeauModel;
using ChapeauService;

namespace ChapeauUI
{
    public partial class CreateOrderForm : Form
    {
        public CreateOrderForm()
        {
            InitializeComponent();
            DisplayOrders(GetOrders());
        }
        private List<Order> GetOrders()
        {
            OrderService orderService = new OrderService();
            return orderService.GetAll();
        }
        private void DisplayOrders(List<Order> orders)
        {
            foreach (Order order in orders)
            {
                ListViewItem li = new ListViewItem(order.tableId.ToString()); //First item in the row
                li.SubItems.Add(order.tableId.ToString()); //Second item in the row
                orderListView.Items.Add(li);
            }
        }

        private void dinnerButton_Click(object sender, EventArgs e)
        {

        }

        private void ShowDinnerMenu()
        {

        }

        //private List<MenuItem> GetDinnerMenu()
        //{
        //    MenuService menuItemService = new MenuService();
        //    //List<MenuItem> menu = menuItemService.GetAllDinner();
        //    //return menu;
        //}
    }
}