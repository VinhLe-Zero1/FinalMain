using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorForm
{
    public partial class Form1 : Form
    {
        public Form1(int id, string name)
        {
            
            InitializeComponent();
            IDLabel.Text += id.ToString();
            nameLabel.Text += name;
        }
/*
        public Form1()
        {
            InitializeComponent();
        }
        */
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HistoryBtn_Click(object sender, EventArgs e)
        {
            PatientHistory.formHistory temp = new PatientHistory.formHistory();
            temp.Show();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            T_benhan.Form1 temp = new T_benhan.Form1();
            temp.Show();
        }

        private void StatBtn_Click(object sender, EventArgs e)
        {
            thongkethongtin.Form1 temp = new thongkethongtin.Form1();
            temp.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
