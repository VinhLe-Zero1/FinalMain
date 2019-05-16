using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MetroFramework.Forms;
using System.IO;
using System.Reflection;

namespace T_chuandoan
{
    public partial class chuandoanForm : Form
    {
        public chuandoanForm()
        {
            InitializeComponent();
            //MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            //// Configure color schema
            //materialSkinManager.ColorScheme = new ColorScheme(
            //    Primary.Blue400, Primary.Blue500,
            //    Primary.Blue500, Accent.LightBlue200,
            //    TextShade.WHITE
            //);
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


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void thongbao_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void dh2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dh1.Text == "" && dh2.Text == "" && dh3.Text == "" && dh4.Text == "" )
            {
                result_label.Text = "Chọn ít nhất một dấu hiệu để có thể chuẩn đoán!";
                result_label.Visible = true;
                return_button.Visible = true;
            }
            else
            {
                Symptom sym1 = new Symptom();
                sym1.setSymptom(dh1.Text);
                Symptom sym2 = new Symptom();
                sym2.setSymptom(dh2.Text);
                Symptom sym3 = new Symptom();
                sym3.setSymptom(dh3.Text);
                Symptom sym4 = new Symptom();
                sym4.setSymptom(dh4.Text);
                chuandoanController chuandoan = new chuandoanController();
                string result = chuandoan.get_Diagnosis_Result(sym1.getSymptom(), sym2.getSymptom(), sym3.getSymptom(), sym4.getSymptom());
                result_label.Text = "Bạn có thể mắc bệnh ";
                result_label.Text = result_label.Text + result;
                return_button.Visible = true;
                result_label.Visible = true;
            }
        }

        private void thongbao_Click_1(object sender, EventArgs e)
        {

        }

        private void thongbao_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void b_thongbao_Click(object sender, EventArgs e)
        {
            result_label.Visible = false;
            return_button.Visible = false;
            Application.Exit();
        }
        private void thongbao_1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
