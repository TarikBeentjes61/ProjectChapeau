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
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.btnDrinks = new System.Windows.Forms.Button();
            this.btnDinner = new System.Windows.Forms.Button();
            this.btnLunch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listViewOrderOverview = new System.Windows.Forms.ListView();
            this.Amount = new System.Windows.Forms.ColumnHeader();
            this.columnName = new System.Windows.Forms.ColumnHeader();
            this.columnPrice = new System.Windows.Forms.ColumnHeader();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 0);
            this.label1.TabIndex = 3;
            this.label1.Text = " ";
            // 
            // lblEmployee
            // 
            this.lblEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(71)))));
            this.lblEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmployee.Location = new System.Drawing.Point(296, 7);
            this.lblEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(86, 40);
            this.lblEmployee.TabIndex = 12;
            this.lblEmployee.Text = "Naam";
            this.lblEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDrinks
            // 
            this.btnDrinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(210)))), ((int)(((byte)(176)))));
            this.btnDrinks.ForeColor = System.Drawing.Color.Black;
            this.btnDrinks.Location = new System.Drawing.Point(277, 89);
            this.btnDrinks.Name = "btnDrinks";
            this.btnDrinks.Size = new System.Drawing.Size(90, 50);
            this.btnDrinks.TabIndex = 11;
            this.btnDrinks.Text = "DRINKS";
            this.btnDrinks.UseVisualStyleBackColor = false;
            // 
            // btnDinner
            // 
            this.btnDinner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(210)))), ((int)(((byte)(176)))));
            this.btnDinner.Location = new System.Drawing.Point(145, 89);
            this.btnDinner.Name = "btnDinner";
            this.btnDinner.Size = new System.Drawing.Size(90, 50);
            this.btnDinner.TabIndex = 10;
            this.btnDinner.Text = "DINNER";
            this.btnDinner.UseVisualStyleBackColor = false;
            // 
            // btnLunch
            // 
            this.btnLunch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(210)))), ((int)(((byte)(176)))));
            this.btnLunch.Location = new System.Drawing.Point(10, 89);
            this.btnLunch.Name = "btnLunch";
            this.btnLunch.Size = new System.Drawing.Size(90, 50);
            this.btnLunch.TabIndex = 9;
            this.btnLunch.Text = "LUNCH";
            this.btnLunch.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(10, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 66);
            this.label2.TabIndex = 8;
            this.label2.Text = " ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(134, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 45);
            this.label3.TabIndex = 7;
            this.label3.Text = "TAFEL #1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewOrderOverview
            // 
            this.listViewOrderOverview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Amount,
            this.columnName,
            this.columnPrice});
            this.listViewOrderOverview.Location = new System.Drawing.Point(12, 177);
            this.listViewOrderOverview.Name = "listViewOrderOverview";
            this.listViewOrderOverview.Size = new System.Drawing.Size(370, 265);
            this.listViewOrderOverview.TabIndex = 13;
            this.listViewOrderOverview.UseCompatibleStateImageBehavior = false;
            this.listViewOrderOverview.View = System.Windows.Forms.View.Details;

            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.Width = 80;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Price";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(71)))));
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPay.Location = new System.Drawing.Point(260, 548);
            this.btnPay.Margin = new System.Windows.Forms.Padding(0);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(127, 49);
            this.btnPay.TabIndex = 14;
            this.btnPay.Text = "PAY";
            this.btnPay.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(171, 461);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(87, 35);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "Total: ";
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVat.Location = new System.Drawing.Point(209, 496);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(54, 28);
            this.lblVat.TabIndex = 16;
            this.lblVat.Text = "VAT:";
            // 
            // OrderOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(396, 606);
            this.Controls.Add(this.lblVat);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.listViewOrderOverview);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.btnDrinks);
            this.Controls.Add(this.btnDinner);
            this.Controls.Add(this.btnLunch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "OrderOverview";
            this.Text = "OrderOverview";
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private ColumnHeader Amount;
        private ColumnHeader columnName;
        private ColumnHeader columnPrice;
    }
}