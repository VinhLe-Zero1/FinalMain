using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Tin
{
    class ConnectString
    {
        public static string connectString = @"Data Source=DESKTOP-LDOMKOB\SQLEXPRESS;Initial Catalog=AllDoctor;Integrated Security=True";
        public DataSet GetDataBaseCommand(string query)
        {
            DataSet data = new DataSet();
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                connection.Open();
                SqlDataAdapter adaper = new SqlDataAdapter(query, connection);
                adaper.Fill(data);
                connection.Close();
            }
            return data;
        }
    }
}
