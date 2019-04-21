using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.searchbookBtn.Image = (Image)(new Bitmap(searchbookBtn.Image, new Size(60, 60)));

            this.searchHisBtn.Image = (Image)(new Bitmap(searchHisBtn.Image, new Size(60, 60)));

        }
        Form3 form3 = null;
        Form2 form2 = null;
        Form6 form6 = null;
        private void searchbookBtn_Click(object sender, EventArgs e)
        {
            
            if (form3 != null)
            {
                form3.BringToFront();
            }
            else
            {
                form3 = new Form3();
                form3.Show();
                if (form2 != null)
                {
                    form2.Hide();
                    form2 = null;
                }
                
            }
            
        }

        private void searchHisBtn_Click(object sender, EventArgs e)
        {
            if (form2 != null)
            {
                form2.BringToFront();
            }
            else
            {
                form2 = new Form2();
                form2.Show();
                if (form3 != null)
                {
                    form3.Hide();
                    form3 = null;
                }
                
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
