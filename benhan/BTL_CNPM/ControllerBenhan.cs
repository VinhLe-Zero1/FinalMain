using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datlich;
namespace BTL_CNPM
{
    class ControllerBenhan:SendMail
    {
        public override DataSet GetDataBaseCommand(string query)
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

        private Benhan private_benhan;
        public void UpdateData(Benhan benhan)
        {
            bool is_sendmail = false;
            DataSet t = new DataSet();
            t = GetDataBaseCommand( "select distinct email from infokhambenh where mabenhnhan = " + benhan.getID().ToString());
            DataTable dt = new DataTable();
            dt = t.Tables[0];
            string take_email = dt.Rows[0]["email"].ToString();
            this.private_benhan = new Benhan();
            this.private_benhan.addBenhan(benhan.getID(), benhan.getChuandoan(), benhan.getDando(), benhan.getDonthuoc());
            if (GuiMail(take_email))
            {
                is_sendmail = true;
            }
            string query = "insert into benhan values (" + benhan.getID().ToString() +
                ",GETDATE(), N'" + benhan.getChuandoan() + "', N' " + benhan.getDonthuoc() + "', N' " +
                benhan.getDando() + "', " + is_sendmail.ToString();
            GetDataBaseCommand(query);
        }

        private string email = "ddtin1408@gmail.com";
        private string pass = "0942212660";
        private string subject_benhan = "THÔNG TIN BỆNH ÁN";
        public override bool GuiMail(string to)
        {
            MailMessage mess = new MailMessage(this.email, to);
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            mess.Subject = this.subject_benhan;
            mess.IsBodyHtml = true;
            mess.Body = "<b>Chào ban, </b><br/>";
            mess.Body += "\nBệnh viện chúng tôi xin gửi đến thông tin bệnh án như sau:<br/>";
            mess.Body += "<b>Chuẩn đoán: </b>" + private_benhan.getChuandoan() + "<br/>";
            mess.Body += "<b>Đơn thuốc: </b>" + private_benhan.getDonthuoc() + "<br/>";  
            mess.Body += "<b>Chuyên khoa: </b>" + private_benhan.getDando() + "<br/>";
            mess.Body += "<b>Xin cảm ơn quý khách đã đặt niềm tin vào bệnh viện chúng tôi.</b>";
            client.Credentials = new System.Net.NetworkCredential(this.email, this.pass);
            try
            {
                client.Send(mess);
            }
            catch
            {
                return false;
            }
            return true;
        }

        private List<int> listID()
        {
            string query = "select mabenhan from benhan where guimail = 0";
            SqlConnection conn = new SqlConnection(ConnectString.connectString);
            conn.Open();
            List<int> listItem = new List<int>();
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listItem.Add(reader.GetInt32(0));
                    }
                }
            }
            conn.Close();
            return listItem;
        }
        public void UnsendEmailProcess()
        {
            List<int> ID = new List<int>();
            ID = listID();
            while (ID.Count != 0)
            {
                foreach (int i in ID)
                {
                    DataSet ds = new DataSet();
                    ds = GetDataBaseCommand("select mabenhnhan, chuandoan, dando, donthuoc from benhan where mabenhan = " + i.ToString());
                    DataTable dt = new DataTable();
                    dt = ds.Tables[0];
                    private_benhan.addBenhan(int.Parse(dt.Rows[0]["mabenhnhan"].ToString()), dt.Rows[0]["chuandoan"].ToString(),
                        dt.Rows[0]["dando"].ToString(), dt.Rows[0]["donthuoc"].ToString());
                    DataSet t = new DataSet();
                    t = GetDataBaseCommand("select distinct email from infokhambenh where mabenhnhan = " + i.ToString());
                    DataTable dt1 = new DataTable();
                    dt1 = t.Tables[0];
                    string take_email = dt1.Rows[0]["email"].ToString();
                    if (GuiMail(take_email))
                    {
                        GetDataBaseCommand("Update benhan set guimail = 1 where mabenhan = " + i.ToString());
                        ID.Remove(i);
                    }
                }
            }
                    
        }
    }
}
