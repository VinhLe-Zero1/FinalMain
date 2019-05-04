using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_CNPM;
namespace T_benhan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool checkNum(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] > '9' || s[i] < '0') return false;
            }
            return true;
        }

        private void Datlich_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lbPhongGio_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void luu_Click(object sender, EventArgs e)
        {
            if (maso.Text == "" || chuandoan.Text == "" || donthuoc.Text == "" || !checkNum(maso.Text.ToString())) {
                b_thongbao.Visible = true;
                thongbao.Visible = true;
                
            }
            else
            {
                int ID;
                if (int.TryParse(maso.ToString(), out ID))
                {
                    Benhan benhan = new Benhan();
                    benhan.addBenhan(ID, chuandoan.Text, dando.Text, donthuoc.Text);
                    BTL_CNPM.Control t = new BTL_CNPM.Control();
                    t.UpdateData(benhan);
                }
                thongbao.Text = "Thông tin bệnh án đã được lưu!";
                b_thongbao.Visible = true;
                thongbao.Visible = true;
            }

        }

        private void maso_TextChanged(object sender, EventArgs e)
        {
            maso.SelectionStart = maso.Text.Length;
            maso.SelectionLength = 0;
        }

        private void b_thongbao_Click(object sender, EventArgs e)
        {
            b_thongbao.Visible = false;
            thongbao.Visible = false;
        }
    }
}
