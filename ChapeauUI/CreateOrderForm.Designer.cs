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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateOrderForm));
            lblTable = new Label();
            label1 = new Label();
            btnLunch = new Button();
            btnDinner = new Button();
            btnDrinks = new Button();
            lblEmployee = new Label();
            orderListView = new ListView();
            label3 = new Label();
            listView1 = new ListView();
            listView2 = new ListView();
            listView3 = new ListView();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // lblTable
            // 
            lblTable.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblTable.Location = new Point(136, 18);
            lblTable.Name = "lblTable";
            lblTable.Size = new Size(124, 45);
            lblTable.TabIndex = 1;
            lblTable.Text = "TAFEL #1";
            lblTable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(131, 66);
            label1.TabIndex = 2;
            label1.Text = " ";
            // 
            // btnLunch
            // 
            btnLunch.BackColor = Color.FromArgb(138, 210, 176);
            btnLunch.Location = new Point(12, 91);
            btnLunch.Name = "btnLunch";
            btnLunch.Size = new Size(90, 50);
            btnLunch.TabIndex = 3;
            btnLunch.Text = "LUNCH";
            btnLunch.UseVisualStyleBackColor = false;
            // 
            // btnDinner
            // 
            btnDinner.BackColor = Color.FromArgb(138, 210, 176);
            btnDinner.Location = new Point(147, 91);
            btnDinner.Name = "btnDinner";
            btnDinner.Size = new Size(90, 50);
            btnDinner.TabIndex = 4;
            btnDinner.Text = "DINNER";
            btnDinner.UseVisualStyleBackColor = false;
            btnDinner.Click += dinnerButton_Click;
            // 
            // btnDrinks
            // 
            btnDrinks.BackColor = Color.FromArgb(138, 210, 176);
            btnDrinks.ForeColor = Color.Black;
            btnDrinks.Location = new Point(279, 91);
            btnDrinks.Name = "btnDrinks";
            btnDrinks.Size = new Size(90, 50);
            btnDrinks.TabIndex = 5;
            btnDrinks.Text = "DRINKS";
            btnDrinks.UseVisualStyleBackColor = false;
            // 
            // lblEmployee
            // 
            lblEmployee.BackColor = Color.FromArgb(255, 179, 71);
            lblEmployee.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmployee.Location = new Point(298, 9);
            lblEmployee.Margin = new Padding(0);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(86, 40);
            lblEmployee.TabIndex = 6;
            lblEmployee.Text = "Naam";
            lblEmployee.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // orderListView
            // 
            orderListView.Location = new Point(12, 847);
            orderListView.Name = "orderListView";
            orderListView.Size = new Size(372, 196);
            orderListView.TabIndex = 7;
            orderListView.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 824);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 8;
            label3.Text = "Order";
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 641);
            listView1.Name = "listView1";
            listView1.Size = new Size(372, 161);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            listView2.Location = new Point(12, 200);
            listView2.Name = "listView2";
            listView2.Size = new Size(372, 161);
            listView2.TabIndex = 10;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listView3
            // 
            listView3.Location = new Point(12, 420);
            listView3.Name = "listView3";
            listView3.Size = new Size(372, 161);
            listView3.TabIndex = 11;
            listView3.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(162, 177);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 12;
            label4.Text = "STARTERS";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(172, 397);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 13;
            label5.Text = "MAINS";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(162, 618);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 14;
            label6.Text = "DESERTS";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CreateOrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(396, 1055);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(listView3);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Controls.Add(label3);
            Controls.Add(orderListView);
            Controls.Add(lblEmployee);
            Controls.Add(btnDrinks);
            Controls.Add(btnDinner);
            Controls.Add(btnLunch);
            Controls.Add(label1);
            Controls.Add(lblTable);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CreateOrderForm";
            Text = "Create Order";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTable;
        private Label label1;
        private Button btnLunch;
        private Button btnDinner;
        private Button btnDrinks;
        private Label lblEmployee;
        private ListView orderListView;
        private Label label3;
        private ListView listView1;
        private ListView listView2;
        private ListView listView3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}