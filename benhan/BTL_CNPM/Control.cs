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

        private Benhan private_benhan;
        public void UpdateData(Benhan benhan)
        {
            bool is_sendmail = false;
            string take_email = "select distinct email from infokhambenh where mabenhnhan = " + benhan.getID().ToString();
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
        private string subject_datlich = "THÔNG TIN BỆNH ÁN";
        public override bool GuiMail(string to)
        {
            MailMessage mess = new MailMessage(this.email, to);
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            mess.Subject = this.subject_datlich;
            mess.IsBodyHtml = true;
            mess.Body = "<b>Chào " + Form1.tenbenhnhan + ",</b><br/>";
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
                MessageBox.Show("No Internet Connection!!");
                return false;
            }
            return true;
        }
    }
}
