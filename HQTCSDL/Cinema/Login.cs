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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string s = tbPass.Text;
            if (s.Equals("1"))
            {
                Admin f = new Admin();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            if (s.Equals("2"))
            {
                Seller f = new Seller();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát hay không", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.Cancel)
                e.Cancel = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
