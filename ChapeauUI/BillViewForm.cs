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
    public partial class BillViewForm : Form
    {
        private int changePricetest = 0;
        public BillViewForm()
        {
            InitializeComponent();
            pnlAddComment.Hide();
            pnlBillPayment.Hide();
            pnlBillSettled.Hide();
            pnlBillView.Show();

            OrderItemService orderItemService = new OrderItemService();
            List<OrderItem> orderItems = orderItemService.GetAll();

            listViewBillOverview.Clear();

            // Specify that each item appears on a separate line.
            listViewBillOverview.View = View.Details;

            // Declare and construct the ColumnHeader objects.
            ColumnHeader amount, name, price;
            amount = new ColumnHeader();
            name = new ColumnHeader();
            price = new ColumnHeader();

            amount.Text = "Amount";
            amount.Width = 80;

            name.Text = "Name";
            name.Width = 200;

            price.Text = "Price";
            price.Width = 60;

            listViewBillOverview.Columns.Add(amount);
            listViewBillOverview.Columns.Add(name);
            listViewBillOverview.Columns.Add(price);

            //labelOrderPrice
            double orderTotalPrice = 0;
            double totalPriceAmount = 0;
            double vatAmount = 0;
            double totalVat = 0;


            foreach (OrderItem order in orderItems)
            {
                ListViewItem item = new ListViewItem(order.amount.ToString());

                MenuItemService menuItemService = new MenuItemService();
                MenuItem menuItem = menuItemService.GetById(order.menuItemId);

                //Berekeningen
                vatAmount = menuItem.tax / 100; //0.21
                totalPriceAmount = ((menuItem.price * order.amount) * (1 + vatAmount)); //7.5(price) * amount * vat(1 + 0.21)
                totalVat += ((menuItem.price * order.amount) * vatAmount); // 15(price * amount) * 0.21
                orderTotalPrice += totalPriceAmount; //optellen totalPrice voor labelOrderPrice

                item.SubItems.Add(menuItem.itemName.ToString());
                item.SubItems.Add(totalPriceAmount.ToString("F"));
                listViewBillOverview.Items.Add(item);
            }

            labelOrderPrice.Text = orderTotalPrice.ToString("F");
            labelOrderPricePayment.Text = orderTotalPrice.ToString("F");
            labelVAT.Text = totalVat.ToString("F");
        }
        private bool buttonClicked = false;


        private void btnProceedToPayment_Click(object sender, EventArgs e)
        {
            //if none button has been clicked:
            if (!buttonClicked)
            {
                MessageBox.Show("No paymethod has been selected, please select one.");
            } else
            {
                //Hide all panels, except Payment
                pnlAddComment.Hide();
                pnlBillSettled.Hide();
                pnlBillView.Hide();
                pnlBillPayment.Show();
                pnlBillPayment.Location = new Point(12, 83);
            }
        }

        private void btnBackPayment_Click(object sender, EventArgs e)
        {
            //Hide all panels, except BillView
            pnlAddComment.Hide();
            pnlBillPayment.Hide();
            pnlBillSettled.Hide();
            pnlBillView.Show();
            pnlBillPayment.Location = new Point(12, 83);
        }

        private void btnSetPrices_Click(object sender, EventArgs e)
        {
            if(txtBoxAmountPaid.Text == "")
            {
                MessageBox.Show("Please enter a amount of pay.");
            } else
            {
                double input = double.Parse(txtBoxAmountPaid.Text);
                double totalOrderPrice = Convert.ToDouble(labelOrderPricePayment.Text);
                double changePrice = 0;

                if (input < totalOrderPrice)
                {
                    MessageBox.Show("Amount paid is lower than the order price. Please check again.");
                }
                else
                {
                    changePrice = input - totalOrderPrice;
                    labelChange.Text = changePrice.ToString("F");
                }
            }
        }

        private void btnAddChangeToTip_Click(object sender, EventArgs e)
        {

        }

        private void btnSetTip_Click(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            //Hide all panels, except Comment
            pnlBillPayment.Hide();
            pnlBillSettled.Hide();
            pnlBillView.Hide();
            pnlAddComment.Show();
            pnlAddComment.Location = new Point(12, 83);
        }

        private void btnBackComment_Click(object sender, EventArgs e)
        {
            //Hide all panels, except Payment
            pnlAddComment.Hide();
            pnlBillSettled.Hide();
            pnlBillView.Hide();
            pnlBillPayment.Show();
            pnlBillPayment.Location = new Point(12, 83);

        }

        private void btnDebit_Click(object sender, EventArgs e)
        {
            btnVisa.Select();
            btnVisa.BackColor = Color.White;
            btnCash.BackColor = Color.White;
            btnDebit.BackColor = Color.FromArgb(255, 179, 71);
            buttonClicked = true;
            //255; 179; 71
        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            btnDebit.BackColor = Color.White;
            btnCash.BackColor = Color.White;
            btnVisa.BackColor = Color.FromArgb(255, 179, 71);
            buttonClicked = true;

        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            btnDebit.BackColor = Color.White;
            btnVisa.BackColor = Color.White;
            btnCash.BackColor = Color.FromArgb(255, 179, 71);
            buttonClicked = true;

        }

        private void btnBackOrderOverview_Click(object sender, EventArgs e)
        {
            Hide();
            OrderOverview orderView = new OrderOverview();
            orderView.Show();

        }

        private void listViewOrderOverview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
