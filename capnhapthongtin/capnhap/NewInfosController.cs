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
        public bool checkPhoneForm(string phonenumber)
        {
            for (int i = 0; i < phonenumber.Length; i++)
            {
                if (phonenumber[i] > '9' || phonenumber[i] < '0') return false;
            }
            return true;
        }
        public bool checkForm(string phone, string email, string hometown_addr, string house_addr)
        {
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
            //MailAddressValidationResult result = MailAddressValidator.Validate(email);
            if (phone == "" || email == "" || hometown_addr == "" || house_addr == "" || checkPhoneForm(phone))
            {
                return false;
            }
            else
                return true;
        }
        public void UpdateData(NewInfos infos)
        {
            System.Data.SqlClient.SqlConnection connection = new SqlConnection(Datlich.ConnectString.connectString);
            connection.Open();
            System.Data.SqlClient.SqlCommand command = new SqlCommand("UPDATE PatientInfo SET Email=@a1 , [Số điện thoại] = @a2, [Địa chỉ] = @a3, [Quê quán] = @a4 WHERE ID=@a5",connection);
            command.Parameters.Add("a1", infos.getEmail());
            command.Parameters.Add("a2", infos.getPhone());
            command.Parameters.Add("a3", infos.getHouse_addr());
            command.Parameters.Add("a4", infos.getHometown_addr());
            command.Parameters.Add("a5", 2);
            command.ExecuteNonQuery();
        }
    }
}
