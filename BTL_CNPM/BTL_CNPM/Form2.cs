using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tin
{
    public partial class Form2 : Form
    {
        Form1 f1out;
        public Form2(Form1 f1in)
        { 
            InitializeComponent();
            Form1 t = new Form1();
            this.Width = t.Width;
            this.Height = t.Height;
            ConnectString display = new ConnectString();
            chooseDoc.DataSource = display.GetDataBaseCommand(Form1.query).Tables[0];
            chooseDoc.Columns[0].HeaderText = "Tên bác sĩ";
            chooseDoc.Columns[1].HeaderText = "Chuyên khoa";
            chooseDoc.Columns[2].HeaderText = "Giá tiền";
            chooseDoc.Columns[3].HeaderText = "Đánh giá";
            chooseDoc.Width = this.Width;
            chooseDoc.Height = this.Height;
            f1out = f1in;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f1out.Doctor_name = chooseDoc.CurrentRow.Cells[0].Value.ToString();
            f1out.changeName();
            this.Close();
        }
    }
}
