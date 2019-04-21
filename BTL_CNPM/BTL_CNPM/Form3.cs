using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tin
{
    public partial class Form3 : Form
    {
        Form1 Out;
        public Form3(Form1 In)
        {
            InitializeComponent();
            Out = In;
        }
        private void change_txt(string s)
        {
            Out.time = s;
            Out.change_txtTime();
            this.Close();
        }
        private void time7_Click(object sender, EventArgs e)
        {
            change_txt(time7.Text);
        }

        private void time8_Click(object sender, EventArgs e)
        {
            
        }

        private void time9_Click(object sender, EventArgs e)
        {
            change_txt(time9.Text);
        }

        private void time10_Click(object sender, EventArgs e)
        {
            change_txt(time10.Text);
        }

        private void time13_Click(object sender, EventArgs e)
        {
            change_txt(time13.Text);
        }

        private void time14_Click(object sender, EventArgs e)
        {
            change_txt(time14.Text);
        }

        private void time15_Click(object sender, EventArgs e)
        {
            change_txt(time15.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            change_txt(button7.Text);
        }

        private void time8_Click_1(object sender, EventArgs e)
        {
            change_txt(time8.Text);
        }
        bool morning = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (morning)
            {
                panel_sang.Width -= 20;
                panel_chieu.Width += 20;
                if (panel_sang.Width <= label2.Width + 30)
                {
                    morning = false;
                    timer1.Stop();
                    this.Refresh();
                }
            }
            else
            {
                panel_chieu.Width -= 20;
                panel_sang.Width += 20;
                if (panel_chieu.Width <= label3.Width + 20)
                {
                    morning = true;
                    timer1.Stop();
                    this.Refresh();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if(!morning) timer1.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if(morning) timer1.Start();
        }
    }
}
