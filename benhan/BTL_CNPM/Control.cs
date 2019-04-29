using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datlich;
namespace BTL_CNPM
{
    class Control:SendMail
    {
        public DataSet GetDataBaseCommand(string query)
        {
            DataSet data = new DataSet();
            using (System.Data.SqlClient.SqlConnection connection = new SqlConnection(ConnectString.connectString))
            {
                connection.Open();
                SqlDataAdapter adaper = new SqlDataAdapter(query, connection);
                adaper.Fill(data);
                connection.Close();
            }
            return data;
        }

        public override void GuiMail(string to)
        {
            
        }
    }
}
