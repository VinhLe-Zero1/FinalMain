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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void tintuc_Click(object sender, EventArgs e)
        {
            capnhatyteganday.Form1 yte = new capnhatyteganday.Form1();
            yte.Show();
        }

        private void chuandoan_Click(object sender, EventArgs e)
        {
            T_chuandoan.chuandoan cd = new T_chuandoan.chuandoan();
            cd.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            capnhatinfo.capnhapthongtin cn = new capnhatinfo.capnhapthongtin();
            cn.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PatientHistory.formHistory t = new PatientHistory.formHistory();
            t.Show();
        }
    }
}
