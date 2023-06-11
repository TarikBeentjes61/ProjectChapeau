namespace ChapeauUI
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            pictureBox1 = new PictureBox();
            labelEmployee = new Label();
            buttonTableView = new Button();
            buttonEmployeeManagement = new Button();
            buttonMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 69);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // labelEmployee
            // 
            labelEmployee.AutoSize = true;
            labelEmployee.BackColor = Color.FromArgb(255, 179, 71);
            labelEmployee.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmployee.Location = new Point(315, 12);
            labelEmployee.Name = "labelEmployee";
            labelEmployee.Size = new Size(71, 30);
            labelEmployee.TabIndex = 10;
            labelEmployee.Text = "Naam";
            // 
            // buttonTableView
            // 
            buttonTableView.BackColor = Color.FromArgb(138, 210, 176);
            buttonTableView.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTableView.Location = new Point(46, 168);
            buttonTableView.Name = "buttonTableView";
            buttonTableView.Size = new Size(294, 64);
            buttonTableView.TabIndex = 11;
            buttonTableView.Text = "TABLE VIEW";
            buttonTableView.UseVisualStyleBackColor = false;
            // 
            // buttonEmployeeManagement
            // 
            buttonEmployeeManagement.BackColor = Color.FromArgb(138, 210, 176);
            buttonEmployeeManagement.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEmployeeManagement.Location = new Point(46, 306);
            buttonEmployeeManagement.Name = "buttonEmployeeManagement";
            buttonEmployeeManagement.Size = new Size(294, 64);
            buttonEmployeeManagement.TabIndex = 12;
            buttonEmployeeManagement.Text = "EMPLOYEE MANAGEMENT";
            buttonEmployeeManagement.UseVisualStyleBackColor = false;
            buttonEmployeeManagement.Click += buttonEmployeeManagement_Click;
            // 
            // buttonMenu
            // 
            buttonMenu.BackColor = Color.FromArgb(138, 210, 176);
            buttonMenu.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMenu.Location = new Point(46, 444);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Size = new Size(294, 64);
            buttonMenu.TabIndex = 13;
            buttonMenu.Text = "MENU";
            buttonMenu.UseVisualStyleBackColor = false;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 697);
            Controls.Add(buttonMenu);
            Controls.Add(buttonEmployeeManagement);
            Controls.Add(buttonTableView);
            Controls.Add(labelEmployee);
            Controls.Add(pictureBox1);
            Name = "ManagerForm";
            Text = "ManagerForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelEmployee;
        private Button buttonTableView;
        private Button buttonEmployeeManagement;
        private Button buttonMenu;
    }
}