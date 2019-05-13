using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace capnhap
{
    class NewInfosController
    {
        public DataSet GetDBCommand(string query)
        {
            DataSet data = new DataSet();
            using (System.Data.SqlClient.SqlConnection connection = new SqlConnection("Data Source = DESKTOP - RHERCMS\SQLEXPRESS; Initial Catalog = PatientInfo; Integrated Security = True"))
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
