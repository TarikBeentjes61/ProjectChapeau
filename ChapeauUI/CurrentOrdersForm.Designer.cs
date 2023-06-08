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
            this.Table = new System.Windows.Forms.ColumnHeader();
            this.Item = new System.Windows.Forms.ColumnHeader();
            this.Amount = new System.Windows.Forms.ColumnHeader();
            this.listViewToDo = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // KitchenLabel
            // 
            this.KitchenLabel.AutoSize = true;
            this.KitchenLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KitchenLabel.Location = new System.Drawing.Point(476, 9);
            this.KitchenLabel.Name = "KitchenLabel";
            this.KitchenLabel.Size = new System.Drawing.Size(191, 37);
            this.KitchenLabel.TabIndex = 0;
            this.KitchenLabel.Text = "Kitchen Orders";
            // 
            // listViewWaiting
            // 
            this.listViewWaiting.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Table,
            this.Item,
            this.Amount});
            this.listViewWaiting.Location = new System.Drawing.Point(37, 68);
            this.listViewWaiting.Name = "listViewWaiting";
            this.listViewWaiting.Size = new System.Drawing.Size(347, 121);
            this.listViewWaiting.TabIndex = 1;
            this.listViewWaiting.UseCompatibleStateImageBehavior = false;
            this.listViewWaiting.View = System.Windows.Forms.View.Details;
            // 
            // Table
            // 
            this.Table.Text = "Table";
            // 
            // Item
            // 
            this.Item.Text = "Item";
            this.Item.Width = 180;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.Width = 100;
            // 
            // listViewToDo
            // 
            this.listViewToDo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewToDo.Location = new System.Drawing.Point(773, 251);
            this.listViewToDo.Name = "listViewToDo";
            this.listViewToDo.Size = new System.Drawing.Size(344, 121);
            this.listViewToDo.TabIndex = 2;
            this.listViewToDo.UseCompatibleStateImageBehavior = false;
            this.listViewToDo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Table";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Item";
            this.columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Amount";
            this.columnHeader3.Width = 100;
            // 
            // CurrentOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 1055);
            this.Controls.Add(this.listViewToDo);
            this.Controls.Add(this.listViewWaiting);
            this.Controls.Add(this.KitchenLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CurrentOrdersForm";
            this.Text = "Orders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label KitchenLabel;
        private ListView listViewWaiting;
        private ColumnHeader Table;
        private ColumnHeader Item;
        private ColumnHeader Amount;
        private ListView listViewToDo;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}