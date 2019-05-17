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
        public CheckupInfo(int id, DateTime date, string dando, string nhanxet, string donthuoc)
        {
            this.ID = id;
            this.Date = date;
            //this.Doctor = doctor;
            //this.Major = major;
            this.Prescription = donthuoc;
            this.Advice = dando;
            this.Review = nhanxet;
        }

        public CheckupInfo(DataRow row)
        {
            this.ID = (int)row["mabenhan"];
            this.Date = (DateTime)row["ngaykham"];
            //this.Doctor = row["doctor"].ToString();
            //this.Major = row["major"].ToString();
            this.Prescription = row["donthuoc"].ToString();
            this.Advice = row["dando"].ToString();
            this.Review = row["nhanxet"].ToString();

        }

        
        private int iD;
        
        public int ID { get => iD; set => iD = value; }

        private DateTime date;
        public DateTime Date { get => date; set => date = value; }
        
        
        
        public string Prescription { get => prescription; set => prescription = value; }
        public string Advice { get => advice; set => advice = value; }
        public string Review { get => review; set => review = value; }

        private string prescription;
        private string advice;
        private string review;
    }
}
