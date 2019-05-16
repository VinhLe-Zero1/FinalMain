using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Net.Mail;
using System.Windows.Forms;

namespace Datlich
{

     public class ControllerDatlich:SendMail
    {
        public static int id_benhnhan;
        public static string name_benhnhan;
        public static string major_name = "";

        public override DataSet GetDataBaseCommand(string query)
        {
            DataSet data = new DataSet();
            using (SqlConnection connection = new SqlConnection(ConnectString.connectString))
            {
                connection.Open();
                SqlDataAdapter adaper = new SqlDataAdapter(query, connection);
                adaper.Fill(data);
                
                connection.Close();
            }
            return data;
        }

        public string showDoctor() {
            string query;
            if (major_name != "") query = "select id, ten, major, price, feedback from adoctor " +
                "where major = N'" + major_name + "'";
            else query = "select id, ten, major, price, feedback from adoctor";
            return query;
        }

        public List<String> listMajor() {
            string query = "select distinct Major from ADoctor";
            SqlConnection conn = new SqlConnection(ConnectString.connectString);
            conn.Open();
            List<string> listItem = new List<string>();
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listItem.Add(reader.GetString(0));
                    }
                }
            }
            conn.Close();
            return listItem;
        }
        private string date, time;
        Doctor doctor = new Doctor();
        bool BHYT;
        public void addVisit(string date, Doctor doctor, string time, bool BHYT)
        {
            Console.Write(doctor.getName());
            string query = "insert into infokhambenh values(" +
                   Form1.mabenhnhan +" , N'" + doctor.getName() + "', N'"
                   + doctor.getMajor() + "' ," + doctor.getPrice() + ",'"
                   + date + " " + time + "' , '" + Form1.email + "' , '"+ BHYT.ToString() + "' )";
            this.date = date;
            this.time = time;
            this.doctor.setDoctor(doctor);
            this.BHYT = BHYT;
            GetDataBaseCommand(query);
        }

        private string email = "ddtin1408@gmail.com";
        private string pass = "0942212660";
        private string subject_datlich = "THÔNG TIN ĐẶT LỊCH";
        public override bool GuiMail(string to)
        {

            MailMessage mess = new MailMessage(this.email, to);
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            mess.Subject = this.subject_datlich;
            mess.IsBodyHtml = true;
            mess.Body = "<b>Chào " + Form1.tenbenhnhan + ",</b><br/>";
            mess.Body += "\nBệnh viện chúng tôi xin gửi đến <b>" + Form1.tenbenhnhan + "</b> thông " +
                "tin khám bệnh như sau:<br/>";
            mess.Body += "Ngày giờ khám: <b>" + time + "  " + date + "</b><br/>";
            mess.Body += "Tên bác sĩ: <b>" + doctor.getName() + "</b><br/>";
            mess.Body += "Chuyên khoa: <b>" + doctor.getMajor() + "</b><br/>";
            mess.Body += "Giá tiền: <b>" + doctor.getPrice() + "</b><br/>";
            if (BHYT) mess.Body += "BHYT: <b>Có</b><br/>";
            else mess.Body += "BHYT: <b>Không</b><br/>";
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

        public List<String> listTimeAble(string datetime, string doctorname)
        {
            string query = "select id from infokhambenh where ngaykham = '"+datetime +"' and doctorName = N'" + doctorname+"'";
            SqlConnection conn = new SqlConnection(ConnectString.connectString);
            conn.Open();
            List<string> listItem = new List<string>();
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listItem.Add(reader.GetInt32(0).ToString());
                    }
                }
            }
            conn.Close();
            return listItem;
        }
    }
}
