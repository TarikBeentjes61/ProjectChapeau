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

        private void buttonEmployeeManagement_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlEmployees);
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
