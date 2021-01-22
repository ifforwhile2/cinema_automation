using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.Forms
{
    public partial class FormSellTicket : Form
    {
        private int salon_id;
        public FormSellTicket()
        {
            InitializeComponent();
        }

        private void FormSellTicket_Load(object sender, EventArgs e)
        {
            OracleDatabase2.form = this;
            OracleDatabase2.LoadFilmList();
            //comboBoxFilmList.SelectedIndex = 0;

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.panelSeats.Controls.Clear();
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            salon_id = int.Parse(row.Cells[1].Value.ToString());
            OracleDatabase2.date= DateTime.Parse(row.Cells[3].Value.ToString());
            OracleDatabase2.session_ID = int.Parse(row.Cells[0].Value.ToString());
            //salon id yi aldık şimdi x,y sini çekelim

            OracleDatabase2.createSeat(salon_id);
        }
        private void createSeat(int x, int y)
        {
            
        }
        
        private void comboBoxFilmList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = null;
            OracleDatabase2.loadDataGrid();
        }

       

        private void buttonSell_Click(object sender, EventArgs e)
        {
            OracleDatabase2.addTicket();
            OracleDatabase2.loadDataGrid();
            OracleDatabase2.createSeat(salon_id);
        }
    }
}
