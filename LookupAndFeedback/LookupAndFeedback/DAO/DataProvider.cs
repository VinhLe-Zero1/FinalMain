using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LookupAndFeedback.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        private string connectionStr = "Data Source=DELL-PC\\MISASME2015;Initial Catalog=MedicalCare;Integrated Security=True";

        /*public DataTable ExcuteQuery(string query)
        {
            DataTable data = new DataTable();
            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            //data = command.ExcuteQuery();
            adapter.Fill(data);
            connection.Close();
            return data;
        }*/
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; } 
            private set => instance = value;
        }
        private DataProvider() { }

        public DataTable ExcuteQuery(string query, object[] paramaters = null)
        {
            //int data = 0;
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                //command.Parameters.AddWithValue("@userName", id);
                if (paramaters != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, paramaters[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                //data = command.ExecuteQuery();
                adapter.Fill(data);
                //data = command.ExcuteQuery();
                connection.Close();
            }
            return data;
        }
        public int ExcuteNonQuery(string query, object [] paramaters =null)
        {
            int data =0;
            //DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionStr)) {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                //command.Parameters.AddWithValue("@userName", id);
                if (paramaters != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach(string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, paramaters[i]);
                            i++;
                        }
                    }
                }
                //SqlDataAdapter adapter = new SqlDataAdapter(command);
                data = command.ExecuteNonQuery();
                //adapter.Fill(data);
                //data = command.ExcuteNonQuery();
                connection.Close();
            }
            return data;           
        }

        /*public object ExcuteScalar(string query, object[] paramaters = null)
        {
            object data = 0;
            //DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                //command.Parameters.AddWithValue("@userName", id);
                if (paramaters != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, paramaters[i]);
                            i++;
                        }
                    }
                }
                //SqlDataAdapter adapter = new SqlDataAdapter(command);
                data = command.ExecuteScalar();
                //adapter.Fill(data);
                //data = command.ExcuteNonQuery();
                connection.Close();
            }
            return data;
        }*/
    }
}
