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
using System.Security.Cryptography;


namespace ChapeauUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userID = txtBxUserID.Text;
            string password = txtBxPassword.Text;
            EmployeeService employeeService = new EmployeeService();
            Password passwordEmployee = new Password();
            Employee employee = new Employee();
            try
            {
                if (employee.CheckUserID(userID))
                {
                    lblError.Text = "";
                    try
                    {
                        //Collects employee information from database
                        employee = employeeService.GetById(int.Parse(userID));
                        //Verifies if the password is correct 
                        if (passwordEmployee.Verify(password, employee.salt, employee.hash, SHA256.Create()))
                        {
                            if (employee.role == Role.Manager)
                            {
                                //Load manager form
                                this.Hide();
                                StockForm stockForm = new StockForm();
                                stockForm.Show();
                            }
                            else if (employee.role == Role.Barista)
                            {
                                //Load barista form
                                this.Hide();
                                CurrentOrdersForm currentOrdersForm = new CurrentOrdersForm(employee);
                                currentOrdersForm.Show();
                            }
                            else if (employee.role == Role.Chef)
                            {
                                //Load chef form
                                this.Hide();
                                CurrentOrdersForm currentOrdersForm = new CurrentOrdersForm(employee);
                                currentOrdersForm.Show();
                            }
                            else if (employee.role == Role.Waiter)
                            {
                                //Load waiter form
                                this.Hide();
                                TableForm tableform = new TableForm(employee);
                                tableform.Show();
                            }
                        }
                        else
                        {
                            lblError.Text = "Wrong User ID or Password";
                        }
                    }
                    catch (Exception ex)
                    {
                        lblError.Text = "Wrong User ID or Password";
                    }
                }
                else
                {
                    lblError.Text = "Wrong User ID or Password";
                }
            }
            catch (Exception ex)
            {
                lblError.Text = "Wrong User ID or Password";
            }

        }
    }
}
