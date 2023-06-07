using ChapeauModel;
using ChapeauService;

namespace ChapeauUI
{
    public partial class CreateOrderForm : Form
    {
        public CreateOrderForm()
        {
            InitializeComponent();
        }
        private List<Order> GetOrders()
        {
            OrderService orderService = new OrderService();
            return orderService.GetAll();
        }
    }
}