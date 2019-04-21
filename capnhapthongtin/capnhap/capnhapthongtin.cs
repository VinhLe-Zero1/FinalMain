using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GemBox.Email;

namespace capnhatinfo
{
    public partial class capnhapthongtin : Form
    {
        public capnhapthongtin()
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
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
            MailAddressValidationResult result = MailAddressValidator.Validate(email.Text);
            if (cmnd.Text == "" || dth.Text == "" || que.Text == "" || noio.Text == "" || !checkNum(dth.Text) || !checkNum(cmnd.Text) || (result.Status.ToString() != "Ok")) {
                //thongbao.Text = "Bạn đã nhập sai vui lòng nhập lại!";
                b_thongbao.Visible = true;

                thongbao.Visible = true;
            }
            else
            {
                thongbao.Text = "Thông tin của bạn đã được lưu!";
                b_thongbao.Visible = true;
                thongbao.Visible = true;
            }

        }



        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void sn_ValueChanged(object sender, EventArgs e)
        {
            string snhat = sn.Value.ToString("yyyy-MM-dd");
        }

        private void thongbao_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void cmnd_TextChanged_1(object sender, EventArgs e)
        {
            cmnd.SelectionStart = cmnd.Text.Length;
            cmnd.SelectionLength = 0;
        }


        private void dth_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void b_thongbao_Click(object sender, EventArgs e)
        {
            thongbao.Visible = false;
            b_thongbao.Visible = false;
        }

        private void thongbao_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
