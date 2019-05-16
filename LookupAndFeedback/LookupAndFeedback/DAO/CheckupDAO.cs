using Datlich;
using LookupAndFeedback.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookupAndFeedback.DAO
{
    class CheckupDAO
    {
        private static CheckupDAO instance;

        public static CheckupDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CheckupDAO();
                }
                return CheckupDAO.instance;
            }
            private set
            {
                CheckupDAO.instance = value;
            }
        }
        int tempId = ControllerDatlich.id_benhnhan;
        private CheckupDAO() { }
        public List<CheckupInfo> LoadCheckupList()
        {
            List<CheckupInfo> checkupList = new List<CheckupInfo>();
            string query = string.Format("select mabenhan, ngaykham, chuandoan, donthuoc, dando, nhanxet  from dbo.benhan where mabenhnhan = {0}", tempId);
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                CheckupInfo checkup = new CheckupInfo(item);
                checkupList.Add(checkup);
            }
            return checkupList;
        }
        public bool UpdateCheckup(string cmt, int id)
        {
            string query = string.Format("update dbo.Info set nhanxet = N'{0}' where id = {1}", cmt, id);
            int res = DataProvider.Instance.ExcuteNonQuery(query);
            return res > 0;
        }

        
    }
}
