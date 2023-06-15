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
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            pictureBox2 = new PictureBox();
            button3 = new Button();
            label12 = new Label();
            label16 = new Label();
            pnlEmployees = new Panel();
            lblBackToMain = new Label();
            pictureBox3 = new PictureBox();
            buttonRemove = new Button();
            buttonAdjustEmployee = new Button();
            listViewEmployees = new ListView();
            buttonAddNewEmployee = new Button();
            label1 = new Label();
            pnlMenu = new Panel();
            lblBackToMainFromMenu = new Label();
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
            pnlAdjustEmployee = new Panel();
            textBoxAdjustEmployeeRole = new TextBox();
            label15 = new Label();
            textBoxAdjustEmployeeNewPassword = new TextBox();
            label14 = new Label();
            textBoxAdjustEmployeeOldPassword = new TextBox();
            label13 = new Label();
            label11 = new Label();
            textBoxAdjustEmployeeName = new TextBox();
            pictureBox6 = new PictureBox();
            btnConfirmAdjustEmployee = new Button();
            lblAdjustEmployeeHeader = new Label();
            lblBackToEmployees = new Label();
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
            pnlAdjustEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
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
            pnlNewEmployee.Controls.Add(textBox1);
            pnlNewEmployee.Controls.Add(label3);
            pnlNewEmployee.Controls.Add(textBox2);
            pnlNewEmployee.Controls.Add(label4);
            pnlNewEmployee.Controls.Add(label6);
            pnlNewEmployee.Controls.Add(textBox4);
            pnlNewEmployee.Controls.Add(pictureBox2);
            pnlNewEmployee.Controls.Add(button3);
            pnlNewEmployee.Controls.Add(label12);
            pnlNewEmployee.Controls.Add(label16);
            pnlNewEmployee.Location = new Point(895, 12);
            pnlNewEmployee.Name = "pnlNewEmployee";
            pnlNewEmployee.Size = new Size(374, 673);
            pnlNewEmployee.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(16, 404);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 36);
            textBox1.TabIndex = 43;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(16, 371);
            label3.Name = "label3";
            label3.Size = new Size(55, 30);
            label3.TabIndex = 42;
            label3.Text = "Role";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(16, 310);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(222, 35);
            textBox2.TabIndex = 41;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(16, 277);
            label4.Name = "label4";
            label4.Size = new Size(147, 30);
            label4.TabIndex = 40;
            label4.Text = "New Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(16, 182);
            label6.Name = "label6";
            label6.Size = new Size(69, 30);
            label6.TabIndex = 37;
            label6.Text = "Naam";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(16, 215);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(222, 35);
            textBox4.TabIndex = 36;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(137, 69);
            pictureBox2.TabIndex = 34;
            pictureBox2.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(138, 210, 176);
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(125, 601);
            button3.Name = "button3";
            button3.Size = new Size(122, 48);
            button3.TabIndex = 33;
            button3.Text = "CONFIRM";
            button3.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(84, 115);
            label12.Name = "label12";
            label12.Size = new Size(259, 45);
            label12.TabIndex = 32;
            label12.Text = "ADD EMPLOYEE";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(3, 118);
            label16.Name = "label16";
            label16.Size = new Size(57, 37);
            label16.TabIndex = 35;
            label16.Text = "<--";
            // 
            // pnlEmployees
            // 
            pnlEmployees.Controls.Add(lblBackToMain);
            pnlEmployees.Controls.Add(pictureBox3);
            pnlEmployees.Controls.Add(buttonRemove);
            pnlEmployees.Controls.Add(buttonAdjustEmployee);
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
            // buttonAdjustEmployee
            // 
            buttonAdjustEmployee.BackColor = Color.FromArgb(138, 210, 176);
            buttonAdjustEmployee.Enabled = false;
            buttonAdjustEmployee.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdjustEmployee.Location = new Point(16, 601);
            buttonAdjustEmployee.Name = "buttonAdjustEmployee";
            buttonAdjustEmployee.Size = new Size(122, 48);
            buttonAdjustEmployee.TabIndex = 3;
            buttonAdjustEmployee.Text = "ADJUST";
            buttonAdjustEmployee.UseVisualStyleBackColor = false;
            buttonAdjustEmployee.Click += buttonAdjustEmployee_Click;
            // 
            // listViewEmployees
            // 
            listViewEmployees.Location = new Point(0, 170);
            listViewEmployees.Name = "listViewEmployees";
            listViewEmployees.Size = new Size(374, 394);
            listViewEmployees.TabIndex = 2;
            listViewEmployees.UseCompatibleStateImageBehavior = false;
            listViewEmployees.SelectedIndexChanged += listViewEmployees_SelectedIndexChanged;
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
            pnlMenu.Controls.Add(lblBackToMainFromMenu);
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
            // lblBackToMainFromMenu
            // 
            lblBackToMainFromMenu.AutoSize = true;
            lblBackToMainFromMenu.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblBackToMainFromMenu.Location = new Point(3, 121);
            lblBackToMainFromMenu.Name = "lblBackToMainFromMenu";
            lblBackToMainFromMenu.Size = new Size(57, 37);
            lblBackToMainFromMenu.TabIndex = 22;
            lblBackToMainFromMenu.Text = "<--";
            lblBackToMainFromMenu.Click += lblBackToMainFromMenu_Click;
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
            label2.Location = new Point(50, 111);
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
            // pnlAdjustEmployee
            // 
            pnlAdjustEmployee.Controls.Add(textBoxAdjustEmployeeRole);
            pnlAdjustEmployee.Controls.Add(label15);
            pnlAdjustEmployee.Controls.Add(textBoxAdjustEmployeeNewPassword);
            pnlAdjustEmployee.Controls.Add(label14);
            pnlAdjustEmployee.Controls.Add(textBoxAdjustEmployeeOldPassword);
            pnlAdjustEmployee.Controls.Add(label13);
            pnlAdjustEmployee.Controls.Add(label11);
            pnlAdjustEmployee.Controls.Add(textBoxAdjustEmployeeName);
            pnlAdjustEmployee.Controls.Add(pictureBox6);
            pnlAdjustEmployee.Controls.Add(btnConfirmAdjustEmployee);
            pnlAdjustEmployee.Controls.Add(lblAdjustEmployeeHeader);
            pnlAdjustEmployee.Controls.Add(lblBackToEmployees);
            pnlAdjustEmployee.Location = new Point(12, 12);
            pnlAdjustEmployee.Name = "pnlAdjustEmployee";
            pnlAdjustEmployee.Size = new Size(374, 673);
            pnlAdjustEmployee.TabIndex = 18;
            // 
            // textBoxAdjustEmployeeRole
            // 
            textBoxAdjustEmployeeRole.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAdjustEmployeeRole.Location = new Point(16, 500);
            textBoxAdjustEmployeeRole.Name = "textBoxAdjustEmployeeRole";
            textBoxAdjustEmployeeRole.Size = new Size(222, 36);
            textBoxAdjustEmployeeRole.TabIndex = 31;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(16, 467);
            label15.Name = "label15";
            label15.Size = new Size(55, 30);
            label15.TabIndex = 30;
            label15.Text = "Role";
            // 
            // textBoxAdjustEmployeeNewPassword
            // 
            textBoxAdjustEmployeeNewPassword.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAdjustEmployeeNewPassword.Location = new Point(16, 405);
            textBoxAdjustEmployeeNewPassword.Name = "textBoxAdjustEmployeeNewPassword";
            textBoxAdjustEmployeeNewPassword.Size = new Size(222, 35);
            textBoxAdjustEmployeeNewPassword.TabIndex = 29;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(16, 372);
            label14.Name = "label14";
            label14.Size = new Size(147, 30);
            label14.TabIndex = 28;
            label14.Text = "New Password";
            // 
            // textBoxAdjustEmployeeOldPassword
            // 
            textBoxAdjustEmployeeOldPassword.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAdjustEmployeeOldPassword.Location = new Point(16, 310);
            textBoxAdjustEmployeeOldPassword.Name = "textBoxAdjustEmployeeOldPassword";
            textBoxAdjustEmployeeOldPassword.Size = new Size(222, 35);
            textBoxAdjustEmployeeOldPassword.TabIndex = 27;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(16, 277);
            label13.Name = "label13";
            label13.Size = new Size(138, 30);
            label13.TabIndex = 26;
            label13.Text = "Old Password";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(16, 182);
            label11.Name = "label11";
            label11.Size = new Size(69, 30);
            label11.TabIndex = 25;
            label11.Text = "Naam";
            // 
            // textBoxAdjustEmployeeName
            // 
            textBoxAdjustEmployeeName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAdjustEmployeeName.Location = new Point(16, 215);
            textBoxAdjustEmployeeName.Name = "textBoxAdjustEmployeeName";
            textBoxAdjustEmployeeName.Size = new Size(222, 35);
            textBoxAdjustEmployeeName.TabIndex = 24;
            textBoxAdjustEmployeeName.TextChanged += textBoxAdjustEmployeeName_TextChanged;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(0, 0);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(137, 69);
            pictureBox6.TabIndex = 22;
            pictureBox6.TabStop = false;
            // 
            // btnConfirmAdjustEmployee
            // 
            btnConfirmAdjustEmployee.BackColor = Color.FromArgb(138, 210, 176);
            btnConfirmAdjustEmployee.Enabled = false;
            btnConfirmAdjustEmployee.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmAdjustEmployee.Location = new Point(125, 601);
            btnConfirmAdjustEmployee.Name = "btnConfirmAdjustEmployee";
            btnConfirmAdjustEmployee.Size = new Size(122, 48);
            btnConfirmAdjustEmployee.TabIndex = 20;
            btnConfirmAdjustEmployee.Text = "CONFIRM";
            btnConfirmAdjustEmployee.UseVisualStyleBackColor = false;
            btnConfirmAdjustEmployee.Click += btnConfirmAdjustEmployee_Click;
            // 
            // lblAdjustEmployeeHeader
            // 
            lblAdjustEmployeeHeader.AutoSize = true;
            lblAdjustEmployeeHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdjustEmployeeHeader.Location = new Point(50, 124);
            lblAdjustEmployeeHeader.Name = "lblAdjustEmployeeHeader";
            lblAdjustEmployeeHeader.Size = new Size(212, 30);
            lblAdjustEmployeeHeader.TabIndex = 17;
            lblAdjustEmployeeHeader.Text = "ADJUST EMPLOYEE";
            // 
            // lblBackToEmployees
            // 
            lblBackToEmployees.AutoSize = true;
            lblBackToEmployees.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblBackToEmployees.Location = new Point(3, 118);
            lblBackToEmployees.Name = "lblBackToEmployees";
            lblBackToEmployees.Size = new Size(57, 37);
            lblBackToEmployees.TabIndex = 23;
            lblBackToEmployees.Text = "<--";
            lblBackToEmployees.Click += lblBackToEmployees_Click;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1281, 697);
            Controls.Add(pnlMain);
            Controls.Add(pnlNewEmployee);
            Controls.Add(pnlAdjustEmployee);
            Controls.Add(pnlEmployees);
            Controls.Add(pnlMenu);
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
            pnlAdjustEmployee.ResumeLayout(false);
            pnlAdjustEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
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
        private Panel pnlEmployees;
        private PictureBox pictureBox3;
        private Button buttonRemove;
        private Button buttonAdjustEmployee;
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
        private Label lblBackToMainFromMenu;
        private Panel pnlAdjustEmployee;
        private Label lblBackToEmployees;
        private PictureBox pictureBox6;
        private Button btnConfirmAdjustEmployee;
        private Label lblAdjustEmployeeHeader;
        private TextBox textBoxAdjustEmployeeNewPassword;
        private Label label14;
        private TextBox textBoxAdjustEmployeeOldPassword;
        private Label label13;
        private Label label11;
        private TextBox textBoxAdjustEmployeeName;
        private TextBox textBoxAdjustEmployeeRole;
        private Label label15;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private Label label6;
        private TextBox textBox4;
        private PictureBox pictureBox2;
        private Button button3;
        private Label label12;
        private Label label16;
    }
}