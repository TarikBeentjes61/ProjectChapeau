namespace ChapeauUI
{
    partial class EmployeeManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeManagementForm));
            panelEmployees = new Panel();
            buttonRemove = new Button();
            buttonAdjust = new Button();
            listViewEmployees = new ListView();
            buttonAddNew = new Button();
            label1 = new Label();
            panelNewEmployee = new Panel();
            buttonAdd = new Button();
            richTextBoxPassword = new RichTextBox();
            richTextBoxRole = new RichTextBox();
            label6 = new Label();
            label5 = new Label();
            richTextBoxName = new RichTextBox();
            label4 = new Label();
            listView1 = new ListView();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panelEmployees.SuspendLayout();
            panelNewEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelEmployees
            // 
            panelEmployees.Controls.Add(buttonRemove);
            panelEmployees.Controls.Add(buttonAdjust);
            panelEmployees.Controls.Add(listViewEmployees);
            panelEmployees.Controls.Add(buttonAddNew);
            panelEmployees.Controls.Add(label1);
            panelEmployees.Location = new Point(12, 80);
            panelEmployees.Name = "panelEmployees";
            panelEmployees.Size = new Size(374, 605);
            panelEmployees.TabIndex = 6;
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = Color.FromArgb(245, 108, 117);
            buttonRemove.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRemove.Location = new Point(194, 530);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(122, 54);
            buttonRemove.TabIndex = 4;
            buttonRemove.Text = "REMOVE";
            buttonRemove.UseVisualStyleBackColor = false;
            // 
            // buttonAdjust
            // 
            buttonAdjust.BackColor = Color.FromArgb(138, 210, 176);
            buttonAdjust.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdjust.Location = new Point(56, 530);
            buttonAdjust.Name = "buttonAdjust";
            buttonAdjust.Size = new Size(122, 54);
            buttonAdjust.TabIndex = 3;
            buttonAdjust.Text = "ADJUST";
            buttonAdjust.UseVisualStyleBackColor = false;
            // 
            // listViewEmployees
            // 
            listViewEmployees.Location = new Point(0, 113);
            listViewEmployees.Name = "listViewEmployees";
            listViewEmployees.Size = new Size(374, 394);
            listViewEmployees.TabIndex = 2;
            listViewEmployees.UseCompatibleStateImageBehavior = false;
            // 
            // buttonAddNew
            // 
            buttonAddNew.BackColor = Color.FromArgb(138, 210, 176);
            buttonAddNew.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddNew.Location = new Point(239, 53);
            buttonAddNew.Name = "buttonAddNew";
            buttonAddNew.Size = new Size(122, 54);
            buttonAddNew.TabIndex = 1;
            buttonAddNew.Text = "ADD NEW";
            buttonAddNew.UseVisualStyleBackColor = false;
            buttonAddNew.Click += buttonAddNew_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 53);
            label1.Name = "label1";
            label1.Size = new Size(243, 54);
            label1.TabIndex = 0;
            label1.Text = "EMPLOYEES";
            // 
            // panelNewEmployee
            // 
            panelNewEmployee.Controls.Add(buttonAdd);
            panelNewEmployee.Controls.Add(richTextBoxPassword);
            panelNewEmployee.Controls.Add(richTextBoxRole);
            panelNewEmployee.Controls.Add(label6);
            panelNewEmployee.Controls.Add(label5);
            panelNewEmployee.Controls.Add(richTextBoxName);
            panelNewEmployee.Controls.Add(label4);
            panelNewEmployee.Controls.Add(listView1);
            panelNewEmployee.Controls.Add(label3);
            panelNewEmployee.Location = new Point(12, 80);
            panelNewEmployee.Name = "panelNewEmployee";
            panelNewEmployee.Size = new Size(374, 605);
            panelNewEmployee.TabIndex = 7;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(138, 210, 176);
            buttonAdd.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdd.Location = new Point(16, 530);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(121, 48);
            buttonAdd.TabIndex = 12;
            buttonAdd.Text = "ADD";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // richTextBoxPassword
            // 
            richTextBoxPassword.BorderStyle = BorderStyle.None;
            richTextBoxPassword.Location = new Point(194, 228);
            richTextBoxPassword.Name = "richTextBoxPassword";
            richTextBoxPassword.Size = new Size(163, 28);
            richTextBoxPassword.TabIndex = 11;
            richTextBoxPassword.Text = "";
            // 
            // richTextBoxRole
            // 
            richTextBoxRole.BorderStyle = BorderStyle.None;
            richTextBoxRole.Location = new Point(194, 176);
            richTextBoxRole.Name = "richTextBoxRole";
            richTextBoxRole.Size = new Size(163, 28);
            richTextBoxRole.TabIndex = 10;
            richTextBoxRole.Text = "";
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(196, 196, 196);
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(16, 224);
            label6.Name = "label6";
            label6.Size = new Size(345, 35);
            label6.TabIndex = 9;
            label6.Text = "Password";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(196, 196, 196);
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(16, 173);
            label5.Name = "label5";
            label5.Size = new Size(345, 35);
            label5.TabIndex = 8;
            label5.Text = "Role";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // richTextBoxName
            // 
            richTextBoxName.BorderStyle = BorderStyle.None;
            richTextBoxName.Location = new Point(194, 126);
            richTextBoxName.Name = "richTextBoxName";
            richTextBoxName.Size = new Size(163, 28);
            richTextBoxName.TabIndex = 7;
            richTextBoxName.Text = "";
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(196, 196, 196);
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(16, 122);
            label4.Name = "label4";
            label4.Size = new Size(345, 35);
            label4.TabIndex = 6;
            label4.Text = "Name";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // listView1
            // 
            listView1.Location = new Point(0, 105);
            listView1.Name = "listView1";
            listView1.Size = new Size(374, 394);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(0, 53);
            label3.Name = "label3";
            label3.Size = new Size(326, 54);
            label3.TabIndex = 0;
            label3.Text = "NEW EMPLOYEE";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 69);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // EmployeeManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 697);
            Controls.Add(pictureBox1);
            Controls.Add(panelEmployees);
            Controls.Add(panelNewEmployee);
            Name = "EmployeeManagementForm";
            Text = "EmployeeManagementForm";
            panelEmployees.ResumeLayout(false);
            panelEmployees.PerformLayout();
            panelNewEmployee.ResumeLayout(false);
            panelNewEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelEmployees;
        private Button buttonRemove;
        private Button buttonAdjust;
        private ListView listViewEmployees;
        private Button buttonAddNew;
        private Label label1;
        private Panel panelNewEmployee;
        private Label label3;
        private Button buttonAdd;
        private RichTextBox richTextBoxPassword;
        private RichTextBox richTextBoxRole;
        private Label label6;
        private Label label5;
        private RichTextBox richTextBoxName;
        private Label label4;
        private ListView listView1;
        private PictureBox pictureBox1;
    }
}