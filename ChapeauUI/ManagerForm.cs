using ChapeauModel;
using ChapeauService;
using ChapeauUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace ChapeauUI
{
    public partial class ManagerForm : Form
    {
        private int selectedEmployeeID;
        public ManagerForm()
        {
            InitializeComponent();
            ShowPanel(pnlAdjustEmployee);
        }

        private void ShowPanel(Panel panel)
        {
            foreach (Control contrl in this.Controls)
            {
                if (contrl is Panel)
                {
                    contrl.Hide();
                }
            }

            panel.Show();
        }

        private List<Employee> GetEmployees()
        {
            EmployeeService employeeService = new EmployeeService();
            List<Employee> employees = employeeService.GetAll();
            return employees;
        }

        private void DisplayEmployees(List<Employee> employees)
        {
            // clear the listview before filling it
            listViewEmployees.Items.Clear();
            listViewEmployees.View = View.Details;

            listViewEmployees.Columns.Add("Name");
            listViewEmployees.Columns.Add("Role");
            listViewEmployees.Columns.Add("ID");

            foreach (Employee employee in employees)
            {
                ListViewItem li = new ListViewItem(employee.name.ToString());
                li.SubItems.Add(employee.role.ToString());
                li.SubItems.Add(employee.employeeId.ToString());
                listViewEmployees.Items.Add(li);
            }
        }

        private void AdjustEmployee(int employeeID)
        {
            EmployeeService employeeService = new EmployeeService();
            Employee employee = employeeService.GetById(employeeID);
            lblAdjustEmployeeHeader.Text = $"ADJUST EMPLOYEE {employee.name.ToUpper()}";
        }

        private void ConfirmAdjustEmployees()
        {

            if (textBoxAdjustEmployeeName.Text.Length < 1)
            {
                MessageBox.Show("Vul iets in!");
            }
        }

        private void buttonEmployeeManagement_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlEmployees);
            List<Employee> employees = GetEmployees();
            DisplayEmployees(employees);
        }

        private void buttonAddNewEmployee_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlNewEmployee);
        }

        private void btnBackToEmployees_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlEmployees);
        }

        private void btnAddNewMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlNewMenuItem);
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlMenu);
        }

        private void lblBackToMain_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlMain);
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlMenu);
        }

        private void lblBackToMainFromMenu_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlMain);
        }

        private void listViewEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewEmployees.SelectedItems.Count == 0)
            {
                buttonAdjustEmployee.Enabled = false;
                return;
            }

            ListViewItem.ListViewSubItem li = listViewEmployees.SelectedItems[0].SubItems[2];
            selectedEmployeeID = int.Parse(li.Text);

            // Enable adjust button
            buttonAdjustEmployee.Enabled = true;
        }

        private void buttonAdjustEmployee_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlAdjustEmployee);
            AdjustEmployee(selectedEmployeeID);
        }

        private void lblBackToEmployees_Click(object sender, EventArgs e)
        {
            textBoxAdjustEmployeeName.Clear();
            textBoxAdjustEmployeeOldPassword.Clear();
            textBoxAdjustEmployeeNewPassword.Clear();
            textBoxAdjustEmployeeRole.Clear();
            ShowPanel(pnlEmployees);
        }

        private void btnConfirmAdjustEmployee_Click(object sender, EventArgs e)
        {
            ConfirmAdjustEmployees();
        }

        private void textBoxAdjustEmployeeName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxAdjustEmployeeName.Text.Length > 0)
            {
                btnConfirmAdjustEmployee.Enabled = true;
            }
            else
            {
                btnConfirmAdjustEmployee.Enabled = false;
            }
        }
    }
}
