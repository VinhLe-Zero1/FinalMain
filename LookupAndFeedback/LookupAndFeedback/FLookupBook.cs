using Datlich;
using LookupAndFeedback.DAO;
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
    public partial class FLookupBook : Form
    {
        public FLookupBook()
        {
            InitializeComponent();
            label1.Text = ControllerDatlich.name_benhnhan;
            label2.Text = ControllerDatlich.id_benhnhan.ToString();
            LoadBooking();
            if (dataGridView1.Rows.Count == 0)
            {
                //CancelBtn.Enabled = false;
                RefreshBtn.Enabled = false;
            }
        }

        private void FLookupBook_Load(object sender, EventArgs e)
        {

        }
        void LoadBooking()
        {
            dataGridView1.DataSource = BookingDAO.Instance.LoadBookingList();
        }
        string idStr;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idStr = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idStr);
            if (BookingDAO.Instance.DeleteBooking(id))
            {
                MessageBox.Show("Hủy thành công");
                LoadBooking();
                if (deleteBook != null)
                    deleteBook(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Lỗi khi hủy");
            }
        }

        private event EventHandler deleteBook;
        public event EventHandler DeleteBook
        {
            add { deleteBook += value; }
            remove { deleteBook -= value; }
        }

        private event EventHandler updateBook;
        public event EventHandler UpdateBook
        {
            add { updateBook += value; }
            remove { updateBook -= value; }

            /*public void DeleteLinking(int id)
            {
                DataProvider.Instance.ExcuteQuery("delete dbo.BillInfo where idFood = " + id);
            }*/
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            LoadBooking();
        }
    }
}
