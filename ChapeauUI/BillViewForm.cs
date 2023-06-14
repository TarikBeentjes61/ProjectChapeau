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
            //Hide all panels, except Payment
            pnlAddComment.Hide();
            pnlBillSettled.Hide();
            pnlBillView.Hide();
            pnlBillPayment.Show();
            pnlBillPayment.Location = new Point(12, 83);

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
            //255; 179; 71
        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            btnDebit.BackColor = Color.White;
            btnCash.BackColor = Color.White;
            btnVisa.BackColor = Color.FromArgb(255, 179, 71);
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            btnDebit.BackColor = Color.White;
            btnVisa.BackColor = Color.White;
            btnCash.BackColor = Color.FromArgb(255, 179, 71);
        }
    }
}
