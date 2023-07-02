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
        Employee employee;
        Table table;
        Bill bill = new Bill();
        Order order = new Order();
        int tableId;

        public BillViewForm(Table table, Employee employee)
        {
            this.table = table;
            //this.table.tableId = table.tableId;
            //this.tableId = table.tableId;
            this.employee = employee;
            InitializeComponent();
            showPanel(pnlBillView, pnlBillSettled, pnlAddComment, pnlBillPayment, pnlSplitBill);
  
            OrderItemService orderItemService = new OrderItemService();
            List<OrderItem> orderItems = orderItemService.GetAll();
            //ShowBillListView(listViewBillOverview);
            listViewBillOverview.Clear();
            listViewBillOverview.View = View.Details; // Specify that each item appears on a separate line.

            listViewBillOverview.Columns.Add("Amount", 80);
            listViewBillOverview.Columns.Add("Name", 200);
            listViewBillOverview.Columns.Add("Price", 60);

            double totalVat = 0;
            double calVat = 0;
            double calPrice = 0;
            double calTotalVat = 0;


            MenuItemService menuItemService = new MenuItemService();

            foreach (OrderItem order in orderItems)
            {
                ListViewItem item = new ListViewItem(order.amount.ToString());

                MenuItem menuItem = menuItemService.GetById(order.menuItem.menuItemId);
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

        public void ShowBillListView(System.Windows.Forms.ListView listView)
        {
            OrderItem orderItem = new OrderItem();
            OrderService orderService = new OrderService();
            OrderItemService orderItemService = new OrderItemService();
            MenuItemService menuItemService = new MenuItemService();
            //int orderId = orderService.AddOrder(tableId, employee.employeeId, 1, DateTime.Now, OrderStatus.Preparation);

            listViewBillOverview.Clear();
            listViewBillOverview.View = View.Details;

            listViewBillOverview.Columns.Add("Amount", 80);
            listViewBillOverview.Columns.Add("Name", 200);
            listViewBillOverview.Columns.Add("Price", 60);

            //foreach (OrderItem o in order.GetOrderItems())
            //{
            //    MenuItem menuItem = menuItemService.GetById(o.menuItem.menuItemId);

            //    orderTotalPrice += menuItem.price;
            //    o.order.id = orderId;
            //    orderItemService.AddOrderItems(orderId, o.menuItem.menuItemId, o.amount, o.comment, o.status);
            //}
        }

        private void btnProceedToPayment_Click(object sender, EventArgs e)
        {
            if (!buttonClicked) //if none button has been clicked:
            {
                MessageBox.Show("No paymethod has been selected, please select one.");
            } else
            {
                showPanel(pnlBillPayment, pnlBillSettled, pnlAddComment, pnlBillView, pnlSplitBill);
            }
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            if (!buttonClicked) //if none button has been clicked:
            {
                MessageBox.Show("No paymethod has been selected, please select one.");
            }
            else
            {
                showPanel(pnlSplitBill, pnlBillSettled, pnlAddComment, pnlBillView, pnlBillPayment);
            }
        }

        private void btnBackPayment_Click(object sender, EventArgs e)
        {
            showPanel(pnlBillView, pnlBillSettled, pnlAddComment, pnlBillPayment, pnlSplitBill);
        }

        private void btnBackPaymentFromSplit_Click(object sender, EventArgs e)
        {
            showPanel(pnlBillView, pnlBillSettled, pnlAddComment, pnlBillPayment, pnlSplitBill);
        }

        private void button2_Click(object sender, EventArgs e) //btnProceedSplitting
        {
            string inputSplit = txtBoxAmountPeopleSplitting.Text;

        }

        private void btnSetPrices_Click(object sender, EventArgs e)
        {
            if(txtBoxAmountPaid.Text == "")
            {
                MessageBox.Show("Please enter a amount of pay.");
            } else
            {
                double input = double.Parse(txtBoxAmountPaid.Text);

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
                labelFinalTipAmount.Text = "€" + totalTip.ToString("F");
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
                showPanel(pnlAddComment, pnlBillSettled, pnlBillView, pnlBillPayment, pnlSplitBill);
                labelChangeFinal.Text = "€" + changePrice.ToString("F");
            }
        }

        private void btnBackComment_Click(object sender, EventArgs e)
        {
            showPanel(pnlBillPayment, pnlBillSettled, pnlBillView, pnlAddComment, pnlSplitBill);
        }

        private void btnDebit_Click(object sender, EventArgs e)
        {
            btnChangeBackColor(btnDebit, btnCash, btnVisa);
            buttonClicked = true;
            paymentMethode = PaymentMethod.Pin;
        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            btnChangeBackColor(btnVisa, btnCash, btnDebit);
            buttonClicked = true;
            paymentMethode = PaymentMethod.CreditCard;
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            btnChangeBackColor(btnCash, btnVisa, btnDebit);
            buttonClicked = true;
            paymentMethode = PaymentMethod.Cash;
        }

        private void btnBackOrderOverview_Click(object sender, EventArgs e)
        {
            Hide();
            CreateOrderForm orderForm = new CreateOrderForm(table, employee);
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
                labelCommendSavedChange();

                comment = labelCustomerComment.Text;
            }
        }

        private void btnFinishPayment_Click(object sender, EventArgs e)
        {
            //database verander dbo.BILL van tip en payed.
            BillService billService = new BillService();

            //id, comment, paymentMethod, tip, payed.
            billService.UpdateBill(1, comment, (int)paymentMethode, totalTip, 1);

            TableForm table = new TableForm(employee);
            this.Close();
            table.Show();
        }

        private void btnContinueWithPayment_Click(object sender, EventArgs e)
        {
            showPanel(pnlBillSettled, pnlBillPayment, pnlBillView, pnlAddComment, pnlSplitBill);

        }

        private void btnBackBillSettled_Click(object sender, EventArgs e)
        {
            showPanel(pnlAddComment, pnlBillSettled, pnlBillView, pnlBillPayment, pnlSplitBill);
        }

        //Methodes verkorten
        private void btnChangeBackColor(System.Windows.Forms.Button btn1, System.Windows.Forms.Button btn2, System.Windows.Forms.Button btn3) //Knoppen Cash, Debit, Visa Backcolor veranderen
        {
            btn1.BackColor = Color.FromArgb(255, 179, 71);
            btn2.BackColor = Color.White;
            btn3.BackColor = Color.White;
        }
        private void labelCommendSavedChange()
        {
            labelCommendSaved.ForeColor = Color.FromArgb(138, 210, 176);
            labelCommendSaved.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelCommendSaved.Text = "COMMENT HAS BEEN SAVED";
        }

        private void showPanel(System.Windows.Forms.Panel panel1, System.Windows.Forms.Panel panel2, System.Windows.Forms.Panel panel3, System.Windows.Forms.Panel panel4, System.Windows.Forms.Panel panel5)
        {
            panel1.Show();
            panel1.Location = new Point(12, 83);

            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
        }
    }
}
