namespace ChapeauUI
{
    partial class CreateOrderForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TafelLabel = new System.Windows.Forms.Label();
            this.CurrentLoginButton = new System.Windows.Forms.Button();
            this.LunchButton = new System.Windows.Forms.Button();
            this.DinnerButton = new System.Windows.Forms.Button();
            this.DrinksButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.numberHeader = new System.Windows.Forms.ColumnHeader();
            this.nameHeader = new System.Windows.Forms.ColumnHeader();
            this.priceHeader = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.VatLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TafelLabel
            // 
            this.TafelLabel.AutoSize = true;
            this.TafelLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TafelLabel.Location = new System.Drawing.Point(129, 9);
            this.TafelLabel.Name = "TafelLabel";
            this.TafelLabel.Size = new System.Drawing.Size(117, 46);
            this.TafelLabel.TabIndex = 0;
            this.TafelLabel.Text = "Tafel #";
            // 
            // CurrentLoginButton
            // 
            this.CurrentLoginButton.Location = new System.Drawing.Point(273, 12);
            this.CurrentLoginButton.Name = "CurrentLoginButton";
            this.CurrentLoginButton.Size = new System.Drawing.Size(111, 43);
            this.CurrentLoginButton.TabIndex = 1;
            this.CurrentLoginButton.Text = "Login";
            this.CurrentLoginButton.UseVisualStyleBackColor = true;
            // 
            // LunchButton
            // 
            this.LunchButton.Location = new System.Drawing.Point(12, 77);
            this.LunchButton.Name = "LunchButton";
            this.LunchButton.Size = new System.Drawing.Size(111, 43);
            this.LunchButton.TabIndex = 2;
            this.LunchButton.Text = "Lunch";
            this.LunchButton.UseVisualStyleBackColor = true;
            // 
            // DinnerButton
            // 
            this.DinnerButton.Location = new System.Drawing.Point(144, 77);
            this.DinnerButton.Name = "DinnerButton";
            this.DinnerButton.Size = new System.Drawing.Size(111, 43);
            this.DinnerButton.TabIndex = 3;
            this.DinnerButton.Text = "Dinner";
            this.DinnerButton.UseVisualStyleBackColor = true;
            // 
            // DrinksButton
            // 
            this.DrinksButton.Location = new System.Drawing.Point(273, 77);
            this.DrinksButton.Name = "DrinksButton";
            this.DrinksButton.Size = new System.Drawing.Size(111, 43);
            this.DrinksButton.TabIndex = 4;
            this.DrinksButton.Text = "Drinks";
            this.DrinksButton.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.numberHeader,
            this.nameHeader,
            this.priceHeader});
            this.listView1.Location = new System.Drawing.Point(12, 197);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(372, 288);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // numberHeader
            // 
            this.numberHeader.Text = "no";
            this.numberHeader.Width = 50;
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "name";
            this.nameHeader.Width = 235;
            // 
            // priceHeader
            // 
            this.priceHeader.Text = "price";
            this.priceHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.priceHeader.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Order";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalLabel.Location = new System.Drawing.Point(244, 542);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(77, 32);
            this.TotalLabel.TabIndex = 7;
            this.TotalLabel.Text = "Total: ";
            // 
            // VatLabel
            // 
            this.VatLabel.AutoSize = true;
            this.VatLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VatLabel.Location = new System.Drawing.Point(244, 588);
            this.VatLabel.Name = "VatLabel";
            this.VatLabel.Size = new System.Drawing.Size(59, 32);
            this.VatLabel.TabIndex = 8;
            this.VatLabel.Text = "Vat: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 634);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "Pay";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CreateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(396, 689);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.VatLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.DrinksButton);
            this.Controls.Add(this.DinnerButton);
            this.Controls.Add(this.LunchButton);
            this.Controls.Add(this.CurrentLoginButton);
            this.Controls.Add(this.TafelLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CreateOrderForm";
            this.Text = "Create Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TafelLabel;
        private Button CurrentLoginButton;
        private Button LunchButton;
        private Button DinnerButton;
        private Button DrinksButton;
        private ListView listView1;
        private ColumnHeader numberHeader;
        private ColumnHeader nameHeader;
        private ColumnHeader priceHeader;
        private Label label1;
        private Label TotalLabel;
        private Label VatLabel;
        private Button button1;
    }
}