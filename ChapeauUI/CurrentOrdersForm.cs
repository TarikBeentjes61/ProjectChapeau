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
    public partial class CurrentOrdersForm : Form
    {
        public CurrentOrdersForm()
        {
            InitializeComponent();
            ListViewItem li = new ListViewItem("1");
            li.SubItems.Add("Cherry Babes");
            li.SubItems.Add("2");
            listViewWaiting.Items.Add(li);
        }
    }
}
