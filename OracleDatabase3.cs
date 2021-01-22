using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using Cinema.Forms;

namespace Cinema
{
    class OracleDatabase3
    {
        static OracleConnection connection = new OracleConnection("Data Source=localhost:1521/XEPDB1; User Id=SYSTEM;Password=oraclepass;");
        public static FormLog form;
        public static void LoadDataGrid()
        {
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM C_LOG";
            connection.Open();


            OracleDataAdapter adaptor = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable();
            adaptor.Fill(dataTable);
            form.dataGridView1.DataSource = dataTable;

            connection.Close();
        }

        public static void LoadSearchColoumn()
        {
            form.comboBoxSearch.Items.Clear();
            for (int i = 0; i < form.dataGridView1.Columns.Count; i++)
            {
                form.comboBoxSearch.Items.Add(form.dataGridView1.Columns[i].Name.ToString());
            }
            form.comboBoxSearch.SelectedIndex = 0;
        }

        public static void search()
        {
            
                        OracleCommand command = new OracleCommand();
                        command.Connection = connection;
                        string text = form.textBoxSearch.Text.ToString();
                        command.CommandText = "SELECT * FROM C_LOG WHERE " + form.comboBoxSearch.SelectedItem.ToString() + " LIKE '%" + form.textBoxSearch.Text + "%'";
                        connection.Open();


                        OracleDataAdapter adaptor = new OracleDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        adaptor.Fill(dataTable);
                        form.dataGridView1.DataSource = dataTable;
                        connection.Close();




            
        }
    }
}
