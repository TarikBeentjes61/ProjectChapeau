﻿using ChapeauModel;
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
            //Define input
            string username = txtBxUserID.Text;
            string password = txtBxPassword.Text;
            try
            {
                EmployeeService employeeService = new EmployeeService();
                Employee employee = employeeService.GetByUsername(username);
                //Check if input is correct
                if (employee != null && PasswordService.VerifyPassword(password, employee.salt, employee.hash))
                {
                    this.Hide();
                    LoginEmployee(employee);
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
        //Direct employee to the right form when login correct
        private static void LoginEmployee(Employee employee)
        {
            switch (employee.role)
            {
                case (Role.Manager):
                    StockForm stockForm = new StockForm();
                    stockForm.Show();
                    break;
                case (Role.Barista):
                case (Role.Chef):
                    CurrentOrdersForm currentOrdersForm = new CurrentOrdersForm(employee);
                    currentOrdersForm.Show();
                    break;
                case (Role.Waiter):
                    TableForm tableform = new TableForm(employee);
                    tableform.Show();
                    break;
            }
        }
    }
}
