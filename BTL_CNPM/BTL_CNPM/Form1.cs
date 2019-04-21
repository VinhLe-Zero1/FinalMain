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

namespace Tin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Date_panel.Visible = false;
            pictureBox1.Width = pictureBox1.Height = panel1.Width - 30;
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox1.Width - 3, pictureBox1.Height - 3);
            Region rg = new Region(gp);
            pictureBox1.Region = rg;
        }
        public static string query = "";
        private void Ngay_MouseClick(object sender, MouseEventArgs e)
        {
            Date_panel.Visible = true;
            Date_panel.Dock = DockStyle.Fill;
            monthCalendar1.Visible = true;
           
        }
        private void lbBacSi_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            Date_panel.Dock = DockStyle.Top;
            Date_panel.Visible = false;
            monthCalendar1.Visible = false;
            lbNgayKham.Visible = true;

            txtDate.Text = monthCalendar1.SelectionStart.Date.ToString("dd/MM/yyyy");
        }
        public string Doctor_name;
        public void changeName()
        {
            txtDoctor.Text = Doctor_name;
        }
        private void txtDoctor_Click(object sender, EventArgs e)
        {
            Form2 chooseDoctor = new Form2(this);
            chooseDoctor.Show();
            
        }

        private void cbMajor_TextChanged(object sender, EventArgs e)
        {
            query = "select * from ADoctor where Major='" + cbMajor.Text + "'";
        }

        private void cbMajor_MouseClick(object sender, MouseEventArgs e)
        {
            string query = "select Major from ADoctor";
            SqlConnection conn = new SqlConnection(ConnectString.connectString);
            conn.Open();
            List<string> listItem = new List<string>();
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listItem.Add(reader.GetString(0));
                    }
                }
            }
            cbMajor.DataSource = listItem;
            conn.Close();
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

        private void txtDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
