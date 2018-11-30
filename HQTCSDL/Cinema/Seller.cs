using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Seller : Form
    {
        public Seller()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InfoCustomer f = new InfoCustomer();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageShowTimes f = new ManageShowTimes();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
