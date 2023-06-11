namespace ChapeauUI
{
    partial class OrderOverview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderOverview));
            label1 = new Label();
            lblEmployee = new Label();
            btnDrinks = new Button();
            btnDinner = new Button();
            btnLunch = new Button();
            label2 = new Label();
            label3 = new Label();
            listViewOrderOverview = new ListView();
            btnPay = new Button();
            lblTotal = new Label();
            lblVat = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(7, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 0);
            label1.TabIndex = 3;
            label1.Text = " ";
            // 
            // lblEmployee
            // 
            lblEmployee.BackColor = Color.FromArgb(255, 179, 71);
            lblEmployee.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmployee.Location = new Point(296, 7);
            lblEmployee.Margin = new Padding(0);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(86, 40);
            lblEmployee.TabIndex = 12;
            lblEmployee.Text = "Naam";
            lblEmployee.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDrinks
            // 
            btnDrinks.BackColor = Color.FromArgb(138, 210, 176);
            btnDrinks.ForeColor = Color.Black;
            btnDrinks.Location = new Point(277, 89);
            btnDrinks.Name = "btnDrinks";
            btnDrinks.Size = new Size(90, 50);
            btnDrinks.TabIndex = 11;
            btnDrinks.Text = "DRINKS";
            btnDrinks.UseVisualStyleBackColor = false;
            btnDrinks.Click += btnDrinks_Click;
            // 
            // btnDinner
            // 
            btnDinner.BackColor = Color.FromArgb(138, 210, 176);
            btnDinner.Location = new Point(145, 89);
            btnDinner.Name = "btnDinner";
            btnDinner.Size = new Size(90, 50);
            btnDinner.TabIndex = 10;
            btnDinner.Text = "DINNER";
            btnDinner.UseVisualStyleBackColor = false;
            btnDinner.Click += btnDinner_Click;
            // 
            // btnLunch
            // 
            btnLunch.BackColor = Color.FromArgb(138, 210, 176);
            btnLunch.Location = new Point(10, 89);
            btnLunch.Name = "btnLunch";
            btnLunch.Size = new Size(90, 50);
            btnLunch.TabIndex = 9;
            btnLunch.Text = "LUNCH";
            btnLunch.UseVisualStyleBackColor = false;
            btnLunch.Click += btnLunch_Click;
            // 
            // label2
            // 
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(10, 7);
            label2.Name = "label2";
            label2.Size = new Size(131, 66);
            label2.TabIndex = 8;
            label2.Text = " ";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(134, 16);
            label3.Name = "label3";
            label3.Size = new Size(124, 45);
            label3.TabIndex = 7;
            label3.Text = "TAFEL #1";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listViewOrderOverview
            // 
            listViewOrderOverview.Location = new Point(12, 177);
            listViewOrderOverview.Name = "listViewOrderOverview";
            listViewOrderOverview.Size = new Size(370, 265);
            listViewOrderOverview.TabIndex = 13;
            listViewOrderOverview.UseCompatibleStateImageBehavior = false;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.FromArgb(255, 179, 71);
            btnPay.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPay.Location = new Point(260, 548);
            btnPay.Margin = new Padding(0);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(127, 49);
            btnPay.TabIndex = 14;
            btnPay.Text = "PAY";
            btnPay.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(171, 461);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(87, 35);
            lblTotal.TabIndex = 15;
            lblTotal.Text = "Total: ";
            // 
            // lblVat
            // 
            lblVat.AutoSize = true;
            lblVat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblVat.Location = new Point(209, 496);
            lblVat.Name = "lblVat";
            lblVat.Size = new Size(54, 28);
            lblVat.TabIndex = 16;
            lblVat.Text = "VAT:";
            // 
            // OrderOverview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(396, 606);
            Controls.Add(lblVat);
            Controls.Add(lblTotal);
            Controls.Add(btnPay);
            Controls.Add(listViewOrderOverview);
            Controls.Add(lblEmployee);
            Controls.Add(btnDrinks);
            Controls.Add(btnDinner);
            Controls.Add(btnLunch);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "OrderOverview";
            Text = "OrderOverview";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblEmployee;
        private Button btnDrinks;
        private Button btnDinner;
        private Button btnLunch;
        private Label label2;
        private Label label3;
        private ListView listViewOrderOverview;
        private Button btnPay;
        private Label lblTotal;
        private Label lblVat;
    }
}