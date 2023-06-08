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
            this.listViewToDo = new System.Windows.Forms.ListView();
            this.TableHeader = new System.Windows.Forms.ColumnHeader();
            this.TimeHeader = new System.Windows.Forms.ColumnHeader();
            this.WaitTime = new System.Windows.Forms.ColumnHeader();
            this.ItemHeader = new System.Windows.Forms.ColumnHeader();
            this.AmountHeader = new System.Windows.Forms.ColumnHeader();
            this.listViewDoing = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.FinishedOrdersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KitchenLabel
            // 
            this.KitchenLabel.AutoSize = true;
            this.KitchenLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KitchenLabel.Location = new System.Drawing.Point(455, 9);
            this.KitchenLabel.Name = "KitchenLabel";
            this.KitchenLabel.Size = new System.Drawing.Size(157, 30);
            this.KitchenLabel.TabIndex = 0;
            this.KitchenLabel.Text = "Kitchen Orders";
            // 
            // listViewToDo
            // 
            this.listViewToDo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TableHeader,
            this.TimeHeader,
            this.WaitTime,
            this.ItemHeader,
            this.AmountHeader});
            this.listViewToDo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listViewToDo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewToDo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listViewToDo.FullRowSelect = true;
            this.listViewToDo.GridLines = true;
            this.listViewToDo.Location = new System.Drawing.Point(12, 81);
            this.listViewToDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewToDo.Name = "listViewToDo";
            this.listViewToDo.Size = new System.Drawing.Size(508, 379);
            this.listViewToDo.TabIndex = 2;
            this.listViewToDo.TileSize = new System.Drawing.Size(400, 45);
            this.listViewToDo.UseCompatibleStateImageBehavior = false;
            this.listViewToDo.View = System.Windows.Forms.View.Details;
            // 
            // TableHeader
            // 
            this.TableHeader.Text = "Table";
            // 
            // TimeHeader
            // 
            this.TimeHeader.Text = "Time";
            this.TimeHeader.Width = 65;
            // 
            // WaitTime
            // 
            this.WaitTime.Text = "Waiting";
            this.WaitTime.Width = 90;
            // 
            // ItemHeader
            // 
            this.ItemHeader.Text = "Item";
            this.ItemHeader.Width = 190;
            // 
            // AmountHeader
            // 
            this.AmountHeader.Text = "Amount";
            this.AmountHeader.Width = 99;
            // 
            // listViewDoing
            // 
            this.listViewDoing.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewDoing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listViewDoing.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewDoing.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listViewDoing.FullRowSelect = true;
            this.listViewDoing.GridLines = true;
            this.listViewDoing.Location = new System.Drawing.Point(548, 81);
            this.listViewDoing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewDoing.Name = "listViewDoing";
            this.listViewDoing.Size = new System.Drawing.Size(508, 379);
            this.listViewDoing.TabIndex = 3;
            this.listViewDoing.TileSize = new System.Drawing.Size(400, 45);
            this.listViewDoing.UseCompatibleStateImageBehavior = false;
            this.listViewDoing.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Table";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Time";
            this.columnHeader2.Width = 65;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Waiting";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Item";
            this.columnHeader4.Width = 190;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Amount";
            this.columnHeader5.Width = 99;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(915, 9);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(141, 47);
            this.LogoutButton.TabIndex = 4;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            // 
            // FinishedOrdersButton
            // 
            this.FinishedOrdersButton.BackColor = System.Drawing.SystemColors.Control;
            this.FinishedOrdersButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FinishedOrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.FinishedOrdersButton.Location = new System.Drawing.Point(737, 9);
            this.FinishedOrdersButton.Name = "FinishedOrdersButton";
            this.FinishedOrdersButton.Size = new System.Drawing.Size(141, 47);
            this.FinishedOrdersButton.TabIndex = 5;
            this.FinishedOrdersButton.Text = "Finished Orders";
            this.FinishedOrdersButton.UseVisualStyleBackColor = false;
            // 
            // CurrentOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 791);
            this.Controls.Add(this.FinishedOrdersButton);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.listViewDoing);
            this.Controls.Add(this.listViewToDo);
            this.Controls.Add(this.KitchenLabel);
            this.Name = "CurrentOrdersForm";
            this.Text = "Orders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label KitchenLabel;
        private ListView listViewToDo;
        private ColumnHeader TableHeader;
        private ColumnHeader TimeHeader;
        private ColumnHeader WaitTime;
        private ColumnHeader ItemHeader;
        private ColumnHeader AmountHeader;
        private ListView listViewDoing;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button LogoutButton;
        private Button FinishedOrdersButton;
    }
}