using LookupAndFeedback.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookupAndFeedback.DTO
{
    class CheckupInfo
    {
        public CheckupInfo(int id, DateTime date, string doctor, string dando, string nhanxet)
        {
            this.ID = id;
            this.Date = date;
            this.Doctor = doctor;
            this.Major = major;
            this.Donthuoc = donthuoc;
            this.Dando = dando;
            this.Nhanxet = nhanxet;
        }

        public CheckupInfo(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Date = (DateTime)row["ngaykham"];
            //this.Doctor = row["doctor"].ToString();
            //this.Major = row["major"].ToString();
            this.Donthuoc = row["donthuoc"].ToString();
            this.Dando = row["dando"].ToString();
            this.Nhanxet = row["nhanxet"].ToString();

        }

        
        private int iD;
        
        public int ID { get => iD; set => iD = value; }

        private DateTime date;
        public DateTime Date { get => date; set => date = value; }
        public string Doctor { get => doctor; set => doctor = value; }
        public string Major { get => major; set => major = value; }
        public string Donthuoc { get => donthuoc; set => donthuoc = value; }
        public string Dando { get => dando; set => dando = value; }
        public string Nhanxet { get => nhanxet; set => nhanxet = value; }

        private string doctor;
        private string major;
        private string donthuoc;
        private string dando;
        private string nhanxet;
    }
}
