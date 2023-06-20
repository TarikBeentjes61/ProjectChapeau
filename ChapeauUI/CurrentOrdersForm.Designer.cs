namespace ChapeauUI
{
    partial class CurrentOrdersForm
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
            mainHeaderPanel = new Panel();
            mainLabel = new Label();
            logoutButton = new Button();
            listViewOrders = new ListView();
            OrderIDHeader = new ColumnHeader();
            OrderNumberHeader = new ColumnHeader();
            CountHeader = new ColumnHeader();
            DescriptionHeader = new ColumnHeader();
            subPanel = new Panel();
            changeOrderLabel = new Label();
            descriptionPanel = new Panel();
            descriptionLabel = new Label();
            countPanel = new Panel();
            countLabel = new Label();
            orderNumberPanel = new Panel();
            orderNumberLabel = new Label();
            orderIdPanel = new Panel();
            orderIdLabel = new Label();
            viewOrderPanel = new Panel();
            viewOrderLabel = new Label();
            preperationButton = new Button();
            preparedButton = new Button();
            ServedButton = new Button();
            OrderIdHeaderPanel = new Panel();
            label1 = new Label();
            OrderStatusHeaderPanel = new Panel();
            orderStatusLabel = new Label();
            selectedIdPanel = new Panel();
            selectedOrderIdLabel = new Label();
            selectedStatusPanel = new Panel();
            selectedOrderStatusLabel = new Label();
            panel1 = new Panel();
            commentHeaderPanel = new Panel();
            commentHeaderLabel = new Label();
            commentPanel = new Panel();
            commentLabel = new Label();
            tableHeaderPanel = new Panel();
            tableHeaderLabel = new Label();
            tablePanel = new Panel();
            tableLabel = new Label();
            showServedButton = new Button();
            pictureBox1 = new PictureBox();
            mainHeaderPanel.SuspendLayout();
            subPanel.SuspendLayout();
            descriptionPanel.SuspendLayout();
            countPanel.SuspendLayout();
            orderNumberPanel.SuspendLayout();
            orderIdPanel.SuspendLayout();
            viewOrderPanel.SuspendLayout();
            OrderIdHeaderPanel.SuspendLayout();
            OrderStatusHeaderPanel.SuspendLayout();
            selectedIdPanel.SuspendLayout();
            selectedStatusPanel.SuspendLayout();
            panel1.SuspendLayout();
            commentHeaderPanel.SuspendLayout();
            commentPanel.SuspendLayout();
            tableHeaderPanel.SuspendLayout();
            tablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mainHeaderPanel
            // 
            mainHeaderPanel.BackColor = Color.FromArgb(255, 179, 71);
            mainHeaderPanel.BorderStyle = BorderStyle.FixedSingle;
            mainHeaderPanel.Controls.Add(mainLabel);
            mainHeaderPanel.Location = new Point(0, 51);
            mainHeaderPanel.Name = "mainHeaderPanel";
            mainHeaderPanel.Size = new Size(1202, 83);
            mainHeaderPanel.TabIndex = 0;
            // 
            // mainLabel
            // 
            mainLabel.AutoSize = true;
            mainLabel.Font = new Font("Segoe UI", 32F, FontStyle.Bold, GraphicsUnit.Point);
            mainLabel.Location = new Point(421, 11);
            mainLabel.Name = "mainLabel";
            mainLabel.Size = new Size(326, 59);
            mainLabel.TabIndex = 8;
            mainLabel.Text = "Kitchen Orders";
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.FromArgb(255, 179, 71);
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Location = new Point(1102, 6);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(95, 39);
            logoutButton.TabIndex = 1;
            logoutButton.Text = "Name";
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += logoutButton_Click;
            // 
            // listViewOrders
            // 
            listViewOrders.BackColor = SystemColors.Window;
            listViewOrders.Columns.AddRange(new ColumnHeader[] { OrderIDHeader, OrderNumberHeader, CountHeader, DescriptionHeader });
            listViewOrders.Cursor = Cursors.Hand;
            listViewOrders.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            listViewOrders.ForeColor = SystemColors.ControlText;
            listViewOrders.FullRowSelect = true;
            listViewOrders.GridLines = true;
            listViewOrders.Location = new Point(-1, 199);
            listViewOrders.Margin = new Padding(3, 2, 3, 2);
            listViewOrders.Name = "listViewOrders";
            listViewOrders.Size = new Size(686, 375);
            listViewOrders.Sorting = SortOrder.Ascending;
            listViewOrders.TabIndex = 3;
            listViewOrders.TileSize = new Size(40, 40);
            listViewOrders.UseCompatibleStateImageBehavior = false;
            listViewOrders.View = View.Details;
            listViewOrders.ItemSelectionChanged += listViewOrders_ItemSelectionChanged;
            // 
            // OrderIDHeader
            // 
            OrderIDHeader.Text = "";
            OrderIDHeader.Width = 127;
            // 
            // OrderNumberHeader
            // 
            OrderNumberHeader.Text = "";
            OrderNumberHeader.Width = 147;
            // 
            // CountHeader
            // 
            CountHeader.Text = "";
            CountHeader.Width = 105;
            // 
            // DescriptionHeader
            // 
            DescriptionHeader.Text = "";
            DescriptionHeader.Width = 303;
            // 
            // subPanel
            // 
            subPanel.BackColor = Color.FromArgb(255, 179, 71);
            subPanel.BorderStyle = BorderStyle.FixedSingle;
            subPanel.Controls.Add(changeOrderLabel);
            subPanel.Location = new Point(684, 184);
            subPanel.Name = "subPanel";
            subPanel.Size = new Size(518, 47);
            subPanel.TabIndex = 1;
            // 
            // changeOrderLabel
            // 
            changeOrderLabel.AutoSize = true;
            changeOrderLabel.FlatStyle = FlatStyle.Flat;
            changeOrderLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            changeOrderLabel.ForeColor = SystemColors.ControlText;
            changeOrderLabel.Location = new Point(851, 11);
            changeOrderLabel.Name = "changeOrderLabel";
            changeOrderLabel.Size = new Size(182, 25);
            changeOrderLabel.TabIndex = 1;
            changeOrderLabel.Text = "Change order status";
            // 
            // descriptionPanel
            // 
            descriptionPanel.BackColor = Color.FromArgb(255, 179, 71);
            descriptionPanel.BorderStyle = BorderStyle.FixedSingle;
            descriptionPanel.Controls.Add(descriptionLabel);
            descriptionPanel.Location = new Point(379, 184);
            descriptionPanel.Name = "descriptionPanel";
            descriptionPanel.Size = new Size(306, 47);
            descriptionPanel.TabIndex = 7;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.FlatStyle = FlatStyle.Flat;
            descriptionLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionLabel.ForeColor = SystemColors.ControlText;
            descriptionLabel.Location = new Point(101, 11);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(108, 25);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Description";
            // 
            // countPanel
            // 
            countPanel.BackColor = Color.FromArgb(255, 179, 71);
            countPanel.BorderStyle = BorderStyle.FixedSingle;
            countPanel.Controls.Add(countLabel);
            countPanel.Location = new Point(274, 184);
            countPanel.Name = "countPanel";
            countPanel.Size = new Size(106, 47);
            countPanel.TabIndex = 6;
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.FlatStyle = FlatStyle.Flat;
            countLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            countLabel.ForeColor = SystemColors.ControlText;
            countLabel.Location = new Point(20, 11);
            countLabel.Name = "countLabel";
            countLabel.Size = new Size(63, 25);
            countLabel.TabIndex = 0;
            countLabel.Text = "Count";
            // 
            // orderNumberPanel
            // 
            orderNumberPanel.BackColor = Color.FromArgb(255, 179, 71);
            orderNumberPanel.BorderStyle = BorderStyle.FixedSingle;
            orderNumberPanel.Controls.Add(orderNumberLabel);
            orderNumberPanel.Location = new Point(128, 184);
            orderNumberPanel.Name = "orderNumberPanel";
            orderNumberPanel.Size = new Size(148, 47);
            orderNumberPanel.TabIndex = 5;
            // 
            // orderNumberLabel
            // 
            orderNumberLabel.AutoSize = true;
            orderNumberLabel.FlatStyle = FlatStyle.Flat;
            orderNumberLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            orderNumberLabel.ForeColor = SystemColors.ControlText;
            orderNumberLabel.Location = new Point(4, 11);
            orderNumberLabel.Name = "orderNumberLabel";
            orderNumberLabel.Size = new Size(135, 25);
            orderNumberLabel.TabIndex = 0;
            orderNumberLabel.Text = "Order Number";
            // 
            // orderIdPanel
            // 
            orderIdPanel.BackColor = Color.FromArgb(255, 179, 71);
            orderIdPanel.BorderStyle = BorderStyle.FixedSingle;
            orderIdPanel.Controls.Add(orderIdLabel);
            orderIdPanel.Location = new Point(0, 184);
            orderIdPanel.Name = "orderIdPanel";
            orderIdPanel.Size = new Size(129, 47);
            orderIdPanel.TabIndex = 4;
            // 
            // orderIdLabel
            // 
            orderIdLabel.AutoSize = true;
            orderIdLabel.FlatStyle = FlatStyle.Flat;
            orderIdLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            orderIdLabel.ForeColor = SystemColors.ControlText;
            orderIdLabel.Location = new Point(21, 11);
            orderIdLabel.Name = "orderIdLabel";
            orderIdLabel.Size = new Size(84, 25);
            orderIdLabel.TabIndex = 0;
            orderIdLabel.Text = "Order ID";
            // 
            // viewOrderPanel
            // 
            viewOrderPanel.BackColor = Color.FromArgb(255, 179, 71);
            viewOrderPanel.Controls.Add(viewOrderLabel);
            viewOrderPanel.Location = new Point(684, 305);
            viewOrderPanel.Name = "viewOrderPanel";
            viewOrderPanel.Size = new Size(518, 67);
            viewOrderPanel.TabIndex = 4;
            // 
            // viewOrderLabel
            // 
            viewOrderLabel.AutoSize = true;
            viewOrderLabel.FlatStyle = FlatStyle.Flat;
            viewOrderLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            viewOrderLabel.ForeColor = SystemColors.ControlText;
            viewOrderLabel.Location = new Point(179, 21);
            viewOrderLabel.Name = "viewOrderLabel";
            viewOrderLabel.Size = new Size(158, 25);
            viewOrderLabel.TabIndex = 8;
            viewOrderLabel.Text = "View order status";
            // 
            // preperationButton
            // 
            preperationButton.FlatStyle = FlatStyle.Flat;
            preperationButton.Location = new Point(698, 248);
            preperationButton.Name = "preperationButton";
            preperationButton.Size = new Size(147, 45);
            preperationButton.TabIndex = 5;
            preperationButton.Text = "In preparation";
            preperationButton.UseVisualStyleBackColor = true;
            preperationButton.Click += preperationButton_Click;
            // 
            // preparedButton
            // 
            preparedButton.BackColor = Color.FromArgb(255, 179, 71);
            preparedButton.FlatStyle = FlatStyle.Flat;
            preparedButton.Location = new Point(871, 248);
            preparedButton.Name = "preparedButton";
            preparedButton.Size = new Size(147, 45);
            preparedButton.TabIndex = 6;
            preparedButton.Text = "Prepared";
            preparedButton.UseVisualStyleBackColor = false;
            preparedButton.Click += preparedButton_Click;
            // 
            // ServedButton
            // 
            ServedButton.BackColor = Color.FromArgb(128, 210, 176);
            ServedButton.FlatStyle = FlatStyle.Flat;
            ServedButton.Location = new Point(1043, 248);
            ServedButton.Name = "ServedButton";
            ServedButton.Size = new Size(147, 45);
            ServedButton.TabIndex = 7;
            ServedButton.Text = "Served";
            ServedButton.UseVisualStyleBackColor = false;
            ServedButton.Click += ServedButton_Click;
            // 
            // OrderIdHeaderPanel
            // 
            OrderIdHeaderPanel.BackColor = Color.Gainsboro;
            OrderIdHeaderPanel.BorderStyle = BorderStyle.FixedSingle;
            OrderIdHeaderPanel.Controls.Add(label1);
            OrderIdHeaderPanel.Location = new Point(0, 0);
            OrderIdHeaderPanel.Name = "OrderIdHeaderPanel";
            OrderIdHeaderPanel.Size = new Size(259, 47);
            OrderIdHeaderPanel.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(47, 10);
            label1.Name = "label1";
            label1.Size = new Size(157, 25);
            label1.TabIndex = 0;
            label1.Text = "Selected order ID";
            // 
            // OrderStatusHeaderPanel
            // 
            OrderStatusHeaderPanel.BackColor = Color.Gainsboro;
            OrderStatusHeaderPanel.BorderStyle = BorderStyle.FixedSingle;
            OrderStatusHeaderPanel.Controls.Add(orderStatusLabel);
            OrderStatusHeaderPanel.Location = new Point(258, 0);
            OrderStatusHeaderPanel.Name = "OrderStatusHeaderPanel";
            OrderStatusHeaderPanel.Size = new Size(260, 47);
            OrderStatusHeaderPanel.TabIndex = 7;
            // 
            // orderStatusLabel
            // 
            orderStatusLabel.AutoSize = true;
            orderStatusLabel.FlatStyle = FlatStyle.Flat;
            orderStatusLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            orderStatusLabel.ForeColor = SystemColors.ControlText;
            orderStatusLabel.Location = new Point(71, 10);
            orderStatusLabel.Name = "orderStatusLabel";
            orderStatusLabel.Size = new Size(116, 25);
            orderStatusLabel.TabIndex = 0;
            orderStatusLabel.Text = "Order Status";
            // 
            // selectedIdPanel
            // 
            selectedIdPanel.BackColor = Color.White;
            selectedIdPanel.BorderStyle = BorderStyle.FixedSingle;
            selectedIdPanel.Controls.Add(selectedOrderIdLabel);
            selectedIdPanel.Location = new Point(0, 46);
            selectedIdPanel.Name = "selectedIdPanel";
            selectedIdPanel.Size = new Size(259, 47);
            selectedIdPanel.TabIndex = 7;
            // 
            // selectedOrderIdLabel
            // 
            selectedOrderIdLabel.AutoSize = true;
            selectedOrderIdLabel.FlatStyle = FlatStyle.Flat;
            selectedOrderIdLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            selectedOrderIdLabel.ForeColor = SystemColors.ControlText;
            selectedOrderIdLabel.Location = new Point(112, 13);
            selectedOrderIdLabel.Name = "selectedOrderIdLabel";
            selectedOrderIdLabel.Size = new Size(0, 25);
            selectedOrderIdLabel.TabIndex = 0;
            // 
            // selectedStatusPanel
            // 
            selectedStatusPanel.BackColor = Color.White;
            selectedStatusPanel.BorderStyle = BorderStyle.FixedSingle;
            selectedStatusPanel.Controls.Add(selectedOrderStatusLabel);
            selectedStatusPanel.Location = new Point(258, 46);
            selectedStatusPanel.Name = "selectedStatusPanel";
            selectedStatusPanel.Size = new Size(260, 47);
            selectedStatusPanel.TabIndex = 8;
            // 
            // selectedOrderStatusLabel
            // 
            selectedOrderStatusLabel.AutoSize = true;
            selectedOrderStatusLabel.FlatStyle = FlatStyle.Flat;
            selectedOrderStatusLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            selectedOrderStatusLabel.ForeColor = SystemColors.ControlText;
            selectedOrderStatusLabel.Location = new Point(92, 12);
            selectedOrderStatusLabel.Name = "selectedOrderStatusLabel";
            selectedOrderStatusLabel.Size = new Size(0, 25);
            selectedOrderStatusLabel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(commentHeaderPanel);
            panel1.Controls.Add(commentPanel);
            panel1.Controls.Add(OrderStatusHeaderPanel);
            panel1.Controls.Add(tableHeaderPanel);
            panel1.Controls.Add(selectedStatusPanel);
            panel1.Controls.Add(tablePanel);
            panel1.Controls.Add(OrderIdHeaderPanel);
            panel1.Controls.Add(selectedIdPanel);
            panel1.Location = new Point(684, 371);
            panel1.Name = "panel1";
            panel1.Size = new Size(518, 203);
            panel1.TabIndex = 9;
            // 
            // commentHeaderPanel
            // 
            commentHeaderPanel.BackColor = Color.Gainsboro;
            commentHeaderPanel.BorderStyle = BorderStyle.FixedSingle;
            commentHeaderPanel.Controls.Add(commentHeaderLabel);
            commentHeaderPanel.Location = new Point(258, 92);
            commentHeaderPanel.Name = "commentHeaderPanel";
            commentHeaderPanel.Size = new Size(260, 47);
            commentHeaderPanel.TabIndex = 10;
            // 
            // commentHeaderLabel
            // 
            commentHeaderLabel.AutoSize = true;
            commentHeaderLabel.FlatStyle = FlatStyle.Flat;
            commentHeaderLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            commentHeaderLabel.ForeColor = SystemColors.ControlText;
            commentHeaderLabel.Location = new Point(85, 10);
            commentHeaderLabel.Name = "commentHeaderLabel";
            commentHeaderLabel.Size = new Size(94, 25);
            commentHeaderLabel.TabIndex = 0;
            commentHeaderLabel.Text = "Comment";
            // 
            // commentPanel
            // 
            commentPanel.BackColor = Color.White;
            commentPanel.BorderStyle = BorderStyle.FixedSingle;
            commentPanel.Controls.Add(commentLabel);
            commentPanel.Location = new Point(258, 138);
            commentPanel.Name = "commentPanel";
            commentPanel.Size = new Size(260, 47);
            commentPanel.TabIndex = 12;
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.FlatStyle = FlatStyle.Flat;
            commentLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            commentLabel.ForeColor = SystemColors.ControlText;
            commentLabel.Location = new Point(13, 7);
            commentLabel.MaximumSize = new Size(230, 30);
            commentLabel.MinimumSize = new Size(230, 30);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new Size(230, 30);
            commentLabel.TabIndex = 0;
            // 
            // tableHeaderPanel
            // 
            tableHeaderPanel.BackColor = Color.Gainsboro;
            tableHeaderPanel.BorderStyle = BorderStyle.FixedSingle;
            tableHeaderPanel.Controls.Add(tableHeaderLabel);
            tableHeaderPanel.Location = new Point(0, 92);
            tableHeaderPanel.Name = "tableHeaderPanel";
            tableHeaderPanel.Size = new Size(259, 47);
            tableHeaderPanel.TabIndex = 9;
            // 
            // tableHeaderLabel
            // 
            tableHeaderLabel.AutoSize = true;
            tableHeaderLabel.FlatStyle = FlatStyle.Flat;
            tableHeaderLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tableHeaderLabel.ForeColor = SystemColors.ControlText;
            tableHeaderLabel.Location = new Point(104, 10);
            tableHeaderLabel.Name = "tableHeaderLabel";
            tableHeaderLabel.Size = new Size(56, 25);
            tableHeaderLabel.TabIndex = 0;
            tableHeaderLabel.Text = "Table";
            // 
            // tablePanel
            // 
            tablePanel.BackColor = Color.White;
            tablePanel.BorderStyle = BorderStyle.FixedSingle;
            tablePanel.Controls.Add(tableLabel);
            tablePanel.Location = new Point(0, 138);
            tablePanel.Name = "tablePanel";
            tablePanel.Size = new Size(259, 47);
            tablePanel.TabIndex = 11;
            // 
            // tableLabel
            // 
            tableLabel.AutoSize = true;
            tableLabel.FlatStyle = FlatStyle.Flat;
            tableLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tableLabel.ForeColor = SystemColors.ControlText;
            tableLabel.Location = new Point(117, 13);
            tableLabel.Name = "tableLabel";
            tableLabel.Size = new Size(0, 25);
            tableLabel.TabIndex = 0;
            // 
            // showServedButton
            // 
            showServedButton.BackColor = Color.FromArgb(128, 210, 176);
            showServedButton.FlatStyle = FlatStyle.Flat;
            showServedButton.Location = new Point(0, 133);
            showServedButton.Name = "showServedButton";
            showServedButton.Size = new Size(276, 52);
            showServedButton.TabIndex = 10;
            showServedButton.Text = "Show Served Orders";
            showServedButton.UseVisualStyleBackColor = false;
            showServedButton.Click += showServedButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Chapeau_logo;
            pictureBox1.Location = new Point(1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // CurrentOrdersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1202, 574);
            Controls.Add(pictureBox1);
            Controls.Add(showServedButton);
            Controls.Add(descriptionPanel);
            Controls.Add(countPanel);
            Controls.Add(orderNumberPanel);
            Controls.Add(orderIdPanel);
            Controls.Add(ServedButton);
            Controls.Add(preparedButton);
            Controls.Add(preperationButton);
            Controls.Add(viewOrderPanel);
            Controls.Add(subPanel);
            Controls.Add(listViewOrders);
            Controls.Add(logoutButton);
            Controls.Add(mainHeaderPanel);
            Controls.Add(panel1);
            Name = "CurrentOrdersForm";
            Text = "Current Orders";
            mainHeaderPanel.ResumeLayout(false);
            mainHeaderPanel.PerformLayout();
            subPanel.ResumeLayout(false);
            subPanel.PerformLayout();
            descriptionPanel.ResumeLayout(false);
            descriptionPanel.PerformLayout();
            countPanel.ResumeLayout(false);
            countPanel.PerformLayout();
            orderNumberPanel.ResumeLayout(false);
            orderNumberPanel.PerformLayout();
            orderIdPanel.ResumeLayout(false);
            orderIdPanel.PerformLayout();
            viewOrderPanel.ResumeLayout(false);
            viewOrderPanel.PerformLayout();
            OrderIdHeaderPanel.ResumeLayout(false);
            OrderIdHeaderPanel.PerformLayout();
            OrderStatusHeaderPanel.ResumeLayout(false);
            OrderStatusHeaderPanel.PerformLayout();
            selectedIdPanel.ResumeLayout(false);
            selectedIdPanel.PerformLayout();
            selectedStatusPanel.ResumeLayout(false);
            selectedStatusPanel.PerformLayout();
            panel1.ResumeLayout(false);
            commentHeaderPanel.ResumeLayout(false);
            commentHeaderPanel.PerformLayout();
            commentPanel.ResumeLayout(false);
            commentPanel.PerformLayout();
            tableHeaderPanel.ResumeLayout(false);
            tableHeaderPanel.PerformLayout();
            tablePanel.ResumeLayout(false);
            tablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainHeaderPanel;
        private Button logoutButton;
        private ListView listViewOrders;
        private Panel subPanel;
        private Panel orderNumberPanel;
        private Label orderNumberLabel;
        private Panel orderIdPanel;
        private Label orderIdLabel;
        private Panel descriptionPanel;
        private Label descriptionLabel;
        private Panel countPanel;
        private Label countLabel;
        private ColumnHeader OrderIDHeader;
        private ColumnHeader OrderNumberHeader;
        private ColumnHeader CountHeader;
        private ColumnHeader DescriptionHeader;
        private Panel viewOrderPanel;
        private Label mainLabel;
        private Label changeOrderLabel;
        private Label viewOrderLabel;
        private Button preperationButton;
        private Button preparedButton;
        private Button ServedButton;
        private Panel OrderIdHeaderPanel;
        private Label label1;
        private Panel OrderStatusHeaderPanel;
        private Label orderStatusLabel;
        private Panel selectedIdPanel;
        private Label selectedOrderIdLabel;
        private Panel selectedStatusPanel;
        private Label selectedOrderStatusLabel;
        private Panel panel1;
        private Panel commentHeaderPanel;
        private Label commentHeaderLabel;
        private Panel commentPanel;
        private Label commentLabel;
        private Panel tableHeaderPanel;
        private Label tableHeaderLabel;
        private Panel tablePanel;
        private Label tableLabel;
        private Button showServedButton;
        private PictureBox pictureBox1;
    }
}