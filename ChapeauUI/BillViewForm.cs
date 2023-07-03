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
        private bool btnClickedPayMethod = false;
        private bool setChange = false;
        private bool setTip = false;
        private double changePrice = 0;
        private PaymentMethod paymentMethode;
        private double totalTip = 0;
        private string comment = "";
        private double orderTotalPrice = 0;
        private double totalVat = 0;
        Employee employee;
        Table table;
        Bill bill = new Bill();
        Order order = new Order();

        public BillViewForm(Table table, Employee employee)
        {
            this.table = table;
            this.employee = employee;

            InitializeComponent();
            showPanel(pnlBillView, pnlBillSettled, pnlAddComment, pnlBillPayment, pnlSplitBill);
  
            OrderItemService orderItemService = new OrderItemService();
            //List<OrderItem> orderItemsTest = orderItemService.GetAllByBillId(bill.billId);

            ShowBillListView(listViewBillOverview, orderItemService);
            //listViewBillOverview.Items.AddRange(DisplayTest(orderItemService, listViewBillOverview, bill).ToArray()); 

        }

        private void ShowBillListView(System.Windows.Forms.ListView listView, OrderItemService orderItemService)
        {
            List<OrderItem> orderItemsTest = orderItemService.GetAllByBillId(1);

            listView.Clear();
            listView.View = View.Details; // Specify that each item appears on a separate line.

            listView.Columns.Add("Amount", 80);
            listView.Columns.Add("Name", 200);
            listView.Columns.Add("Price", 60);

            double calVat = 0;
            double calPrice = 0;
            double calTotalVat = 0;

            foreach (OrderItem order in orderItemsTest)
            {
                ListViewItem item = new ListViewItem(order.amount.ToString());
                calVat = bill.CalculateVAT(order.menuItem.tax, order.menuItem.price);
                calPrice = bill.CalculateTotalPrice(calVat, order.amount, order.menuItem.price);
                calTotalVat = bill.CalculateTotalVAT(calPrice, order.menuItem.tax);

                orderTotalPrice += calPrice;
                totalVat += calTotalVat;

                item.SubItems.Add(order.menuItem.itemName.ToString());
                item.SubItems.Add("€" + calPrice.ToString("F"));
                //item.SubItems.Add(bill.CalculateTotalPrice(bill.CalculateVAT(order.menuItem.tax, order.menuItem.price), order.amount, order.menuItem.price).ToString());
                listView.Items.Add(item);
            }

            SetlabelsOrderPrice(labelOrderPrice, labelOrderPricePayment, labelFinalOrderPrice);
            SetlabelsTotalVAT(labelVAT, labelFinalVAT);
        }

        private void btnProceedToPayment_Click(object sender, EventArgs e)
        {
            if (!btnClickedPayMethod) //if none button has been clicked:
            {
                MessageBox.Show("No paymethod has been selected, please select one.");
            } else
            {
                showPanel(pnlBillPayment, pnlBillSettled, pnlAddComment, pnlBillView, pnlSplitBill);
            }
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            if (!btnClickedPayMethod) //if none button has been clicked:
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

                if (input < orderTotalPrice)
                {
                    MessageBox.Show("Amount paid is lower than the order price. Please check again.");
                }
                else
                {
                    changePrice = input - orderTotalPrice;
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
        private void SetlabelsOrderPrice(Label label1, Label label2, Label label3)
        {
            label1.Text = bill.StringOverride(orderTotalPrice);
            label2.Text = bill.StringOverride(orderTotalPrice);
            label3.Text = bill.StringOverride(orderTotalPrice);
        }

        private void SetlabelsTotalVAT(Label label1, Label label2)
        {
            label1.Text = bill.StringOverride(totalVat);
            label2.Text = bill.StringOverride(totalVat);
        }

        private void btnBackComment_Click(object sender, EventArgs e)
        {
            showPanel(pnlBillPayment, pnlBillSettled, pnlBillView, pnlAddComment, pnlSplitBill);
        }

        private void btnDebit_Click(object sender, EventArgs e)
        {
            btnChangeBackColor(btnDebit, btnCash, btnVisa);
            btnProceedToPayment.Tag = PaymentMethod.Pin;
        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            btnChangeBackColor(btnVisa, btnCash, btnDebit);
            btnProceedToPayment.Tag = PaymentMethod.CreditCard;
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            btnChangeBackColor(btnCash, btnVisa, btnDebit);
            btnProceedToPayment.Tag = PaymentMethod.Cash;
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
