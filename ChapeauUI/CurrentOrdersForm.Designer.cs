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
            // CurrentOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 1055);
            this.Controls.Add(this.KitchenLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CurrentOrdersForm";
            this.Text = "Orders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label KitchenLabel;
    }
}