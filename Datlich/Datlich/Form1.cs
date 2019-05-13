using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datlich
{
    public partial class Form1 : Form
    {
        string defaultDate = "";
        string defaultMajor = "";
        string defaultName = "";
        string defaultTime = "";
        public static string mabenhnhan, email, tenbenhnhan;
        public Form1()
        {
            InitializeComponent();
            Date_panel.Visible = false;
            pictureBox1.Width = pictureBox1.Height = panel1.Width - 30;
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox1.Width - 3, pictureBox1.Height - 3);
            Region rg = new Region(gp);
            pictureBox1.Region = rg;
            defaultDate = txtDate.Text;
            defaultMajor = cbMajor.Text;
            defaultName = txtDoctor.Text;
            defaultTime = txtTime.Text;
            mabenhnhan = mabn.Text;
            email = email1.Text;
            tenbenhnhan = name.Text; 
        }
        private void Ngay_MouseClick(object sender, MouseEventArgs e)
        {
            cbMajor.Enabled = true;
            Date_panel.Visible = true;
            Date_panel.Dock = DockStyle.Fill;
            monthCalendar1.Visible = true;
            monthCalendar1.MinDate = monthCalendar1.TodayDate;
            monthCalendar1.MaxDate = monthCalendar1.TodayDate.AddMonths(1);
        }
        private void lbBacSi_Click(object sender, EventArgs e)
        {

        }
        private Doctor t = new Doctor();
        internal void addDoctor(int id, string doctor_name, string price, string major)
        {
            t.setDoctor(id, doctor_name, price, major);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public static string date = "";
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            Date_panel.Dock = DockStyle.Top;
            Date_panel.Visible = false;
            monthCalendar1.Visible = false;
            lbNgayKham.Visible = true;

            txtDate.Text = monthCalendar1.SelectionStart.Date.ToString("yyyy-MM-dd");
            date = txtDate.Text;
        }
        public static string Doctor_name = "";
        public void changeName()
        {
            txtDoctor.Text = Doctor_name;
        }
        private void txtDoctor_Click(object sender, EventArgs e)
        {
            txtTime.Enabled = true;
            Form2 chooseDoctor = new Form2(this);
            chooseDoctor.Show();
            
        }
        private void cbMajor_TextChanged(object sender, EventArgs e)
        {
            ControllerDatlich.major_name = cbMajor.Text;
            Doctor_name = "";
            txtDoctor.Text = "";
        }

        private void cbMajor_MouseClick(object sender, MouseEventArgs e)
        {
            txtDoctor.Enabled = true;
            ControllerDatlich listMajor = new ControllerDatlich();
            cbMajor.DataSource = listMajor.listMajor();
        }

        private void cbMajor_TextUpdate(object sender, EventArgs e)
        {
            
        }

        private void cbMajor_DataSourceChanged(object sender, EventArgs e)
        {
        }

        private void cbMajor_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cbMajor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void txtTime_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.Show();
            form3.Width = this.Width;
            form3.Height = this.Height;
            form3.Location = this.Location;
        }
        public string time;
        public void change_txtTime()
        {
            txtTime.Text = time;
        }
        private void txtTime_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtTime_ReadOnlyChanged(object sender, EventArgs e)
        {
        }

        private void txtTime_DragOver(object sender, DragEventArgs e)
        {

        }

        private void txtTime_Validating(object sender, CancelEventArgs e)
        {
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool show = false;
        int PW = 237;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (show)
            {
                panel2.Height -= 20;
                logout.Location = new Point(logout.Location.X, logout.Location.Y - 20);
                if (panel2.Height <= button1.Height)
                {
                    timer1.Stop();
                    show = !show;
                    this.Refresh();
                }             
            }
            else
            {
                panel2.Height += 20;
                logout.Location = new Point(logout.Location.X, logout.Location.Y + 20);
                if (panel2.Height >= PW)
                {
                    timer1.Stop();
                    show = !show;
                    this.Refresh();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        bool BHYT = true;

        private void Confirm_Click(object sender, EventArgs e)
        {
            if ((txtDate.Text == defaultDate) || (txtDoctor.Text == defaultName) ||
                (cbMajor.Text == defaultMajor) || (txtDoctor.Text == "") || (txtTime.Text == defaultTime))
                MessageBox.Show("Ban chua dien du thong tin!!!");
            else {
                ControllerDatlich control = new ControllerDatlich();

                control.addVisit(txtDate.Text, t, txtTime.Text, BHYT);
                control.GuiMail(email);
                this.Close();
            }
        }

        private void txtDoctor_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void mabn_Click(object sender, EventArgs e)
        {

        }

        private void Yes_CheckedChanged(object sender, EventArgs e)
        {
            BHYT = true;
        }

        private void No_CheckedChanged(object sender, EventArgs e)
        {
            BHYT = false;
        }
    }
}
