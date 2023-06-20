using ChapeauDAL;
using ChapeauModel;
using ChapeauService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChapeauUI
{
    public partial class BillViewForm : Form
    {
        private bool setChange = false;
        private bool setTip = false;
        private bool goFurther = false;
        private bool buttonClicked = false;
        private double changePrice = 0;
        private PaymentMethod paymentMethode;
        private double doubleOrderPrice = 0;
        private double totalTip = 0;
        private string comment = "";
        private double orderTotalPrice = 0;

        int tableId;
        Employee employee;
        public BillViewForm(int tableId, Employee employee)
        {
            InitializeComponent();
            this.tableId = tableId;
            this.employee = employee;
        }

        public BillViewForm()
        {
            InitializeComponent();
            pnlAddComment.Hide();
            pnlBillPayment.Hide();
            pnlBillSettled.Hide();
            pnlBillView.Show();

            BillViewForm paymentForm = new BillViewForm(tableId, employee);

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
            double totalVat = 0;

            double calVat = 0;
            double calPrice = 0;
            double calTotalVat = 0;

            Bill bill = new Bill();
            MenuItemService menuItemService = new MenuItemService();

            foreach (OrderItem order in orderItems)
            {
                ListViewItem item = new ListViewItem(order.amount.ToString());

                MenuItem menuItem = menuItemService.GetById(order.menuItemId);
                calVat = bill.CalculateVAT(menuItem.tax, menuItem.price);
                calPrice = bill.CalculateTotalPrice(calVat, order.amount, menuItem.price);
                calTotalVat = bill.CalculateTotalVAT(calPrice, menuItem.tax);

                orderTotalPrice += calPrice;
                totalVat += calTotalVat;

                item.SubItems.Add(menuItem.itemName.ToString());
                item.SubItems.Add("€" + calPrice.ToString("F"));
                listViewBillOverview.Items.Add(item);
            }

            labelOrderPrice.Text = "€" + orderTotalPrice.ToString("F");
            labelOrderPricePayment.Text = "€" + orderTotalPrice.ToString("F");
            labelFinalOrderPrice.Text = "€" + orderTotalPrice.ToString("F");

            doubleOrderPrice = orderTotalPrice;
            labelVAT.Text = "€" + totalVat.ToString("F");
            labelFinalVAT.Text = "€" + totalVat.ToString("F");
        }


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
                //double totalOrderPrice = Convert.ToDouble(labelOrderPricePayment.Text);
                //double totalOrderPrice = double.Parse(labelOrderPricePayment.Text);
                //double changePrice = 0;

                if (input < doubleOrderPrice)
                {
                    MessageBox.Show("Amount paid is lower than the order price. Please check again.");
                }
                else
                {
                    changePrice = input - doubleOrderPrice;
                    labelChange.Text = "€" + changePrice.ToString("F");
                    labelFinalAmountPaid.Text = "€" + input.ToString("F");
                    setChange = true;
                }
            }
        }

        private void btnAddChangeToTip_Click(object sender, EventArgs e)
        {
            labelFinalTipAmount.Text = "€0,00";
            if (!setChange)
            {
                MessageBox.Show("Please enter a amount of pay;");
            } else
            {
                totalTip = changePrice;
                labelTotalTip.Text = "€" + totalTip.ToString("F");

                //update Change
                changePrice = 0;
                labelChange.Text = "€" + changePrice.ToString("F");
                setTip = true;
            }
        }

        private void btnSetTip_Click(object sender, EventArgs e)
        {
            if (txtBoxCustomTip.Text == "")
            {
                MessageBox.Show("Please enter a amount of tip.");
            }
            else
            {
                double input = double.Parse(txtBoxCustomTip.Text);

                if (input > changePrice)
                {
                    MessageBox.Show("Amount tip is higher than the change. Please check again.");
                }
                else
                {
                    //update Change
                    changePrice -= input;
                    labelChange.Text = "€" + changePrice.ToString("F");


                    labelTotalTip.Text = "€" + input.ToString("F");
                    totalTip = changePrice;
                    labelFinalTipAmount.Text = "€" + input.ToString("F");
                    setTip = true;
                }
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (!setChange)
            {
                MessageBox.Show("There is not an amount paid. Please enter a amount.");
            }
            else if (!setTip)
            {
                MessageBox.Show("There is no tip. Please enter a tip.");
            }
            else
            {
                //Hide all panels, except Comment
                pnlBillPayment.Hide();
                pnlBillSettled.Hide();
                pnlBillView.Hide();
                pnlAddComment.Show();
                pnlAddComment.Location = new Point(12, 83);
                labelChangeFinal.Text = "€" + changePrice.ToString("F");
            }


            //tip en change required
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
            paymentMethode = PaymentMethod.Pin;
            //255; 179; 71
        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            btnDebit.BackColor = Color.White;
            btnCash.BackColor = Color.White;
            btnVisa.BackColor = Color.FromArgb(255, 179, 71);
            buttonClicked = true;
            paymentMethode = PaymentMethod.CreditCard;

        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            btnDebit.BackColor = Color.White;
            btnVisa.BackColor = Color.White;
            btnCash.BackColor = Color.FromArgb(255, 179, 71);
            buttonClicked = true;
            paymentMethode = PaymentMethod.Cash;

        }

        private void btnBackOrderOverview_Click(object sender, EventArgs e)
        {
            Hide();
            CreateOrderForm orderForm = new CreateOrderForm(tableId, employee);
            orderForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(labelCustomerComment.Text == "")
            {
                MessageBox.Show("No comment has been given, please enter comment.");
                labelCommendSaved.Hide();
            } else
            {
                labelCommendSaved.Show();
                labelCommendSaved.ForeColor = Color.FromArgb(138, 210, 176);
                labelCommendSaved.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                labelCommendSaved.Text = "COMMENT HAS BEEN SAVED";

                comment = labelCustomerComment.Text;
            }            
        }



        private void btnFinishPayment_Click(object sender, EventArgs e)
        {
            //database verander dbo.BILL van tip en payed.
            BillService billService = new BillService();

            //id, comment, paymentMethod, tip, payed.
            billService.UpdateBill(1, comment, (int)paymentMethode, totalTip, 1);

            
        }

        private void btnContinueWithPayment_Click(object sender, EventArgs e)
        {
                //Hide all panels, except Payment
                pnlAddComment.Hide();
                pnlBillView.Hide();
                pnlBillPayment.Hide();
                pnlBillSettled.Show();
                pnlBillSettled.Location = new Point(12, 83);

        }

        private void btnBackBillSettled_Click(object sender, EventArgs e)
        {
            pnlBillView.Hide();
            pnlBillPayment.Hide();
            pnlBillSettled.Hide();
            pnlAddComment.Show();
            pnlAddComment.Location = new Point(12, 83);
        }
    }
}
