using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capnhatyteganday
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbDay.Text = DateTime.Now.ToLongDateString();
            NewsControl news = new NewsControl();
            news.UpdateNews();
            int temp = news.MostDesease.Count;
            if (temp != 0)
            {
                Most0.Text = news.MostDesease[0].desease;
                temp--;
            }
            if (temp != 0)
            {
                Most1.Text = news.MostDesease[1].desease;
                temp--;
            }
            if (temp != 0)
            {
                Most2.Text = news.MostDesease[2].desease;
                temp--;
            }
            temp = news.IncreaseDesease.Count;
            if (temp != 0)
            {
                Increase0.Text = news.IncreaseDesease[0].desease;
                temp--;
            }
            if (temp != 0)
            {
                Increase1.Text = news.IncreaseDesease[1].desease;
                temp--;
            }
            if (temp != 0)
            {
                Increase2.Text = news.IncreaseDesease[2].desease;
                temp--;
            }
            temp = news.DecreaseDesease.Count;
            if (temp != 0)
            {
                Decrease0.Text = news.DecreaseDesease[0].desease;
                temp--;
            }
            if (temp != 0)
            {
                Decrease1.Text = news.DecreaseDesease[1].desease;
                temp--;
            }
            if (temp != 0)
            {
                Decrease2.Text = news.DecreaseDesease[2].desease;
                temp--;
            }
            Seasonal0.Text = news.SeasonalDesease[0].desease;
            Seasonal1.Text = news.SeasonalDesease[1].desease;
            Seasonal2.Text = news.SeasonalDesease[2].desease;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
