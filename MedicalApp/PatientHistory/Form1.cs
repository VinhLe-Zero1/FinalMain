using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Datlich;
// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace PatientHistory
{
    public partial class formHistory : Form
    {
        SqlConnection con = new SqlConnection(ConnectString.connectString);

        private void loadData()
        {
            
            SqlCommand cmd = new SqlCommand("SELECT * FROM PatientInfo", con);
            try
            {
                
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataView.DataSource = dt;
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public formHistory()
        {
            InitializeComponent();
            loadData();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if(!rBtnName.Checked && !rBtnIll.Checked && !rBtnDate.Checked)
            {
                MessageBox.Show("Choose an option!");
                return;
            }
            if (String.IsNullOrEmpty(searchBox.Text))
            {
                MessageBox.Show("No keyword in the search bar!!");
            }

            string field = "";
            string value = searchBox.Text;
            value = "'" + value + "'";
            if (rBtnName.Checked)
            {
                field = "[Tên bệnh nhân]";
                value = "N" + value;
            }
            else if (rBtnIll.Checked)
            {
                field = "[Loại Bệnh]";
                value = "N" + value;
            }
            else if (rBtnDate.Checked)
            {
                if (searchBox.Text.Contains("/"))
                {
                    MessageBox.Show("Wrong format! Correct format is y-m-d.");
                    return;
                }
                string front = searchBox.Text.Substring(0, 3);
                if(front != "201")
                {
                    MessageBox.Show("Wrong format! Correct format is y-m-d.");
                    return;
                }
                    
                field = "[Ngày khám bệnh]";
              
            }
               

            string query = "select * from PatientInfo where " + field + " like " + value;
            
            try
            { 
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                if(dt.Rows.Count == 0)
                {
                    MessageBox.Show("No result found!!!");
                }
                else
                {
                    dataView.DataSource = dt;
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchBox_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
