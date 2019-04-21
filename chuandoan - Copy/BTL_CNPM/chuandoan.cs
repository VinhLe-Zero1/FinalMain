using System;
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
namespace T_chuandoan
{
    public partial class chuandoan : Form
    {
        public chuandoan()
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
                b_thongbao.Visible = true;
                thongbao.Visible = true;
            }
            else
            {
                b_thongbao_1.Visible = true;
                thongbao_1.Visible = true;
                string file_name = "C:\\Users\\DELL\\Desktop\\Output.txt";
                System.IO.StreamWriter obj;
                obj = new System.IO.StreamWriter(file_name);
                obj.WriteLine(dh1.Text);
                obj.WriteLine(dh2.Text);
                obj.WriteLine(dh3.Text);
                obj.WriteLine(dh4.Text);
                obj.Close();
               
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
            thongbao.Visible = false;
            b_thongbao.Visible = false;
        }

        private void b_thongbao_1_Click(object sender, EventArgs e)
        {
            thongbao_1.Visible = false;
            b_thongbao_1.Visible = false;
        }

        private void thongbao_1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
