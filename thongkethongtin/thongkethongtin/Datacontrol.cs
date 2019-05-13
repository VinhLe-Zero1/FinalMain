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
    public struct Desease
    {
        public string desease;
        public int count;
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
                Data = Data1;
                return Data;
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
                Data = Data1;
                return Data;
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
                Data = Data1;
                return Data;
            }
        }
        public DataTable ChooseAllData()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-5R6GU4E;Initial Catalog=DataBenhnhan;Integrated Security=True"))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("select * from benhnhan", connection);
                adapter.Fill(Data);
                return Data;
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
        public List<int> GetAge()
        {
            List<int> ageList = new List<int>();
            int underSix = 0;
            int SixtoEighteen = 0;
            int EighteentoSixty = 0;
            int upSixty = 0;
            foreach (DataRow row in Data.Rows)
            {
                string age = row["age"].ToString();
                int ageInInt = int.Parse(age);
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
            foreach (DataRow row in Data.Rows)
            {
                string sex = row["gender"].ToString();
                if (sex == "Nu") nu++;
                else if (sex == "Nam") nam++;
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
                string getDesease = row["desease"].ToString();
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
