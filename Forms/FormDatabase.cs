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
    public partial class FormDatabase : Form
    {
        public FormDatabase()
        {
            InitializeComponent();
        }

        private void FormDatabase_Load(object sender, EventArgs e)
        {
            OracleDatabase.form = this;
            comboBoxTableList.SelectedIndex = 0;
            OracleDatabase.LoadDataGrid();
        }
        private void comboBoxTableList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OracleDatabase.LoadDataGrid();
                OracleDatabase.LoadTableInfo();
                OracleDatabase.LoadSearchColoumn();
            }
            catch (Exception)
            {
                MessageBox.Show("Combobox'da seçilen tablo veri tabanı ile eşleşmiyor !");
                throw;
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //tıklanan satırın verileri sola yazdırılıyor
        {

            if (e.RowIndex > -1)
            {
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    try
                    {
                        int rowIndex = e.RowIndex;
                        DataGridViewRow row = dataGridView1.Rows[rowIndex];
                        this.panelTableInfo.Controls.Find(("textBoxPanel" + i).ToString(), false).First().Text = row.Cells[i].Value.ToString();
                    }
                    catch (Exception)
                    {

                        throw;
                    }

                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Ara ..." || textBoxSearch.Text == null)
            {
                OracleDatabase.LoadDataGrid();
            }
            else
            {
                OracleDatabase.search();
            }
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text=="Ara ...")
            {
                textBoxSearch.Text = "";
                textBoxSearch.ForeColor = Color.Black;
            }
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "")
            {
                textBoxSearch.Text = "Ara ...";
                textBoxSearch.ForeColor = Color.Silver;
            }
        }
    }
}
