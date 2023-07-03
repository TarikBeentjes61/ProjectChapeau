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
        private Employee employee;
        private Button lastClickedTable;
        public TableForm(Employee employee)
        {
            InitializeComponent();
            pnlTableView.Hide();
            this.employee = employee;
        }
        private void TableForm_Load(object sender, EventArgs e)
        {
            int tableNumber = 1;
            TableService tableService = new TableService();
            List<Table> tables = tableService.GetAll();
            lblName.Text = employee.name;
            flpnlTables.Controls.Clear();
            //Creates dynamic table overview depending on count of tables in database
            foreach (Table table in tables)
            {
                Button button = btnCreate(table, tableNumber);
                btnStyle(button);
                button.Click += TableButton_Click;
                flpnlTables.Controls.Add(button);
                tableNumber++;
            }
        }
        //Styles a button
        private static Button btnCreate(Table table, int tableNumber)
        {
            Button button = new Button();
            button.Name = $"btnTable{tableNumber}";
            button.Text = $"{tableNumber}";
            button.Tag = table;
            return button;
        }
        private static void btnStyle(Button button)
        {
            button.Font = new Font("Segoe UI", 18);
            button.AutoSize = true;
            button.Margin = new Padding(25, 25, 25, 25);
            TableStatus tableStatus = ((Table)button.Tag).status;
            switch (tableStatus)
            {
                case TableStatus.Reserved:
                    button.BackColor = Color.Gray;
                    break;
                case TableStatus.Occupied:
                    button.BackColor = Color.Orange;
                    break;
                case TableStatus.Ordered:
                    button.BackColor = Color.Salmon;
                    break;
                default:
                    button.BackColor = Color.LightGreen;
                    break;
            }
        }
        //Each button will have the following method to style and disables the current status button
        private void TableButton_Click(object sender, EventArgs e)
        {
            pnlTableView.Show();
            Button clickedButton = (Button)sender;
            lastClickedTable = clickedButton;
            Table table = (Table)clickedButton.Tag;
            lblTableID.Text = table.tableId.ToString();
            btnTableOrder.Tag = table;
            switch (table.status)
            {
                case TableStatus.Free:
                    btnTableControle(btnFree, FlatStyle.Standard, false, table);
                    btnTableControle(btnOccupied, FlatStyle.Popup, true, table);
                    btnTableControle(btnReserved, FlatStyle.Popup, true, table);
                    break;
                case TableStatus.Occupied:
                    btnTableControle(btnFree, FlatStyle.Popup, true, table);
                    btnTableControle(btnOccupied, FlatStyle.Standard, false, table);
                    btnTableControle(btnReserved, FlatStyle.Popup, true, table);
                    break;
                case TableStatus.Reserved:
                    btnTableControle(btnFree, FlatStyle.Popup, true, table);
                    btnTableControle(btnOccupied, FlatStyle.Popup, true, table);
                    btnTableControle(btnReserved, FlatStyle.Standard, false, table);
                    break;
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
            Button clickedButton = (Button)sender;
            Table table = (Table)clickedButton.Tag;
            TableService tableService = new TableService();
            tableService.UpdateById(table.tableId, Convert.ToInt32(TableStatus.Free));
            btnUpdate(TableStatus.Free);
            btnTableControle(btnFree, FlatStyle.Standard, false, table);
            btnTableControle(btnOccupied, FlatStyle.Popup, true, table);
            btnTableControle(btnReserved, FlatStyle.Popup, true, table);
        }
        //Button to see a table status to occupied
        private void btnOccupied_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Table table = (Table)clickedButton.Tag;
            TableService tableService = new TableService();
            tableService.UpdateById(table.tableId, Convert.ToInt32(TableStatus.Occupied));
            btnUpdate(TableStatus.Occupied);
            btnTableControle(btnFree, FlatStyle.Popup, true, table);
            btnTableControle(btnOccupied, FlatStyle.Standard, false, table);
            btnTableControle(btnReserved, FlatStyle.Popup, true, table);
        }
        //Button to see a table status to reserved
        private void btnReserved_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Table table = (Table)clickedButton.Tag;
            TableService tableService = new TableService();
            tableService.UpdateById(table.tableId, Convert.ToInt32(TableStatus.Reserved));
            btnUpdate(TableStatus.Reserved);
            btnTableControle(btnFree, FlatStyle.Popup, true, table);
            btnTableControle(btnOccupied, FlatStyle.Popup, true, table);
            btnTableControle(btnReserved, FlatStyle.Standard, false, table);
        }
        //Gives correct tableId and employee object to the next form
        private void btnTableOrder_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Table tableOrdering = (Table)clickedButton.Tag;
            this.Close();
            CreateOrderForm createOrderForm = new CreateOrderForm(tableOrdering, employee);
            createOrderForm.Show();
        }
        //Clicking the picture will logout
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
        //This method will enable or disable a button
        private void btnTableControle(Button button, FlatStyle style, bool enable, Table table)
        {
            button.FlatStyle = style;
            button.Enabled = enable;
            button.Tag = table;
        }
        //The table overview will only update the effected tablebutton
        private void btnUpdate(TableStatus status)
        {
            Table table = (Table)lastClickedTable.Tag;
            table.status = status;
            btnStyle(lastClickedTable);
        }
        //The timer will refresh the overview each 60 secondes
        private void timer1_Tick(object sender, EventArgs e)
        {
            TableForm_Load(sender, e);
        }
    }
}