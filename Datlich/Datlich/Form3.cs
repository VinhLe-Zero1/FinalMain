using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datlich
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
            Out.time = s[0].ToString() + s[1].ToString() + ":00:00";
            Out.change_txtTime();
            this.Close();
        }
        private bool checkTimeAble(string s)
        {
            ControllerDatlich t = new ControllerDatlich();
            string datetime = Form1.date + " " + s[0].ToString() + s[1].ToString() + ":00:00";
            return (t.listTimeAble(datetime, Form1.Doctor_name).Count < Doctor.cap + 1);
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

        private void panel_sang_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (checkTimeAble(time7.Text)) time7.Enabled = true;
            else time7.Enabled = false;

            if (checkTimeAble(time8.Text)) time8.Enabled = true;
            else time8.Enabled = false;

            if (checkTimeAble(time9.Text)) time9.Enabled = true;
            else time9.Enabled = false;

            if (checkTimeAble(time10.Text)) time10.Enabled = true;
            else time10.Enabled = false;

            if (checkTimeAble(time13.Text)) time13.Enabled = true;
            else time13.Enabled = false;

            if (checkTimeAble(time14.Text)) time14.Enabled = true;
            else time14.Enabled = false;

            if (checkTimeAble(time15.Text)) time15.Enabled = true;
            else time15.Enabled = false;

            if (checkTimeAble(button7.Text)) button7.Enabled = true;
            else button7.Enabled = false;

        }
    }
}
