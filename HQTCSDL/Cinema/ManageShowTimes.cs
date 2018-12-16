using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cinema.DAL;
using System.Data.SqlClient;

namespace Cinema
{
    public partial class ManageShowTimes : Form
    {
        public ManageShowTimes()
        {
            InitializeComponent();
        }

        // --------------------------------------------------------------------------
        // Load
        private void ManageShowTimes_Load(object sender, EventArgs e)
        {
            LichChieu_Load();
            LichChieu_Add_Load();
        }

        public void LichChieu_Load()
        {
            DataProvider.OpenConnection();
            
            string query = "select * from LichChieuPhim";
            DataProvider.Command = new SqlCommand(query, DataProvider.Connection);
            SqlDataAdapter adapter = new SqlDataAdapter(DataProvider.Command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dtgv_LichChieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_LichChieu.DataSource = table;

            DataProvider.CloseConnection();
        }

        public void LichChieu_Update()
        {
            DataProvider.OpenConnection();

            int maPhim = int.Parse(txt_MaPhim.Text.ToString());
            DateTime ngayChieu = dtpk_NgayChieu.Value.Date;

            string query = "select * from LichChieuPhim where phim = " + maPhim + " and ngayChieu = '" + ngayChieu + "'";
            DataProvider.Command = new SqlCommand(query, DataProvider.Connection);
            SqlDataAdapter adapter = new SqlDataAdapter(DataProvider.Command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dtgv_LichChieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_LichChieu.DataSource = table;

            DataProvider.CloseConnection();
        }

        public void LichChieu_Add_Load()
        {
            DataProvider.OpenConnection();
            
            string query = "select * from LichChieuPhim";
            DataProvider.Command = new SqlCommand(query, DataProvider.Connection);
            SqlDataAdapter adapter = new SqlDataAdapter(DataProvider.Command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dtgv_LichChieu_Add.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_LichChieu_Add.DataSource = table;

            DataProvider.CloseConnection();
        }

        public void TenPhim_Load()
        {
            DataProvider.OpenConnection();

            string query = "select * from Phim where maPhim = " + int.Parse(txt_MaPhim.Text.ToString());
            DataProvider.Command = new SqlCommand(query, DataProvider.Connection);
            SqlDataReader reader = DataProvider.Command.ExecuteReader();
            if (reader.Read())
                txt_TenPhim.Text = reader[1].ToString();

            DataProvider.CloseConnection();
        }
        
        // --------------------------------------------------------------------------
        // Event 
        private void dtgv_LichChieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv_LichChieu.Rows[e.RowIndex];

                txt_MaPhim.Text = row.Cells["phim"].Value.ToString();
                dtpk_NgayChieu.Value = (DateTime)row.Cells["ngayChieu"].Value;
                dtpk_GioChieu.Value = DateTime.Parse(row.Cells["giochieu"].Value.ToString());
                txt_Phong.Text = row.Cells["phong"].Value.ToString();
                txt_GiaVe.Text = row.Cells["giave"].Value.ToString();
                txt_LoaiPhim.Text = row.Cells["loaiphim"].Value.ToString();
                if ((bool)row.Cells["dohot"].Value)
                    cbb_DoHot.SelectedIndex = 1;
                else
                    cbb_DoHot.SelectedIndex = 0;
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DataProvider.OpenConnection();

            string procname = "sp_xoaLichChieuGio";
            DataProvider.Command = new SqlCommand(procname, DataProvider.Connection);
            DataProvider.Command.CommandType = CommandType.StoredProcedure;
            DataProvider.Command.Parameters.Add("@ngayChieu", SqlDbType.DateTime).Value = dtpk_NgayChieu.Value.Date;
            DataProvider.Command.Parameters.Add("@phong", SqlDbType.Char).Value = txt_Phong.Text;
            DataProvider.Command.Parameters.Add("gioChieu", SqlDbType.Time).Value = dtpk_GioChieu.Value.TimeOfDay;

            DataProvider.Command.ExecuteNonQuery();
            DataProvider.CloseConnection();
            LichChieu_Load ();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DataProvider.OpenConnection();

            string procname = "sp_capNhatLichChieu";
            DataProvider.Command = new SqlCommand(procname, DataProvider.Connection);
            DataProvider.Command.CommandType = CommandType.StoredProcedure;
            DataProvider.Command.Parameters.Add("@phim", SqlDbType.Int).Value = 1;
            DataProvider.Command.Parameters.Add("@phong", SqlDbType.Char).Value = txt_Phong.Text;
            DataProvider.Command.Parameters.Add("@ngayChieu", SqlDbType.DateTime).Value = dtpk_NgayChieu.Value.Date;
            DataProvider.Command.Parameters.Add("@gioChieu", SqlDbType.Time).Value = dtpk_GioChieu.Value.TimeOfDay;
            DataProvider.Command.Parameters.Add("@giaVe", SqlDbType.Float).Value = txt_GiaVe.Text;
            DataProvider.Command.Parameters.Add("@loaiPhim", SqlDbType.NVarChar).Value = txt_LoaiPhim.Text;
            DataProvider.Command.Parameters.Add("@doHot", SqlDbType.Bit).Value = cbb_DoHot.SelectedIndex;
            DataProvider.Command.Parameters.Add("@nvXepLich", SqlDbType.Int).Value = 11;

            DataProvider.Command.ExecuteNonQuery();
            DataProvider.CloseConnection();
            LichChieu_Load();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            TenPhim_Load();
            LichChieu_Update();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            DataProvider.OpenConnection();

            string procname = "sp_themLichChieuPhim";
            DataProvider.Command = new SqlCommand(procname, DataProvider.Connection);
            DataProvider.Command.CommandType = CommandType.StoredProcedure;
            DataProvider.Command.Parameters.Add("@phim", SqlDbType.Int).Value = int.Parse(txt_MaPhim_Add.Text.ToString());
            DataProvider.Command.Parameters.Add("@phong", SqlDbType.Char).Value = txt_Phong_Add.Text;
            DataProvider.Command.Parameters.Add("@ngayChieu", SqlDbType.DateTime).Value = dtpk_NgayChieu_Add.Value.Date;
            DataProvider.Command.Parameters.Add("@gioChieu", SqlDbType.Time).Value = dtpk_GioChieu_Add.Value.TimeOfDay;
            DataProvider.Command.Parameters.Add("@giaVe", SqlDbType.Float).Value = float.Parse(txt_GiaVe_Add.Text.ToString());
            DataProvider.Command.Parameters.Add("@loaiPhim", SqlDbType.NVarChar).Value = txt_LoaiPhim_Add.Text;
            DataProvider.Command.Parameters.Add("@doHot", SqlDbType.Bit).Value = cbb_DoHot_Add.SelectedIndex;
            DataProvider.Command.Parameters.Add("@nvXepLich", SqlDbType.Int).Value = 12;

            DataProvider.Command.ExecuteNonQuery();
            DataProvider.CloseConnection();
            LichChieu_Add_Load();
        }

    }
}
