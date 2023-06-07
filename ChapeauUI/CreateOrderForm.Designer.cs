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
            TableLabel = new Label();
            label1 = new Label();
            lunchButton = new Button();
            dinnerButton = new Button();
            drinksButton = new Button();
            emplyeeLabel = new Label();
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
            // TableLabel
            // 
            TableLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TableLabel.Location = new Point(135, 20);
            TableLabel.Name = "TableLabel";
            TableLabel.Size = new Size(148, 55);
            TableLabel.TabIndex = 1;
            TableLabel.Text = "Tabel #1";
            TableLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            // lunchButton
            // 
            lunchButton.BackColor = Color.FromArgb(138, 210, 176);
            lunchButton.Location = new Point(12, 91);
            lunchButton.Name = "lunchButton";
            lunchButton.Size = new Size(90, 50);
            lunchButton.TabIndex = 3;
            lunchButton.Text = "LUNCH";
            lunchButton.UseVisualStyleBackColor = false;
            // 
            // dinnerButton
            // 
            dinnerButton.BackColor = Color.FromArgb(138, 210, 176);
            dinnerButton.Location = new Point(147, 91);
            dinnerButton.Name = "dinnerButton";
            dinnerButton.Size = new Size(90, 50);
            dinnerButton.TabIndex = 4;
            dinnerButton.Text = "DINNER";
            dinnerButton.UseVisualStyleBackColor = false;
            dinnerButton.Click += dinnerButton_Click;
            // 
            // drinksButton
            // 
            drinksButton.BackColor = Color.FromArgb(138, 210, 176);
            drinksButton.ForeColor = Color.Black;
            drinksButton.Location = new Point(279, 91);
            drinksButton.Name = "drinksButton";
            drinksButton.Size = new Size(90, 50);
            drinksButton.TabIndex = 5;
            drinksButton.Text = "DRINKS";
            drinksButton.UseVisualStyleBackColor = false;
            // 
            // emplyeeLabel
            // 
            emplyeeLabel.BackColor = Color.FromArgb(255, 179, 71);
            emplyeeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            emplyeeLabel.Location = new Point(298, 9);
            emplyeeLabel.Margin = new Padding(0);
            emplyeeLabel.Name = "emplyeeLabel";
            emplyeeLabel.Size = new Size(86, 40);
            emplyeeLabel.TabIndex = 6;
            emplyeeLabel.Text = "Marlene";
            emplyeeLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            Controls.Add(emplyeeLabel);
            Controls.Add(drinksButton);
            Controls.Add(dinnerButton);
            Controls.Add(lunchButton);
            Controls.Add(label1);
            Controls.Add(TableLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CreateOrderForm";
            Text = "Create Order";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label TableLabel;
        private Label label1;
        private Button lunchButton;
        private Button dinnerButton;
        private Button drinksButton;
        private Label emplyeeLabel;
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