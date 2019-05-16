using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace FinalMain
{
    public partial class Form1 : Form
    {
        public Form1(/*int id, string name*/)
        {
            InitializeComponent();
            //nameLabel.Text += name;
            //IDLabel.Text += id.ToString();
        }
        //Dat Lich
        private void button1_Click(object sender, EventArgs e)
        {
        //    Datlich.Form1 form1 = new Datlich.Form1();
        //    form1.Show();
        }
        private void tintuc_Click(object sender, EventArgs e)
        {
            capnhatyteganday.Form1 yte = new capnhatyteganday.Form1();
            yte.Show();
        }

        private void chuandoan_Click(object sender, EventArgs e)
        {
            T_chuandoan.DiagnoseForm cd = new T_chuandoan.DiagnoseForm();
            cd.Show();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            capnhatinfo.capnhapthongtin cn = new capnhatinfo.capnhapthongtin();
            cn.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LookupAndFeedback.FLookupFeedback t = new LookupAndFeedback.FLookupFeedback();
            t.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void patient_info_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void patient_info_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
