﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace thongkethongtin
{
    public static class DateTimeExtensions
    {
        public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
            return dt.AddDays(-1 * diff).Date;
        }
    }
    public struct Desease
    {
        public string desease;
        public int count;
    }
    class Datacontrol
    {
        public DataTable Data = new DataTable();
        public DataTable Data1 = new DataTable();
        public void ChooseWeekData()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=OneForAll;Integrated Security=True"))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable temp = new DataTable();
                adapter.SelectCommand = new SqlCommand("select mabenhnhan, ngaykham, chuandoan from benhan", connection);
                adapter.Fill(temp);
                DataTable temp1=new DataTable();
                temp1.Clear();
                temp1.Columns.Add("maBenhNhan");
                temp1.Columns.Add("ngayKham");
                temp1.Columns.Add("chanDoan");
                DateTime monday = DateTime.Now.StartOfWeek(DayOfWeek.Monday);
                foreach (DataRow row in temp.Rows)
                {
                    string time = row["ngaykham"].ToString();
                    string[] date = time.Split(new[] { "/" }, StringSplitOptions.None);
                    date[2] = date[2].Substring(0, 4);
                    DateTime newdate = new DateTime(int.Parse(date[2]), int.Parse(date[0]), int.Parse(date[1]));
                    TimeSpan diff = newdate - monday;
                    if (diff.TotalDays >= 0)
                    {
                        temp1.Rows.Add(row.ItemArray);
                    }
                }
                Data = temp1;
                DataTable temp2 = new DataTable();
                adapter.SelectCommand = new SqlCommand("select [ID], [Ngày tháng năm sinh], [Giới tính] from PatientInfo", connection);
                adapter.Fill(temp2);
                DataTable temp3 = new DataTable();
                temp3.Clear();
                temp3.Columns.Add("maBenhNhan");
                temp3.Columns.Add("dateOfBirth");
                temp3.Columns.Add("gender");
                foreach (DataRow row in temp2.Rows)
                {
                    foreach(DataRow row1 in Data.Rows)
                    {
                        if ((row["ID"]).ToString() == row1["maBenhNhan"].ToString())
                        {
                            temp3.Rows.Add(row.ItemArray);
                            break;
                        }
                    }
                }
                Data1 = temp3;
            }
        }
        public void ChooseMonthData()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=OneForAll;Integrated Security=True"))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable temp = new DataTable();
                adapter.SelectCommand = new SqlCommand("select mabenhnhan, ngaykham, chuandoan from benhan", connection);
                adapter.Fill(temp);
                DataTable temp1 = new DataTable();
                temp1.Clear();
                temp1.Columns.Add("maBenhNhan");
                temp1.Columns.Add("ngayKham");
                temp1.Columns.Add("chanDoan");
                DateTime now = DateTime.Now;
                foreach (DataRow row in temp.Rows)
                {
                    string time = row["ngaykham"].ToString();
                    string[] date = time.Split(new[] { "/" }, StringSplitOptions.None);
                    if (int.Parse(date[0]) == now.Month)
                    {
                        temp1.Rows.Add(row.ItemArray);
                    }
                }
                Data = temp1;
                DataTable temp2 = new DataTable();
                adapter.SelectCommand = new SqlCommand("select [ID], [Ngày tháng năm sinh], [Giới tính] from PatientInfo", connection);
                adapter.Fill(temp2);
                DataTable temp3 = new DataTable();
                temp3.Clear();
                temp3.Columns.Add("maBenhNhan");
                temp3.Columns.Add("dateOfBirth");
                temp3.Columns.Add("gender");
                foreach (DataRow row in temp2.Rows)
                {
                    foreach (DataRow row1 in Data.Rows)
                    {
                        if ((row["ID"]).ToString() == row1["maBenhNhan"].ToString())
                        {
                            temp3.Rows.Add(row.ItemArray);
                            break;
                        }
                    }
                }
                Data1 = temp3;
            }
        }
        public void ChooseYearData()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=OneForAll;Integrated Security=True"))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable temp = new DataTable();
                adapter.SelectCommand = new SqlCommand("select mabenhnhan, ngaykham, chuandoan from benhan", connection);
                adapter.Fill(temp);
                DataTable temp1 = new DataTable();
                temp1.Clear();
                temp1.Columns.Add("maBenhNhan");
                temp1.Columns.Add("ngayKham");
                temp1.Columns.Add("chanDoan");
                DateTime now = DateTime.Now;
                foreach (DataRow row in temp.Rows)
                {
                    string time = row["ngaykham"].ToString();
                    string[] date = time.Split(new[] { "/" }, StringSplitOptions.None);
                    date[2] = date[2].Substring(0, 4);
                    if (int.Parse(date[2]) == now.Year)
                    {
                        temp1.Rows.Add(row.ItemArray);
                    }
                }
                Data = temp1;
                DataTable temp2 = new DataTable();
                adapter.SelectCommand = new SqlCommand("select [ID], [Ngày tháng năm sinh], [Giới tính] from PatientInfo", connection);
                adapter.Fill(temp2);
                DataTable temp3 = new DataTable();
                temp3.Clear();
                temp3.Columns.Add("maBenhNhan");
                temp3.Columns.Add("dateOfBirth");
                temp3.Columns.Add("gender");
                foreach (DataRow row in temp2.Rows)
                {
                    foreach (DataRow row1 in Data.Rows)
                    {
                        if ((row["ID"]).ToString() == row1["maBenhNhan"].ToString())
                        {
                            temp3.Rows.Add(row.ItemArray);
                            break;
                        }
                    }
                }
                Data1 = temp3;
            }
        }
        public void ChooseAllData()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=OneForAll;Integrated Security=True"))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable temp = new DataTable();
                adapter.SelectCommand = new SqlCommand("select mabenhnhan, ngaykham, chuandoan from benhan", connection);
                adapter.Fill(temp);
                DataTable temp1 = new DataTable();
                temp1.Clear();
                temp1.Columns.Add("maBenhNhan");
                temp1.Columns.Add("ngayKham");
                temp1.Columns.Add("chanDoan");
                foreach (DataRow row in temp.Rows) temp1.Rows.Add(row.ItemArray);
                Data = temp1;
                DataTable temp2 = new DataTable();
                adapter.SelectCommand = new SqlCommand("SELECT [ID], [Ngày tháng năm sinh], [Giới tính] FROM PatientInfo", connection);
                adapter.Fill(temp2);
                DataTable temp3 = new DataTable();
                temp3.Clear();
                temp3.Columns.Add("maBenhNhan");
                temp3.Columns.Add("dateOfBirth");
                temp3.Columns.Add("gender");
                foreach (DataRow row in temp2.Rows)
                {
                    temp3.Rows.Add(row.ItemArray);

                }
                Data1 = temp3;
            }
        }
        public bool IsDataEmpty()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=OneForAll;Integrated Security=True"))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable temp = new DataTable();
                adapter.SelectCommand = new SqlCommand("select mabenhnhan, ngaykham, chuandoan from benhan", connection);
                adapter.Fill(temp);
                Data = temp;
                if (Data == null)
                {
                    return true;
                }
                else return false;
            }
        }
        public List<int> GetAge()
        {
            List<int> ageList = new List<int>();
            int underSix = 0;
            int SixtoEighteen = 0;
            int EighteentoSixty = 0;
            int upSixty = 0;
            DateTime now = DateTime.Now;
            foreach (DataRow row in Data1.Rows)
            {
                string date = row["dateOfBirth"].ToString();
                string[] dateString = date.Split(new[] { "/" }, StringSplitOptions.None);
                dateString[2] = dateString[2].Substring(0, 4);
                int ageInInt = now.Year - int.Parse(dateString[2]);
                if (ageInInt < 6) underSix++;
                else if (ageInInt < 18) SixtoEighteen++;
                else if (ageInInt < 60) EighteentoSixty++;
                else upSixty++;
            }
            ageList.Add(underSix);
            ageList.Add(SixtoEighteen);
            ageList.Add(EighteentoSixty);
            ageList.Add(upSixty);
            return ageList;
        }
        public List<int> GetSex()
        {
            List<int> sexList = new List<int>();
            int nu = 0;
            int nam = 0;
            foreach (DataRow row in Data1.Rows)
            {
                string sex = row["gender"].ToString();
                if (sex == "Nu        ") nu++;
                else if (sex == "Nam       ") nam++;
            }
            sexList.Add(nu);
            sexList.Add(nam);
            return sexList;
        }
        public List<Desease> GetDesease()
        {
            List<Desease> deseaseList = new List<Desease>();
            foreach (DataRow row in Data.Rows)
            {
                string getDesease = row["chandoan"].ToString();
                int dem = 0;
                for (int i = 0; i < deseaseList.Count; i++)
                    if (deseaseList[i].desease == getDesease)
                    {
                        deseaseList[i] = new Desease { desease = deseaseList[i].desease, count = deseaseList[i].count + 1 };
                    }
                    else dem++;
                if (dem == deseaseList.Count) {
                    Desease newDesease = new Desease { desease = getDesease, count = 1 };
                    deseaseList.Add(newDesease);
                }
            }
            return deseaseList;
        }
    }
}
