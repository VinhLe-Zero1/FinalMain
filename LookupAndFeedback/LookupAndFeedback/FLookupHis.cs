using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LookupAndFeedback.DAO;
using LookupAndFeedback.DTO;

namespace LookupAndFeedback
{
    public partial class FLookupHis : Form
    {
        public object CheckupInfo { get; private set; }

        public FLookupHis()
        {
            InitializeComponent();
            LoadHistory();
            DonthuocBinding();

        }

        private void FLookupBooking_Load(object sender, EventArgs e)
        {
            this.CmtBtn.Image = (Image)(new Bitmap(CmtBtn.Image, new Size(40, 40)));
        }
        static
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //if (dataGridView1.SelectedCells.Count > 0)
            //{
            //    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

            //    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

            //    string a = Convert.ToString(selectedRow.Cells[1].Value);
                


            //}
        }
        private void CmtBtn_Click(object sender, EventArgs e)
        {
            FFeedback f = new FFeedback();
            
            f.Show();
            

            
        }

        private void DateFind_TextChanged(object sender, EventArgs e)
        {

        }

        /*void LoadHistory()
        {
            //string query = "select id as [ID] from dbo.Info";
            string query = "select * from dbo.Info";
            
            dataGridView1.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }*/

        void LoadHistory()
        {
            dataGridView1.DataSource = CheckupDAO.Instance.LoadCheckupList();
        }

        void DonthuocBinding()
        {
            DonthuocTxt.DataBindings.Add("Text", dataGridView1.DataSource, "Donthuoc");
            IDTxt.DataBindings.Add("Text", dataGridView1.DataSource, "id");
        }

        private void DonthuocTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = SearchByText(textBox1.Text);
        }

        /*List<Booking> SearchByText(string name)
        {
            List<Booking> listBook = new List<Booking>();
            BookingDAO booking = new BookingDAO();
            listBook = booking.SearchByText(name);

            return listBook;
        }*/

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateCmt()
        {
            int id = Convert.ToInt32(IDTxt.Text);
            string cmt = FFeedback.str;
            CheckupDAO.Instance.UpdateCheckup(cmt, id);
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            UpdateCmt(); 
            LoadHistory();
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //string value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();
        }
    }
}
