using LookupAndFeedback.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookupAndFeedback.DTO
{
    class Booking
    {
        public Booking(int id, DateTime date, string doctor, string major, string price)
        {
            this.ID = id;
            this.Date = date;
            this.Doctor = doctor;
            this.Major = major;
            this.Price = price;
        }
        
        public Booking(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Doctor = row["doctorName"].ToString();
            this.Major = row["chuyenkhoa"].ToString();
            this.Price = row["giaTien"].ToString();
            this.Date = (DateTime)row["ngaykham"];
            
        }

        
        private int iD;

        public int ID { get => iD; set => iD = value; }

        private DateTime date;
        public DateTime Date { get => date; set => date = value; }
        public string Doctor { get => doctor; set => doctor = value; }
        public string Major { get => major; set => major = value; }
        public string Price { get => price; set => price = value; }

        private string price;
        private string doctor;
        private string major;
    }
}
