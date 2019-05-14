using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using GemBox.Email;
namespace capnhap
{
    class NewInfosController
    {
        public DataSet GetDBCommand(string query)
        {
            DataSet data = new DataSet();
            using (System.Data.SqlClient.SqlConnection connection = new SqlConnection("Data Source = DESKTOP - RHERCMS\\SQLEXPRESS; Initial Catalog = PatientInfo; Integrated Security = True"))
            {
                connection.Open();
                SqlDataAdapter adaper = new SqlDataAdapter(query, connection);
                adaper.Fill(data);
                connection.Close();
            }
            return data;
        }
        public bool checkPhoneForm(string phonenumber)
        {
            for (int i = 0; i < phonenumber.Length; i++)
            {
                if (phonenumber[i] > '9' || phonenumber[i] < '0') return false;
            }
            return true;
        }
        public bool checkForm(string personal_ID, string phone, string email, string hometown_addr, string house_addr)
        {
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
            MailAddressValidationResult result = MailAddressValidator.Validate(email);
            if (personal_ID == "" || phone == "" || email == "" || hometown_addr == "" || house_addr == "" || !checkPhoneForm(phone) || (result.Status.ToString() != "Ok"))
            {
                return false;
            }
            else
                return true;
        }
        public void UpdateData(NewInfos infos)
        {
            bool is_sendmail = false;
            DataSet t = new DataSet();
            t = GetDataBaseCommand("select distinct email from infokhambenh where mabenhnhan = " + benhan.getID().ToString());
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
                benhan.getDando() + "', '" + is_sendmail.ToString() + "')";
            GetDataBaseCommand(query);
        }
    }
}
