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
            this.pnlBillSettled = new System.Windows.Forms.Panel();
            this.btnFinishPayment = new System.Windows.Forms.Button();
            this.btnBackBillSettled = new System.Windows.Forms.Button();
            this.labelChangeFinal = new System.Windows.Forms.Label();
            this.labelChangeFinalText = new System.Windows.Forms.Label();
            this.labelFinalVAT = new System.Windows.Forms.Label();
            this.labelFinalTipAmount = new System.Windows.Forms.Label();
            this.labelFinalAmountPaid = new System.Windows.Forms.Label();
            this.labelFinalOrderPrice = new System.Windows.Forms.Label();
            this.labelFinalVATText = new System.Windows.Forms.Label();
            this.labelFinalTipAmountText = new System.Windows.Forms.Label();
            this.labelFinalAmountPaidText = new System.Windows.Forms.Label();
            this.labelFinalOrderPriceText = new System.Windows.Forms.Label();
            this.labelSettled = new System.Windows.Forms.Label();
            this.labelBillHas = new System.Windows.Forms.Label();
            this.pnlAddComment = new System.Windows.Forms.Panel();
            this.btnContinueWithPayment = new System.Windows.Forms.Button();
            this.btnBackComment = new System.Windows.Forms.Button();
            this.labelCommendSaved = new System.Windows.Forms.Label();
            this.btnConfirmComment = new System.Windows.Forms.Button();
            this.labelCustomerComment = new System.Windows.Forms.RichTextBox();
            this.labelTypeComment = new System.Windows.Forms.Label();
            this.pnlBillPayment = new System.Windows.Forms.Panel();
            this.labelTotalTip = new System.Windows.Forms.Label();
            this.labelChangeTotalTip = new System.Windows.Forms.Label();
            this.btnBackPayment = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnSetTip = new System.Windows.Forms.Button();
            this.txtBoxCustomTip = new System.Windows.Forms.TextBox();
            this.btnAddChangeToTip = new System.Windows.Forms.Button();
            this.labelCustomTip = new System.Windows.Forms.Label();
            this.labelTIP = new System.Windows.Forms.Label();
            this.labelChange = new System.Windows.Forms.Label();
            this.labelChangeText = new System.Windows.Forms.Label();
            this.btnSetPrices = new System.Windows.Forms.Button();
            this.txtBoxAmountPaid = new System.Windows.Forms.TextBox();
            this.labelAmountPaid = new System.Windows.Forms.Label();
            this.labelOrderPricePayment = new System.Windows.Forms.Label();
            this.labelOrderPricePaymentText = new System.Windows.Forms.Label();
            this.labelPayment = new System.Windows.Forms.Label();
            this.pnlBillView = new System.Windows.Forms.Panel();
            this.btnSplit = new System.Windows.Forms.Button();
            this.btnBackOrderOverview = new System.Windows.Forms.Button();
            this.labelBill = new System.Windows.Forms.Label();
            this.labelChoosePayment = new System.Windows.Forms.Label();
            this.btnProceedToPayment = new System.Windows.Forms.Button();
            this.btnDebit = new System.Windows.Forms.Button();
            this.listViewBillOverview = new System.Windows.Forms.ListView();
            this.AmountColumn = new System.Windows.Forms.ColumnHeader();
            this.btnVisa = new System.Windows.Forms.Button();
            this.labelVAT = new System.Windows.Forms.Label();
            this.btnCash = new System.Windows.Forms.Button();
            this.labelOrderPrice = new System.Windows.Forms.Label();
            this.labelOrderPriceText = new System.Windows.Forms.Label();
            this.labelVATText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlSplitBill = new System.Windows.Forms.Panel();
            this.txtBoxAmountPeopleSplitting = new System.Windows.Forms.TextBox();
            this.btnBackPaymentFromSplit = new System.Windows.Forms.Button();
            this.labelBillSpitting = new System.Windows.Forms.Label();
            this.btnProceedSplitting = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlBillSettled.SuspendLayout();
            this.pnlAddComment.SuspendLayout();
            this.pnlBillPayment.SuspendLayout();
            this.pnlBillView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlSplitBill.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBillSettled
            // 
            this.pnlBillSettled.Controls.Add(this.btnFinishPayment);
            this.pnlBillSettled.Controls.Add(this.btnBackBillSettled);
            this.pnlBillSettled.Controls.Add(this.labelChangeFinal);
            this.pnlBillSettled.Controls.Add(this.labelChangeFinalText);
            this.pnlBillSettled.Controls.Add(this.labelFinalVAT);
            this.pnlBillSettled.Controls.Add(this.labelFinalTipAmount);
            this.pnlBillSettled.Controls.Add(this.labelFinalAmountPaid);
            this.pnlBillSettled.Controls.Add(this.labelFinalOrderPrice);
            this.pnlBillSettled.Controls.Add(this.labelFinalVATText);
            this.pnlBillSettled.Controls.Add(this.labelFinalTipAmountText);
            this.pnlBillSettled.Controls.Add(this.labelFinalAmountPaidText);
            this.pnlBillSettled.Controls.Add(this.labelFinalOrderPriceText);
            this.pnlBillSettled.Controls.Add(this.labelSettled);
            this.pnlBillSettled.Controls.Add(this.labelBillHas);
            this.pnlBillSettled.Location = new System.Drawing.Point(1214, 70);
            this.pnlBillSettled.Name = "pnlBillSettled";
            this.pnlBillSettled.Size = new System.Drawing.Size(372, 555);
            this.pnlBillSettled.TabIndex = 46;
            // 
            // btnFinishPayment
            // 
            this.btnFinishPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(71)))));
            this.btnFinishPayment.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFinishPayment.Location = new System.Drawing.Point(3, 495);
            this.btnFinishPayment.Name = "btnFinishPayment";
            this.btnFinishPayment.Size = new System.Drawing.Size(366, 55);
            this.btnFinishPayment.TabIndex = 41;
            this.btnFinishPayment.Text = "FINISH PAYMENT";
            this.btnFinishPayment.UseVisualStyleBackColor = false;
            this.btnFinishPayment.Click += new System.EventHandler(this.btnFinishPayment_Click);
            // 
            // btnBackBillSettled
            // 
            this.btnBackBillSettled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(71)))));
            this.btnBackBillSettled.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBackBillSettled.Location = new System.Drawing.Point(269, 3);
            this.btnBackBillSettled.Name = "btnBackBillSettled";
            this.btnBackBillSettled.Size = new System.Drawing.Size(100, 36);
            this.btnBackBillSettled.TabIndex = 41;
            this.btnBackBillSettled.Text = "BACK";
            this.btnBackBillSettled.UseVisualStyleBackColor = false;
            this.btnBackBillSettled.Click += new System.EventHandler(this.btnBackBillSettled_Click);
            // 
            // labelChangeFinal
            // 
            this.labelChangeFinal.AutoSize = true;
            this.labelChangeFinal.Location = new System.Drawing.Point(202, 417);
            this.labelChangeFinal.Name = "labelChangeFinal";
            this.labelChangeFinal.Size = new System.Drawing.Size(97, 20);
            this.labelChangeFinal.TabIndex = 47;
            this.labelChangeFinal.Text = "hier CHANGE";
            // 
            // labelChangeFinalText
            // 
            this.labelChangeFinalText.AutoSize = true;
            this.labelChangeFinalText.Location = new System.Drawing.Point(71, 417);
            this.labelChangeFinalText.Name = "labelChangeFinalText";
            this.labelChangeFinalText.Size = new System.Drawing.Size(71, 20);
            this.labelChangeFinalText.TabIndex = 46;
            this.labelChangeFinalText.Text = "CHANGE:";
            // 
            // labelFinalVAT
            // 
            this.labelFinalVAT.AutoSize = true;
            this.labelFinalVAT.Location = new System.Drawing.Point(202, 388);
            this.labelFinalVAT.Name = "labelFinalVAT";
            this.labelFinalVAT.Size = new System.Drawing.Size(63, 20);
            this.labelFinalVAT.TabIndex = 45;
            this.labelFinalVAT.Text = "hier VAT";
            // 
            // labelFinalTipAmount
            // 
            this.labelFinalTipAmount.AutoSize = true;
            this.labelFinalTipAmount.Location = new System.Drawing.Point(202, 354);
            this.labelFinalTipAmount.Name = "labelFinalTipAmount";
            this.labelFinalTipAmount.Size = new System.Drawing.Size(111, 20);
            this.labelFinalTipAmount.TabIndex = 44;
            this.labelFinalTipAmount.Text = "hier tip amount";
            // 
            // labelFinalAmountPaid
            // 
            this.labelFinalAmountPaid.AutoSize = true;
            this.labelFinalAmountPaid.Location = new System.Drawing.Point(202, 323);
            this.labelFinalAmountPaid.Name = "labelFinalAmountPaid";
            this.labelFinalAmountPaid.Size = new System.Drawing.Size(123, 20);
            this.labelFinalAmountPaid.TabIndex = 43;
            this.labelFinalAmountPaid.Text = "hier amount paid";
            // 
            // labelFinalOrderPrice
            // 
            this.labelFinalOrderPrice.AutoSize = true;
            this.labelFinalOrderPrice.Location = new System.Drawing.Point(202, 288);
            this.labelFinalOrderPrice.Name = "labelFinalOrderPrice";
            this.labelFinalOrderPrice.Size = new System.Drawing.Size(111, 20);
            this.labelFinalOrderPrice.TabIndex = 42;
            this.labelFinalOrderPrice.Text = "hier order price";
            // 
            // labelFinalVATText
            // 
            this.labelFinalVATText.AutoSize = true;
            this.labelFinalVATText.Location = new System.Drawing.Point(68, 388);
            this.labelFinalVATText.Name = "labelFinalVATText";
            this.labelFinalVATText.Size = new System.Drawing.Size(37, 20);
            this.labelFinalVATText.TabIndex = 41;
            this.labelFinalVATText.Text = "VAT:";
            // 
            // labelFinalTipAmountText
            // 
            this.labelFinalTipAmountText.AutoSize = true;
            this.labelFinalTipAmountText.Location = new System.Drawing.Point(71, 354);
            this.labelFinalTipAmountText.Name = "labelFinalTipAmountText";
            this.labelFinalTipAmountText.Size = new System.Drawing.Size(99, 20);
            this.labelFinalTipAmountText.TabIndex = 40;
            this.labelFinalTipAmountText.Text = "TIP AMOUNT:";
            // 
            // labelFinalAmountPaidText
            // 
            this.labelFinalAmountPaidText.AutoSize = true;
            this.labelFinalAmountPaidText.Location = new System.Drawing.Point(71, 323);
            this.labelFinalAmountPaidText.Name = "labelFinalAmountPaidText";
            this.labelFinalAmountPaidText.Size = new System.Drawing.Size(111, 20);
            this.labelFinalAmountPaidText.TabIndex = 39;
            this.labelFinalAmountPaidText.Text = "AMOUNT PAID:";
            // 
            // labelFinalOrderPriceText
            // 
            this.labelFinalOrderPriceText.AutoSize = true;
            this.labelFinalOrderPriceText.Location = new System.Drawing.Point(71, 288);
            this.labelFinalOrderPriceText.Name = "labelFinalOrderPriceText";
            this.labelFinalOrderPriceText.Size = new System.Drawing.Size(102, 20);
            this.labelFinalOrderPriceText.TabIndex = 15;
            this.labelFinalOrderPriceText.Text = "ORDER PRICE:";
            // 
            // labelSettled
            // 
            this.labelSettled.AutoSize = true;
            this.labelSettled.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSettled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(210)))), ((int)(((byte)(176)))));
            this.labelSettled.Location = new System.Drawing.Point(114, 211);
            this.labelSettled.Name = "labelSettled";
            this.labelSettled.Size = new System.Drawing.Size(151, 41);
            this.labelSettled.TabIndex = 38;
            this.labelSettled.Text = "SETTLED!";
            // 
            // labelBillHas
            // 
            this.labelBillHas.AutoSize = true;
            this.labelBillHas.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBillHas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(210)))), ((int)(((byte)(176)))));
            this.labelBillHas.Location = new System.Drawing.Point(43, 155);
            this.labelBillHas.Name = "labelBillHas";
            this.labelBillHas.Size = new System.Drawing.Size(294, 41);
            this.labelBillHas.TabIndex = 37;
            this.labelBillHas.Text = "THE BILL HAS BEEN";
            // 
            // pnlAddComment
            // 
            this.pnlAddComment.Controls.Add(this.btnContinueWithPayment);
            this.pnlAddComment.Controls.Add(this.btnBackComment);
            this.pnlAddComment.Controls.Add(this.labelCommendSaved);
            this.pnlAddComment.Controls.Add(this.btnConfirmComment);
            this.pnlAddComment.Controls.Add(this.labelCustomerComment);
            this.pnlAddComment.Controls.Add(this.labelTypeComment);
            this.pnlAddComment.Location = new System.Drawing.Point(814, 70);
            this.pnlAddComment.Name = "pnlAddComment";
            this.pnlAddComment.Size = new System.Drawing.Size(372, 555);
            this.pnlAddComment.TabIndex = 45;
            // 
            // btnContinueWithPayment
            // 
            this.btnContinueWithPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(71)))));
            this.btnContinueWithPayment.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnContinueWithPayment.Location = new System.Drawing.Point(3, 495);
            this.btnContinueWithPayment.Name = "btnContinueWithPayment";
            this.btnContinueWithPayment.Size = new System.Drawing.Size(366, 55);
            this.btnContinueWithPayment.TabIndex = 40;
            this.btnContinueWithPayment.Text = "CONTINUE WITH PAYMENT";
            this.btnContinueWithPayment.UseVisualStyleBackColor = false;
            this.btnContinueWithPayment.Click += new System.EventHandler(this.btnContinueWithPayment_Click);
            // 
            // btnBackComment
            // 
            this.btnBackComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(71)))));
            this.btnBackComment.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBackComment.Location = new System.Drawing.Point(269, 3);
            this.btnBackComment.Name = "btnBackComment";
            this.btnBackComment.Size = new System.Drawing.Size(100, 36);
            this.btnBackComment.TabIndex = 36;
            this.btnBackComment.Text = "BACK";
            this.btnBackComment.UseVisualStyleBackColor = false;
            this.btnBackComment.Click += new System.EventHandler(this.btnBackComment_Click);
            // 
            // labelCommendSaved
            // 
            this.labelCommendSaved.AutoSize = true;
            this.labelCommendSaved.Location = new System.Drawing.Point(32, 388);
            this.labelCommendSaved.Name = "labelCommendSaved";
            this.labelCommendSaved.Size = new System.Drawing.Size(0, 20);
            this.labelCommendSaved.TabIndex = 22;
            // 
            // btnConfirmComment
            // 
            this.btnConfirmComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(210)))), ((int)(((byte)(176)))));
            this.btnConfirmComment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmComment.Location = new System.Drawing.Point(6, 428);
            this.btnConfirmComment.Name = "btnConfirmComment";
            this.btnConfirmComment.Size = new System.Drawing.Size(366, 55);
            this.btnConfirmComment.TabIndex = 21;
            this.btnConfirmComment.Text = "SAVE COMMENT";
            this.btnConfirmComment.UseVisualStyleBackColor = false;
            this.btnConfirmComment.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelCustomerComment
            // 
            this.labelCustomerComment.Location = new System.Drawing.Point(16, 143);
            this.labelCustomerComment.Name = "labelCustomerComment";
            this.labelCustomerComment.Size = new System.Drawing.Size(340, 231);
            this.labelCustomerComment.TabIndex = 20;
            this.labelCustomerComment.Text = "";
            // 
            // labelTypeComment
            // 
            this.labelTypeComment.AutoSize = true;
            this.labelTypeComment.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTypeComment.Location = new System.Drawing.Point(22, 103);
            this.labelTypeComment.Name = "labelTypeComment";
            this.labelTypeComment.Size = new System.Drawing.Size(334, 25);
            this.labelTypeComment.TabIndex = 19;
            this.labelTypeComment.Text = "TYPE CUSTOMERS COMMENT HERE:";
            // 
            // pnlBillPayment
            // 
            this.pnlBillPayment.Controls.Add(this.labelTotalTip);
            this.pnlBillPayment.Controls.Add(this.labelChangeTotalTip);
            this.pnlBillPayment.Controls.Add(this.btnBackPayment);
            this.pnlBillPayment.Controls.Add(this.btnPay);
            this.pnlBillPayment.Controls.Add(this.btnSetTip);
            this.pnlBillPayment.Controls.Add(this.txtBoxCustomTip);
            this.pnlBillPayment.Controls.Add(this.btnAddChangeToTip);
            this.pnlBillPayment.Controls.Add(this.labelCustomTip);
            this.pnlBillPayment.Controls.Add(this.labelTIP);
            this.pnlBillPayment.Controls.Add(this.labelChange);
            this.pnlBillPayment.Controls.Add(this.labelChangeText);
            this.pnlBillPayment.Controls.Add(this.btnSetPrices);
            this.pnlBillPayment.Controls.Add(this.txtBoxAmountPaid);
            this.pnlBillPayment.Controls.Add(this.labelAmountPaid);
            this.pnlBillPayment.Controls.Add(this.labelOrderPricePayment);
            this.pnlBillPayment.Controls.Add(this.labelOrderPricePaymentText);
            this.pnlBillPayment.Controls.Add(this.labelPayment);
            this.pnlBillPayment.Location = new System.Drawing.Point(414, 70);
            this.pnlBillPayment.Name = "pnlBillPayment";
            this.pnlBillPayment.Size = new System.Drawing.Size(372, 555);
            this.pnlBillPayment.TabIndex = 44;
            // 
            // labelTotalTip
            // 
            this.labelTotalTip.AutoSize = true;
            this.labelTotalTip.Location = new System.Drawing.Point(304, 455);
            this.labelTotalTip.Name = "labelTotalTip";
            this.labelTotalTip.Size = new System.Drawing.Size(0, 20);
            this.labelTotalTip.TabIndex = 39;
            // 
            // labelChangeTotalTip
            // 
            this.labelChangeTotalTip.AutoSize = true;
            this.labelChangeTotalTip.Location = new System.Drawing.Point(6, 455);
            this.labelChangeTotalTip.Name = "labelChangeTotalTip";
            this.labelChangeTotalTip.Size = new System.Drawing.Size(32, 20);
            this.labelChangeTotalTip.TabIndex = 38;
            this.labelChangeTotalTip.Text = "TIP:";
            // 
            // btnBackPayment
            // 
            this.btnBackPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(71)))));
            this.btnBackPayment.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBackPayment.Location = new System.Drawing.Point(269, 3);
            this.btnBackPayment.Name = "btnBackPayment";
            this.btnBackPayment.Size = new System.Drawing.Size(100, 36);
            this.btnBackPayment.TabIndex = 37;
            this.btnBackPayment.Text = "BACK";
            this.btnBackPayment.UseVisualStyleBackColor = false;
            this.btnBackPayment.Click += new System.EventHandler(this.btnBackPayment_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(71)))));
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPay.Location = new System.Drawing.Point(3, 495);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(366, 55);
            this.btnPay.TabIndex = 34;
            this.btnPay.Text = "PAY";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnSetTip
            // 
            this.btnSetTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(210)))), ((int)(((byte)(176)))));
            this.btnSetTip.Location = new System.Drawing.Point(289, 388);
            this.btnSetTip.Name = "btnSetTip";
            this.btnSetTip.Size = new System.Drawing.Size(66, 29);
            this.btnSetTip.TabIndex = 33;
            this.btnSetTip.Text = "SET";
            this.btnSetTip.UseVisualStyleBackColor = false;
            this.btnSetTip.Click += new System.EventHandler(this.btnSetTip_Click);
            // 
            // txtBoxCustomTip
            // 
            this.txtBoxCustomTip.Location = new System.Drawing.Point(201, 339);
            this.txtBoxCustomTip.Name = "txtBoxCustomTip";
            this.txtBoxCustomTip.Size = new System.Drawing.Size(154, 27);
            this.txtBoxCustomTip.TabIndex = 32;
            // 
            // btnAddChangeToTip
            // 
            this.btnAddChangeToTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(210)))), ((int)(((byte)(176)))));
            this.btnAddChangeToTip.Location = new System.Drawing.Point(3, 288);
            this.btnAddChangeToTip.Name = "btnAddChangeToTip";
            this.btnAddChangeToTip.Size = new System.Drawing.Size(366, 41);
            this.btnAddChangeToTip.TabIndex = 31;
            this.btnAddChangeToTip.Text = "ADD CHANGE TO TIP:";
            this.btnAddChangeToTip.UseVisualStyleBackColor = false;
            this.btnAddChangeToTip.Click += new System.EventHandler(this.btnAddChangeToTip_Click);
            // 
            // labelCustomTip
            // 
            this.labelCustomTip.AutoSize = true;
            this.labelCustomTip.Location = new System.Drawing.Point(0, 339);
            this.labelCustomTip.Name = "labelCustomTip";
            this.labelCustomTip.Size = new System.Drawing.Size(94, 20);
            this.labelCustomTip.TabIndex = 30;
            this.labelCustomTip.Text = "CUSTOM TIP:";
            // 
            // labelTIP
            // 
            this.labelTIP.AutoSize = true;
            this.labelTIP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTIP.Location = new System.Drawing.Point(3, 253);
            this.labelTIP.Name = "labelTIP";
            this.labelTIP.Size = new System.Drawing.Size(42, 28);
            this.labelTIP.TabIndex = 29;
            this.labelTIP.Text = "TIP";
            // 
            // labelChange
            // 
            this.labelChange.AutoSize = true;
            this.labelChange.Location = new System.Drawing.Point(304, 194);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(0, 20);
            this.labelChange.TabIndex = 28;
            // 
            // labelChangeText
            // 
            this.labelChangeText.AutoSize = true;
            this.labelChangeText.Location = new System.Drawing.Point(6, 194);
            this.labelChangeText.Name = "labelChangeText";
            this.labelChangeText.Size = new System.Drawing.Size(71, 20);
            this.labelChangeText.TabIndex = 27;
            this.labelChangeText.Text = "CHANGE:";
            // 
            // btnSetPrices
            // 
            this.btnSetPrices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(210)))), ((int)(((byte)(176)))));
            this.btnSetPrices.Location = new System.Drawing.Point(290, 140);
            this.btnSetPrices.Name = "btnSetPrices";
            this.btnSetPrices.Size = new System.Drawing.Size(66, 29);
            this.btnSetPrices.TabIndex = 26;
            this.btnSetPrices.Text = "SET";
            this.btnSetPrices.UseVisualStyleBackColor = false;
            this.btnSetPrices.Click += new System.EventHandler(this.btnSetPrices_Click);
            // 
            // txtBoxAmountPaid
            // 
            this.txtBoxAmountPaid.Location = new System.Drawing.Point(202, 101);
            this.txtBoxAmountPaid.Name = "txtBoxAmountPaid";
            this.txtBoxAmountPaid.Size = new System.Drawing.Size(154, 27);
            this.txtBoxAmountPaid.TabIndex = 25;
            // 
            // labelAmountPaid
            // 
            this.labelAmountPaid.AutoSize = true;
            this.labelAmountPaid.Location = new System.Drawing.Point(3, 100);
            this.labelAmountPaid.Name = "labelAmountPaid";
            this.labelAmountPaid.Size = new System.Drawing.Size(111, 20);
            this.labelAmountPaid.TabIndex = 24;
            this.labelAmountPaid.Text = "AMOUNT PAID:";
            // 
            // labelOrderPricePayment
            // 
            this.labelOrderPricePayment.AutoSize = true;
            this.labelOrderPricePayment.Location = new System.Drawing.Point(304, 69);
            this.labelOrderPricePayment.Name = "labelOrderPricePayment";
            this.labelOrderPricePayment.Size = new System.Drawing.Size(51, 20);
            this.labelOrderPricePayment.TabIndex = 23;
            this.labelOrderPricePayment.Text = "xxxxxx";
            // 
            // labelOrderPricePaymentText
            // 
            this.labelOrderPricePaymentText.AutoSize = true;
            this.labelOrderPricePaymentText.Location = new System.Drawing.Point(3, 69);
            this.labelOrderPricePaymentText.Name = "labelOrderPricePaymentText";
            this.labelOrderPricePaymentText.Size = new System.Drawing.Size(102, 20);
            this.labelOrderPricePaymentText.TabIndex = 22;
            this.labelOrderPricePaymentText.Text = "ORDER PRICE:";
            // 
            // labelPayment
            // 
            this.labelPayment.AutoSize = true;
            this.labelPayment.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPayment.Location = new System.Drawing.Point(0, 0);
            this.labelPayment.Name = "labelPayment";
            this.labelPayment.Size = new System.Drawing.Size(132, 35);
            this.labelPayment.TabIndex = 21;
            this.labelPayment.Text = "PAYMENT";
            // 
            // pnlBillView
            // 
            this.pnlBillView.Controls.Add(this.btnSplit);
            this.pnlBillView.Controls.Add(this.btnBackOrderOverview);
            this.pnlBillView.Controls.Add(this.labelBill);
            this.pnlBillView.Controls.Add(this.labelChoosePayment);
            this.pnlBillView.Controls.Add(this.btnProceedToPayment);
            this.pnlBillView.Controls.Add(this.btnDebit);
            this.pnlBillView.Controls.Add(this.listViewBillOverview);
            this.pnlBillView.Controls.Add(this.btnVisa);
            this.pnlBillView.Controls.Add(this.labelVAT);
            this.pnlBillView.Controls.Add(this.btnCash);
            this.pnlBillView.Controls.Add(this.labelOrderPrice);
            this.pnlBillView.Controls.Add(this.labelOrderPriceText);
            this.pnlBillView.Controls.Add(this.labelVATText);
            this.pnlBillView.Location = new System.Drawing.Point(12, 70);
            this.pnlBillView.Name = "pnlBillView";
            this.pnlBillView.Size = new System.Drawing.Size(372, 555);
            this.pnlBillView.TabIndex = 43;
            // 
            // btnSplit
            // 
            this.btnSplit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(71)))));
            this.btnSplit.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSplit.Location = new System.Drawing.Point(275, 495);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(97, 55);
            this.btnSplit.TabIndex = 39;
            this.btnSplit.Text = "SPLIT";
            this.btnSplit.UseVisualStyleBackColor = false;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // btnBackOrderOverview
            // 
            this.btnBackOrderOverview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(71)))));
            this.btnBackOrderOverview.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBackOrderOverview.Location = new System.Drawing.Point(272, 0);
            this.btnBackOrderOverview.Name = "btnBackOrderOverview";
            this.btnBackOrderOverview.Size = new System.Drawing.Size(100, 36);
            this.btnBackOrderOverview.TabIndex = 38;
            this.btnBackOrderOverview.Text = "BACK";
            this.btnBackOrderOverview.UseVisualStyleBackColor = false;
            this.btnBackOrderOverview.Click += new System.EventHandler(this.btnBackOrderOverview_Click);
            // 
            // labelBill
            // 
            this.labelBill.AutoSize = true;
            this.labelBill.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBill.Location = new System.Drawing.Point(13, 0);
            this.labelBill.Name = "labelBill";
            this.labelBill.Size = new System.Drawing.Size(65, 35);
            this.labelBill.TabIndex = 0;
            this.labelBill.Text = "BILL";
            // 
            // labelChoosePayment
            // 
            this.labelChoosePayment.AutoSize = true;
            this.labelChoosePayment.Location = new System.Drawing.Point(13, 339);
            this.labelChoosePayment.Name = "labelChoosePayment";
            this.labelChoosePayment.Size = new System.Drawing.Size(174, 20);
            this.labelChoosePayment.TabIndex = 14;
            this.labelChoosePayment.Text = "CHOOSE PAYMENT TYPE:";
            // 
            // btnProceedToPayment
            // 
            this.btnProceedToPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(210)))), ((int)(((byte)(176)))));
            this.btnProceedToPayment.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProceedToPayment.Location = new System.Drawing.Point(3, 495);
            this.btnProceedToPayment.Name = "btnProceedToPayment";
            this.btnProceedToPayment.Size = new System.Drawing.Size(275, 55);
            this.btnProceedToPayment.TabIndex = 2;
            this.btnProceedToPayment.Text = "PROCEED TO PAYMENT";
            this.btnProceedToPayment.UseVisualStyleBackColor = false;
            this.btnProceedToPayment.Click += new System.EventHandler(this.btnProceedToPayment_Click);
            // 
            // btnDebit
            // 
            this.btnDebit.BackColor = System.Drawing.SystemColors.Window;
            this.btnDebit.Location = new System.Drawing.Point(13, 363);
            this.btnDebit.Name = "btnDebit";
            this.btnDebit.Size = new System.Drawing.Size(94, 29);
            this.btnDebit.TabIndex = 3;
            this.btnDebit.Text = "DEBIT";
            this.btnDebit.UseVisualStyleBackColor = false;
            this.btnDebit.Click += new System.EventHandler(this.btnDebit_Click);
            // 
            // listViewBillOverview
            // 
            this.listViewBillOverview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AmountColumn});
            this.listViewBillOverview.Location = new System.Drawing.Point(13, 38);
            this.listViewBillOverview.Name = "listViewBillOverview";
            this.listViewBillOverview.Size = new System.Drawing.Size(344, 282);
            this.listViewBillOverview.TabIndex = 10;
            this.listViewBillOverview.UseCompatibleStateImageBehavior = false;
            this.listViewBillOverview.View = System.Windows.Forms.View.Details;
            // 
            // AmountColumn
            // 
            this.AmountColumn.Text = "Amount";
            // 
            // btnVisa
            // 
            this.btnVisa.Location = new System.Drawing.Point(139, 363);
            this.btnVisa.Name = "btnVisa";
            this.btnVisa.Size = new System.Drawing.Size(94, 29);
            this.btnVisa.TabIndex = 4;
            this.btnVisa.Text = "VISA/AMEX";
            this.btnVisa.UseVisualStyleBackColor = true;
            this.btnVisa.Click += new System.EventHandler(this.btnVisa_Click);
            // 
            // labelVAT
            // 
            this.labelVAT.AutoSize = true;
            this.labelVAT.Location = new System.Drawing.Point(306, 448);
            this.labelVAT.Name = "labelVAT";
            this.labelVAT.Size = new System.Drawing.Size(51, 20);
            this.labelVAT.TabIndex = 9;
            this.labelVAT.Text = "xxxxxx";
            // 
            // btnCash
            // 
            this.btnCash.Location = new System.Drawing.Point(263, 363);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(94, 29);
            this.btnCash.TabIndex = 5;
            this.btnCash.Text = "CASH";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // labelOrderPrice
            // 
            this.labelOrderPrice.AutoSize = true;
            this.labelOrderPrice.Location = new System.Drawing.Point(306, 417);
            this.labelOrderPrice.Name = "labelOrderPrice";
            this.labelOrderPrice.Size = new System.Drawing.Size(51, 20);
            this.labelOrderPrice.TabIndex = 8;
            this.labelOrderPrice.Text = "xxxxxx";
            // 
            // labelOrderPriceText
            // 
            this.labelOrderPriceText.AutoSize = true;
            this.labelOrderPriceText.Location = new System.Drawing.Point(13, 417);
            this.labelOrderPriceText.Name = "labelOrderPriceText";
            this.labelOrderPriceText.Size = new System.Drawing.Size(102, 20);
            this.labelOrderPriceText.TabIndex = 6;
            this.labelOrderPriceText.Text = "ORDER PRICE:";
            // 
            // labelVATText
            // 
            this.labelVATText.AutoSize = true;
            this.labelVATText.Location = new System.Drawing.Point(13, 448);
            this.labelVATText.Name = "labelVATText";
            this.labelVATText.Size = new System.Drawing.Size(37, 20);
            this.labelVATText.TabIndex = 7;
            this.labelVATText.Text = "VAT:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 62);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // pnlSplitBill
            // 
            this.pnlSplitBill.Controls.Add(this.txtBoxAmountPeopleSplitting);
            this.pnlSplitBill.Controls.Add(this.btnBackPaymentFromSplit);
            this.pnlSplitBill.Controls.Add(this.labelBillSpitting);
            this.pnlSplitBill.Controls.Add(this.btnProceedSplitting);
            this.pnlSplitBill.Controls.Add(this.label5);
            this.pnlSplitBill.Location = new System.Drawing.Point(12, 642);
            this.pnlSplitBill.Name = "pnlSplitBill";
            this.pnlSplitBill.Size = new System.Drawing.Size(372, 555);
            this.pnlSplitBill.TabIndex = 44;
            // 
            // txtBoxAmountPeopleSplitting
            // 
            this.txtBoxAmountPeopleSplitting.Location = new System.Drawing.Point(87, 219);
            this.txtBoxAmountPeopleSplitting.Name = "txtBoxAmountPeopleSplitting";
            this.txtBoxAmountPeopleSplitting.Size = new System.Drawing.Size(181, 27);
            this.txtBoxAmountPeopleSplitting.TabIndex = 39;
            // 
            // btnBackPaymentFromSplit
            // 
            this.btnBackPaymentFromSplit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(71)))));
            this.btnBackPaymentFromSplit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBackPaymentFromSplit.Location = new System.Drawing.Point(272, 0);
            this.btnBackPaymentFromSplit.Name = "btnBackPaymentFromSplit";
            this.btnBackPaymentFromSplit.Size = new System.Drawing.Size(100, 36);
            this.btnBackPaymentFromSplit.TabIndex = 38;
            this.btnBackPaymentFromSplit.Text = "BACK";
            this.btnBackPaymentFromSplit.UseVisualStyleBackColor = false;
            this.btnBackPaymentFromSplit.Click += new System.EventHandler(this.btnBackPaymentFromSplit_Click);
            // 
            // labelBillSpitting
            // 
            this.labelBillSpitting.AutoSize = true;
            this.labelBillSpitting.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBillSpitting.Location = new System.Drawing.Point(13, 0);
            this.labelBillSpitting.Name = "labelBillSpitting";
            this.labelBillSpitting.Size = new System.Drawing.Size(144, 35);
            this.labelBillSpitting.TabIndex = 0;
            this.labelBillSpitting.Text = " BILL SPLIT";
            // 
            // btnProceedSplitting
            // 
            this.btnProceedSplitting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(210)))), ((int)(((byte)(176)))));
            this.btnProceedSplitting.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProceedSplitting.Location = new System.Drawing.Point(3, 495);
            this.btnProceedSplitting.Name = "btnProceedSplitting";
            this.btnProceedSplitting.Size = new System.Drawing.Size(366, 55);
            this.btnProceedSplitting.TabIndex = 2;
            this.btnProceedSplitting.Text = "PROCEED WITH SPLITTING";
            this.btnProceedSplitting.UseVisualStyleBackColor = false;
            this.btnProceedSplitting.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(210)))), ((int)(((byte)(176)))));
            this.label5.Location = new System.Drawing.Point(23, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(322, 31);
            this.label5.TabIndex = 6;
            this.label5.Text = "Amount people for splitting:";
            // 
            // BillViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.pnlSplitBill);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlBillSettled);
            this.Controls.Add(this.pnlAddComment);
            this.Controls.Add(this.pnlBillPayment);
            this.Controls.Add(this.pnlBillView);
            this.Name = "BillViewForm";
            this.Text = "BillViewForm";
            this.pnlBillSettled.ResumeLayout(false);
            this.pnlBillSettled.PerformLayout();
            this.pnlAddComment.ResumeLayout(false);
            this.pnlAddComment.PerformLayout();
            this.pnlBillPayment.ResumeLayout(false);
            this.pnlBillPayment.PerformLayout();
            this.pnlBillView.ResumeLayout(false);
            this.pnlBillView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlSplitBill.ResumeLayout(false);
            this.pnlSplitBill.PerformLayout();
            this.ResumeLayout(false);

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
        private RichTextBox labelCustomerComment;
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