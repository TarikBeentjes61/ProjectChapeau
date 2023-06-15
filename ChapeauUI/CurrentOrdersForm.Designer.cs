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
            this.mainHeaderPanel = new System.Windows.Forms.Panel();
            this.mainLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listViewOrders = new System.Windows.Forms.ListView();
            this.OrderIDHeader = new System.Windows.Forms.ColumnHeader();
            this.OrderNumberHeader = new System.Windows.Forms.ColumnHeader();
            this.CountHeader = new System.Windows.Forms.ColumnHeader();
            this.DescriptionHeader = new System.Windows.Forms.ColumnHeader();
            this.subPanel = new System.Windows.Forms.Panel();
            this.changeOrderLabel = new System.Windows.Forms.Label();
            this.descriptionPanel = new System.Windows.Forms.Panel();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.countPanel = new System.Windows.Forms.Panel();
            this.countLabel = new System.Windows.Forms.Label();
            this.orderNumberPanel = new System.Windows.Forms.Panel();
            this.orderNumberLabel = new System.Windows.Forms.Label();
            this.orderIdPanel = new System.Windows.Forms.Panel();
            this.orderIdLabel = new System.Windows.Forms.Label();
            this.viewOrderPanel = new System.Windows.Forms.Panel();
            this.viewOrderLabel = new System.Windows.Forms.Label();
            this.preperationButton = new System.Windows.Forms.Button();
            this.preparedButton = new System.Windows.Forms.Button();
            this.ServedButton = new System.Windows.Forms.Button();
            this.OrderIdHeaderPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.OrderStatusHeaderPanel = new System.Windows.Forms.Panel();
            this.orderStatusLabel = new System.Windows.Forms.Label();
            this.selectedIdPanel = new System.Windows.Forms.Panel();
            this.selectedOrderIdLabel = new System.Windows.Forms.Label();
            this.selectedStatusPanel = new System.Windows.Forms.Panel();
            this.selectedOrderStatusLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.commentHeaderPanel = new System.Windows.Forms.Panel();
            this.commentHeaderLabel = new System.Windows.Forms.Label();
            this.commentPanel = new System.Windows.Forms.Panel();
            this.commentLabel = new System.Windows.Forms.Label();
            this.tableHeaderPanel = new System.Windows.Forms.Panel();
            this.tableHeaderLabel = new System.Windows.Forms.Label();
            this.tablePanel = new System.Windows.Forms.Panel();
            this.tableLabel = new System.Windows.Forms.Label();
            this.mainHeaderPanel.SuspendLayout();
            this.subPanel.SuspendLayout();
            this.descriptionPanel.SuspendLayout();
            this.countPanel.SuspendLayout();
            this.orderNumberPanel.SuspendLayout();
            this.orderIdPanel.SuspendLayout();
            this.viewOrderPanel.SuspendLayout();
            this.OrderIdHeaderPanel.SuspendLayout();
            this.OrderStatusHeaderPanel.SuspendLayout();
            this.selectedIdPanel.SuspendLayout();
            this.selectedStatusPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.commentHeaderPanel.SuspendLayout();
            this.commentPanel.SuspendLayout();
            this.tableHeaderPanel.SuspendLayout();
            this.tablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainHeaderPanel
            // 
            this.mainHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(71)))));
            this.mainHeaderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainHeaderPanel.Controls.Add(this.mainLabel);
            this.mainHeaderPanel.Location = new System.Drawing.Point(0, 51);
            this.mainHeaderPanel.Name = "mainHeaderPanel";
            this.mainHeaderPanel.Size = new System.Drawing.Size(1202, 83);
            this.mainHeaderPanel.TabIndex = 0;
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mainLabel.Location = new System.Drawing.Point(421, 11);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(326, 59);
            this.mainLabel.TabIndex = 8;
            this.mainLabel.Text = "Kitchen Orders";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(71)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1102, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Name";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // listViewOrders
            // 
            this.listViewOrders.BackColor = System.Drawing.SystemColors.Window;
            this.listViewOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderIDHeader,
            this.OrderNumberHeader,
            this.CountHeader,
            this.DescriptionHeader});
            this.listViewOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listViewOrders.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewOrders.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listViewOrders.FullRowSelect = true;
            this.listViewOrders.GridLines = true;
            this.listViewOrders.Location = new System.Drawing.Point(-1, 199);
            this.listViewOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewOrders.Name = "listViewOrders";
            this.listViewOrders.Size = new System.Drawing.Size(686, 357);
            this.listViewOrders.TabIndex = 3;
            this.listViewOrders.TileSize = new System.Drawing.Size(40, 40);
            this.listViewOrders.UseCompatibleStateImageBehavior = false;
            this.listViewOrders.View = System.Windows.Forms.View.Details;
            this.listViewOrders.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewOrders_ItemSelectionChanged);
            // 
            // OrderIDHeader
            // 
            this.OrderIDHeader.Text = "";
            this.OrderIDHeader.Width = 127;
            // 
            // OrderNumberHeader
            // 
            this.OrderNumberHeader.Text = "";
            this.OrderNumberHeader.Width = 147;
            // 
            // CountHeader
            // 
            this.CountHeader.Text = "";
            this.CountHeader.Width = 105;
            // 
            // DescriptionHeader
            // 
            this.DescriptionHeader.Text = "";
            this.DescriptionHeader.Width = 303;
            // 
            // subPanel
            // 
            this.subPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(71)))));
            this.subPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subPanel.Controls.Add(this.changeOrderLabel);
            this.subPanel.Location = new System.Drawing.Point(684, 184);
            this.subPanel.Name = "subPanel";
            this.subPanel.Size = new System.Drawing.Size(518, 47);
            this.subPanel.TabIndex = 1;
            // 
            // changeOrderLabel
            // 
            this.changeOrderLabel.AutoSize = true;
            this.changeOrderLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeOrderLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeOrderLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.changeOrderLabel.Location = new System.Drawing.Point(851, 11);
            this.changeOrderLabel.Name = "changeOrderLabel";
            this.changeOrderLabel.Size = new System.Drawing.Size(182, 25);
            this.changeOrderLabel.TabIndex = 1;
            this.changeOrderLabel.Text = "Change order status";
            // 
            // descriptionPanel
            // 
            this.descriptionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(71)))));
            this.descriptionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionPanel.Controls.Add(this.descriptionLabel);
            this.descriptionPanel.Location = new System.Drawing.Point(379, 184);
            this.descriptionPanel.Name = "descriptionPanel";
            this.descriptionPanel.Size = new System.Drawing.Size(306, 47);
            this.descriptionPanel.TabIndex = 7;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.descriptionLabel.Location = new System.Drawing.Point(101, 11);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(108, 25);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.Text = "Description";
            // 
            // countPanel
            // 
            this.countPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(71)))));
            this.countPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countPanel.Controls.Add(this.countLabel);
            this.countPanel.Location = new System.Drawing.Point(274, 184);
            this.countPanel.Name = "countPanel";
            this.countPanel.Size = new System.Drawing.Size(106, 47);
            this.countPanel.TabIndex = 6;
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.countLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.countLabel.Location = new System.Drawing.Point(20, 11);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(63, 25);
            this.countLabel.TabIndex = 0;
            this.countLabel.Text = "Count";
            // 
            // orderNumberPanel
            // 
            this.orderNumberPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(71)))));
            this.orderNumberPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orderNumberPanel.Controls.Add(this.orderNumberLabel);
            this.orderNumberPanel.Location = new System.Drawing.Point(128, 184);
            this.orderNumberPanel.Name = "orderNumberPanel";
            this.orderNumberPanel.Size = new System.Drawing.Size(148, 47);
            this.orderNumberPanel.TabIndex = 5;
            // 
            // orderNumberLabel
            // 
            this.orderNumberLabel.AutoSize = true;
            this.orderNumberLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderNumberLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orderNumberLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.orderNumberLabel.Location = new System.Drawing.Point(4, 11);
            this.orderNumberLabel.Name = "orderNumberLabel";
            this.orderNumberLabel.Size = new System.Drawing.Size(135, 25);
            this.orderNumberLabel.TabIndex = 0;
            this.orderNumberLabel.Text = "Order Number";
            // 
            // orderIdPanel
            // 
            this.orderIdPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(71)))));
            this.orderIdPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orderIdPanel.Controls.Add(this.orderIdLabel);
            this.orderIdPanel.Location = new System.Drawing.Point(1, 184);
            this.orderIdPanel.Name = "orderIdPanel";
            this.orderIdPanel.Size = new System.Drawing.Size(128, 47);
            this.orderIdPanel.TabIndex = 4;
            // 
            // orderIdLabel
            // 
            this.orderIdLabel.AutoSize = true;
            this.orderIdLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderIdLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orderIdLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.orderIdLabel.Location = new System.Drawing.Point(21, 11);
            this.orderIdLabel.Name = "orderIdLabel";
            this.orderIdLabel.Size = new System.Drawing.Size(84, 25);
            this.orderIdLabel.TabIndex = 0;
            this.orderIdLabel.Text = "Order ID";
            // 
            // viewOrderPanel
            // 
            this.viewOrderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(71)))));
            this.viewOrderPanel.Controls.Add(this.viewOrderLabel);
            this.viewOrderPanel.Location = new System.Drawing.Point(684, 305);
            this.viewOrderPanel.Name = "viewOrderPanel";
            this.viewOrderPanel.Size = new System.Drawing.Size(518, 67);
            this.viewOrderPanel.TabIndex = 4;
            // 
            // viewOrderLabel
            // 
            this.viewOrderLabel.AutoSize = true;
            this.viewOrderLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewOrderLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viewOrderLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.viewOrderLabel.Location = new System.Drawing.Point(179, 21);
            this.viewOrderLabel.Name = "viewOrderLabel";
            this.viewOrderLabel.Size = new System.Drawing.Size(158, 25);
            this.viewOrderLabel.TabIndex = 8;
            this.viewOrderLabel.Text = "View order status";
            // 
            // preperationButton
            // 
            this.preperationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.preperationButton.Location = new System.Drawing.Point(698, 248);
            this.preperationButton.Name = "preperationButton";
            this.preperationButton.Size = new System.Drawing.Size(147, 45);
            this.preperationButton.TabIndex = 5;
            this.preperationButton.Text = "In preparation";
            this.preperationButton.UseVisualStyleBackColor = true;
            this.preperationButton.Click += new System.EventHandler(this.preperationButton_Click);
            // 
            // preparedButton
            // 
            this.preparedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(71)))));
            this.preparedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.preparedButton.Location = new System.Drawing.Point(871, 248);
            this.preparedButton.Name = "preparedButton";
            this.preparedButton.Size = new System.Drawing.Size(147, 45);
            this.preparedButton.TabIndex = 6;
            this.preparedButton.Text = "Prepared";
            this.preparedButton.UseVisualStyleBackColor = false;
            this.preparedButton.Click += new System.EventHandler(this.preparedButton_Click);
            // 
            // ServedButton
            // 
            this.ServedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(210)))), ((int)(((byte)(176)))));
            this.ServedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ServedButton.Location = new System.Drawing.Point(1043, 248);
            this.ServedButton.Name = "ServedButton";
            this.ServedButton.Size = new System.Drawing.Size(147, 45);
            this.ServedButton.TabIndex = 7;
            this.ServedButton.Text = "Served";
            this.ServedButton.UseVisualStyleBackColor = false;
            this.ServedButton.Click += new System.EventHandler(this.ServedButton_Click);
            // 
            // OrderIdHeaderPanel
            // 
            this.OrderIdHeaderPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.OrderIdHeaderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrderIdHeaderPanel.Controls.Add(this.label1);
            this.OrderIdHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.OrderIdHeaderPanel.Name = "OrderIdHeaderPanel";
            this.OrderIdHeaderPanel.Size = new System.Drawing.Size(259, 47);
            this.OrderIdHeaderPanel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(47, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selected order ID";
            // 
            // OrderStatusHeaderPanel
            // 
            this.OrderStatusHeaderPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.OrderStatusHeaderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrderStatusHeaderPanel.Controls.Add(this.orderStatusLabel);
            this.OrderStatusHeaderPanel.Location = new System.Drawing.Point(258, 0);
            this.OrderStatusHeaderPanel.Name = "OrderStatusHeaderPanel";
            this.OrderStatusHeaderPanel.Size = new System.Drawing.Size(260, 47);
            this.OrderStatusHeaderPanel.TabIndex = 7;
            // 
            // orderStatusLabel
            // 
            this.orderStatusLabel.AutoSize = true;
            this.orderStatusLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderStatusLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orderStatusLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.orderStatusLabel.Location = new System.Drawing.Point(71, 10);
            this.orderStatusLabel.Name = "orderStatusLabel";
            this.orderStatusLabel.Size = new System.Drawing.Size(116, 25);
            this.orderStatusLabel.TabIndex = 0;
            this.orderStatusLabel.Text = "Order Status";
            // 
            // selectedIdPanel
            // 
            this.selectedIdPanel.BackColor = System.Drawing.Color.White;
            this.selectedIdPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedIdPanel.Controls.Add(this.selectedOrderIdLabel);
            this.selectedIdPanel.Location = new System.Drawing.Point(0, 46);
            this.selectedIdPanel.Name = "selectedIdPanel";
            this.selectedIdPanel.Size = new System.Drawing.Size(259, 47);
            this.selectedIdPanel.TabIndex = 7;
            // 
            // selectedOrderIdLabel
            // 
            this.selectedOrderIdLabel.AutoSize = true;
            this.selectedOrderIdLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectedOrderIdLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectedOrderIdLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.selectedOrderIdLabel.Location = new System.Drawing.Point(112, 13);
            this.selectedOrderIdLabel.Name = "selectedOrderIdLabel";
            this.selectedOrderIdLabel.Size = new System.Drawing.Size(0, 25);
            this.selectedOrderIdLabel.TabIndex = 0;
            // 
            // selectedStatusPanel
            // 
            this.selectedStatusPanel.BackColor = System.Drawing.Color.White;
            this.selectedStatusPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedStatusPanel.Controls.Add(this.selectedOrderStatusLabel);
            this.selectedStatusPanel.Location = new System.Drawing.Point(258, 46);
            this.selectedStatusPanel.Name = "selectedStatusPanel";
            this.selectedStatusPanel.Size = new System.Drawing.Size(260, 47);
            this.selectedStatusPanel.TabIndex = 8;
            // 
            // selectedOrderStatusLabel
            // 
            this.selectedOrderStatusLabel.AutoSize = true;
            this.selectedOrderStatusLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectedOrderStatusLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectedOrderStatusLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.selectedOrderStatusLabel.Location = new System.Drawing.Point(92, 12);
            this.selectedOrderStatusLabel.Name = "selectedOrderStatusLabel";
            this.selectedOrderStatusLabel.Size = new System.Drawing.Size(0, 25);
            this.selectedOrderStatusLabel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.commentHeaderPanel);
            this.panel1.Controls.Add(this.commentPanel);
            this.panel1.Controls.Add(this.OrderStatusHeaderPanel);
            this.panel1.Controls.Add(this.tableHeaderPanel);
            this.panel1.Controls.Add(this.selectedStatusPanel);
            this.panel1.Controls.Add(this.tablePanel);
            this.panel1.Controls.Add(this.OrderIdHeaderPanel);
            this.panel1.Controls.Add(this.selectedIdPanel);
            this.panel1.Location = new System.Drawing.Point(684, 371);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 203);
            this.panel1.TabIndex = 9;
            // 
            // commentHeaderPanel
            // 
            this.commentHeaderPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.commentHeaderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commentHeaderPanel.Controls.Add(this.commentHeaderLabel);
            this.commentHeaderPanel.Location = new System.Drawing.Point(258, 92);
            this.commentHeaderPanel.Name = "commentHeaderPanel";
            this.commentHeaderPanel.Size = new System.Drawing.Size(260, 47);
            this.commentHeaderPanel.TabIndex = 10;
            // 
            // commentHeaderLabel
            // 
            this.commentHeaderLabel.AutoSize = true;
            this.commentHeaderLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.commentHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.commentHeaderLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.commentHeaderLabel.Location = new System.Drawing.Point(85, 10);
            this.commentHeaderLabel.Name = "commentHeaderLabel";
            this.commentHeaderLabel.Size = new System.Drawing.Size(94, 25);
            this.commentHeaderLabel.TabIndex = 0;
            this.commentHeaderLabel.Text = "Comment";
            // 
            // commentPanel
            // 
            this.commentPanel.BackColor = System.Drawing.Color.White;
            this.commentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commentPanel.Controls.Add(this.commentLabel);
            this.commentPanel.Location = new System.Drawing.Point(258, 138);
            this.commentPanel.Name = "commentPanel";
            this.commentPanel.Size = new System.Drawing.Size(260, 47);
            this.commentPanel.TabIndex = 12;
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.commentLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.commentLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.commentLabel.Location = new System.Drawing.Point(13, 7);
            this.commentLabel.MaximumSize = new System.Drawing.Size(230, 30);
            this.commentLabel.MinimumSize = new System.Drawing.Size(230, 30);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(230, 30);
            this.commentLabel.TabIndex = 0;
            // 
            // tableHeaderPanel
            // 
            this.tableHeaderPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.tableHeaderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableHeaderPanel.Controls.Add(this.tableHeaderLabel);
            this.tableHeaderPanel.Location = new System.Drawing.Point(0, 92);
            this.tableHeaderPanel.Name = "tableHeaderPanel";
            this.tableHeaderPanel.Size = new System.Drawing.Size(259, 47);
            this.tableHeaderPanel.TabIndex = 9;
            // 
            // tableHeaderLabel
            // 
            this.tableHeaderLabel.AutoSize = true;
            this.tableHeaderLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tableHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tableHeaderLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableHeaderLabel.Location = new System.Drawing.Point(104, 10);
            this.tableHeaderLabel.Name = "tableHeaderLabel";
            this.tableHeaderLabel.Size = new System.Drawing.Size(56, 25);
            this.tableHeaderLabel.TabIndex = 0;
            this.tableHeaderLabel.Text = "Table";
            // 
            // tablePanel
            // 
            this.tablePanel.BackColor = System.Drawing.Color.White;
            this.tablePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tablePanel.Controls.Add(this.tableLabel);
            this.tablePanel.Location = new System.Drawing.Point(0, 138);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(259, 47);
            this.tablePanel.TabIndex = 11;
            // 
            // tableLabel
            // 
            this.tableLabel.AutoSize = true;
            this.tableLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tableLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tableLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLabel.Location = new System.Drawing.Point(117, 13);
            this.tableLabel.Name = "tableLabel";
            this.tableLabel.Size = new System.Drawing.Size(0, 25);
            this.tableLabel.TabIndex = 0;
            // 
            // CurrentOrdersForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1202, 574);
            this.Controls.Add(this.descriptionPanel);
            this.Controls.Add(this.countPanel);
            this.Controls.Add(this.orderNumberPanel);
            this.Controls.Add(this.orderIdPanel);
            this.Controls.Add(this.ServedButton);
            this.Controls.Add(this.preparedButton);
            this.Controls.Add(this.preperationButton);
            this.Controls.Add(this.viewOrderPanel);
            this.Controls.Add(this.subPanel);
            this.Controls.Add(this.listViewOrders);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mainHeaderPanel);
            this.Controls.Add(this.panel1);
            this.Name = "CurrentOrdersForm2";
            this.Text = "CurrentOrdersForm2";
            this.mainHeaderPanel.ResumeLayout(false);
            this.mainHeaderPanel.PerformLayout();
            this.subPanel.ResumeLayout(false);
            this.subPanel.PerformLayout();
            this.descriptionPanel.ResumeLayout(false);
            this.descriptionPanel.PerformLayout();
            this.countPanel.ResumeLayout(false);
            this.countPanel.PerformLayout();
            this.orderNumberPanel.ResumeLayout(false);
            this.orderNumberPanel.PerformLayout();
            this.orderIdPanel.ResumeLayout(false);
            this.orderIdPanel.PerformLayout();
            this.viewOrderPanel.ResumeLayout(false);
            this.viewOrderPanel.PerformLayout();
            this.OrderIdHeaderPanel.ResumeLayout(false);
            this.OrderIdHeaderPanel.PerformLayout();
            this.OrderStatusHeaderPanel.ResumeLayout(false);
            this.OrderStatusHeaderPanel.PerformLayout();
            this.selectedIdPanel.ResumeLayout(false);
            this.selectedIdPanel.PerformLayout();
            this.selectedStatusPanel.ResumeLayout(false);
            this.selectedStatusPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.commentHeaderPanel.ResumeLayout(false);
            this.commentHeaderPanel.PerformLayout();
            this.commentPanel.ResumeLayout(false);
            this.commentPanel.PerformLayout();
            this.tableHeaderPanel.ResumeLayout(false);
            this.tableHeaderPanel.PerformLayout();
            this.tablePanel.ResumeLayout(false);
            this.tablePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel mainHeaderPanel;
        private Button button1;
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
    }
}