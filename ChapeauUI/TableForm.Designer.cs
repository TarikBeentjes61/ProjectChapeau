namespace ChapeauUI
{
    partial class TableForm
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
            components = new System.ComponentModel.Container();
            flpnlTables = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            lblName = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            Free = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pnlTableView = new Panel();
            btnTableOrder = new Button();
            lblTableID = new Label();
            btnReserved = new Button();
            btnOccupied = new Button();
            btnFree = new Button();
            btnBack = new Button();
            lblTable = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlTableView.SuspendLayout();
            SuspendLayout();
            // 
            // flpnlTables
            // 
            flpnlTables.Location = new Point(83, 101);
            flpnlTables.Name = "flpnlTables";
            flpnlTables.Size = new Size(302, 711);
            flpnlTables.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Chapeau_logo;
            pictureBox1.Location = new Point(11, 12);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.FromArgb(255, 192, 128);
            lblName.BorderStyle = BorderStyle.FixedSingle;
            lblName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(328, 12);
            lblName.Name = "lblName";
            lblName.RightToLeft = RightToLeft.No;
            lblName.Size = new Size(2, 25);
            lblName.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGreen;
            panel1.Location = new Point(46, 827);
            panel1.Name = "panel1";
            panel1.Size = new Size(25, 25);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Orange;
            panel2.Location = new Point(162, 827);
            panel2.Name = "panel2";
            panel2.Size = new Size(25, 25);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gray;
            panel3.Location = new Point(280, 827);
            panel3.Name = "panel3";
            panel3.Size = new Size(25, 25);
            panel3.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Salmon;
            panel4.Location = new Point(397, 827);
            panel4.Name = "panel4";
            panel4.Size = new Size(25, 25);
            panel4.TabIndex = 10;
            // 
            // Free
            // 
            Free.AutoSize = true;
            Free.Location = new Point(37, 853);
            Free.Name = "Free";
            Free.Size = new Size(37, 20);
            Free.TabIndex = 12;
            Free.Text = "Free";
            Free.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 853);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 14;
            label1.Text = "Occupied";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(261, 853);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 16;
            label2.Text = "Reserved";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(378, 853);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 18;
            label3.Text = "Ordered";
            // 
            // pnlTableView
            // 
            pnlTableView.Controls.Add(btnTableOrder);
            pnlTableView.Controls.Add(lblTableID);
            pnlTableView.Controls.Add(btnReserved);
            pnlTableView.Controls.Add(btnOccupied);
            pnlTableView.Controls.Add(btnFree);
            pnlTableView.Controls.Add(btnBack);
            pnlTableView.Controls.Add(lblTable);
            pnlTableView.Location = new Point(0, 101);
            pnlTableView.Name = "pnlTableView";
            pnlTableView.Size = new Size(490, 795);
            pnlTableView.TabIndex = 20;
            // 
            // btnTableOrder
            // 
            btnTableOrder.BackColor = Color.Transparent;
            btnTableOrder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTableOrder.Location = new Point(138, 368);
            btnTableOrder.Name = "btnTableOrder";
            btnTableOrder.Size = new Size(192, 43);
            btnTableOrder.TabIndex = 13;
            btnTableOrder.Text = "Go to table";
            btnTableOrder.UseVisualStyleBackColor = false;
            btnTableOrder.Click += btnTableOrder_Click;
            // 
            // lblTableID
            // 
            lblTableID.AutoSize = true;
            lblTableID.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblTableID.Location = new Point(221, 123);
            lblTableID.Name = "lblTableID";
            lblTableID.Size = new Size(0, 46);
            lblTableID.TabIndex = 11;
            // 
            // btnReserved
            // 
            btnReserved.BackColor = Color.Gray;
            btnReserved.FlatStyle = FlatStyle.Popup;
            btnReserved.Location = new Point(314, 285);
            btnReserved.Name = "btnReserved";
            btnReserved.Size = new Size(94, 32);
            btnReserved.TabIndex = 9;
            btnReserved.Text = "Reserved";
            btnReserved.UseVisualStyleBackColor = false;
            btnReserved.Click += btnReserved_Click;
            // 
            // btnOccupied
            // 
            btnOccupied.BackColor = Color.Orange;
            btnOccupied.FlatStyle = FlatStyle.Popup;
            btnOccupied.Location = new Point(184, 285);
            btnOccupied.Name = "btnOccupied";
            btnOccupied.Size = new Size(94, 32);
            btnOccupied.TabIndex = 7;
            btnOccupied.Text = "Occupied";
            btnOccupied.UseVisualStyleBackColor = false;
            btnOccupied.Click += btnOccupied_Click;
            // 
            // btnFree
            // 
            btnFree.BackColor = Color.LightGreen;
            btnFree.FlatStyle = FlatStyle.Popup;
            btnFree.ForeColor = SystemColors.ControlText;
            btnFree.Location = new Point(55, 285);
            btnFree.Name = "btnFree";
            btnFree.Size = new Size(94, 32);
            btnFree.TabIndex = 5;
            btnFree.Tag = "1";
            btnFree.Text = "Free";
            btnFree.UseVisualStyleBackColor = false;
            btnFree.Click += btnFree_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Orange;
            btnBack.Location = new Point(0, 673);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(90, 27);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblTable
            // 
            lblTable.AutoSize = true;
            lblTable.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblTable.Location = new Point(138, 123);
            lblTable.Name = "lblTable";
            lblTable.Size = new Size(97, 46);
            lblTable.TabIndex = 1;
            lblTable.Text = "Table";
            // 
            // TableForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 896);
            Controls.Add(pnlTableView);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Free);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblName);
            Controls.Add(pictureBox1);
            Controls.Add(flpnlTables);
            Name = "TableForm";
            Text = "TableForm";
            Load += TableForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlTableView.ResumeLayout(false);
            pnlTableView.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpnlTables;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Label lblName;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label Free;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel pnlTableView;
        private Label lblTable;
        private Button btnBack;
        private Button btnReserved;
        private Button btnOccupied;
        private Button btnFree;
        private Label lblTableID;
        private Button btnTableOrder;
    }
}