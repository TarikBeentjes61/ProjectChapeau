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
            pnlMain = new Panel();
            pnlNewEmployee = new Panel();
            pictureBox2 = new PictureBox();
            btnBackToEmployees = new Button();
            btnAdd = new Button();
            richTextBoxPassword = new RichTextBox();
            richTextBoxRole = new RichTextBox();
            label6 = new Label();
            label5 = new Label();
            richTextBoxName = new RichTextBox();
            label4 = new Label();
            listView1 = new ListView();
            label3 = new Label();
            pnlEmployees = new Panel();
            lblBackToMain = new Label();
            pictureBox3 = new PictureBox();
            buttonRemove = new Button();
            buttonAdjust = new Button();
            listViewEmployees = new ListView();
            buttonAddNewEmployee = new Button();
            label1 = new Label();
            pnlMenu = new Panel();
            pictureBox4 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            listView2 = new ListView();
            btnAddNewMenuItem = new Button();
            label2 = new Label();
            pnlNewMenuItem = new Panel();
            btnBackToMenu = new Button();
            richTextBox3 = new RichTextBox();
            label10 = new Label();
            richTextBox2 = new RichTextBox();
            label9 = new Label();
            richTextBox1 = new RichTextBox();
            label8 = new Label();
            pictureBox5 = new PictureBox();
            btnNewMenuItemAdd = new Button();
            listView3 = new ListView();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlMain.SuspendLayout();
            pnlNewEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            pnlNewMenuItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
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
            labelEmployee.Location = new Point(303, 0);
            labelEmployee.Name = "labelEmployee";
            labelEmployee.Size = new Size(71, 30);
            labelEmployee.TabIndex = 10;
            labelEmployee.Text = "Naam";
            // 
            // buttonTableView
            // 
            buttonTableView.BackColor = Color.FromArgb(138, 210, 176);
            buttonTableView.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTableView.Location = new Point(40, 186);
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
            buttonEmployeeManagement.Location = new Point(40, 324);
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
            buttonMenu.Location = new Point(40, 462);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Size = new Size(294, 64);
            buttonMenu.TabIndex = 13;
            buttonMenu.Text = "MENU";
            buttonMenu.UseVisualStyleBackColor = false;
            buttonMenu.Click += buttonMenu_Click;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(labelEmployee);
            pnlMain.Controls.Add(buttonMenu);
            pnlMain.Controls.Add(pictureBox1);
            pnlMain.Controls.Add(buttonTableView);
            pnlMain.Controls.Add(buttonEmployeeManagement);
            pnlMain.Location = new Point(484, 12);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(374, 673);
            pnlMain.TabIndex = 14;
            // 
            // pnlNewEmployee
            // 
            pnlNewEmployee.Controls.Add(pictureBox2);
            pnlNewEmployee.Controls.Add(btnBackToEmployees);
            pnlNewEmployee.Controls.Add(btnAdd);
            pnlNewEmployee.Controls.Add(richTextBoxPassword);
            pnlNewEmployee.Controls.Add(richTextBoxRole);
            pnlNewEmployee.Controls.Add(label6);
            pnlNewEmployee.Controls.Add(label5);
            pnlNewEmployee.Controls.Add(richTextBoxName);
            pnlNewEmployee.Controls.Add(label4);
            pnlNewEmployee.Controls.Add(listView1);
            pnlNewEmployee.Controls.Add(label3);
            pnlNewEmployee.Location = new Point(12, 12);
            pnlNewEmployee.Name = "pnlNewEmployee";
            pnlNewEmployee.Size = new Size(374, 673);
            pnlNewEmployee.TabIndex = 15;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(137, 69);
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // btnBackToEmployees
            // 
            btnBackToEmployees.BackColor = Color.FromArgb(255, 179, 71);
            btnBackToEmployees.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBackToEmployees.Location = new Point(16, 601);
            btnBackToEmployees.Name = "btnBackToEmployees";
            btnBackToEmployees.Size = new Size(121, 48);
            btnBackToEmployees.TabIndex = 13;
            btnBackToEmployees.Text = "BACK";
            btnBackToEmployees.UseVisualStyleBackColor = false;
            btnBackToEmployees.Click += btnBackToEmployees_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(138, 210, 176);
            btnAdd.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(236, 601);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(121, 48);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // richTextBoxPassword
            // 
            richTextBoxPassword.BorderStyle = BorderStyle.None;
            richTextBoxPassword.Location = new Point(194, 293);
            richTextBoxPassword.Name = "richTextBoxPassword";
            richTextBoxPassword.Size = new Size(163, 28);
            richTextBoxPassword.TabIndex = 11;
            richTextBoxPassword.Text = "";
            // 
            // richTextBoxRole
            // 
            richTextBoxRole.BorderStyle = BorderStyle.None;
            richTextBoxRole.Location = new Point(194, 241);
            richTextBoxRole.Name = "richTextBoxRole";
            richTextBoxRole.Size = new Size(163, 28);
            richTextBoxRole.TabIndex = 10;
            richTextBoxRole.Text = "";
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(196, 196, 196);
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(16, 289);
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
            label5.Location = new Point(16, 238);
            label5.Name = "label5";
            label5.Size = new Size(345, 35);
            label5.TabIndex = 8;
            label5.Text = "Role";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // richTextBoxName
            // 
            richTextBoxName.BorderStyle = BorderStyle.None;
            richTextBoxName.Location = new Point(194, 191);
            richTextBoxName.Name = "richTextBoxName";
            richTextBoxName.Size = new Size(163, 28);
            richTextBoxName.TabIndex = 7;
            richTextBoxName.Text = "";
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(196, 196, 196);
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(16, 187);
            label4.Name = "label4";
            label4.Size = new Size(345, 35);
            label4.TabIndex = 6;
            label4.Text = "Name";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // listView1
            // 
            listView1.Location = new Point(0, 170);
            listView1.Name = "listView1";
            listView1.Size = new Size(374, 394);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(0, 118);
            label3.Name = "label3";
            label3.Size = new Size(326, 54);
            label3.TabIndex = 0;
            label3.Text = "NEW EMPLOYEE";
            // 
            // pnlEmployees
            // 
            pnlEmployees.Controls.Add(lblBackToMain);
            pnlEmployees.Controls.Add(pictureBox3);
            pnlEmployees.Controls.Add(buttonRemove);
            pnlEmployees.Controls.Add(buttonAdjust);
            pnlEmployees.Controls.Add(listViewEmployees);
            pnlEmployees.Controls.Add(buttonAddNewEmployee);
            pnlEmployees.Controls.Add(label1);
            pnlEmployees.Location = new Point(12, 12);
            pnlEmployees.Name = "pnlEmployees";
            pnlEmployees.Size = new Size(374, 673);
            pnlEmployees.TabIndex = 16;
            // 
            // lblBackToMain
            // 
            lblBackToMain.AutoSize = true;
            lblBackToMain.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblBackToMain.Location = new Point(3, 118);
            lblBackToMain.Name = "lblBackToMain";
            lblBackToMain.Size = new Size(57, 37);
            lblBackToMain.TabIndex = 16;
            lblBackToMain.Text = "<--";
            lblBackToMain.Click += lblBackToMain_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(137, 69);
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = Color.FromArgb(245, 108, 117);
            buttonRemove.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRemove.Location = new Point(235, 601);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(122, 48);
            buttonRemove.TabIndex = 4;
            buttonRemove.Text = "REMOVE";
            buttonRemove.UseVisualStyleBackColor = false;
            // 
            // buttonAdjust
            // 
            buttonAdjust.BackColor = Color.FromArgb(138, 210, 176);
            buttonAdjust.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdjust.Location = new Point(16, 601);
            buttonAdjust.Name = "buttonAdjust";
            buttonAdjust.Size = new Size(122, 48);
            buttonAdjust.TabIndex = 3;
            buttonAdjust.Text = "ADJUST";
            buttonAdjust.UseVisualStyleBackColor = false;
            // 
            // listViewEmployees
            // 
            listViewEmployees.Location = new Point(0, 170);
            listViewEmployees.Name = "listViewEmployees";
            listViewEmployees.Size = new Size(374, 394);
            listViewEmployees.TabIndex = 2;
            listViewEmployees.UseCompatibleStateImageBehavior = false;
            // 
            // buttonAddNewEmployee
            // 
            buttonAddNewEmployee.BackColor = Color.FromArgb(138, 210, 176);
            buttonAddNewEmployee.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddNewEmployee.Location = new Point(242, 110);
            buttonAddNewEmployee.Name = "buttonAddNewEmployee";
            buttonAddNewEmployee.Size = new Size(122, 54);
            buttonAddNewEmployee.TabIndex = 1;
            buttonAddNewEmployee.Text = "ADD NEW";
            buttonAddNewEmployee.UseVisualStyleBackColor = false;
            buttonAddNewEmployee.Click += buttonAddNewEmployee_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(50, 115);
            label1.Name = "label1";
            label1.Size = new Size(197, 45);
            label1.TabIndex = 0;
            label1.Text = "EMPLOYEES";
            // 
            // pnlMenu
            // 
            pnlMenu.Controls.Add(pictureBox4);
            pnlMenu.Controls.Add(button1);
            pnlMenu.Controls.Add(button2);
            pnlMenu.Controls.Add(listView2);
            pnlMenu.Controls.Add(btnAddNewMenuItem);
            pnlMenu.Controls.Add(label2);
            pnlMenu.Location = new Point(12, 12);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(374, 673);
            pnlMenu.TabIndex = 17;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(137, 69);
            pictureBox4.TabIndex = 21;
            pictureBox4.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(245, 108, 117);
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(235, 601);
            button1.Name = "button1";
            button1.Size = new Size(122, 48);
            button1.TabIndex = 20;
            button1.Text = "REMOVE";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(138, 210, 176);
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(16, 601);
            button2.Name = "button2";
            button2.Size = new Size(122, 48);
            button2.TabIndex = 19;
            button2.Text = "ADJUST";
            button2.UseVisualStyleBackColor = false;
            // 
            // listView2
            // 
            listView2.Location = new Point(0, 170);
            listView2.Name = "listView2";
            listView2.Size = new Size(374, 394);
            listView2.TabIndex = 18;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // btnAddNewMenuItem
            // 
            btnAddNewMenuItem.BackColor = Color.FromArgb(138, 210, 176);
            btnAddNewMenuItem.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddNewMenuItem.Location = new Point(242, 110);
            btnAddNewMenuItem.Name = "btnAddNewMenuItem";
            btnAddNewMenuItem.Size = new Size(122, 54);
            btnAddNewMenuItem.TabIndex = 17;
            btnAddNewMenuItem.Text = "ADD NEW";
            btnAddNewMenuItem.UseVisualStyleBackColor = false;
            btnAddNewMenuItem.Click += btnAddNewMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 110);
            label2.Name = "label2";
            label2.Size = new Size(143, 54);
            label2.TabIndex = 16;
            label2.Text = "MENU";
            // 
            // pnlNewMenuItem
            // 
            pnlNewMenuItem.Controls.Add(btnBackToMenu);
            pnlNewMenuItem.Controls.Add(richTextBox3);
            pnlNewMenuItem.Controls.Add(label10);
            pnlNewMenuItem.Controls.Add(richTextBox2);
            pnlNewMenuItem.Controls.Add(label9);
            pnlNewMenuItem.Controls.Add(richTextBox1);
            pnlNewMenuItem.Controls.Add(label8);
            pnlNewMenuItem.Controls.Add(pictureBox5);
            pnlNewMenuItem.Controls.Add(btnNewMenuItemAdd);
            pnlNewMenuItem.Controls.Add(listView3);
            pnlNewMenuItem.Controls.Add(label7);
            pnlNewMenuItem.Location = new Point(12, 12);
            pnlNewMenuItem.Name = "pnlNewMenuItem";
            pnlNewMenuItem.Size = new Size(374, 673);
            pnlNewMenuItem.TabIndex = 17;
            // 
            // btnBackToMenu
            // 
            btnBackToMenu.BackColor = Color.FromArgb(255, 179, 71);
            btnBackToMenu.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBackToMenu.Location = new Point(16, 601);
            btnBackToMenu.Name = "btnBackToMenu";
            btnBackToMenu.Size = new Size(121, 48);
            btnBackToMenu.TabIndex = 30;
            btnBackToMenu.Text = "BACK";
            btnBackToMenu.UseVisualStyleBackColor = false;
            btnBackToMenu.Click += btnBackToMenu_Click;
            // 
            // richTextBox3
            // 
            richTextBox3.BorderStyle = BorderStyle.None;
            richTextBox3.Location = new Point(193, 282);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(163, 28);
            richTextBox3.TabIndex = 29;
            richTextBox3.Text = "";
            // 
            // label10
            // 
            label10.BackColor = Color.FromArgb(196, 196, 196);
            label10.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(16, 279);
            label10.Name = "label10";
            label10.Size = new Size(345, 35);
            label10.TabIndex = 28;
            label10.Text = "Stock";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // richTextBox2
            // 
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Location = new Point(193, 236);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(163, 28);
            richTextBox2.TabIndex = 27;
            richTextBox2.Text = "";
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(196, 196, 196);
            label9.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(16, 233);
            label9.Name = "label9";
            label9.Size = new Size(345, 35);
            label9.TabIndex = 26;
            label9.Text = "Category";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(193, 189);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(163, 28);
            richTextBox1.TabIndex = 25;
            richTextBox1.Text = "";
            // 
            // label8
            // 
            label8.BackColor = Color.FromArgb(196, 196, 196);
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(16, 186);
            label8.Name = "label8";
            label8.Size = new Size(345, 35);
            label8.TabIndex = 24;
            label8.Text = "Name";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(137, 69);
            pictureBox5.TabIndex = 23;
            pictureBox5.TabStop = false;
            // 
            // btnNewMenuItemAdd
            // 
            btnNewMenuItemAdd.BackColor = Color.FromArgb(138, 210, 176);
            btnNewMenuItemAdd.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewMenuItemAdd.Location = new Point(234, 601);
            btnNewMenuItemAdd.Name = "btnNewMenuItemAdd";
            btnNewMenuItemAdd.Size = new Size(122, 48);
            btnNewMenuItemAdd.TabIndex = 22;
            btnNewMenuItemAdd.Text = "ADD";
            btnNewMenuItemAdd.UseVisualStyleBackColor = false;
            // 
            // listView3
            // 
            listView3.Location = new Point(0, 171);
            listView3.Name = "listView3";
            listView3.Size = new Size(374, 394);
            listView3.TabIndex = 21;
            listView3.UseCompatibleStateImageBehavior = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(6, 111);
            label7.Name = "label7";
            label7.Size = new Size(354, 54);
            label7.TabIndex = 20;
            label7.Text = "NEW MENU ITEM";
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1281, 697);
            Controls.Add(pnlMain);
            Controls.Add(pnlEmployees);
            Controls.Add(pnlMenu);
            Controls.Add(pnlNewEmployee);
            Controls.Add(pnlNewMenuItem);
            Name = "ManagerForm";
            Text = "ManagerForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            pnlNewEmployee.ResumeLayout(false);
            pnlNewEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlEmployees.ResumeLayout(false);
            pnlEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            pnlNewMenuItem.ResumeLayout(false);
            pnlNewMenuItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelEmployee;
        private Button buttonTableView;
        private Button buttonEmployeeManagement;
        private Button buttonMenu;
        private Panel pnlMain;
        private Panel pnlNewEmployee;
        private Button btnBackToEmployees;
        private Button btnAdd;
        private RichTextBox richTextBoxPassword;
        private RichTextBox richTextBoxRole;
        private Label label6;
        private Label label5;
        private RichTextBox richTextBoxName;
        private Label label4;
        private ListView listView1;
        private Label label3;
        private PictureBox pictureBox2;
        private Panel pnlEmployees;
        private PictureBox pictureBox3;
        private Button buttonRemove;
        private Button buttonAdjust;
        private ListView listViewEmployees;
        private Button buttonAddNewEmployee;
        private Label label1;
        private Panel pnlMenu;
        private PictureBox pictureBox4;
        private Button button1;
        private Button button2;
        private ListView listView2;
        private Button btnAddNewMenuItem;
        private Panel pnlNewMenuItem;
        private PictureBox pictureBox5;
        private Button btnNewMenuItemAdd;
        private ListView listView3;
        private Label label7;
        private RichTextBox richTextBox1;
        private Label label8;
        private RichTextBox richTextBox3;
        private Label label10;
        private RichTextBox richTextBox2;
        private Label label9;
        private Label label2;
        private Button btnBackToMenu;
        private Label lblBackToMain;
    }
}