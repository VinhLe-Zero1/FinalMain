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
        public Form1()
        {
            InitializeComponent();
            DataTable ds;
            Datacontrol a = new Datacontrol();
            ds = a.ChooseAllData();
            dataGridView1.DataSource = ds;
            List<Desease> age = new List<Desease>();
            age = a.GetDesease();
            string label = "";
            foreach (var el in age)
                label = label + el.desease.ToString() + " " + el.count.ToString() + " ";
            label3.Text = label;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayMessageSuccess();
            DisplayMessageFail();
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
            DisplayMessageSuccess();
            DisplayMessageFail();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DisplayMessageSuccess();
            DisplayMessageFail();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DisplayMessageSuccess();
            DisplayMessageFail();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
