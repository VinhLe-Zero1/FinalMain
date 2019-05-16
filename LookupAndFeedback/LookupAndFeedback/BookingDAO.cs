using Datlich;
using LookupAndFeedback.DAO;
using LookupAndFeedback.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookupAndFeedback
{
    class BookingDAO
    {
        /*public bool DeleteBooking(int idBooking)
        {
            //BillInfoDAO.Instance.DeleteBill(idFood);
            string query = string.Format("Delete Food where id = {0}", idBooking);
            int result = DataProvider.ExcuteNonQuery(query);

            return result > 0;
        }*/
        private static BookingDAO instance;

        public static BookingDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BookingDAO();
                }
                return BookingDAO.instance;
            }
            private set
            {
                BookingDAO.instance = value;
            }
        }
        int tempId = ControllerDatlich.id_benhnhan;
        private BookingDAO() { }
        public List<Booking> LoadBookingList()
        {
            List<Booking> bookingList = new List<Booking>();
            string query = string.Format("select id, doctorName, chuyenkhoa, giaTien, ngaykham  from dbo.infokhambenh where mabenhnhan = {0}", tempId);
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Booking booking = new Booking(item);
                bookingList.Add(booking);
            }
            return bookingList;
        }
        
        /*public List<Booking> SearchByText(string name)
        {
            List<Booking> list = new List<Booking>();
            string query = string.Format("select * from dbo.Info where dbo.fc_ConvertString(name) like N'%' + dbo.fc_ConvertString(N'{0}') + '%'", name);
            DataProvider dataProvider = new DataProvider();
            DataTable data = new DataTable();
            data = dataProvider.ExcuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                Booking booking = new Booking(item);
                list.Add(booking);
            }
            return list;
        }*/
        public void DeleteBookingLinking(int id)
        {
            DataProvider.Instance.ExcuteQuery("delete dbo. where id = " + id);
        }
        public bool DeleteBooking(int id)
        {
            string query = string.Format("Delete infokhambenh where id = {0}", id);
            int res = DataProvider.Instance.ExcuteNonQuery(query);
            return res > 0;
        }
    }
}
