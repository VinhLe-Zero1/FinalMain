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
        public Booking(int id, DateTime date, string doctor, string major)
        {
            this.ID = id;
            this.Date = date;
            this.Doctor = doctor;
            this.Major = major;
        }
        
        public Booking(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Date = (DateTime)row["date"];
            this.Doctor = row["doctor"].ToString();
            this.Major = row["major"].ToString();

        }

        
        private int iD;

        public int ID { get => iD; set => iD = value; }

        private DateTime date;
        public DateTime Date { get => date; set => date = value; }
        public string Doctor { get => doctor; set => doctor = value; }
        public string Major { get => major; set => major = value; }

        private string doctor;
        private string major;
    }
}
