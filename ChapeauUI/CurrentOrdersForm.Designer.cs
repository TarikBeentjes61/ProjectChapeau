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
            this.KitchenLabel = new System.Windows.Forms.Label();
            this.listViewWaiting = new System.Windows.Forms.ListView();
            this.WaitingTableHeader = new System.Windows.Forms.ColumnHeader();
            this.WaitingTimeHeader = new System.Windows.Forms.ColumnHeader();
            this.WaitingWaitTime = new System.Windows.Forms.ColumnHeader();
            this.WaitingItemHeader = new System.Windows.Forms.ColumnHeader();
            this.WaitingAmountHeader = new System.Windows.Forms.ColumnHeader();
            this.listViewDoing = new System.Windows.Forms.ListView();
            this.DoingTableHeader = new System.Windows.Forms.ColumnHeader();
            this.DoingTimeHeader = new System.Windows.Forms.ColumnHeader();
            this.DoingWaitingHeader = new System.Windows.Forms.ColumnHeader();
            this.DoingItemHeader = new System.Windows.Forms.ColumnHeader();
            this.DoingAmountHeader = new System.Windows.Forms.ColumnHeader();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.FinishedOrdersButton = new System.Windows.Forms.Button();
            this.WaitingLabel = new System.Windows.Forms.Label();
            this.doingLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.finishedPanel = new System.Windows.Forms.Panel();
            this.finishedLabel = new System.Windows.Forms.Label();
            this.finishedBackButton = new System.Windows.Forms.Button();
            this.listViewFinished = new System.Windows.Forms.ListView();
            this.FinishedTableHeader = new System.Windows.Forms.ColumnHeader();
            this.FinishedTimeHeader = new System.Windows.Forms.ColumnHeader();
            this.FinishedItemHeader = new System.Windows.Forms.ColumnHeader();
            this.FinishedAmountHeader = new System.Windows.Forms.ColumnHeader();
            this.changeStatusPanel = new System.Windows.Forms.Panel();
            this.changeStatusButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.finishedPanel.SuspendLayout();
            this.changeStatusPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // KitchenLabel
            // 
            this.KitchenLabel.AutoSize = true;
            this.KitchenLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KitchenLabel.Location = new System.Drawing.Point(451, 14);
            this.KitchenLabel.Name = "KitchenLabel";
            this.KitchenLabel.Size = new System.Drawing.Size(157, 30);
            this.KitchenLabel.TabIndex = 0;
            this.KitchenLabel.Text = "Kitchen Orders";
            // 
            // listViewWaiting
            // 
            this.listViewWaiting.BackColor = System.Drawing.SystemColors.Window;
            this.listViewWaiting.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.WaitingTableHeader,
            this.WaitingTimeHeader,
            this.WaitingWaitTime,
            this.WaitingItemHeader,
            this.WaitingAmountHeader});
            this.listViewWaiting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listViewWaiting.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewWaiting.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listViewWaiting.FullRowSelect = true;
            this.listViewWaiting.Location = new System.Drawing.Point(12, 126);
            this.listViewWaiting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewWaiting.Name = "listViewWaiting";
            this.listViewWaiting.Size = new System.Drawing.Size(508, 379);
            this.listViewWaiting.TabIndex = 2;
            this.listViewWaiting.TileSize = new System.Drawing.Size(400, 45);
            this.listViewWaiting.UseCompatibleStateImageBehavior = false;
            this.listViewWaiting.View = System.Windows.Forms.View.Details;
            this.listViewWaiting.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewWaiting_ItemSelectionChanged);
            // 
            // WaitingTableHeader
            // 
            this.WaitingTableHeader.Text = "Table";
            // 
            // WaitingTimeHeader
            // 
            this.WaitingTimeHeader.Text = "Time";
            this.WaitingTimeHeader.Width = 65;
            // 
            // WaitingWaitTime
            // 
            this.WaitingWaitTime.Text = "Waiting";
            this.WaitingWaitTime.Width = 90;
            // 
            // WaitingItemHeader
            // 
            this.WaitingItemHeader.Text = "Item";
            this.WaitingItemHeader.Width = 190;
            // 
            // WaitingAmountHeader
            // 
            this.WaitingAmountHeader.Text = "Amount";
            this.WaitingAmountHeader.Width = 99;
            // 
            // listViewDoing
            // 
            this.listViewDoing.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DoingTableHeader,
            this.DoingTimeHeader,
            this.DoingWaitingHeader,
            this.DoingItemHeader,
            this.DoingAmountHeader});
            this.listViewDoing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listViewDoing.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewDoing.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listViewDoing.FullRowSelect = true;
            this.listViewDoing.Location = new System.Drawing.Point(548, 126);
            this.listViewDoing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewDoing.Name = "listViewDoing";
            this.listViewDoing.Size = new System.Drawing.Size(508, 379);
            this.listViewDoing.TabIndex = 3;
            this.listViewDoing.TileSize = new System.Drawing.Size(400, 45);
            this.listViewDoing.UseCompatibleStateImageBehavior = false;
            this.listViewDoing.View = System.Windows.Forms.View.Details;
            this.listViewDoing.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewDoing_ItemSelectionChanged);
            // 
            // DoingTableHeader
            // 
            this.DoingTableHeader.Text = "Table";
            // 
            // DoingTimeHeader
            // 
            this.DoingTimeHeader.Text = "Time";
            this.DoingTimeHeader.Width = 65;
            // 
            // DoingWaitingHeader
            // 
            this.DoingWaitingHeader.Text = "Waiting";
            this.DoingWaitingHeader.Width = 90;
            // 
            // DoingItemHeader
            // 
            this.DoingItemHeader.Text = "Item";
            this.DoingItemHeader.Width = 190;
            // 
            // DoingAmountHeader
            // 
            this.DoingAmountHeader.Text = "Amount";
            this.DoingAmountHeader.Width = 99;
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(71)))));
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Location = new System.Drawing.Point(927, 0);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(141, 62);
            this.LogoutButton.TabIndex = 4;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = false;
            // 
            // FinishedOrdersButton
            // 
            this.FinishedOrdersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.FinishedOrdersButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.FinishedOrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinishedOrdersButton.Location = new System.Drawing.Point(789, 0);
            this.FinishedOrdersButton.Name = "FinishedOrdersButton";
            this.FinishedOrdersButton.Size = new System.Drawing.Size(141, 62);
            this.FinishedOrdersButton.TabIndex = 5;
            this.FinishedOrdersButton.Text = "Finished Orders";
            this.FinishedOrdersButton.UseVisualStyleBackColor = false;
            this.FinishedOrdersButton.Click += new System.EventHandler(this.FinishedOrdersButton_Click);
            // 
            // WaitingLabel
            // 
            this.WaitingLabel.AutoSize = true;
            this.WaitingLabel.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WaitingLabel.Location = new System.Drawing.Point(12, 65);
            this.WaitingLabel.Name = "WaitingLabel";
            this.WaitingLabel.Size = new System.Drawing.Size(169, 59);
            this.WaitingLabel.TabIndex = 6;
            this.WaitingLabel.Text = "Waiting";
            // 
            // doingLabel
            // 
            this.doingLabel.AutoSize = true;
            this.doingLabel.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.doingLabel.Location = new System.Drawing.Point(548, 65);
            this.doingLabel.Name = "doingLabel";
            this.doingLabel.Size = new System.Drawing.Size(139, 59);
            this.doingLabel.TabIndex = 7;
            this.doingLabel.Text = "Doing";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.KitchenLabel);
            this.panel1.Controls.Add(this.FinishedOrdersButton);
            this.panel1.Controls.Add(this.LogoutButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 62);
            this.panel1.TabIndex = 8;
            // 
            // finishedPanel
            // 
            this.finishedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.finishedPanel.Controls.Add(this.finishedLabel);
            this.finishedPanel.Controls.Add(this.finishedBackButton);
            this.finishedPanel.Controls.Add(this.listViewFinished);
            this.finishedPanel.Location = new System.Drawing.Point(13, 520);
            this.finishedPanel.Name = "finishedPanel";
            this.finishedPanel.Size = new System.Drawing.Size(507, 425);
            this.finishedPanel.TabIndex = 9;
            this.finishedPanel.Visible = false;
            // 
            // finishedLabel
            // 
            this.finishedLabel.AutoSize = true;
            this.finishedLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.finishedLabel.Location = new System.Drawing.Point(173, 9);
            this.finishedLabel.Name = "finishedLabel";
            this.finishedLabel.Size = new System.Drawing.Size(165, 30);
            this.finishedLabel.TabIndex = 10;
            this.finishedLabel.Text = "Finished Orders";
            // 
            // finishedBackButton
            // 
            this.finishedBackButton.BackColor = System.Drawing.Color.Silver;
            this.finishedBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finishedBackButton.Location = new System.Drawing.Point(0, 0);
            this.finishedBackButton.Name = "finishedBackButton";
            this.finishedBackButton.Size = new System.Drawing.Size(110, 49);
            this.finishedBackButton.TabIndex = 10;
            this.finishedBackButton.Text = "<--";
            this.finishedBackButton.UseVisualStyleBackColor = false;
            this.finishedBackButton.Click += new System.EventHandler(this.finishedBackButton_Click);
            // 
            // listViewFinished
            // 
            this.listViewFinished.BackColor = System.Drawing.SystemColors.Window;
            this.listViewFinished.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FinishedTableHeader,
            this.FinishedTimeHeader,
            this.FinishedItemHeader,
            this.FinishedAmountHeader});
            this.listViewFinished.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listViewFinished.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewFinished.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listViewFinished.FullRowSelect = true;
            this.listViewFinished.Location = new System.Drawing.Point(0, 48);
            this.listViewFinished.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewFinished.Name = "listViewFinished";
            this.listViewFinished.Size = new System.Drawing.Size(508, 379);
            this.listViewFinished.TabIndex = 10;
            this.listViewFinished.TileSize = new System.Drawing.Size(400, 45);
            this.listViewFinished.UseCompatibleStateImageBehavior = false;
            this.listViewFinished.View = System.Windows.Forms.View.Details;
            // 
            // FinishedTableHeader
            // 
            this.FinishedTableHeader.Text = "Table";
            // 
            // FinishedTimeHeader
            // 
            this.FinishedTimeHeader.Text = "Time";
            this.FinishedTimeHeader.Width = 65;
            // 
            // FinishedItemHeader
            // 
            this.FinishedItemHeader.Text = "Item";
            this.FinishedItemHeader.Width = 280;
            // 
            // FinishedAmountHeader
            // 
            this.FinishedAmountHeader.Text = "Amount";
            this.FinishedAmountHeader.Width = 99;
            // 
            // changeStatusPanel
            // 
            this.changeStatusPanel.BackColor = System.Drawing.SystemColors.Window;
            this.changeStatusPanel.Controls.Add(this.changeStatusButton);
            this.changeStatusPanel.Controls.Add(this.cancelButton);
            this.changeStatusPanel.Controls.Add(this.statusLabel);
            this.changeStatusPanel.Location = new System.Drawing.Point(548, 520);
            this.changeStatusPanel.Name = "changeStatusPanel";
            this.changeStatusPanel.Size = new System.Drawing.Size(430, 125);
            this.changeStatusPanel.TabIndex = 10;
            this.changeStatusPanel.Visible = false;
            // 
            // changeStatusButton
            // 
            this.changeStatusButton.BackColor = System.Drawing.Color.White;
            this.changeStatusButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.changeStatusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeStatusButton.Location = new System.Drawing.Point(215, 63);
            this.changeStatusButton.Name = "changeStatusButton";
            this.changeStatusButton.Size = new System.Drawing.Size(215, 62);
            this.changeStatusButton.TabIndex = 12;
            this.changeStatusButton.Text = "Change to #####";
            this.changeStatusButton.UseVisualStyleBackColor = false;
            this.changeStatusButton.Click += new System.EventHandler(this.changeStatusButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Silver;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(0, 63);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(215, 62);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusLabel.Location = new System.Drawing.Point(147, 9);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(132, 25);
            this.statusLabel.TabIndex = 11;
            this.statusLabel.Text = "Change Status";
            // 
            // CurrentOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 1067);
            this.Controls.Add(this.changeStatusPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.doingLabel);
            this.Controls.Add(this.WaitingLabel);
            this.Controls.Add(this.listViewDoing);
            this.Controls.Add(this.listViewWaiting);
            this.Controls.Add(this.finishedPanel);
            this.Name = "CurrentOrdersForm";
            this.Text = "Orders";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.finishedPanel.ResumeLayout(false);
            this.finishedPanel.PerformLayout();
            this.changeStatusPanel.ResumeLayout(false);
            this.changeStatusPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label KitchenLabel;
        private ListView listViewWaiting;
        private ColumnHeader WaitingTableHeader;
        private ColumnHeader WaitingTimeHeader;
        private ColumnHeader WaitingWaitTime;
        private ColumnHeader WaitingItemHeader;
        private ColumnHeader WaitingAmountHeader;
        private ListView listViewDoing;
        private ColumnHeader DoingTableHeader;
        private ColumnHeader DoingTimeHeader;
        private ColumnHeader DoingWaitingHeader;
        private ColumnHeader DoingItemHeader;
        private ColumnHeader DoingAmountHeader;
        private Button LogoutButton;
        private Button FinishedOrdersButton;
        private Label WaitingLabel;
        private Label doingLabel;
        private Panel panel1;
        private Panel finishedPanel;
        private Button finishedBackButton;
        private ListView listViewFinished;
        private ColumnHeader FinishedTableHeader;
        private ColumnHeader FinishedTimeHeader;
        private ColumnHeader FinishedItemHeader;
        private ColumnHeader FinishedAmountHeader;
        private Label finishedLabel;
        private Panel changeStatusPanel;
        private Button changeStatusButton;
        private Button cancelButton;
        private Label statusLabel;
    }
}