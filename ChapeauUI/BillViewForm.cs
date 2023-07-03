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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace ChapeauUI
{
    public partial class BillViewForm : Form
    {
        private Employee employee;
        private Bill bill;
        public BillViewForm(Bill bill, Employee employee)
        {
            this.employee = employee;
            this.bill = bill;
            InitializeComponent();
            showPanel(pnlBillView);

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

            foreach (OrderItem item in orderItemsTest)
            {
                ListViewItem listViewItem = new ListViewItem(item.amount.ToString());
                listViewItem.SubItems.Add(item.menuItem.itemName);
                listViewItem.SubItems.Add(item.menuItem.price.ToString());
                listView.Items.Add(listViewItem);
            }
            SetTotalPriceLabels(CalculateBill.CalculateTotalVat(orderItemsTest), CalculateBill.CalculateTotalPriceInclVat(orderItemsTest));

        }
        private void SetTotalPriceLabels(double totalVat, double totalPrice)
        {
            labelFinalVAT.Text = "€ " + totalVat.ToString();
            labelVAT.Text = totalVat.ToString();
            labelOrderPrice.Text = totalPrice.ToString();
            labelFinalOrderPrice.Text = totalPrice.ToString();
            labelOrderPricePayment.Text = totalPrice.ToString();
            btnSetPrices.Tag = totalPrice;
        }

        private void btnProceedToPayment_Click(object sender, EventArgs e)
        {
            if (btnProceedToPayment.Tag is null) //if none button has been clicked:
            {
                MessageBox.Show("No paymethod has been selected, please select one.");
            }
            else
            {
                showPanel(pnlBillPayment);
            }
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            showPanel(pnlSplitBill);
        }

        private void btnBackPayment_Click(object sender, EventArgs e)
        {
            showPanel(pnlBillView);
        }

        private void btnBackPaymentFromSplit_Click(object sender, EventArgs e)
        {
            showPanel(pnlBillView);
        }

        private void button2_Click(object sender, EventArgs e) //btnProceedSplitting
        {
            string inputSplit = txtBoxAmountPeopleSplitting.Text;

        }

        private void btnSetPrices_Click(object sender, EventArgs e)
        {
            if (txtBoxAmountPaid.Text == "")
            {
                MessageBox.Show("Please enter a amount of pay.");
            }
            else
            {
                double input = double.Parse(txtBoxAmountPaid.Text);
                double totalPrice = (double)btnSetPrices.Tag;
                if (input < totalPrice)
                {
                    MessageBox.Show("Amount paid is lower than the order price. Please check again.");
                }
                else
                {
                    double changePrice = input - totalPrice;
                    labelChange.Text = "€" + changePrice.ToString("F");
                    labelChangeFinal.Text = "€" + changePrice.ToString("F");
                    labelFinalAmountPaid.Text = "€" + input.ToString("F");
                    SetButtonTags(totalPrice, changePrice, input);
                }
            }
        }

        private void SetButtonTags(double totalPrice, double changePrice, double amountPaid)
        {
            btnAddChangeToTip.Tag = changePrice;
            btnSetTip.Tag = changePrice;
            btnPay.Tag = amountPaid;
        }

        private void btnAddChangeToTip_Click(object sender, EventArgs e)
        {
            labelFinalTipAmount.Text = "€0,00";
            double changePrice = (double)btnAddChangeToTip.Tag;
            if (changePrice > 0)
            {
                double totalTip = changePrice;
                labelTotalTip.Text = "€" + totalTip.ToString("F");

                //update Change
                changePrice = 0;
                labelChange.Text = "€" + changePrice.ToString("F");
                labelFinalTipAmount.Text = "€" + totalTip.ToString("F");
            }
            else
            {
                MessageBox.Show("Please enter a amount of pay;");
            }
        }

        private void btnSetTip_Click(object sender, EventArgs e)
        {
            if (txtBoxCustomTip.Text != "")
            {
                double input = double.Parse(txtBoxCustomTip.Text);
                double changePrice = (double)btnSetTip.Tag;
                if (input > changePrice)
                {
                    MessageBox.Show("Amount tip is higher than the change. Please check again.");
                }
                else
                {
                    //update Change
                    changePrice -= input;
                    labelChange.Text = "€" + changePrice.ToString("F");

                    bill.tip = input;
                    labelChangeFinal.Text = "€" + changePrice.ToString("F");
                    labelTotalTip.Text = "€" + input.ToString("F");
                    labelFinalTipAmount.Text = "€" + input.ToString("F");
                }
            }
            else
            {
                MessageBox.Show("Please enter a amount of tip.");
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            double amountPaid = (double)btnPay.Tag;
            if (amountPaid > 0)
            {
                showPanel(pnlAddComment);
            }
            else
            {
                MessageBox.Show("There is not an amount paid. Please enter a amount.");
            }
        }

        private void btnBackComment_Click(object sender, EventArgs e)
        {
            showPanel(pnlBillPayment);
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
            //CreateOrderForm orderForm = new CreateOrderForm(table, employee);
            //orderForm.Show();
        }
        private void btnConfirmComment_Click(object sender, EventArgs e)
        {
            if (textBoxCustomerComment.Text != "")
            {
                labelCommendSavedChange();

                bill.comment = textBoxCustomerComment.Text;
            }
            else
            {
                MessageBox.Show("No comment has been given, please enter comment.");
            }
        }
        private void btnFinishPayment_Click(object sender, EventArgs e)
        {
            //database verander dbo.BILL van tip en payed.
            BillService billService = new BillService();
            //id, comment, paymentMethod, tip, payed.
            billService.UpdateBill(bill.billId, bill.comment, (int)bill.paymentMethod, 1, 1);

            TableForm table = new TableForm(employee);
            this.Close();
            table.Show();
        }

        private void btnContinueWithPayment_Click(object sender, EventArgs e)
        {
            showPanel(pnlBillSettled);
        }

        private void btnBackBillSettled_Click(object sender, EventArgs e)
        {
            showPanel(pnlAddComment);
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

        private void showPanel(Panel panel)
        {
            HidePanels();
            panel.Show();
            panel.Location = new Point(12, 83);
        }
        private void HidePanels()
        {
            pnlAddComment.Hide();
            pnlBillPayment.Hide();
            pnlBillSettled.Hide();
            pnlBillView.Hide();
            pnlSplitBill.Hide();
        }
    }
}
