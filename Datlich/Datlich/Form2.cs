using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datlich
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
            ControllerDatlich display = new ControllerDatlich();
            chooseDoc.DataSource = display.GetDataBaseCommand(display.showDoctor()).Tables[0];
            chooseDoc.Columns[0].HeaderText = "ID";
            chooseDoc.Columns[1].HeaderText = "Tên bác sĩ";
            chooseDoc.Columns[2].HeaderText = "Chuyên khoa";
            chooseDoc.Columns[3].HeaderText = "Giá tiền";
            chooseDoc.Columns[4].HeaderText = "Đánh giá";
            chooseDoc.Width = this.Width;
            chooseDoc.Height = this.Height;
            f1out = f1in;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.Doctor_name = chooseDoc.CurrentRow.Cells[1].Value.ToString();
            int id = (int)chooseDoc.CurrentRow.Cells[0].Value;
            string major = chooseDoc.CurrentRow.Cells[2].Value.ToString();
            string price = chooseDoc.CurrentRow.Cells[3].Value.ToString();
            f1out.changeName();
            f1out.addDoctor(id, Form1.Doctor_name, price, major);
            this.Close();
        }

        private void chooseDoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
