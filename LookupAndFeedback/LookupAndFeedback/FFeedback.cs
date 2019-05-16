using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LookupAndFeedback
{
    public partial class FFeedback : Form
    {
        public FFeedback()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FFeedback_FormClosing(object sender, FormClosingEventArgs e)
        {
            

                if (MessageBox.Show("Bạn có thực sự muốn trở về?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                {
                    e.Cancel = true;
                }
            
        }
        
        private void FFeedback_Load(object sender, EventArgs e)
        {
            
        }
        public static string str;
        public static bool DoneCliked = false;
        private void DoneBtn_Click(object sender, EventArgs e)
        {
            DoneCliked = true;
            str = textBox1.Text;
            if (radioButton1.Checked == true && str != "" )
            {
                MessageBox.Show("Bạn đã hoàn thành bình luận về lần khám này");
                textBox1.ReadOnly = true;
                panel1.Enabled = false;
                return;
            }
            else if (radioButton2.Checked == true && str != "")
            {
                MessageBox.Show("Bạn đã hoàn thành bình luận về lần khám này");
                textBox1.ReadOnly = true;
                panel1.Enabled = false;
                return;
            }
            else if (radioButton3.Checked == true && str != "")
            {
                MessageBox.Show("Bạn đã hoàn thành bình luận về lần khám này");
                textBox1.ReadOnly = true;
                panel1.Enabled = false;
                return;
            }
            else if (radioButton4.Checked == true && str != "")
            {
                MessageBox.Show("Bạn đã hoàn thành bình luận về lần khám này");
                textBox1.ReadOnly = true;
                panel1.Enabled = false;
                return;
            }
            else if (radioButton5.Checked == true && str != "")
            {
                MessageBox.Show("Bạn đã hoàn thành bình luận về lần khám này");
                textBox1.ReadOnly = true;
                panel1.Enabled = false;
                return;
            }
            else
            {
                MessageBox.Show("Đã có lỗi khi bình luận!");
                return;
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            panel1.Enabled = true;
            DoneCliked = false;
        }
    }
}
