namespace ChapeauUI
{
    partial class LoginForm
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
            btnLogin = new Button();
            listView1 = new ListView();
            label1 = new Label();
            label2 = new Label();
            txtBxUserID = new TextBox();
            txtBxPassword = new TextBox();
            pictureBox1 = new PictureBox();
            lblError = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(150, 438);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(87, 60);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(27, 183);
            listView1.Name = "listView1";
            listView1.Size = new Size(343, 365);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(89, 258);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 5;
            label1.Text = "User ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(89, 321);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 7;
            label2.Text = "Password:";
            // 
            // txtBxUserID
            // 
            txtBxUserID.Location = new Point(213, 258);
            txtBxUserID.Name = "txtBxUserID";
            txtBxUserID.Size = new Size(100, 27);
            txtBxUserID.TabIndex = 9;
            // 
            // txtBxPassword
            // 
            txtBxPassword.Location = new Point(213, 321);
            txtBxPassword.Name = "txtBxPassword";
            txtBxPassword.Size = new Size(100, 27);
            txtBxPassword.TabIndex = 11;
            txtBxPassword.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.Chapeau_logo;
            pictureBox1.Location = new Point(66, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(110, 389);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 20);
            lblError.TabIndex = 15;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(406, 600);
            Controls.Add(lblError);
            Controls.Add(pictureBox1);
            Controls.Add(txtBxPassword);
            Controls.Add(txtBxUserID);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(listView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private ListView listView1;
        private Label label1;
        private Label label2;
        private TextBox txtBxUserID;
        private TextBox txtBxPassword;
        private PictureBox pictureBox1;
        private Label lblError;
    }
}