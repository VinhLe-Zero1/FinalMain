using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formLogin loginForm = new formLogin();
            Application.Run(loginForm);
            if (loginForm.credential == 0)
            {
                Application.Run(new DoctorForm.Form1(loginForm.id, loginForm.name));
            }else if(loginForm.credential == 1)
            {
                Application.Run(new FinalMain.Form1(loginForm.id, loginForm.name));
            }
        }
    }
}
