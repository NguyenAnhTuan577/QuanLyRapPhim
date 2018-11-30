using Cinema.DAL;
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
    public partial class ManageFilm : Form
    {
        public ManageFilm()
        {
            InitializeComponent();
        }

        private void lbName_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void loadFilm()
        {
            string query = "SELECT * FROM Phim";

            dtgvListFilm.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadFilm();
        }
    }
}
