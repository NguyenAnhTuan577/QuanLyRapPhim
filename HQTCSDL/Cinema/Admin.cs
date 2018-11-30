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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnFilm_Click(object sender, EventArgs e)
        {
            ManageFilm f = new ManageFilm();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnShowtimes_Click(object sender, EventArgs e)
        {
            ManageShowTimes f = new ManageShowTimes();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnSchetistic_Click(object sender, EventArgs e)
        {
            ManageSchetistic f = new ManageSchetistic();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnAddAccountSeller_Click(object sender, EventArgs e)
        {
            AddAcountSeller f = new AddAcountSeller();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
    }
}
