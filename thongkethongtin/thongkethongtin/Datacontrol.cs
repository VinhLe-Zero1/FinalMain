using System;
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
    class Datacontrol
    {
        DataTable Data = new DataTable();
        public DataTable ChooseWeekData()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-5R6GU4E;Initial Catalog=DataBenhnhan;Integrated Security=True"))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("select * from benhnhan", connection);
                adapter.Fill(Data);
                DataTable Data1=new DataTable();
                Data1.Clear();
                Data1.Columns.Add("age");
                Data1.Columns.Add("gender");
                Data1.Columns.Add("desease");
                Data1.Columns.Add("date");
                DateTime monday = DateTime.Now.StartOfWeek(DayOfWeek.Monday);
                foreach (DataRow row in Data.Rows)
                {
                    string time = row["date"].ToString();
                    string[] date = time.Split(new[] { "/" }, StringSplitOptions.None);
                    date[2] = date[2].Substring(0, 4);
                    DateTime newdate = new DateTime(int.Parse(date[2]), int.Parse(date[0]), int.Parse(date[1]));
                    TimeSpan diff = newdate - monday;
                    if (diff.TotalDays >= 0)
                    {
                        Data1.Rows.Add(row.ItemArray);
                    }
                }
                return Data1;
            }
        }
        public DataTable ChooseMonthData()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-5R6GU4E;Initial Catalog=DataBenhnhan;Integrated Security=True"))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("select * from benhnhan", connection);
                adapter.Fill(Data);
                DataTable Data1 = new DataTable();
                Data1.Clear();
                Data1.Columns.Add("age");
                Data1.Columns.Add("gender");
                Data1.Columns.Add("desease");
                Data1.Columns.Add("date");
                DateTime now = DateTime.Now;
                foreach (DataRow row in Data.Rows)
                {
                    string time = row["date"].ToString();
                    string[] date = time.Split(new[] { "/" }, StringSplitOptions.None);
                    date[2] = date[2].Substring(0, 4);
                    int month = int.Parse(date[0]);
                    int year = int.Parse(date[2]);
                    if ((month == now.Month) && (year == now.Year))
                    {
                        Data1.Rows.Add(row.ItemArray);
                    }
                }
                return Data1;
            }
        }
        public DataTable ChooseYearData()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-5R6GU4E;Initial Catalog=DataBenhnhan;Integrated Security=True"))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("select * from benhnhan", connection);
                adapter.Fill(Data);
                DataTable Data1 = new DataTable();
                Data1.Clear();
                Data1.Columns.Add("age");
                Data1.Columns.Add("gender");
                Data1.Columns.Add("desease");
                Data1.Columns.Add("date");
                DateTime now = DateTime.Now;
                foreach (DataRow row in Data.Rows)
                {
                    string time = row["date"].ToString();
                    string[] date = time.Split(new[] { "/" }, StringSplitOptions.None);
                    date[2] = date[2].Substring(0, 4);
                    int year = int.Parse(date[2]);
                    if ( year == now.Year)
                    {
                        Data1.Rows.Add(row.ItemArray);
                    }
                }
                return Data1;
            }
        }
        public DataTable ChooseAllData()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-5R6GU4E;Initial Catalog=DataBenhnhan;Integrated Security=True"))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("select * from benhnhan", connection);
                adapter.Fill(Data);
                DataTable Data1 = new DataTable();
                Data1.Clear();
                Data1.Columns.Add("age");
                Data1.Columns.Add("gender");
                Data1.Columns.Add("desease");
                Data1.Columns.Add("date");
                DateTime now = DateTime.Now;
                foreach (DataRow row in Data.Rows)
                {
                        Data1.Rows.Add(row.ItemArray);   
                }
                return Data1;
            }
        }
        public bool IsDataEmpty()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-5R6GU4E;Initial Catalog=DataBenhnhan;Integrated Security=True"))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("select * from benhnhan", connection);
                adapter.Fill(Data);
                if (Data == null)
                {
                    return true;
                }
                else return false;
            }
        }
    }
}
