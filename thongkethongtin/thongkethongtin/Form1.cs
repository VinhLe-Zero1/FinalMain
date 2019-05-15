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

namespace thongkethongtin
{
    public partial class Form1 : Form
    {
        public bool IsError;
        public Form1()
        {
            InitializeComponent();
            DataTable ds,ds1;
            Datacontrol a = new Datacontrol();
            a.ChooseAllData();
            ds = a.Data;
            ds1 = a.Data1;
            PatientData.DataSource = ds;
            PatientData.ReadOnly = true;
            PatientData.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PatientData.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PatientData.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PatientData1.DataSource = ds1;
            PatientData1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PatientData1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PatientData1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StatInformationControl temp = new StatInformationControl();
            if (temp.Error() == true)
            {
                DisplayMessageFail();
            }
            else
            {
                temp.StatWeek();
                IsError=temp.MakeStatFile();
                if (IsError==false) DisplayMessageSuccess();
            }
        }
        private void DisplayMessageSuccess()
        {
            MessageBox.Show("Đã thống kê thành công");
        }
        private void DisplayMessageFail()
        {
            MessageBox.Show("Lỗi: Không có dữ liệu để thống kê");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StatInformationControl temp = new StatInformationControl();
            if (temp.Error() == true)
            {
                DisplayMessageFail();
            }
            else
            {
                temp.StatMonth();
                IsError = temp.MakeStatFile();
                if (IsError == false) DisplayMessageSuccess();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StatInformationControl temp = new StatInformationControl();
            if (temp.Error() == true)
            {
                DisplayMessageFail();
            }
            else
            {
                temp.StatYear();
                IsError = temp.MakeStatFile();
                if (IsError == false) DisplayMessageSuccess();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StatInformationControl temp = new StatInformationControl();
            if (temp.Error() == true)
            {
                DisplayMessageFail();
            }
            else
            {
                temp.StatAll();
                IsError = temp.MakeStatFile();
                if (IsError == false) DisplayMessageSuccess();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
