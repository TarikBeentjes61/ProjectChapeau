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
            this.VatLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CreateOrderForm";
            this.Text = "Create Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label VatLabel;
        private Button button1;
    }
}