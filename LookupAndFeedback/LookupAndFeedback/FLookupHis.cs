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
using Datlich;

namespace LookupAndFeedback
{
    public partial class FLookupHis : Form
    {
        public object CheckupInfo { get; private set; }

        public FLookupHis()
        {
            InitializeComponent();
            label1.Text = ControllerDatlich.name_benhnhan;
            label4.Text = ControllerDatlich.id_benhnhan.ToString();
            LoadHistory();
            DonthuocBinding();
            if (dataGridView1.Rows.Count == 0)
            {
                SearchBtn.Enabled = false;
                CmtBtn.Enabled = false;
                RefreshBtn.Enabled = false;
            }
        }

        private void FLookupBooking_Load(object sender, EventArgs e)
        {
            this.CmtBtn.Image = (Image)(new Bitmap(CmtBtn.Image, new Size(20, 20)));
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

        void LoadHistory()
        {
            dataGridView1.DataSource = CheckupDAO.Instance.LoadCheckupList();
        }

        void DonthuocBinding()
        {
            DonthuocTxt.DataBindings.Add("Text", dataGridView1.DataSource, "Prescription");
            IDTxt.DataBindings.Add("Text", dataGridView1.DataSource, "id");
            textBox2.DataBindings.Add("Text", dataGridView1.DataSource, "Advice");
        }

        private void DonthuocTxt_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string search = textBox1.Text;
            if (IdRB.Checked == true)
            {
                int id = 0;
                int.TryParse(search, out id);
                dataGridView1.DataSource = SearchByID(id);

            }
            else if (PreRB.Checked == true)
            {
                dataGridView1.DataSource = SearchByPre(search);
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn trường tìm kiếm");
                return;
            }
        }

        List<CheckupInfo> SearchByID(int id)
        {
            List<CheckupInfo> listCheck = CheckupDAO.Instance.SearchById(id);
            return listCheck;
        }

        List<CheckupInfo> SearchByPre(string pre)
        {
            List<CheckupInfo> listCheck = CheckupDAO.Instance.SearchByPre(pre);
            return listCheck;
        }
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

        private void IDTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
