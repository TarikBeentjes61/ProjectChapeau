using ChapeauModel;
using ChapeauService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class TableForm : Form
    {
        Employee employee;
        public TableForm(Employee employee)
        {
            InitializeComponent();
            pnlTableView.Hide();
            this.employee = employee;
        }
        private void TableForm_Load(object sender, EventArgs e)
        {
            TableService tableService = new TableService();
            List<Table> tables = tableService.GetAll();
            lblName.Text = employee.name;
            flpnlTables.Controls.Clear();
            //Creates dynamic table overview depending on count of tables in database
            foreach (Table t in tables)
            {
                Button button = new Button();
                button.Name = t.tableId.ToString();
                button.Text = $"{t.tableId}";
                button.Font = new Font("Segoe UI", 18);
                button.AutoSize = true;
                button.Margin = new Padding(25, 25, 25, 25);
                button.Tag = t.status;
                flpnlTables.Controls.Add(button);
                button.Click += TableButton_Click;
                if (t.status == TableStatus.Reserved)
                {
                    button.BackColor = Color.Gray;
                }
                else if (t.status == TableStatus.Occupied)
                {
                    button.BackColor = Color.Orange;
                }
                else if (t.status == TableStatus.Ordered)
                {
                    button.BackColor = Color.Salmon;
                }
                else
                {
                    button.BackColor = Color.LightGreen;
                }
            }
        }
        //Reloads the table designs each 5 seconds from the database
        private void timer1_Tick(object sender, EventArgs e)
        {
            TableForm_Load(sender, e);
        }
        //Each button will have the following method to style and disables the current status button
        private void TableButton_Click(object sender, EventArgs e)
        {
            pnlTableView.Show();
            Button clicked = (Button)sender;
            int id = int.Parse(clicked.Name);
            lblTableID.Text = id.ToString();
            if ((TableStatus)clicked.Tag == TableStatus.Free)
            {
                btnFree.FlatStyle = FlatStyle.Standard;
                btnOccupied.FlatStyle = FlatStyle.Popup;
                btnReserved.FlatStyle = FlatStyle.Popup;
                btnFree.Enabled = false;
                btnOccupied.Enabled = true;
                btnReserved.Enabled = true;
                btnOccupied.Tag = id;
                btnReserved.Tag = id;
                btnTableOrder.Tag = id;
            }
            else if ((TableStatus)clicked.Tag == TableStatus.Occupied)
            {
                btnOccupied.FlatStyle = FlatStyle.Standard;
                btnFree.FlatStyle = FlatStyle.Popup;
                btnReserved.FlatStyle = FlatStyle.Popup;
                btnOccupied.Enabled = false;
                btnFree.Enabled = true;
                btnReserved.Enabled = true;
                btnFree.Tag = id;
                btnReserved.Tag = id;
                btnTableOrder.Tag = id;
            }
            else if ((TableStatus)clicked.Tag == TableStatus.Reserved)
            {
                btnReserved.FlatStyle = FlatStyle.Standard;
                btnFree.FlatStyle = FlatStyle.Popup;
                btnOccupied.FlatStyle = FlatStyle.Popup;
                btnReserved.Enabled = false;
                btnFree.Enabled = true;
                btnReserved.Enabled = true;
                btnFree.Tag = id;
                btnOccupied.Tag = id;
                btnTableOrder.Tag = id;
            }
        }
        //To go back to the table overview
        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlTableView.Hide();
        }
        //Button to see a table status to free
        private void btnFree_Click(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            int id = int.Parse(clicked.Tag.ToString());
            TableService tableService = new TableService();
            tableService.UpdateById(id, Convert.ToInt32(TableStatus.Free));
            btnFree.FlatStyle = FlatStyle.Standard;
            btnOccupied.FlatStyle = FlatStyle.Popup;
            btnReserved.FlatStyle = FlatStyle.Popup;
            btnFree.Enabled = false;
            btnOccupied.Enabled = true;
            btnReserved.Enabled = true;
        }
        //Button to see a table status to occupied
        private void btnOccupied_Click(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            int id = int.Parse(clicked.Tag.ToString());
            TableService tableService = new TableService();
            tableService.UpdateById(id, Convert.ToInt32(TableStatus.Occupied));
            btnOccupied.FlatStyle = FlatStyle.Standard;
            btnFree.FlatStyle = FlatStyle.Popup;
            btnReserved.FlatStyle = FlatStyle.Popup;
            btnOccupied.Enabled = false;
            btnFree.Enabled = true;
            btnReserved.Enabled = true;
        }
        //Button to see a table status to reserved
        private void btnReserved_Click(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            int id = int.Parse(clicked.Tag.ToString());
            TableService tableService = new TableService();
            tableService.UpdateById(id, Convert.ToInt32(TableStatus.Reserved));
            btnReserved.FlatStyle = FlatStyle.Standard;
            btnFree.FlatStyle = FlatStyle.Popup;
            btnOccupied.FlatStyle = FlatStyle.Popup;
            btnReserved.Enabled = false;
            btnFree.Enabled = true;
            btnOccupied.Enabled = true;
        }
        //Gives correct tableId and employee object to the next form
        private void btnTableOrder_Click(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            int tableId = int.Parse(clicked.Tag.ToString());
            this.Hide();
            CreateOrderForm createOrderForm = new CreateOrderForm(tableId, employee);
            createOrderForm.Show();
        }
        //Clicking the picture will logout
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}