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
    public partial class FormReadDatabase : Form
    {
        public FormReadDatabase()
        {
            InitializeComponent();
        }

        private void FormReadDatabase_Load(object sender, EventArgs e)
        {
            OracleDatabase4.form = this;
            comboBoxTableList.SelectedIndex = 0;
            OracleDatabase4.LoadDataGrid();
        }

        private void comboBoxTableList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OracleDatabase4.LoadDataGrid();
                OracleDatabase4.LoadSearchColoumn();
            }
            catch (Exception)
            {
                MessageBox.Show("Combobox'da seçilen tablo veri tabanı ile eşleşmiyor !");
                throw;
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Ara ..." || textBoxSearch.Text == null)
            {
                OracleDatabase4.LoadDataGrid();
            }
            else
            {
                OracleDatabase4.search();
            }
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Ara ...")
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
