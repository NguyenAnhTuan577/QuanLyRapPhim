using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.DAL
{
    public class DataProvider
    {
        static string ConnectString = @"Data Source=NHN\SQLEXPRESS;Initial Catalog=DatVeXemPhim1;Integrated Security=True";
        static public SqlConnection Connection = new SqlConnection(ConnectString);
        static public SqlCommand Command = null;
        public static void OpenConnection()
        {
            Connection.Open();
        }
        public static void CloseConnection()
        {
            Connection.Close();
        }

        private static DataProvider instance; // Ctrl + R + E
        private DataProvider() { }

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }


        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            OpenConnection();
            DataTable data = new DataTable();
            SqlCommand command = new SqlCommand(query, Connection);

            if (parameter != null)
            {
                string[] listPara = query.Split(' ');
                int i = 0;
                foreach (string item in listPara)
                {
                    if (item.Contains('@'))
                    {
                        command.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                }
            }

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            CloseConnection();

            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand(query, Connection);
            int data = 0;

            if (parameter != null)
            {
                string[] listPara = query.Split(' ');
                int i = 0;
                foreach (string item in listPara)
                {
                    if (item.Contains('@'))
                    {
                        command.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                }
            }

            data = command.ExecuteNonQuery();
            CloseConnection();

            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand(query, Connection);
            object data = 0;

            if (parameter != null)
            {
                string[] listPara = query.Split(' ');
                int i = 0;
                foreach (string item in listPara)
                {
                    if (item.Contains('@'))
                    {
                        command.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                }
            }

            data = command.ExecuteScalar();
            CloseConnection();

            return data;
        }
    }
}
