using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Data.SqlClient;
using Datlich;
// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace InfoRegister
{
    public partial class formRegister : Form
    {
        public formRegister()
        {
            InitializeComponent();
            labelMissing.Hide();
            labelMissing2.Hide();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks!");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
        
        

        private void btnRegister_Click(object sender, EventArgs e)
        {
            bool m1 = false, m2 = false, m3 = false;
            foreach (TextBox tb in this.tLPInfo.Controls.OfType<TextBox>())
            {
                if (String.IsNullOrEmpty(tb.Text))
                {
                    tb.ForeColor = Color.Red;
                    tb.Text = "This field is empty";
                    m1 = true;
                }
                
            }

            foreach (ComboBox cb in this.fLPDate.Controls.OfType<ComboBox>())
            {
                if(cb.SelectedItem == null)
                {
                    labelMissing.Show(); m2 = true;
                }
            }

            if (!radioButtonMale.Checked && !radioButtonFemale.Checked)
            {
                labelMissing2.Show();
                m3 = true;
            }

            if (m1 || m2 || m3)
            {
                return;
            }

            string[] monthArr = {"Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín", "Mười", "Mưởi một", "Mười hai"};

            string lastName = "'" + lastNameBox.Text + "'";
            string firstName = "'"+firstNameBox.Text + "'";
            string civilianID = "'" + CMNDBox.Text + "'";
            string address = "'" + adrBox.Text + "'";
            string phone = "'" + phoneNumBox.Text + "'";
            string email = "'" + emailBox.Text + "'";
            string homeTown = "'" + homeTownBox.Text + "'";
            string month = "";
            for (int i = 0; i < 12; i++)
            {
                if (monthArr[i] == comboBoxMonth.Text)
                {
                    month = (i + 1).ToString();
                    break;
                }
            }
            string dateOfBirth = "'" + comboBoxDay.Text + "/" + month + "/" + comboBoxYear.Text + "'";
            string sex;
            if (radioButtonMale.Checked)
                sex = "'Nam'";
            else sex = "'Nu'";
            
            string value = "("+lastName+", "+firstName+", "+dateOfBirth+", "+sex+", "+civilianID+", "+ address+ ", "+phone+", "+email+", "+ homeTown +")";


            try
            {
                string conStr = ConnectString.connectString;
                SqlConnection con = new SqlConnection(conStr);
                SqlDataAdapter da = new SqlDataAdapter();
                da.InsertCommand = new SqlCommand("INSERT INTO PatientInfo VALUES " + value, con);

                con.Open();
                da.InsertCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Client Successfully added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //sMessageBox.Show("fail");
            }

        }
        private void OnMouseLeft(Object sender, MouseEventArgs e)
        {
            TextBox tb = (TextBox) sender;
            tb.Text = string.Empty;
            tb.ForeColor = Color.Black;
        }
        private void OnComboBoxMouseLeft(object sender, MouseEventArgs e)
        {
            labelMissing.Hide();
        }
        private void OnRadioBtnMouseLeft(object sender, MouseEventArgs e)
        {
            labelMissing2.Hide();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

        

