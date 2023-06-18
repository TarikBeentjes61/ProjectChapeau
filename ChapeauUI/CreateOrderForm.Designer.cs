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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateOrderForm));
            lblTableLunchOverview = new Label();
            lblImageChapeau1 = new Label();
            btnLunchUnavailable = new Button();
            btnDinnerFromLunchOverview = new Button();
            btnDrinksFromLunchOverview = new Button();
            lblEmployee = new Label();
            listViewOrderLunch = new ListView();
            lblOrderLunch = new Label();
            listViewDesertsLunch = new ListView();
            listViewStartersLunch = new ListView();
            listViewMainsLunch = new ListView();
            lblStartersLunch = new Label();
            lblMainsLunch = new Label();
            lblDesertsLunch = new Label();
            pnlCreateOrderLunch = new Panel();
            btnRemoveLunch = new Button();
            btnCommentLunch = new Button();
            btnAddLunch = new Button();
            pnlOrderOverview = new Panel();
            btnDrinksOrderOverview = new Button();
            listViewOrderOverview = new ListView();
            lblTableOrderOverview = new Label();
            lblImageChapeau2 = new Label();
            btnLunchOrderOverview = new Button();
            label2 = new Label();
            btnDinnerOrderOverview = new Button();
            lblTotal = new Label();
            lblEmployee2 = new Label();
            label7 = new Label();
            btnPay = new Button();
            label8 = new Label();
            button1 = new Button();
            label9 = new Label();
            button2 = new Button();
            button3 = new Button();
            pnlCreateOrderDinner = new Panel();
            btnRemoveDinner = new Button();
            btnCommentDinner = new Button();
            btnAddDinner = new Button();
            lblEntres = new Label();
            listViewEntresDinner = new ListView();
            btnDrinksFromDinnerOverview = new Button();
            lblDesertsDinner = new Label();
            lblTableDinnerOverview = new Label();
            lblMainsDinner = new Label();
            lblImageChapeau3 = new Label();
            lblStartersDinner = new Label();
            btnLunchFromDinnerOverview = new Button();
            listViewMainsDinner = new ListView();
            btnDinnerUnavailable = new Button();
            listViewStartersDinner = new ListView();
            listViewDesertsDinner = new ListView();
            lblEmployee3 = new Label();
            lblOrderDinner = new Label();
            listViewOrderDinner = new ListView();
            pnlCreateOrderDrinks = new Panel();
            btnRemoveDrinks = new Button();
            btnCommentDrinks = new Button();
            btnAddDrinks = new Button();
            listViewHotDrinks = new ListView();
            listViewSpirits = new ListView();
            lblHotDrinks = new Label();
            lblSpirits = new Label();
            btnDrinksUnavailable = new Button();
            lblWines = new Label();
            lblTableDrinksOverview = new Label();
            lblBeers = new Label();
            lblImageChapeau = new Label();
            lblSoftDrinks = new Label();
            btnLunchFromDrinksOverview = new Button();
            listViewBeers = new ListView();
            btnDinnerFromDrinksOverview = new Button();
            listViewSoftDrinks = new ListView();
            listViewWines = new ListView();
            lblEmployee4 = new Label();
            lblOrderDrinks = new Label();
            listViewOrderDrinks = new ListView();
            pnlComment = new Panel();
            txtBoxComment = new TextBox();
            btnBack = new Button();
            btnAddComment = new Button();
            pnlCreateOrderLunch.SuspendLayout();
            pnlOrderOverview.SuspendLayout();
            pnlCreateOrderDinner.SuspendLayout();
            pnlCreateOrderDrinks.SuspendLayout();
            pnlComment.SuspendLayout();
            SuspendLayout();
            // 
            // lblTableLunchOverview
            // 
            lblTableLunchOverview.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblTableLunchOverview.Location = new Point(183, 24);
            lblTableLunchOverview.Name = "lblTableLunchOverview";
            lblTableLunchOverview.Size = new Size(124, 45);
            lblTableLunchOverview.TabIndex = 1;
            lblTableLunchOverview.Text = "TAFEL #1";
            lblTableLunchOverview.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblImageChapeau1
            // 
            lblImageChapeau1.Image = (Image)resources.GetObject("lblImageChapeau1.Image");
            lblImageChapeau1.Location = new Point(3, 3);
            lblImageChapeau1.Name = "lblImageChapeau1";
            lblImageChapeau1.Size = new Size(131, 66);
            lblImageChapeau1.TabIndex = 2;
            lblImageChapeau1.Text = " ";
            // 
            // btnLunchUnavailable
            // 
            btnLunchUnavailable.BackColor = Color.FromArgb(138, 210, 176);
            btnLunchUnavailable.FlatAppearance.BorderSize = 2;
            btnLunchUnavailable.Location = new Point(61, 95);
            btnLunchUnavailable.Name = "btnLunchUnavailable";
            btnLunchUnavailable.Size = new Size(90, 50);
            btnLunchUnavailable.TabIndex = 3;
            btnLunchUnavailable.Text = "LUNCH";
            btnLunchUnavailable.UseVisualStyleBackColor = false;
            // 
            // btnDinnerFromLunchOverview
            // 
            btnDinnerFromLunchOverview.BackColor = Color.FromArgb(138, 210, 176);
            btnDinnerFromLunchOverview.Location = new Point(196, 95);
            btnDinnerFromLunchOverview.Name = "btnDinnerFromLunchOverview";
            btnDinnerFromLunchOverview.Size = new Size(90, 50);
            btnDinnerFromLunchOverview.TabIndex = 4;
            btnDinnerFromLunchOverview.Text = "DINNER";
            btnDinnerFromLunchOverview.UseVisualStyleBackColor = false;
            btnDinnerFromLunchOverview.Click += btnDinner_Click;
            // 
            // btnDrinksFromLunchOverview
            // 
            btnDrinksFromLunchOverview.BackColor = Color.FromArgb(138, 210, 176);
            btnDrinksFromLunchOverview.ForeColor = Color.Black;
            btnDrinksFromLunchOverview.Location = new Point(328, 95);
            btnDrinksFromLunchOverview.Name = "btnDrinksFromLunchOverview";
            btnDrinksFromLunchOverview.Size = new Size(90, 50);
            btnDrinksFromLunchOverview.TabIndex = 5;
            btnDrinksFromLunchOverview.Text = "DRINKS";
            btnDrinksFromLunchOverview.UseVisualStyleBackColor = false;
            btnDrinksFromLunchOverview.Click += btnDrinksFromLunchOverview_Click;
            // 
            // lblEmployee
            // 
            lblEmployee.BackColor = Color.FromArgb(255, 179, 71);
            lblEmployee.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmployee.Location = new Point(382, 8);
            lblEmployee.Margin = new Padding(0);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(86, 40);
            lblEmployee.TabIndex = 6;
            lblEmployee.Text = "Naam";
            lblEmployee.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listViewOrderLunch
            // 
            listViewOrderLunch.Location = new Point(15, 704);
            listViewOrderLunch.Name = "listViewOrderLunch";
            listViewOrderLunch.Size = new Size(344, 246);
            listViewOrderLunch.TabIndex = 7;
            listViewOrderLunch.UseCompatibleStateImageBehavior = false;
            listViewOrderLunch.View = View.Details;
            listViewOrderLunch.SelectedIndexChanged += listViewOrderLunch_SelectedIndexChanged;
            // 
            // lblOrderLunch
            // 
            lblOrderLunch.AutoSize = true;
            lblOrderLunch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrderLunch.Location = new Point(15, 671);
            lblOrderLunch.Name = "lblOrderLunch";
            lblOrderLunch.Size = new Size(49, 20);
            lblOrderLunch.TabIndex = 8;
            lblOrderLunch.Text = "Order";
            // 
            // listViewDesertsLunch
            // 
            listViewDesertsLunch.Location = new Point(15, 502);
            listViewDesertsLunch.Name = "listViewDesertsLunch";
            listViewDesertsLunch.Size = new Size(444, 116);
            listViewDesertsLunch.TabIndex = 9;
            listViewDesertsLunch.UseCompatibleStateImageBehavior = false;
            listViewDesertsLunch.View = View.Details;
            listViewDesertsLunch.SelectedIndexChanged += listViewDesertsLunch_SelectedIndexChanged;
            // 
            // listViewStartersLunch
            // 
            listViewStartersLunch.Location = new Point(15, 185);
            listViewStartersLunch.Name = "listViewStartersLunch";
            listViewStartersLunch.Size = new Size(444, 116);
            listViewStartersLunch.TabIndex = 10;
            listViewStartersLunch.UseCompatibleStateImageBehavior = false;
            listViewStartersLunch.SelectedIndexChanged += listViewStartersLunch_SelectedIndexChanged;
            // 
            // listViewMainsLunch
            // 
            listViewMainsLunch.Location = new Point(15, 341);
            listViewMainsLunch.Name = "listViewMainsLunch";
            listViewMainsLunch.Size = new Size(444, 116);
            listViewMainsLunch.TabIndex = 11;
            listViewMainsLunch.UseCompatibleStateImageBehavior = false;
            listViewMainsLunch.SelectedIndexChanged += listViewMainsLunch_SelectedIndexChanged;
            // 
            // lblStartersLunch
            // 
            lblStartersLunch.AutoSize = true;
            lblStartersLunch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblStartersLunch.Location = new Point(196, 162);
            lblStartersLunch.Name = "lblStartersLunch";
            lblStartersLunch.Size = new Size(81, 20);
            lblStartersLunch.TabIndex = 12;
            lblStartersLunch.Text = "STARTERS";
            lblStartersLunch.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMainsLunch
            // 
            lblMainsLunch.AutoSize = true;
            lblMainsLunch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMainsLunch.Location = new Point(208, 313);
            lblMainsLunch.Name = "lblMainsLunch";
            lblMainsLunch.Size = new Size(59, 20);
            lblMainsLunch.TabIndex = 13;
            lblMainsLunch.Text = "MAINS";
            lblMainsLunch.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDesertsLunch
            // 
            lblDesertsLunch.AutoSize = true;
            lblDesertsLunch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDesertsLunch.Location = new Point(206, 479);
            lblDesertsLunch.Name = "lblDesertsLunch";
            lblDesertsLunch.Size = new Size(71, 20);
            lblDesertsLunch.TabIndex = 14;
            lblDesertsLunch.Text = "DESERTS";
            lblDesertsLunch.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCreateOrderLunch
            // 
            pnlCreateOrderLunch.AutoScroll = true;
            pnlCreateOrderLunch.Controls.Add(btnRemoveLunch);
            pnlCreateOrderLunch.Controls.Add(btnCommentLunch);
            pnlCreateOrderLunch.Controls.Add(btnAddLunch);
            pnlCreateOrderLunch.Controls.Add(btnDrinksFromLunchOverview);
            pnlCreateOrderLunch.Controls.Add(lblDesertsLunch);
            pnlCreateOrderLunch.Controls.Add(lblTableLunchOverview);
            pnlCreateOrderLunch.Controls.Add(lblMainsLunch);
            pnlCreateOrderLunch.Controls.Add(lblImageChapeau1);
            pnlCreateOrderLunch.Controls.Add(lblStartersLunch);
            pnlCreateOrderLunch.Controls.Add(btnLunchUnavailable);
            pnlCreateOrderLunch.Controls.Add(listViewMainsLunch);
            pnlCreateOrderLunch.Controls.Add(btnDinnerFromLunchOverview);
            pnlCreateOrderLunch.Controls.Add(listViewStartersLunch);
            pnlCreateOrderLunch.Controls.Add(listViewDesertsLunch);
            pnlCreateOrderLunch.Controls.Add(lblEmployee);
            pnlCreateOrderLunch.Controls.Add(lblOrderLunch);
            pnlCreateOrderLunch.Controls.Add(listViewOrderLunch);
            pnlCreateOrderLunch.Location = new Point(2, 2);
            pnlCreateOrderLunch.Name = "pnlCreateOrderLunch";
            pnlCreateOrderLunch.Size = new Size(477, 968);
            pnlCreateOrderLunch.TabIndex = 15;
            // 
            // btnRemoveLunch
            // 
            btnRemoveLunch.BackColor = Color.FromArgb(255, 179, 71);
            btnRemoveLunch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemoveLunch.Location = new Point(362, 753);
            btnRemoveLunch.Margin = new Padding(0);
            btnRemoveLunch.Name = "btnRemoveLunch";
            btnRemoveLunch.Size = new Size(106, 49);
            btnRemoveLunch.TabIndex = 17;
            btnRemoveLunch.Text = "REMOVE";
            btnRemoveLunch.UseVisualStyleBackColor = false;
            btnRemoveLunch.Click += btnRemoveLunch_Click;
            // 
            // btnCommentLunch
            // 
            btnCommentLunch.BackColor = Color.FromArgb(196, 196, 196);
            btnCommentLunch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCommentLunch.Location = new Point(362, 704);
            btnCommentLunch.Margin = new Padding(0);
            btnCommentLunch.Name = "btnCommentLunch";
            btnCommentLunch.Size = new Size(106, 49);
            btnCommentLunch.TabIndex = 16;
            btnCommentLunch.Text = "COMMENT";
            btnCommentLunch.UseVisualStyleBackColor = false;
            btnCommentLunch.Click += btnCommentLunch_Click;
            // 
            // btnAddLunch
            // 
            btnAddLunch.BackColor = Color.FromArgb(255, 179, 71);
            btnAddLunch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddLunch.Location = new Point(362, 901);
            btnAddLunch.Margin = new Padding(0);
            btnAddLunch.Name = "btnAddLunch";
            btnAddLunch.Size = new Size(106, 49);
            btnAddLunch.TabIndex = 15;
            btnAddLunch.Text = "ADD";
            btnAddLunch.UseVisualStyleBackColor = false;
            btnAddLunch.Click += btnAddLunch_Click;
            // 
            // pnlOrderOverview
            // 
            pnlOrderOverview.Controls.Add(btnDrinksOrderOverview);
            pnlOrderOverview.Controls.Add(listViewOrderOverview);
            pnlOrderOverview.Controls.Add(lblTableOrderOverview);
            pnlOrderOverview.Controls.Add(lblImageChapeau2);
            pnlOrderOverview.Controls.Add(btnLunchOrderOverview);
            pnlOrderOverview.Controls.Add(label2);
            pnlOrderOverview.Controls.Add(btnDinnerOrderOverview);
            pnlOrderOverview.Controls.Add(lblTotal);
            pnlOrderOverview.Controls.Add(lblEmployee2);
            pnlOrderOverview.Controls.Add(label7);
            pnlOrderOverview.Controls.Add(btnPay);
            pnlOrderOverview.Controls.Add(label8);
            pnlOrderOverview.Controls.Add(button1);
            pnlOrderOverview.Controls.Add(label9);
            pnlOrderOverview.Controls.Add(button2);
            pnlOrderOverview.Controls.Add(button3);
            pnlOrderOverview.Location = new Point(485, 2);
            pnlOrderOverview.Name = "pnlOrderOverview";
            pnlOrderOverview.Size = new Size(477, 603);
            pnlOrderOverview.TabIndex = 18;
            // 
            // btnDrinksOrderOverview
            // 
            btnDrinksOrderOverview.BackColor = Color.FromArgb(138, 210, 176);
            btnDrinksOrderOverview.ForeColor = Color.Black;
            btnDrinksOrderOverview.Location = new Point(335, 98);
            btnDrinksOrderOverview.Name = "btnDrinksOrderOverview";
            btnDrinksOrderOverview.Size = new Size(90, 50);
            btnDrinksOrderOverview.TabIndex = 23;
            btnDrinksOrderOverview.Text = "DRINKS";
            btnDrinksOrderOverview.UseVisualStyleBackColor = false;
            btnDrinksOrderOverview.Click += btnDrinksOrderOverview_Click;
            // 
            // listViewOrderOverview
            // 
            listViewOrderOverview.Location = new Point(17, 183);
            listViewOrderOverview.Name = "listViewOrderOverview";
            listViewOrderOverview.Size = new Size(444, 265);
            listViewOrderOverview.TabIndex = 13;
            listViewOrderOverview.UseCompatibleStateImageBehavior = false;
            // 
            // lblTableOrderOverview
            // 
            lblTableOrderOverview.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblTableOrderOverview.Location = new Point(179, 24);
            lblTableOrderOverview.Name = "lblTableOrderOverview";
            lblTableOrderOverview.Size = new Size(124, 45);
            lblTableOrderOverview.TabIndex = 19;
            lblTableOrderOverview.Text = "TAFEL #1";
            lblTableOrderOverview.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblImageChapeau2
            // 
            lblImageChapeau2.Image = (Image)resources.GetObject("lblImageChapeau2.Image");
            lblImageChapeau2.Location = new Point(3, 3);
            lblImageChapeau2.Name = "lblImageChapeau2";
            lblImageChapeau2.Size = new Size(131, 66);
            lblImageChapeau2.TabIndex = 20;
            lblImageChapeau2.Text = " ";
            // 
            // btnLunchOrderOverview
            // 
            btnLunchOrderOverview.BackColor = Color.FromArgb(138, 210, 176);
            btnLunchOrderOverview.FlatAppearance.BorderSize = 2;
            btnLunchOrderOverview.Location = new Point(68, 98);
            btnLunchOrderOverview.Name = "btnLunchOrderOverview";
            btnLunchOrderOverview.Size = new Size(90, 50);
            btnLunchOrderOverview.TabIndex = 21;
            btnLunchOrderOverview.Text = "LUNCH";
            btnLunchOrderOverview.UseVisualStyleBackColor = false;
            btnLunchOrderOverview.Click += btnLunchOrderOverview_Click;
            // 
            // label2
            // 
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(-2, 5);
            label2.Name = "label2";
            label2.Size = new Size(0, 0);
            label2.TabIndex = 3;
            label2.Text = " ";
            // 
            // btnDinnerOrderOverview
            // 
            btnDinnerOrderOverview.BackColor = Color.FromArgb(138, 210, 176);
            btnDinnerOrderOverview.Location = new Point(203, 98);
            btnDinnerOrderOverview.Name = "btnDinnerOrderOverview";
            btnDinnerOrderOverview.Size = new Size(90, 50);
            btnDinnerOrderOverview.TabIndex = 22;
            btnDinnerOrderOverview.Text = "DINNER";
            btnDinnerOrderOverview.UseVisualStyleBackColor = false;
            btnDinnerOrderOverview.Click += btnDinnerOrderOverview_Click;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(248, 467);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(87, 35);
            lblTotal.TabIndex = 15;
            lblTotal.Text = "Total: ";
            // 
            // lblEmployee2
            // 
            lblEmployee2.BackColor = Color.FromArgb(255, 179, 71);
            lblEmployee2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmployee2.Location = new Point(382, 8);
            lblEmployee2.Margin = new Padding(0);
            lblEmployee2.Name = "lblEmployee2";
            lblEmployee2.Size = new Size(86, 40);
            lblEmployee2.TabIndex = 24;
            lblEmployee2.Text = "Naam";
            lblEmployee2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(141, 22);
            label7.Name = "label7";
            label7.Size = new Size(0, 0);
            label7.TabIndex = 7;
            label7.Text = "TAFEL #1";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.FromArgb(255, 179, 71);
            btnPay.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPay.Location = new Point(334, 541);
            btnPay.Margin = new Padding(0);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(127, 49);
            btnPay.TabIndex = 14;
            btnPay.Text = "PAY";
            btnPay.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.Image = (Image)resources.GetObject("label8.Image");
            label8.Location = new Point(17, 13);
            label8.Name = "label8";
            label8.Size = new Size(0, 0);
            label8.TabIndex = 8;
            label8.Text = " ";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(138, 210, 176);
            button1.Location = new Point(68, 95);
            button1.Name = "button1";
            button1.Size = new Size(0, 0);
            button1.TabIndex = 9;
            button1.Text = "LUNCH";
            button1.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(255, 179, 71);
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(303, 13);
            label9.Margin = new Padding(0);
            label9.Name = "label9";
            label9.Size = new Size(0, 0);
            label9.TabIndex = 12;
            label9.Text = "Naam";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(138, 210, 176);
            button2.Location = new Point(203, 95);
            button2.Name = "button2";
            button2.Size = new Size(0, 0);
            button2.TabIndex = 10;
            button2.Text = "DINNER";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(138, 210, 176);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(335, 95);
            button3.Name = "button3";
            button3.Size = new Size(0, 0);
            button3.TabIndex = 11;
            button3.Text = "DRINKS";
            button3.UseVisualStyleBackColor = false;
            // 
            // pnlCreateOrderDinner
            // 
            pnlCreateOrderDinner.Controls.Add(btnRemoveDinner);
            pnlCreateOrderDinner.Controls.Add(btnCommentDinner);
            pnlCreateOrderDinner.Controls.Add(btnAddDinner);
            pnlCreateOrderDinner.Controls.Add(lblEntres);
            pnlCreateOrderDinner.Controls.Add(listViewEntresDinner);
            pnlCreateOrderDinner.Controls.Add(btnDrinksFromDinnerOverview);
            pnlCreateOrderDinner.Controls.Add(lblDesertsDinner);
            pnlCreateOrderDinner.Controls.Add(lblTableDinnerOverview);
            pnlCreateOrderDinner.Controls.Add(lblMainsDinner);
            pnlCreateOrderDinner.Controls.Add(lblImageChapeau3);
            pnlCreateOrderDinner.Controls.Add(lblStartersDinner);
            pnlCreateOrderDinner.Controls.Add(btnLunchFromDinnerOverview);
            pnlCreateOrderDinner.Controls.Add(listViewMainsDinner);
            pnlCreateOrderDinner.Controls.Add(btnDinnerUnavailable);
            pnlCreateOrderDinner.Controls.Add(listViewStartersDinner);
            pnlCreateOrderDinner.Controls.Add(listViewDesertsDinner);
            pnlCreateOrderDinner.Controls.Add(lblEmployee3);
            pnlCreateOrderDinner.Controls.Add(lblOrderDinner);
            pnlCreateOrderDinner.Controls.Add(listViewOrderDinner);
            pnlCreateOrderDinner.Location = new Point(968, 2);
            pnlCreateOrderDinner.Name = "pnlCreateOrderDinner";
            pnlCreateOrderDinner.Size = new Size(492, 1047);
            pnlCreateOrderDinner.TabIndex = 19;
            // 
            // btnRemoveDinner
            // 
            btnRemoveDinner.BackColor = Color.FromArgb(255, 179, 71);
            btnRemoveDinner.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemoveDinner.Location = new Point(362, 853);
            btnRemoveDinner.Margin = new Padding(0);
            btnRemoveDinner.Name = "btnRemoveDinner";
            btnRemoveDinner.Size = new Size(106, 49);
            btnRemoveDinner.TabIndex = 20;
            btnRemoveDinner.Text = "REMOVE";
            btnRemoveDinner.UseVisualStyleBackColor = false;
            btnRemoveDinner.Click += btnRemoveDinner_Click;
            // 
            // btnCommentDinner
            // 
            btnCommentDinner.BackColor = Color.FromArgb(196, 196, 196);
            btnCommentDinner.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCommentDinner.Location = new Point(362, 804);
            btnCommentDinner.Margin = new Padding(0);
            btnCommentDinner.Name = "btnCommentDinner";
            btnCommentDinner.Size = new Size(106, 49);
            btnCommentDinner.TabIndex = 19;
            btnCommentDinner.Text = "COMMENT";
            btnCommentDinner.UseVisualStyleBackColor = false;
            btnCommentDinner.Click += btnCommentDinner_Click;
            // 
            // btnAddDinner
            // 
            btnAddDinner.BackColor = Color.FromArgb(255, 179, 71);
            btnAddDinner.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddDinner.Location = new Point(362, 979);
            btnAddDinner.Margin = new Padding(0);
            btnAddDinner.Name = "btnAddDinner";
            btnAddDinner.Size = new Size(106, 49);
            btnAddDinner.TabIndex = 17;
            btnAddDinner.Text = "ADD";
            btnAddDinner.UseVisualStyleBackColor = false;
            btnAddDinner.Click += btnAddDinner_Click;
            // 
            // lblEntres
            // 
            lblEntres.AutoSize = true;
            lblEntres.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEntres.Location = new Point(206, 302);
            lblEntres.Name = "lblEntres";
            lblEntres.Size = new Size(64, 20);
            lblEntres.TabIndex = 16;
            lblEntres.Text = "ENTRES";
            // 
            // listViewEntresDinner
            // 
            listViewEntresDinner.Location = new Point(15, 327);
            listViewEntresDinner.Name = "listViewEntresDinner";
            listViewEntresDinner.Size = new Size(444, 121);
            listViewEntresDinner.TabIndex = 15;
            listViewEntresDinner.UseCompatibleStateImageBehavior = false;
            listViewEntresDinner.SelectedIndexChanged += listViewEntresDinner_SelectedIndexChanged;
            // 
            // btnDrinksFromDinnerOverview
            // 
            btnDrinksFromDinnerOverview.BackColor = Color.FromArgb(138, 210, 176);
            btnDrinksFromDinnerOverview.ForeColor = Color.Black;
            btnDrinksFromDinnerOverview.Location = new Point(334, 98);
            btnDrinksFromDinnerOverview.Name = "btnDrinksFromDinnerOverview";
            btnDrinksFromDinnerOverview.Size = new Size(90, 50);
            btnDrinksFromDinnerOverview.TabIndex = 5;
            btnDrinksFromDinnerOverview.Text = "DRINKS";
            btnDrinksFromDinnerOverview.UseVisualStyleBackColor = false;
            btnDrinksFromDinnerOverview.Click += btnDrinksFromDinnerOverview_Click;
            // 
            // lblDesertsDinner
            // 
            lblDesertsDinner.AutoSize = true;
            lblDesertsDinner.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDesertsDinner.Location = new Point(208, 593);
            lblDesertsDinner.Name = "lblDesertsDinner";
            lblDesertsDinner.Size = new Size(71, 20);
            lblDesertsDinner.TabIndex = 14;
            lblDesertsDinner.Text = "DESERTS";
            lblDesertsDinner.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTableDinnerOverview
            // 
            lblTableDinnerOverview.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblTableDinnerOverview.Location = new Point(177, 24);
            lblTableDinnerOverview.Name = "lblTableDinnerOverview";
            lblTableDinnerOverview.Size = new Size(124, 45);
            lblTableDinnerOverview.TabIndex = 1;
            lblTableDinnerOverview.Text = "TAFEL #1";
            lblTableDinnerOverview.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMainsDinner
            // 
            lblMainsDinner.AutoSize = true;
            lblMainsDinner.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMainsDinner.Location = new Point(211, 451);
            lblMainsDinner.Name = "lblMainsDinner";
            lblMainsDinner.Size = new Size(59, 20);
            lblMainsDinner.TabIndex = 13;
            lblMainsDinner.Text = "MAINS";
            lblMainsDinner.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblImageChapeau3
            // 
            lblImageChapeau3.Image = (Image)resources.GetObject("lblImageChapeau3.Image");
            lblImageChapeau3.Location = new Point(3, 3);
            lblImageChapeau3.Name = "lblImageChapeau3";
            lblImageChapeau3.Size = new Size(131, 66);
            lblImageChapeau3.TabIndex = 2;
            lblImageChapeau3.Text = " ";
            // 
            // lblStartersDinner
            // 
            lblStartersDinner.AutoSize = true;
            lblStartersDinner.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblStartersDinner.Location = new Point(202, 161);
            lblStartersDinner.Name = "lblStartersDinner";
            lblStartersDinner.Size = new Size(81, 20);
            lblStartersDinner.TabIndex = 12;
            lblStartersDinner.Text = "STARTERS";
            lblStartersDinner.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLunchFromDinnerOverview
            // 
            btnLunchFromDinnerOverview.BackColor = Color.FromArgb(138, 210, 176);
            btnLunchFromDinnerOverview.FlatAppearance.BorderSize = 2;
            btnLunchFromDinnerOverview.Location = new Point(67, 98);
            btnLunchFromDinnerOverview.Name = "btnLunchFromDinnerOverview";
            btnLunchFromDinnerOverview.Size = new Size(90, 50);
            btnLunchFromDinnerOverview.TabIndex = 3;
            btnLunchFromDinnerOverview.Text = "LUNCH";
            btnLunchFromDinnerOverview.UseVisualStyleBackColor = false;
            btnLunchFromDinnerOverview.Click += btnLunchFromDinnerOverview_Click;
            // 
            // listViewMainsDinner
            // 
            listViewMainsDinner.Location = new Point(15, 474);
            listViewMainsDinner.Name = "listViewMainsDinner";
            listViewMainsDinner.Size = new Size(444, 116);
            listViewMainsDinner.TabIndex = 11;
            listViewMainsDinner.UseCompatibleStateImageBehavior = false;
            listViewMainsDinner.SelectedIndexChanged += listViewMainsDinner_SelectedIndexChanged;
            // 
            // btnDinnerUnavailable
            // 
            btnDinnerUnavailable.BackColor = Color.FromArgb(138, 210, 176);
            btnDinnerUnavailable.Location = new Point(202, 98);
            btnDinnerUnavailable.Name = "btnDinnerUnavailable";
            btnDinnerUnavailable.Size = new Size(90, 50);
            btnDinnerUnavailable.TabIndex = 4;
            btnDinnerUnavailable.Text = "DINNER";
            btnDinnerUnavailable.UseVisualStyleBackColor = false;
            // 
            // listViewStartersDinner
            // 
            listViewStartersDinner.Location = new Point(15, 183);
            listViewStartersDinner.Name = "listViewStartersDinner";
            listViewStartersDinner.Size = new Size(444, 116);
            listViewStartersDinner.TabIndex = 10;
            listViewStartersDinner.UseCompatibleStateImageBehavior = false;
            listViewStartersDinner.SelectedIndexChanged += listViewStartersDinner_SelectedIndexChanged;
            // 
            // listViewDesertsDinner
            // 
            listViewDesertsDinner.Location = new Point(15, 616);
            listViewDesertsDinner.Name = "listViewDesertsDinner";
            listViewDesertsDinner.Size = new Size(444, 116);
            listViewDesertsDinner.TabIndex = 9;
            listViewDesertsDinner.UseCompatibleStateImageBehavior = false;
            listViewDesertsDinner.SelectedIndexChanged += listViewDesertsDinner_SelectedIndexChanged;
            // 
            // lblEmployee3
            // 
            lblEmployee3.BackColor = Color.FromArgb(255, 179, 71);
            lblEmployee3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmployee3.Location = new Point(382, 7);
            lblEmployee3.Margin = new Padding(0);
            lblEmployee3.Name = "lblEmployee3";
            lblEmployee3.Size = new Size(86, 40);
            lblEmployee3.TabIndex = 6;
            lblEmployee3.Text = "Naam";
            lblEmployee3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOrderDinner
            // 
            lblOrderDinner.AutoSize = true;
            lblOrderDinner.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrderDinner.Location = new Point(15, 767);
            lblOrderDinner.Name = "lblOrderDinner";
            lblOrderDinner.Size = new Size(49, 20);
            lblOrderDinner.TabIndex = 8;
            lblOrderDinner.Text = "Order";
            // 
            // listViewOrderDinner
            // 
            listViewOrderDinner.Location = new Point(15, 790);
            listViewOrderDinner.Name = "listViewOrderDinner";
            listViewOrderDinner.Size = new Size(344, 238);
            listViewOrderDinner.TabIndex = 7;
            listViewOrderDinner.UseCompatibleStateImageBehavior = false;
            listViewOrderDinner.SelectedIndexChanged += listViewOrderDinner_SelectedIndexChanged;
            // 
            // pnlCreateOrderDrinks
            // 
            pnlCreateOrderDrinks.AutoScroll = true;
            pnlCreateOrderDrinks.Controls.Add(btnRemoveDrinks);
            pnlCreateOrderDrinks.Controls.Add(btnCommentDrinks);
            pnlCreateOrderDrinks.Controls.Add(btnAddDrinks);
            pnlCreateOrderDrinks.Controls.Add(listViewHotDrinks);
            pnlCreateOrderDrinks.Controls.Add(listViewSpirits);
            pnlCreateOrderDrinks.Controls.Add(lblHotDrinks);
            pnlCreateOrderDrinks.Controls.Add(lblSpirits);
            pnlCreateOrderDrinks.Controls.Add(btnDrinksUnavailable);
            pnlCreateOrderDrinks.Controls.Add(lblWines);
            pnlCreateOrderDrinks.Controls.Add(lblTableDrinksOverview);
            pnlCreateOrderDrinks.Controls.Add(lblBeers);
            pnlCreateOrderDrinks.Controls.Add(lblImageChapeau);
            pnlCreateOrderDrinks.Controls.Add(lblSoftDrinks);
            pnlCreateOrderDrinks.Controls.Add(btnLunchFromDrinksOverview);
            pnlCreateOrderDrinks.Controls.Add(listViewBeers);
            pnlCreateOrderDrinks.Controls.Add(btnDinnerFromDrinksOverview);
            pnlCreateOrderDrinks.Controls.Add(listViewSoftDrinks);
            pnlCreateOrderDrinks.Controls.Add(listViewWines);
            pnlCreateOrderDrinks.Controls.Add(lblEmployee4);
            pnlCreateOrderDrinks.Controls.Add(lblOrderDrinks);
            pnlCreateOrderDrinks.Controls.Add(listViewOrderDrinks);
            pnlCreateOrderDrinks.Location = new Point(1463, 2);
            pnlCreateOrderDrinks.Name = "pnlCreateOrderDrinks";
            pnlCreateOrderDrinks.Size = new Size(492, 1056);
            pnlCreateOrderDrinks.TabIndex = 20;
            // 
            // btnRemoveDrinks
            // 
            btnRemoveDrinks.BackColor = Color.FromArgb(255, 179, 71);
            btnRemoveDrinks.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemoveDrinks.Location = new Point(362, 949);
            btnRemoveDrinks.Margin = new Padding(0);
            btnRemoveDrinks.Name = "btnRemoveDrinks";
            btnRemoveDrinks.Size = new Size(106, 49);
            btnRemoveDrinks.TabIndex = 24;
            btnRemoveDrinks.Text = "REMOVE";
            btnRemoveDrinks.UseVisualStyleBackColor = false;
            btnRemoveDrinks.Click += btnRemoveDrinks_Click;
            // 
            // btnCommentDrinks
            // 
            btnCommentDrinks.BackColor = Color.FromArgb(196, 196, 196);
            btnCommentDrinks.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCommentDrinks.Location = new Point(362, 900);
            btnCommentDrinks.Margin = new Padding(0);
            btnCommentDrinks.Name = "btnCommentDrinks";
            btnCommentDrinks.Size = new Size(106, 49);
            btnCommentDrinks.TabIndex = 23;
            btnCommentDrinks.Text = "COMMENT";
            btnCommentDrinks.UseVisualStyleBackColor = false;
            btnCommentDrinks.Click += btnCommentDrinks_Click;
            // 
            // btnAddDrinks
            // 
            btnAddDrinks.BackColor = Color.FromArgb(255, 179, 71);
            btnAddDrinks.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddDrinks.Location = new Point(362, 1007);
            btnAddDrinks.Margin = new Padding(0);
            btnAddDrinks.Name = "btnAddDrinks";
            btnAddDrinks.Size = new Size(106, 49);
            btnAddDrinks.TabIndex = 21;
            btnAddDrinks.Text = "ADD";
            btnAddDrinks.UseVisualStyleBackColor = false;
            btnAddDrinks.Click += btnAddDrinks_Click;
            // 
            // listViewHotDrinks
            // 
            listViewHotDrinks.Location = new Point(15, 753);
            listViewHotDrinks.Name = "listViewHotDrinks";
            listViewHotDrinks.Size = new Size(444, 116);
            listViewHotDrinks.TabIndex = 20;
            listViewHotDrinks.UseCompatibleStateImageBehavior = false;
            listViewHotDrinks.SelectedIndexChanged += listViewHotDrinks_SelectedIndexChanged;
            // 
            // listViewSpirits
            // 
            listViewSpirits.Location = new Point(15, 609);
            listViewSpirits.Name = "listViewSpirits";
            listViewSpirits.Size = new Size(444, 116);
            listViewSpirits.TabIndex = 19;
            listViewSpirits.UseCompatibleStateImageBehavior = false;
            listViewSpirits.SelectedIndexChanged += listViewSpirits_SelectedIndexChanged;
            // 
            // lblHotDrinks
            // 
            lblHotDrinks.AutoSize = true;
            lblHotDrinks.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblHotDrinks.Location = new Point(194, 730);
            lblHotDrinks.Name = "lblHotDrinks";
            lblHotDrinks.Size = new Size(99, 20);
            lblHotDrinks.TabIndex = 18;
            lblHotDrinks.Text = "HOT DRINKS";
            // 
            // lblSpirits
            // 
            lblSpirits.AutoSize = true;
            lblSpirits.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSpirits.Location = new Point(212, 586);
            lblSpirits.Name = "lblSpirits";
            lblSpirits.Size = new Size(63, 20);
            lblSpirits.TabIndex = 17;
            lblSpirits.Text = "SPIRITS";
            // 
            // btnDrinksUnavailable
            // 
            btnDrinksUnavailable.BackColor = Color.FromArgb(138, 210, 176);
            btnDrinksUnavailable.ForeColor = Color.Black;
            btnDrinksUnavailable.Location = new Point(335, 95);
            btnDrinksUnavailable.Name = "btnDrinksUnavailable";
            btnDrinksUnavailable.Size = new Size(90, 50);
            btnDrinksUnavailable.TabIndex = 5;
            btnDrinksUnavailable.Text = "DRINKS";
            btnDrinksUnavailable.UseVisualStyleBackColor = false;
            // 
            // lblWines
            // 
            lblWines.AutoSize = true;
            lblWines.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblWines.Location = new Point(218, 444);
            lblWines.Name = "lblWines";
            lblWines.Size = new Size(57, 20);
            lblWines.TabIndex = 14;
            lblWines.Text = "WINES";
            lblWines.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTableDrinksOverview
            // 
            lblTableDrinksOverview.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblTableDrinksOverview.Location = new Point(186, 24);
            lblTableDrinksOverview.Name = "lblTableDrinksOverview";
            lblTableDrinksOverview.Size = new Size(124, 45);
            lblTableDrinksOverview.TabIndex = 1;
            lblTableDrinksOverview.Text = "TAFEL #1";
            lblTableDrinksOverview.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBeers
            // 
            lblBeers.AutoSize = true;
            lblBeers.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblBeers.Location = new Point(218, 302);
            lblBeers.Name = "lblBeers";
            lblBeers.Size = new Size(53, 20);
            lblBeers.TabIndex = 13;
            lblBeers.Text = "BEERS";
            lblBeers.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblImageChapeau
            // 
            lblImageChapeau.Image = (Image)resources.GetObject("lblImageChapeau.Image");
            lblImageChapeau.Location = new Point(3, 3);
            lblImageChapeau.Name = "lblImageChapeau";
            lblImageChapeau.Size = new Size(131, 66);
            lblImageChapeau.TabIndex = 2;
            lblImageChapeau.Text = " ";
            // 
            // lblSoftDrinks
            // 
            lblSoftDrinks.AutoSize = true;
            lblSoftDrinks.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSoftDrinks.Location = new Point(188, 162);
            lblSoftDrinks.Name = "lblSoftDrinks";
            lblSoftDrinks.Size = new Size(105, 20);
            lblSoftDrinks.TabIndex = 12;
            lblSoftDrinks.Text = "SOFT DRINKS";
            lblSoftDrinks.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLunchFromDrinksOverview
            // 
            btnLunchFromDrinksOverview.BackColor = Color.FromArgb(138, 210, 176);
            btnLunchFromDrinksOverview.FlatAppearance.BorderSize = 2;
            btnLunchFromDrinksOverview.Location = new Point(68, 95);
            btnLunchFromDrinksOverview.Name = "btnLunchFromDrinksOverview";
            btnLunchFromDrinksOverview.Size = new Size(90, 50);
            btnLunchFromDrinksOverview.TabIndex = 3;
            btnLunchFromDrinksOverview.Text = "LUNCH";
            btnLunchFromDrinksOverview.UseVisualStyleBackColor = false;
            btnLunchFromDrinksOverview.Click += btnLunchFromDrinksOverview_Click;
            // 
            // listViewBeers
            // 
            listViewBeers.Location = new Point(15, 325);
            listViewBeers.Name = "listViewBeers";
            listViewBeers.Size = new Size(444, 116);
            listViewBeers.TabIndex = 11;
            listViewBeers.UseCompatibleStateImageBehavior = false;
            listViewBeers.SelectedIndexChanged += listViewBeers_SelectedIndexChanged;
            // 
            // btnDinnerFromDrinksOverview
            // 
            btnDinnerFromDrinksOverview.BackColor = Color.FromArgb(138, 210, 176);
            btnDinnerFromDrinksOverview.Location = new Point(203, 95);
            btnDinnerFromDrinksOverview.Name = "btnDinnerFromDrinksOverview";
            btnDinnerFromDrinksOverview.Size = new Size(90, 50);
            btnDinnerFromDrinksOverview.TabIndex = 4;
            btnDinnerFromDrinksOverview.Text = "DINNER";
            btnDinnerFromDrinksOverview.UseVisualStyleBackColor = false;
            btnDinnerFromDrinksOverview.Click += btnDinnerFromDrinksOverview_Click;
            // 
            // listViewSoftDrinks
            // 
            listViewSoftDrinks.Location = new Point(15, 185);
            listViewSoftDrinks.Name = "listViewSoftDrinks";
            listViewSoftDrinks.Size = new Size(444, 116);
            listViewSoftDrinks.TabIndex = 10;
            listViewSoftDrinks.UseCompatibleStateImageBehavior = false;
            listViewSoftDrinks.SelectedIndexChanged += listViewSoftDrinks_SelectedIndexChanged;
            // 
            // listViewWines
            // 
            listViewWines.Location = new Point(15, 467);
            listViewWines.Name = "listViewWines";
            listViewWines.Size = new Size(444, 116);
            listViewWines.TabIndex = 9;
            listViewWines.UseCompatibleStateImageBehavior = false;
            listViewWines.SelectedIndexChanged += listViewWines_SelectedIndexChanged;
            // 
            // lblEmployee4
            // 
            lblEmployee4.BackColor = Color.FromArgb(255, 179, 71);
            lblEmployee4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmployee4.Location = new Point(382, 7);
            lblEmployee4.Margin = new Padding(0);
            lblEmployee4.Name = "lblEmployee4";
            lblEmployee4.Size = new Size(86, 40);
            lblEmployee4.TabIndex = 6;
            lblEmployee4.Text = "Naam";
            lblEmployee4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOrderDrinks
            // 
            lblOrderDrinks.AutoSize = true;
            lblOrderDrinks.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrderDrinks.Location = new Point(15, 877);
            lblOrderDrinks.Name = "lblOrderDrinks";
            lblOrderDrinks.Size = new Size(49, 20);
            lblOrderDrinks.TabIndex = 8;
            lblOrderDrinks.Text = "Order";
            // 
            // listViewOrderDrinks
            // 
            listViewOrderDrinks.Location = new Point(15, 900);
            listViewOrderDrinks.Name = "listViewOrderDrinks";
            listViewOrderDrinks.Size = new Size(344, 166);
            listViewOrderDrinks.TabIndex = 7;
            listViewOrderDrinks.UseCompatibleStateImageBehavior = false;
            listViewOrderDrinks.SelectedIndexChanged += listViewOrderDrinks_SelectedIndexChanged;
            // 
            // pnlComment
            // 
            pnlComment.Controls.Add(txtBoxComment);
            pnlComment.Controls.Add(btnBack);
            pnlComment.Controls.Add(btnAddComment);
            pnlComment.Location = new Point(485, 618);
            pnlComment.Name = "pnlComment";
            pnlComment.Size = new Size(392, 382);
            pnlComment.TabIndex = 18;
            // 
            // txtBoxComment
            // 
            txtBoxComment.Location = new Point(88, 79);
            txtBoxComment.Multiline = true;
            txtBoxComment.Name = "txtBoxComment";
            txtBoxComment.Size = new Size(215, 130);
            txtBoxComment.TabIndex = 18;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(255, 179, 71);
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.Location = new Point(0, 17);
            btnBack.Margin = new Padding(0);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(80, 40);
            btnBack.TabIndex = 17;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnAddComment
            // 
            btnAddComment.BackColor = Color.FromArgb(255, 179, 71);
            btnAddComment.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddComment.Location = new Point(141, 238);
            btnAddComment.Margin = new Padding(0);
            btnAddComment.Name = "btnAddComment";
            btnAddComment.Size = new Size(106, 49);
            btnAddComment.TabIndex = 16;
            btnAddComment.Text = "ADD";
            btnAddComment.UseVisualStyleBackColor = false;
            btnAddComment.Click += btnAddComment_Click;
            // 
            // CreateOrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1924, 1055);
            Controls.Add(pnlComment);
            Controls.Add(pnlCreateOrderDrinks);
            Controls.Add(pnlCreateOrderDinner);
            Controls.Add(pnlOrderOverview);
            Controls.Add(pnlCreateOrderLunch);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CreateOrderForm";
            Text = "Create Order";
            Load += CreateOrderForm_Load;
            pnlCreateOrderLunch.ResumeLayout(false);
            pnlCreateOrderLunch.PerformLayout();
            pnlOrderOverview.ResumeLayout(false);
            pnlCreateOrderDinner.ResumeLayout(false);
            pnlCreateOrderDinner.PerformLayout();
            pnlCreateOrderDrinks.ResumeLayout(false);
            pnlCreateOrderDrinks.PerformLayout();
            pnlComment.ResumeLayout(false);
            pnlComment.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlOrderOverview;
        private Label lblTableLunchOverview;
        private Label lblImageChapeau1;
        public Button btnLunchUnavailable;
        public Button btnDinnerFromLunchOverview;
        public Button btnDrinksFromLunchOverview;
        private Label lblEmployee;
        private ListView listViewOrderLunch;
        private Label lblOrderLunch;
        public ListView listViewDesertsLunch;
        public ListView listViewStartersLunch;
        public ListView listViewMainsLunch;
        private Label lblStartersLunch;
        private Label lblMainsLunch;
        private Label lblDesertsLunch;
        private Panel pnlCreateOrderLunch;
        private ListView listViewOrderOverview;
        private Label label2;
        private Label lblTotal;
        private Label label7;
        private Button btnPay;
        private Label label8;
        private Button button1;
        private Label label9;
        private Button button2;
        private Button button3;
        public Button btnDrinksOrderOverview;
        private Label lblTableOrderOverview;
        private Label lblImageChapeau2;
        public Button btnLunchOrderOverview;
        public Button btnDinnerOrderOverview;
        private Label lblEmployee2;
        private Panel pnlCreateOrderDinner;
        public Button btnDrinksFromDinnerOverview;
        private Label lblDesertsDinner;
        private Label lblTableDinnerOverview;
        private Label lblMainsDinner;
        private Label lblImageChapeau3;
        private Label lblStartersDinner;
        public Button btnLunchFromDinnerOverview;
        public ListView listViewMainsDinner;
        public Button btnDinnerUnavailable;
        public ListView listViewStartersDinner;
        public ListView listViewDesertsDinner;
        private Label lblEmployee3;
        private Label lblOrderDinner;
        private ListView listViewOrderDinner;
        private Panel pnlCreateOrderDrinks;
        public Button btnDrinksUnavailable;
        private Label lblWines;
        private Label lblTableDrinksOverview;
        private Label lblBeers;
        private Label lblImageChapeau;
        private Label lblSoftDrinks;
        public Button btnLunchFromDrinksOverview;
        public ListView listViewBeers;
        public Button btnDinnerFromDrinksOverview;
        public ListView listViewSoftDrinks;
        public ListView listViewWines;
        private Label lblEmployee4;
        private Label lblOrderDrinks;
        private ListView listViewOrderDrinks;
        private ListView listViewEntresDinner;
        private Label lblEntres;
        private Label lblHotDrinks;
        private Label lblSpirits;
        private ListView listViewSpirits;
        private ListView listViewHotDrinks;
        private Button btnAddLunch;
        private Button btnAddDinner;
        private Button btnAddDrinks;
        private Button btnCommentLunch;
        private Button btnCommentDinner;
        private Button btnCommentDrinks;
        private Panel pnlComment;
        private Button btnAddComment;
        private TextBox txtBoxComment;
        private Button btnBack;
        private Button btnRemoveLunch;
        private Button btnRemoveDinner;
        private Button btnRemoveDrinks;
    }
}