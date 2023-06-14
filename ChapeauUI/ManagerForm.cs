using ChapeauModel;
using ChapeauService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
            ShowPanel(pnlMain);
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

            foreach (Employee employee in employees)
            {
                ListViewItem li = new ListViewItem(employee.name.ToString());
                li.SubItems.Add(employee.role.ToString());
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
    }
}
