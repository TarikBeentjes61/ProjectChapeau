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
        public BillViewForm()
        {
            InitializeComponent();
            pnlAddComment.Hide();
            pnlBillPayment.Hide();
            pnlBillSettled.Hide();
            pnlBillView.Show();
        }



        private void btnProceedToPayment_Click(object sender, EventArgs e)
        {
            pnlAddComment.Hide();
            pnlBillSettled.Hide();
            pnlBillView.Hide();
            pnlBillPayment.Show();
            pnlBillPayment.Location = new Point(12, 83);

        }

        private void btnBackPayment_Click(object sender, EventArgs e)
        {
            pnlAddComment.Hide();
            pnlBillPayment.Hide();
            pnlBillSettled.Hide();
            pnlBillView.Show();
            pnlBillPayment.Location = new Point(12, 83);
        }

        private void btnSetPrices_Click(object sender, EventArgs e)
        {

        }

        private void btnAddChangeToTip_Click(object sender, EventArgs e)
        {

        }

        private void btnSetTip_Click(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            pnlBillPayment.Hide();
            pnlBillSettled.Hide();
            pnlBillView.Hide();
            pnlAddComment.Show();
            pnlAddComment.Location = new Point(12, 83);
        }
    }
}
