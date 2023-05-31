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
                ListViewItem li = new ListViewItem(order.orderId.ToString()); //First item in the row
                li.SubItems.Add(order.tableId.ToString()); //Second item in the row
                listView1.Items.Add(li);    
            }
        }
    }
}