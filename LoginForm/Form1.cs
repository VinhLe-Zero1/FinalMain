using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.Data.SqlClient;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace LoginForm
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
       
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //add new comment
        //add a new comment

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(boxLogin.Text))
            {
                boxLogin.Text = "Can't leave out";
                boxLogin.ForeColor = Color.Red;
                if (String.IsNullOrEmpty(boxPwd.Text))
                {
                    boxPwd.PasswordChar = '\0';
                    boxPwd.Text = "Can't leave out";
                    boxPwd.ForeColor = Color.Red;

                }

            }else if (String.IsNullOrEmpty(boxPwd.Text)){
                boxPwd.PasswordChar = '\0';
                boxPwd.Text = "Can't leave out";
                boxPwd.ForeColor = Color.Red;

            }
            else if (!String.IsNullOrEmpty(boxLogin.Text) && !String.IsNullOrEmpty(boxPwd.Text)){
                try
                {
                    string username = boxLogin.Text;
                    string password = boxPwd.Text;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source=.;Initial Catalog=Patient;Integrated Security=True";
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select username,password from loginInfo where username='" + username + "'and password='" + password + "'", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        Form mainForm = new FinalMain.Form1();
                        mainForm.Show();
                        
                        
                    }
                    else
                    {
                        MessageBox.Show("Invalid Login! Please check username and password");
                    }
                    con.Close();
                }catch(Exception ex)
                {
                    MessageBox.Show("Error connecting server");
                }
            }
        }

        private void regBtn_Click(object sender, EventArgs e)
        {

            Form infoRegForm = new InfoRegister.formRegister();
            infoRegForm.Show();
            
        }

        

        private void boxPwd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(boxPwd.Text) && boxPwd.Text == "Can't leave out")
            {
                boxPwd.Text = "";
            }
            boxPwd.PasswordChar = '*';
            boxPwd.ForeColor = Color.Black;
        }

        private void boxLogin_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(boxLogin.Text) && boxLogin.Text == "Can't leave out")
            {
                boxLogin.Text = "";
            }
            boxLogin.ForeColor = Color.Black;
        }

        private void btnForget_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shake brain to remember your password!");
        }
    }
}
