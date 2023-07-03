namespace ChapeauUI
{
    partial class BillViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillViewForm));
            pnlBillSettled = new Panel();
            btnFinishPayment = new Button();
            btnBackBillSettled = new Button();
            labelChangeFinal = new Label();
            labelChangeFinalText = new Label();
            labelFinalVAT = new Label();
            labelFinalTipAmount = new Label();
            labelFinalAmountPaid = new Label();
            labelFinalOrderPrice = new Label();
            labelFinalVATText = new Label();
            labelFinalTipAmountText = new Label();
            labelFinalAmountPaidText = new Label();
            labelFinalOrderPriceText = new Label();
            labelSettled = new Label();
            labelBillHas = new Label();
            pnlAddComment = new Panel();
            btnContinueWithPayment = new Button();
            btnBackComment = new Button();
            labelCommendSaved = new Label();
            btnConfirmComment = new Button();
            textBoxCustomerComment = new RichTextBox();
            labelTypeComment = new Label();
            pnlBillPayment = new Panel();
            labelTotalTip = new Label();
            labelChangeTotalTip = new Label();
            btnBackPayment = new Button();
            btnPay = new Button();
            btnSetTip = new Button();
            txtBoxCustomTip = new TextBox();
            btnAddChangeToTip = new Button();
            labelCustomTip = new Label();
            labelTIP = new Label();
            labelChange = new Label();
            labelChangeText = new Label();
            btnSetPrices = new Button();
            txtBoxAmountPaid = new TextBox();
            labelAmountPaid = new Label();
            labelOrderPricePayment = new Label();
            labelOrderPricePaymentText = new Label();
            labelPayment = new Label();
            pnlBillView = new Panel();
            btnSplit = new Button();
            btnBackOrderOverview = new Button();
            labelBill = new Label();
            labelChoosePayment = new Label();
            btnProceedToPayment = new Button();
            btnDebit = new Button();
            listViewBillOverview = new ListView();
            AmountColumn = new ColumnHeader();
            btnVisa = new Button();
            labelVAT = new Label();
            btnCash = new Button();
            labelOrderPrice = new Label();
            labelOrderPriceText = new Label();
            labelVATText = new Label();
            pictureBox1 = new PictureBox();
            pnlSplitBill = new Panel();
            txtBoxAmountPeopleSplitting = new TextBox();
            btnBackPaymentFromSplit = new Button();
            labelBillSpitting = new Label();
            btnProceedSplitting = new Button();
            label5 = new Label();
            pnlBillSettled.SuspendLayout();
            pnlAddComment.SuspendLayout();
            pnlBillPayment.SuspendLayout();
            pnlBillView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlSplitBill.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBillSettled
            // 
            pnlBillSettled.Controls.Add(btnFinishPayment);
            pnlBillSettled.Controls.Add(btnBackBillSettled);
            pnlBillSettled.Controls.Add(labelChangeFinal);
            pnlBillSettled.Controls.Add(labelChangeFinalText);
            pnlBillSettled.Controls.Add(labelFinalVAT);
            pnlBillSettled.Controls.Add(labelFinalTipAmount);
            pnlBillSettled.Controls.Add(labelFinalAmountPaid);
            pnlBillSettled.Controls.Add(labelFinalOrderPrice);
            pnlBillSettled.Controls.Add(labelFinalVATText);
            pnlBillSettled.Controls.Add(labelFinalTipAmountText);
            pnlBillSettled.Controls.Add(labelFinalAmountPaidText);
            pnlBillSettled.Controls.Add(labelFinalOrderPriceText);
            pnlBillSettled.Controls.Add(labelSettled);
            pnlBillSettled.Controls.Add(labelBillHas);
            pnlBillSettled.Location = new Point(1062, 52);
            pnlBillSettled.Margin = new Padding(3, 2, 3, 2);
            pnlBillSettled.Name = "pnlBillSettled";
            pnlBillSettled.Size = new Size(326, 416);
            pnlBillSettled.TabIndex = 46;
            // 
            // btnFinishPayment
            // 
            btnFinishPayment.BackColor = Color.FromArgb(255, 179, 71);
            btnFinishPayment.Font = new Font("Segoe UI", 13.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnFinishPayment.Location = new Point(3, 371);
            btnFinishPayment.Margin = new Padding(3, 2, 3, 2);
            btnFinishPayment.Name = "btnFinishPayment";
            btnFinishPayment.Size = new Size(320, 41);
            btnFinishPayment.TabIndex = 41;
            btnFinishPayment.Text = "FINISH PAYMENT";
            btnFinishPayment.UseVisualStyleBackColor = false;
            btnFinishPayment.Click += btnFinishPayment_Click;
            // 
            // btnBackBillSettled
            // 
            btnBackBillSettled.BackColor = Color.FromArgb(255, 179, 71);
            btnBackBillSettled.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnBackBillSettled.Location = new Point(235, 2);
            btnBackBillSettled.Margin = new Padding(3, 2, 3, 2);
            btnBackBillSettled.Name = "btnBackBillSettled";
            btnBackBillSettled.Size = new Size(88, 27);
            btnBackBillSettled.TabIndex = 41;
            btnBackBillSettled.Text = "BACK";
            btnBackBillSettled.UseVisualStyleBackColor = false;
            btnBackBillSettled.Click += btnBackBillSettled_Click;
            // 
            // labelChangeFinal
            // 
            labelChangeFinal.AutoSize = true;
            labelChangeFinal.Location = new Point(177, 313);
            labelChangeFinal.Name = "labelChangeFinal";
            labelChangeFinal.Size = new Size(78, 15);
            labelChangeFinal.TabIndex = 47;
            labelChangeFinal.Text = "hier CHANGE";
            // 
            // labelChangeFinalText
            // 
            labelChangeFinalText.AutoSize = true;
            labelChangeFinalText.Location = new Point(62, 313);
            labelChangeFinalText.Name = "labelChangeFinalText";
            labelChangeFinalText.Size = new Size(58, 15);
            labelChangeFinalText.TabIndex = 46;
            labelChangeFinalText.Text = "CHANGE:";
            // 
            // labelFinalVAT
            // 
            labelFinalVAT.AutoSize = true;
            labelFinalVAT.Location = new Point(177, 291);
            labelFinalVAT.Name = "labelFinalVAT";
            labelFinalVAT.Size = new Size(49, 15);
            labelFinalVAT.TabIndex = 45;
            labelFinalVAT.Text = "hier VAT";
            // 
            // labelFinalTipAmount
            // 
            labelFinalTipAmount.AutoSize = true;
            labelFinalTipAmount.Location = new Point(177, 266);
            labelFinalTipAmount.Name = "labelFinalTipAmount";
            labelFinalTipAmount.Size = new Size(89, 15);
            labelFinalTipAmount.TabIndex = 44;
            labelFinalTipAmount.Text = "hier tip amount";
            // 
            // labelFinalAmountPaid
            // 
            labelFinalAmountPaid.AutoSize = true;
            labelFinalAmountPaid.Location = new Point(177, 242);
            labelFinalAmountPaid.Name = "labelFinalAmountPaid";
            labelFinalAmountPaid.Size = new Size(98, 15);
            labelFinalAmountPaid.TabIndex = 43;
            labelFinalAmountPaid.Text = "hier amount paid";
            // 
            // labelFinalOrderPrice
            // 
            labelFinalOrderPrice.AutoSize = true;
            labelFinalOrderPrice.Location = new Point(177, 216);
            labelFinalOrderPrice.Name = "labelFinalOrderPrice";
            labelFinalOrderPrice.Size = new Size(87, 15);
            labelFinalOrderPrice.TabIndex = 42;
            labelFinalOrderPrice.Text = "hier order price";
            // 
            // labelFinalVATText
            // 
            labelFinalVATText.AutoSize = true;
            labelFinalVATText.Location = new Point(60, 291);
            labelFinalVATText.Name = "labelFinalVATText";
            labelFinalVATText.Size = new Size(29, 15);
            labelFinalVATText.TabIndex = 41;
            labelFinalVATText.Text = "VAT:";
            // 
            // labelFinalTipAmountText
            // 
            labelFinalTipAmountText.AutoSize = true;
            labelFinalTipAmountText.Location = new Point(62, 266);
            labelFinalTipAmountText.Name = "labelFinalTipAmountText";
            labelFinalTipAmountText.Size = new Size(80, 15);
            labelFinalTipAmountText.TabIndex = 40;
            labelFinalTipAmountText.Text = "TIP AMOUNT:";
            // 
            // labelFinalAmountPaidText
            // 
            labelFinalAmountPaidText.AutoSize = true;
            labelFinalAmountPaidText.Location = new Point(62, 242);
            labelFinalAmountPaidText.Name = "labelFinalAmountPaidText";
            labelFinalAmountPaidText.Size = new Size(89, 15);
            labelFinalAmountPaidText.TabIndex = 39;
            labelFinalAmountPaidText.Text = "AMOUNT PAID:";
            // 
            // labelFinalOrderPriceText
            // 
            labelFinalOrderPriceText.AutoSize = true;
            labelFinalOrderPriceText.Location = new Point(62, 216);
            labelFinalOrderPriceText.Name = "labelFinalOrderPriceText";
            labelFinalOrderPriceText.Size = new Size(81, 15);
            labelFinalOrderPriceText.TabIndex = 15;
            labelFinalOrderPriceText.Text = "ORDER PRICE:";
            // 
            // labelSettled
            // 
            labelSettled.AutoSize = true;
            labelSettled.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelSettled.ForeColor = Color.FromArgb(138, 210, 176);
            labelSettled.Location = new Point(100, 158);
            labelSettled.Name = "labelSettled";
            labelSettled.Size = new Size(119, 32);
            labelSettled.TabIndex = 38;
            labelSettled.Text = "SETTLED!";
            // 
            // labelBillHas
            // 
            labelBillHas.AutoSize = true;
            labelBillHas.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelBillHas.ForeColor = Color.FromArgb(138, 210, 176);
            labelBillHas.Location = new Point(38, 116);
            labelBillHas.Name = "labelBillHas";
            labelBillHas.Size = new Size(235, 32);
            labelBillHas.TabIndex = 37;
            labelBillHas.Text = "THE BILL HAS BEEN";
            // 
            // pnlAddComment
            // 
            pnlAddComment.Controls.Add(btnContinueWithPayment);
            pnlAddComment.Controls.Add(btnBackComment);
            pnlAddComment.Controls.Add(labelCommendSaved);
            pnlAddComment.Controls.Add(btnConfirmComment);
            pnlAddComment.Controls.Add(textBoxCustomerComment);
            pnlAddComment.Controls.Add(labelTypeComment);
            pnlAddComment.Location = new Point(712, 52);
            pnlAddComment.Margin = new Padding(3, 2, 3, 2);
            pnlAddComment.Name = "pnlAddComment";
            pnlAddComment.Size = new Size(326, 416);
            pnlAddComment.TabIndex = 45;
            // 
            // btnContinueWithPayment
            // 
            btnContinueWithPayment.BackColor = Color.FromArgb(255, 179, 71);
            btnContinueWithPayment.Font = new Font("Segoe UI", 13.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnContinueWithPayment.Location = new Point(3, 371);
            btnContinueWithPayment.Margin = new Padding(3, 2, 3, 2);
            btnContinueWithPayment.Name = "btnContinueWithPayment";
            btnContinueWithPayment.Size = new Size(320, 41);
            btnContinueWithPayment.TabIndex = 40;
            btnContinueWithPayment.Text = "CONTINUE WITH PAYMENT";
            btnContinueWithPayment.UseVisualStyleBackColor = false;
            btnContinueWithPayment.Click += btnContinueWithPayment_Click;
            // 
            // btnBackComment
            // 
            btnBackComment.BackColor = Color.FromArgb(255, 179, 71);
            btnBackComment.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnBackComment.Location = new Point(235, 2);
            btnBackComment.Margin = new Padding(3, 2, 3, 2);
            btnBackComment.Name = "btnBackComment";
            btnBackComment.Size = new Size(88, 27);
            btnBackComment.TabIndex = 36;
            btnBackComment.Text = "BACK";
            btnBackComment.UseVisualStyleBackColor = false;
            btnBackComment.Click += btnBackComment_Click;
            // 
            // labelCommendSaved
            // 
            labelCommendSaved.AutoSize = true;
            labelCommendSaved.Location = new Point(28, 291);
            labelCommendSaved.Name = "labelCommendSaved";
            labelCommendSaved.Size = new Size(0, 15);
            labelCommendSaved.TabIndex = 22;
            // 
            // btnConfirmComment
            // 
            btnConfirmComment.BackColor = Color.FromArgb(138, 210, 176);
            btnConfirmComment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmComment.Location = new Point(5, 321);
            btnConfirmComment.Margin = new Padding(3, 2, 3, 2);
            btnConfirmComment.Name = "btnConfirmComment";
            btnConfirmComment.Size = new Size(320, 41);
            btnConfirmComment.TabIndex = 21;
            btnConfirmComment.Text = "SAVE COMMENT";
            btnConfirmComment.UseVisualStyleBackColor = false;
            btnConfirmComment.Click += btnConfirmComment_Click;
            // 
            // textBoxCustomerComment
            // 
            textBoxCustomerComment.Location = new Point(14, 107);
            textBoxCustomerComment.Margin = new Padding(3, 2, 3, 2);
            textBoxCustomerComment.Name = "textBoxCustomerComment";
            textBoxCustomerComment.Size = new Size(298, 174);
            textBoxCustomerComment.TabIndex = 20;
            textBoxCustomerComment.Text = "";
            // 
            // labelTypeComment
            // 
            labelTypeComment.AutoSize = true;
            labelTypeComment.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelTypeComment.Location = new Point(19, 77);
            labelTypeComment.Name = "labelTypeComment";
            labelTypeComment.Size = new Size(261, 20);
            labelTypeComment.TabIndex = 19;
            labelTypeComment.Text = "TYPE CUSTOMERS COMMENT HERE:";
            // 
            // pnlBillPayment
            // 
            pnlBillPayment.Controls.Add(labelTotalTip);
            pnlBillPayment.Controls.Add(labelChangeTotalTip);
            pnlBillPayment.Controls.Add(btnBackPayment);
            pnlBillPayment.Controls.Add(btnPay);
            pnlBillPayment.Controls.Add(btnSetTip);
            pnlBillPayment.Controls.Add(txtBoxCustomTip);
            pnlBillPayment.Controls.Add(btnAddChangeToTip);
            pnlBillPayment.Controls.Add(labelCustomTip);
            pnlBillPayment.Controls.Add(labelTIP);
            pnlBillPayment.Controls.Add(labelChange);
            pnlBillPayment.Controls.Add(labelChangeText);
            pnlBillPayment.Controls.Add(btnSetPrices);
            pnlBillPayment.Controls.Add(txtBoxAmountPaid);
            pnlBillPayment.Controls.Add(labelAmountPaid);
            pnlBillPayment.Controls.Add(labelOrderPricePayment);
            pnlBillPayment.Controls.Add(labelOrderPricePaymentText);
            pnlBillPayment.Controls.Add(labelPayment);
            pnlBillPayment.Location = new Point(362, 52);
            pnlBillPayment.Margin = new Padding(3, 2, 3, 2);
            pnlBillPayment.Name = "pnlBillPayment";
            pnlBillPayment.Size = new Size(326, 416);
            pnlBillPayment.TabIndex = 44;
            // 
            // labelTotalTip
            // 
            labelTotalTip.AutoSize = true;
            labelTotalTip.Location = new Point(266, 341);
            labelTotalTip.Name = "labelTotalTip";
            labelTotalTip.Size = new Size(0, 15);
            labelTotalTip.TabIndex = 39;
            // 
            // labelChangeTotalTip
            // 
            labelChangeTotalTip.AutoSize = true;
            labelChangeTotalTip.Location = new Point(5, 341);
            labelChangeTotalTip.Name = "labelChangeTotalTip";
            labelChangeTotalTip.Size = new Size(26, 15);
            labelChangeTotalTip.TabIndex = 38;
            labelChangeTotalTip.Text = "TIP:";
            // 
            // btnBackPayment
            // 
            btnBackPayment.BackColor = Color.FromArgb(255, 179, 71);
            btnBackPayment.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnBackPayment.Location = new Point(235, 2);
            btnBackPayment.Margin = new Padding(3, 2, 3, 2);
            btnBackPayment.Name = "btnBackPayment";
            btnBackPayment.Size = new Size(88, 27);
            btnBackPayment.TabIndex = 37;
            btnBackPayment.Text = "BACK";
            btnBackPayment.UseVisualStyleBackColor = false;
            btnBackPayment.Click += btnBackPayment_Click;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.FromArgb(255, 179, 71);
            btnPay.Font = new Font("Segoe UI", 13.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnPay.Location = new Point(3, 371);
            btnPay.Margin = new Padding(3, 2, 3, 2);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(320, 41);
            btnPay.TabIndex = 34;
            btnPay.Text = "PAY";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // btnSetTip
            // 
            btnSetTip.BackColor = Color.FromArgb(138, 210, 176);
            btnSetTip.Location = new Point(253, 291);
            btnSetTip.Margin = new Padding(3, 2, 3, 2);
            btnSetTip.Name = "btnSetTip";
            btnSetTip.Size = new Size(58, 22);
            btnSetTip.TabIndex = 33;
            btnSetTip.Text = "SET";
            btnSetTip.UseVisualStyleBackColor = false;
            btnSetTip.Click += btnSetTip_Click;
            // 
            // txtBoxCustomTip
            // 
            txtBoxCustomTip.Location = new Point(176, 254);
            txtBoxCustomTip.Margin = new Padding(3, 2, 3, 2);
            txtBoxCustomTip.Name = "txtBoxCustomTip";
            txtBoxCustomTip.Size = new Size(135, 23);
            txtBoxCustomTip.TabIndex = 32;
            // 
            // btnAddChangeToTip
            // 
            btnAddChangeToTip.BackColor = Color.FromArgb(138, 210, 176);
            btnAddChangeToTip.Location = new Point(3, 216);
            btnAddChangeToTip.Margin = new Padding(3, 2, 3, 2);
            btnAddChangeToTip.Name = "btnAddChangeToTip";
            btnAddChangeToTip.Size = new Size(320, 31);
            btnAddChangeToTip.TabIndex = 31;
            btnAddChangeToTip.Text = "ADD CHANGE TO TIP:";
            btnAddChangeToTip.UseVisualStyleBackColor = false;
            btnAddChangeToTip.Click += btnAddChangeToTip_Click;
            // 
            // labelCustomTip
            // 
            labelCustomTip.AutoSize = true;
            labelCustomTip.Location = new Point(0, 254);
            labelCustomTip.Name = "labelCustomTip";
            labelCustomTip.Size = new Size(76, 15);
            labelCustomTip.TabIndex = 30;
            labelCustomTip.Text = "CUSTOM TIP:";
            // 
            // labelTIP
            // 
            labelTIP.AutoSize = true;
            labelTIP.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTIP.Location = new Point(3, 190);
            labelTIP.Name = "labelTIP";
            labelTIP.Size = new Size(34, 21);
            labelTIP.TabIndex = 29;
            labelTIP.Text = "TIP";
            // 
            // labelChange
            // 
            labelChange.AutoSize = true;
            labelChange.Location = new Point(266, 146);
            labelChange.Name = "labelChange";
            labelChange.Size = new Size(0, 15);
            labelChange.TabIndex = 28;
            // 
            // labelChangeText
            // 
            labelChangeText.AutoSize = true;
            labelChangeText.Location = new Point(5, 146);
            labelChangeText.Name = "labelChangeText";
            labelChangeText.Size = new Size(58, 15);
            labelChangeText.TabIndex = 27;
            labelChangeText.Text = "CHANGE:";
            // 
            // btnSetPrices
            // 
            btnSetPrices.BackColor = Color.FromArgb(138, 210, 176);
            btnSetPrices.Location = new Point(254, 105);
            btnSetPrices.Margin = new Padding(3, 2, 3, 2);
            btnSetPrices.Name = "btnSetPrices";
            btnSetPrices.Size = new Size(58, 22);
            btnSetPrices.TabIndex = 26;
            btnSetPrices.Text = "SET";
            btnSetPrices.UseVisualStyleBackColor = false;
            btnSetPrices.Click += btnSetPrices_Click;
            // 
            // txtBoxAmountPaid
            // 
            txtBoxAmountPaid.Location = new Point(177, 76);
            txtBoxAmountPaid.Margin = new Padding(3, 2, 3, 2);
            txtBoxAmountPaid.Name = "txtBoxAmountPaid";
            txtBoxAmountPaid.Size = new Size(135, 23);
            txtBoxAmountPaid.TabIndex = 25;
            // 
            // labelAmountPaid
            // 
            labelAmountPaid.AutoSize = true;
            labelAmountPaid.Location = new Point(3, 75);
            labelAmountPaid.Name = "labelAmountPaid";
            labelAmountPaid.Size = new Size(89, 15);
            labelAmountPaid.TabIndex = 24;
            labelAmountPaid.Text = "AMOUNT PAID:";
            // 
            // labelOrderPricePayment
            // 
            labelOrderPricePayment.AutoSize = true;
            labelOrderPricePayment.Location = new Point(266, 52);
            labelOrderPricePayment.Name = "labelOrderPricePayment";
            labelOrderPricePayment.Size = new Size(43, 15);
            labelOrderPricePayment.TabIndex = 23;
            labelOrderPricePayment.Text = "xxxxxx";
            // 
            // labelOrderPricePaymentText
            // 
            labelOrderPricePaymentText.AutoSize = true;
            labelOrderPricePaymentText.Location = new Point(3, 52);
            labelOrderPricePaymentText.Name = "labelOrderPricePaymentText";
            labelOrderPricePaymentText.Size = new Size(81, 15);
            labelOrderPricePaymentText.TabIndex = 22;
            labelOrderPricePaymentText.Text = "ORDER PRICE:";
            // 
            // labelPayment
            // 
            labelPayment.AutoSize = true;
            labelPayment.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            labelPayment.Location = new Point(0, 0);
            labelPayment.Name = "labelPayment";
            labelPayment.Size = new Size(105, 28);
            labelPayment.TabIndex = 21;
            labelPayment.Text = "PAYMENT";
            // 
            // pnlBillView
            // 
            pnlBillView.Controls.Add(btnSplit);
            pnlBillView.Controls.Add(btnBackOrderOverview);
            pnlBillView.Controls.Add(labelBill);
            pnlBillView.Controls.Add(labelChoosePayment);
            pnlBillView.Controls.Add(btnProceedToPayment);
            pnlBillView.Controls.Add(btnDebit);
            pnlBillView.Controls.Add(listViewBillOverview);
            pnlBillView.Controls.Add(btnVisa);
            pnlBillView.Controls.Add(labelVAT);
            pnlBillView.Controls.Add(btnCash);
            pnlBillView.Controls.Add(labelOrderPrice);
            pnlBillView.Controls.Add(labelOrderPriceText);
            pnlBillView.Controls.Add(labelVATText);
            pnlBillView.Location = new Point(10, 52);
            pnlBillView.Margin = new Padding(3, 2, 3, 2);
            pnlBillView.Name = "pnlBillView";
            pnlBillView.Size = new Size(326, 416);
            pnlBillView.TabIndex = 43;
            // 
            // btnSplit
            // 
            btnSplit.BackColor = Color.FromArgb(255, 179, 71);
            btnSplit.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnSplit.Location = new Point(241, 371);
            btnSplit.Margin = new Padding(3, 2, 3, 2);
            btnSplit.Name = "btnSplit";
            btnSplit.Size = new Size(85, 41);
            btnSplit.TabIndex = 39;
            btnSplit.Text = "SPLIT";
            btnSplit.UseVisualStyleBackColor = false;
            btnSplit.Click += btnSplit_Click;
            // 
            // btnBackOrderOverview
            // 
            btnBackOrderOverview.BackColor = Color.FromArgb(255, 179, 71);
            btnBackOrderOverview.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnBackOrderOverview.Location = new Point(238, 0);
            btnBackOrderOverview.Margin = new Padding(3, 2, 3, 2);
            btnBackOrderOverview.Name = "btnBackOrderOverview";
            btnBackOrderOverview.Size = new Size(88, 27);
            btnBackOrderOverview.TabIndex = 38;
            btnBackOrderOverview.Text = "BACK";
            btnBackOrderOverview.UseVisualStyleBackColor = false;
            btnBackOrderOverview.Click += btnBackOrderOverview_Click;
            // 
            // labelBill
            // 
            labelBill.AutoSize = true;
            labelBill.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            labelBill.Location = new Point(11, 0);
            labelBill.Name = "labelBill";
            labelBill.Size = new Size(51, 28);
            labelBill.TabIndex = 0;
            labelBill.Text = "BILL";
            // 
            // labelChoosePayment
            // 
            labelChoosePayment.AutoSize = true;
            labelChoosePayment.Location = new Point(11, 254);
            labelChoosePayment.Name = "labelChoosePayment";
            labelChoosePayment.Size = new Size(141, 15);
            labelChoosePayment.TabIndex = 14;
            labelChoosePayment.Text = "CHOOSE PAYMENT TYPE:";
            // 
            // btnProceedToPayment
            // 
            btnProceedToPayment.BackColor = Color.FromArgb(138, 210, 176);
            btnProceedToPayment.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnProceedToPayment.Location = new Point(3, 371);
            btnProceedToPayment.Margin = new Padding(3, 2, 3, 2);
            btnProceedToPayment.Name = "btnProceedToPayment";
            btnProceedToPayment.Size = new Size(241, 41);
            btnProceedToPayment.TabIndex = 2;
            btnProceedToPayment.Text = "PROCEED TO PAYMENT";
            btnProceedToPayment.UseVisualStyleBackColor = false;
            btnProceedToPayment.Click += btnProceedToPayment_Click;
            // 
            // btnDebit
            // 
            btnDebit.BackColor = SystemColors.Window;
            btnDebit.Location = new Point(11, 272);
            btnDebit.Margin = new Padding(3, 2, 3, 2);
            btnDebit.Name = "btnDebit";
            btnDebit.Size = new Size(82, 22);
            btnDebit.TabIndex = 3;
            btnDebit.Text = "DEBIT";
            btnDebit.UseVisualStyleBackColor = false;
            btnDebit.Click += btnDebit_Click;
            // 
            // listViewBillOverview
            // 
            listViewBillOverview.Columns.AddRange(new ColumnHeader[] { AmountColumn });
            listViewBillOverview.Location = new Point(11, 28);
            listViewBillOverview.Margin = new Padding(3, 2, 3, 2);
            listViewBillOverview.Name = "listViewBillOverview";
            listViewBillOverview.Size = new Size(302, 212);
            listViewBillOverview.TabIndex = 10;
            listViewBillOverview.UseCompatibleStateImageBehavior = false;
            listViewBillOverview.View = View.Details;
            // 
            // AmountColumn
            // 
            AmountColumn.Text = "Amount";
            // 
            // btnVisa
            // 
            btnVisa.Location = new Point(122, 272);
            btnVisa.Margin = new Padding(3, 2, 3, 2);
            btnVisa.Name = "btnVisa";
            btnVisa.Size = new Size(82, 22);
            btnVisa.TabIndex = 4;
            btnVisa.Text = "VISA/AMEX";
            btnVisa.UseVisualStyleBackColor = true;
            btnVisa.Click += btnVisa_Click;
            // 
            // labelVAT
            // 
            labelVAT.AutoSize = true;
            labelVAT.Location = new Point(268, 336);
            labelVAT.Name = "labelVAT";
            labelVAT.Size = new Size(43, 15);
            labelVAT.TabIndex = 9;
            labelVAT.Text = "xxxxxx";
            // 
            // btnCash
            // 
            btnCash.Location = new Point(230, 272);
            btnCash.Margin = new Padding(3, 2, 3, 2);
            btnCash.Name = "btnCash";
            btnCash.Size = new Size(82, 22);
            btnCash.TabIndex = 5;
            btnCash.Text = "CASH";
            btnCash.UseVisualStyleBackColor = true;
            btnCash.Click += btnCash_Click;
            // 
            // labelOrderPrice
            // 
            labelOrderPrice.AutoSize = true;
            labelOrderPrice.Location = new Point(268, 313);
            labelOrderPrice.Name = "labelOrderPrice";
            labelOrderPrice.Size = new Size(43, 15);
            labelOrderPrice.TabIndex = 8;
            labelOrderPrice.Text = "xxxxxx";
            // 
            // labelOrderPriceText
            // 
            labelOrderPriceText.AutoSize = true;
            labelOrderPriceText.Location = new Point(11, 313);
            labelOrderPriceText.Name = "labelOrderPriceText";
            labelOrderPriceText.Size = new Size(81, 15);
            labelOrderPriceText.TabIndex = 6;
            labelOrderPriceText.Text = "ORDER PRICE:";
            // 
            // labelVATText
            // 
            labelVATText.AutoSize = true;
            labelVATText.Location = new Point(11, 336);
            labelVATText.Name = "labelVATText";
            labelVATText.Size = new Size(29, 15);
            labelVATText.TabIndex = 7;
            labelVATText.Text = "VAT:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 46);
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // pnlSplitBill
            // 
            pnlSplitBill.Controls.Add(txtBoxAmountPeopleSplitting);
            pnlSplitBill.Controls.Add(btnBackPaymentFromSplit);
            pnlSplitBill.Controls.Add(labelBillSpitting);
            pnlSplitBill.Controls.Add(btnProceedSplitting);
            pnlSplitBill.Controls.Add(label5);
            pnlSplitBill.Location = new Point(7, 373);
            pnlSplitBill.Margin = new Padding(3, 2, 3, 2);
            pnlSplitBill.Name = "pnlSplitBill";
            pnlSplitBill.Size = new Size(326, 416);
            pnlSplitBill.TabIndex = 44;
            // 
            // txtBoxAmountPeopleSplitting
            // 
            txtBoxAmountPeopleSplitting.Location = new Point(76, 164);
            txtBoxAmountPeopleSplitting.Margin = new Padding(3, 2, 3, 2);
            txtBoxAmountPeopleSplitting.Name = "txtBoxAmountPeopleSplitting";
            txtBoxAmountPeopleSplitting.Size = new Size(159, 23);
            txtBoxAmountPeopleSplitting.TabIndex = 39;
            // 
            // btnBackPaymentFromSplit
            // 
            btnBackPaymentFromSplit.BackColor = Color.FromArgb(255, 179, 71);
            btnBackPaymentFromSplit.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnBackPaymentFromSplit.Location = new Point(238, 0);
            btnBackPaymentFromSplit.Margin = new Padding(3, 2, 3, 2);
            btnBackPaymentFromSplit.Name = "btnBackPaymentFromSplit";
            btnBackPaymentFromSplit.Size = new Size(88, 27);
            btnBackPaymentFromSplit.TabIndex = 38;
            btnBackPaymentFromSplit.Text = "BACK";
            btnBackPaymentFromSplit.UseVisualStyleBackColor = false;
            btnBackPaymentFromSplit.Click += btnBackPaymentFromSplit_Click;
            // 
            // labelBillSpitting
            // 
            labelBillSpitting.AutoSize = true;
            labelBillSpitting.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            labelBillSpitting.Location = new Point(11, 0);
            labelBillSpitting.Name = "labelBillSpitting";
            labelBillSpitting.Size = new Size(114, 28);
            labelBillSpitting.TabIndex = 0;
            labelBillSpitting.Text = " BILL SPLIT";
            // 
            // btnProceedSplitting
            // 
            btnProceedSplitting.BackColor = Color.FromArgb(138, 210, 176);
            btnProceedSplitting.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnProceedSplitting.Location = new Point(3, 371);
            btnProceedSplitting.Margin = new Padding(3, 2, 3, 2);
            btnProceedSplitting.Name = "btnProceedSplitting";
            btnProceedSplitting.Size = new Size(320, 41);
            btnProceedSplitting.TabIndex = 2;
            btnProceedSplitting.Text = "PROCEED WITH SPLITTING";
            btnProceedSplitting.UseVisualStyleBackColor = false;
            btnProceedSplitting.Click += btnProceedSplitting_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(138, 210, 176);
            label5.Location = new Point(20, 130);
            label5.Name = "label5";
            label5.Size = new Size(266, 25);
            label5.TabIndex = 6;
            label5.Text = "Amount people for splitting:";
            // 
            // BillViewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1684, 791);
            Controls.Add(pnlSplitBill);
            Controls.Add(pictureBox1);
            Controls.Add(pnlBillSettled);
            Controls.Add(pnlAddComment);
            Controls.Add(pnlBillPayment);
            Controls.Add(pnlBillView);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BillViewForm";
            Text = "BillViewForm";
            pnlBillSettled.ResumeLayout(false);
            pnlBillSettled.PerformLayout();
            pnlAddComment.ResumeLayout(false);
            pnlAddComment.PerformLayout();
            pnlBillPayment.ResumeLayout(false);
            pnlBillPayment.PerformLayout();
            pnlBillView.ResumeLayout(false);
            pnlBillView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlSplitBill.ResumeLayout(false);
            pnlSplitBill.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBillSettled;
        private Label labelFinalVAT;
        private Label labelFinalTipAmount;
        private Label labelFinalAmountPaid;
        private Label labelFinalOrderPrice;
        private Label labelFinalVATText;
        private Label labelFinalTipAmountText;
        private Label labelFinalAmountPaidText;
        private Label labelFinalOrderPriceText;
        private Label labelSettled;
        private Label labelBillHas;
        private Panel pnlAddComment;
        private Button btnBackComment;
        private Label labelCommendSaved;
        private Button btnConfirmComment;
        private RichTextBox textBoxCustomerComment;
        private Label labelTypeComment;
        private Panel pnlBillPayment;
        private Button btnBackPayment;
        private Button btnPay;
        private Button btnSetTip;
        private TextBox txtBoxCustomTip;
        private Button btnAddChangeToTip;
        private Label labelCustomTip;
        private Label labelTIP;
        private Label labelChange;
        private Label labelChangeText;
        private Button btnSetPrices;
        private TextBox txtBoxAmountPaid;
        private Label labelAmountPaid;
        private Label labelOrderPricePayment;
        private Label labelOrderPricePaymentText;
        private Label labelPayment;
        private Panel pnlBillView;
        private Label labelBill;
        private Label labelChoosePayment;
        private Button btnProceedToPayment;
        private Button btnDebit;
        private ListView listViewBillOverview;
        private Button btnVisa;
        private Label labelVAT;
        private Button btnCash;
        private Label labelOrderPrice;
        private Label labelOrderPriceText;
        private Label labelVATText;
        private PictureBox pictureBox1;
        private Button btnBackOrderOverview;
        private ColumnHeader AmountColumn;
        private Label labelTotalTip;
        private Label labelChangeTotalTip;
        private Label labelChangeFinal;
        private Label labelChangeFinalText;
        private Button btnFinishPayment;
        private Button btnBackBillSettled;
        private Button btnContinueWithPayment;
        private Button btnSplit;
        private Panel pnlSplitBill;
        private TextBox txtBoxAmountPeopleSplitting;
        private Button btnBackPaymentFromSplit;
        private Label labelBillSpitting;
        private Button btnProceedSplitting;
        private Label label5;
    }
}