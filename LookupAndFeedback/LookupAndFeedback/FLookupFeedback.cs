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
using LookupAndFeedback.DAO;
using Datlich;

namespace LookupAndFeedback
{
    public partial class FLookupFeedback : Form
    {
        public FLookupFeedback()
        {
            InitializeComponent();
        }

        private void FLookupFeedback_Load(object sender, EventArgs e)
        {
            this.LookupHisBtn.Image = (Image)(new Bitmap(LookupHisBtn.Image, new Size(40, 40)));

            this.LookupBookingBtn.Image = (Image)(new Bitmap(LookupBookingBtn.Image, new Size(40, 40)));
            label1.Text = ControllerDatlich.name_benhnhan;
            label2.Text = ControllerDatlich.id_benhnhan.ToString();
        }

        private void LookupHisBtn_Click(object sender, EventArgs e)
        {
            FLookupHis f = new FLookupHis();
            this.Hide();
            f.ShowDialog();
            Show();
        }

        private void LookupBookingBtn_Click(object sender, EventArgs e)
        {
            
            FLookupBook f = new FLookupBook();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        
    }
}
