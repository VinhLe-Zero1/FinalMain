using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thongkethongtin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
