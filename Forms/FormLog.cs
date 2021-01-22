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
    public partial class FormLog : Form
    {
        public FormLog()
        {
            InitializeComponent();
        }

        private void FormLog_Load(object sender, EventArgs e)
        {
            OracleDatabase3.form = this;
            OracleDatabase3.LoadDataGrid();
            OracleDatabase3.LoadSearchColoumn();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Ara ..." || textBoxSearch.Text == null)
            {
                OracleDatabase3.LoadDataGrid();
            }
            else
            {
                OracleDatabase3.search();
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
