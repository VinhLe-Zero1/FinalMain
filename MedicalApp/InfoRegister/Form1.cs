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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

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

            string lastName = lastNameBox.Text;
            string firstName = firstNameBox.Text;
            string civilianID = CMNDBox.Text;
            string address = adrBox.Text;
            string phone = phoneNumBox.Text;
            string email = emailBox.Text;
            string dateOfBirth = comboBoxDay.Text + "-" + comboBoxMonth.Text + "-" + comboBoxYear.Text;
            string sex;
            if (radioButtonMale.Checked)
                sex = "Nam";
            else sex = "Nữ";
            try
            {
                string conStr = "Data Source=.;Initial Catalog=Patient;Integrated Security=True";
                SqlConnection con = new SqlConnection(conStr);
                SqlDataAdapter da = new SqlDataAdapter();
                da.InsertCommand = new SqlCommand("INSERT INTO loginInfo VALUES(@)", con);
                da.InsertCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = bxUN.Text;
                da.InsertCommand.Parameters.AddWithValue("@password", bxPwd.Text);


                con.Open();
                da.InsertCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Client Successfully added");
            }
            catch (Exception ex)
            {
                MessageBox.Show("fail");
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


    }
}

        

