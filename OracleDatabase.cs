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
//using System.Data.OracleClient;
namespace Cinema
{
    public class OracleDatabase
    {
        static OracleConnection connection = new OracleConnection("Data Source=localhost:1521/XEPDB1; User Id=SYSTEM;Password=oraclepass;");
        

        public static FormDatabase form;

        public static string selectedColoumn;

        public static void LoadDataGrid()
        {
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "select * from " + form.comboBoxTableList.SelectedItem.ToString();
            connection.Open();


            OracleDataAdapter adaptor = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable();
            adaptor.Fill(dataTable);
            form.dataGridView1.DataSource = dataTable;
            
            connection.Close();
        }

        public static void LoadTableInfo()
        {
            form.panelTableInfo.Controls.Clear();
            for (int i = 0; i < form.dataGridView1.Columns.Count; i++)
            {
                //LABEL
                Label label = new Label();
                label.Text = form.dataGridView1.Columns[i].Name;
                label.Name = "labelPanel" + i;
                label.Size = new Size(100, 20);
                label.Location = new Point(10, i * 30+10);
                label.ForeColor = Color.Gainsboro;
                form.panelTableInfo.Controls.Add(label);
                //Textbox
                TextBox textBox = new TextBox();
                textBox.Size = new Size(110, 20);
                textBox.Name = "textBoxPanel" + i;
                textBox.Location = new Point(130, i * 30+10);
                if (i == 0) //farklı kontroller yapılabilir
                {
                    textBox.Enabled = false;
                }
                form.panelTableInfo.Controls.Add(textBox);
            }
            //GÜNCELLE BUTONU
            Button button = new Button();
            button.Text = "Güncelle";
            button.Size = new Size(120, 30);
            button.Location = new Point(0, form.dataGridView1.Columns.Count * 30+10);
            button.ForeColor = Color.Gainsboro;
            button.Name = "buttonPanelUpdate";
            button.Click += (s, e) => {
                MessageBox.Show("Güncelle");
                updateData();
                //updateData();
            };
            form.panelTableInfo.Controls.Add(button);
            //SİL BUTONU
            Button button4 = new Button();
            button4.Text = "Sil";
            button4.Size = new Size(120, 30);
            button4.Location = new Point(125, form.dataGridView1.Columns.Count * 30+10);
            button4.ForeColor = Color.Gainsboro;
            button4.Name = "buttonPanelRemove";
            button4.Click += (s, e) => {
                MessageBox.Show("Sil");
                removeData();
            };
            form.panelTableInfo.Controls.Add(button4);
            //TEMİZLE BUTONU
            Button button2 = new Button();
            button2.Text = "Temizle";
            button2.Size = new Size(120, 30);
            button2.Location = new Point(0, form.dataGridView1.Columns.Count * 30 + 30+10);
            button2.ForeColor = Color.Gainsboro;
            button2.Name = "buttonPanelClear";
            button2.Click += (s, e) => {
                MessageBox.Show("Temizle");

                for (int i = 0; i < form.dataGridView1.Columns.Count; i++)
                {
                    form.panelTableInfo.Controls.Find(("textBoxPanel" + i).ToString(), false).First().Text = "";
                }
            };
            form.panelTableInfo.Controls.Add(button2);
            //YENİ EKLE BUTONU
            Button button3 = new Button();
            button3.Text = "Yeni Ekle";
            button3.Size = new Size(120, 30);
            button3.Location = new Point(125, form.dataGridView1.Columns.Count * 30 + 30+10);
            button3.ForeColor = Color.Gainsboro;
            button3.Name = "buttonPaneAdd";
            button3.Click += (s, e) => {
                MessageBox.Show(form.comboBoxTableList.SelectedItem.ToString());
                //
                OracleCommand command = new OracleCommand();
                addData();
            };
            form.panelTableInfo.Controls.Add(button3);
        }

        public static void addData()
        {
            OracleDataAdapter da = new OracleDataAdapter();
            connection.Open();




            switch (form.comboBoxTableList.SelectedItem.ToString())
            {
                case "C_USER":
                    {
                        OracleCommand cmd = new OracleCommand("INSERT INTO C_USER(TYPE, NAME, PASSWORD, USERNAME) VALUES(:TYPE,:NAME,:PASSWORD,:USERNAME)", connection);
                        cmd.Parameters.Add("TYPE", OracleDbType.Varchar2, 20).Value = form.panelTableInfo.Controls.Find("textBoxPanel1", false).First().Text;
                        cmd.Parameters.Add("NAME", OracleDbType.Varchar2, 20).Value = form.panelTableInfo.Controls.Find("textBoxPanel2", false).First().Text;
                        cmd.Parameters.Add("PASSWORD", OracleDbType.Varchar2, 20).Value = form.panelTableInfo.Controls.Find("textBoxPanel3", false).First().Text;
                        cmd.Parameters.Add("USERNAME", OracleDbType.Varchar2, 20).Value = form.panelTableInfo.Controls.Find("textBoxPanel4", false).First().Text;
                        da.InsertCommand = cmd;
                        try
                        {
                            int n = cmd.ExecuteNonQuery();
                            if (n > 0)
                            {
                                MessageBox.Show("oldu");
                                connection.Close();
                                LoadDataGrid();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Veri ekleme sırasında hata oluştu!");
                        }

                        break;
                    }
                case "C_SALON":
                    {
                        OracleCommand cmd = new OracleCommand("INSERT INTO C_SALON(NAME, OPEN, X, Y) VALUES(:NAME,:OPEN,:X,:Y)", connection);
                        cmd.Parameters.Add("NAME", OracleDbType.Varchar2, 20).Value = form.panelTableInfo.Controls.Find("textBoxPanel1", false).First().Text;
                        cmd.Parameters.Add("OPEN", OracleDbType.Int32, 20).Value = form.panelTableInfo.Controls.Find("textBoxPanel2", false).First().Text;
                        cmd.Parameters.Add("X", OracleDbType.Int32, 20).Value = form.panelTableInfo.Controls.Find("textBoxPanel3", false).First().Text;
                        cmd.Parameters.Add("Y", OracleDbType.Int32, 20).Value = form.panelTableInfo.Controls.Find("textBoxPanel4", false).First().Text;
                        da.InsertCommand = cmd;
                        try
                        {
                            int n = cmd.ExecuteNonQuery();
                            if (n > 0)
                            {
                                MessageBox.Show("oldu");
                                connection.Close();
                                LoadDataGrid();
                                addSeat(form.panelTableInfo.Controls.Find("textBoxPanel3", false).First().Text, form.panelTableInfo.Controls.Find("textBoxPanel4", false).First().Text, form.panelTableInfo.Controls.Find("textBoxPanel1", false).First().Text);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Veri ekleme sırasında hata oluştu!");
                        }
                        break;
                    }
                case "C_SEAT":
                    {

                        break;
                    }
                case "C_SESSION":
                    {
                        OracleCommand cmd = new OracleCommand("INSERT INTO C_SESSION(SALON_ID, FILM_ID, DAY) VALUES(:SALON_ID, :FILM_ID, :DAY)", connection);
                        cmd.Parameters.Add("SALON_ID", OracleDbType.Int32, 20).Value = form.panelTableInfo.Controls.Find("textBoxPanel1", false).First().Text;
                        cmd.Parameters.Add("FILM_ID", OracleDbType.Int32, 20).Value = form.panelTableInfo.Controls.Find("textBoxPanel2", false).First().Text;
                        cmd.Parameters.Add("DAY", OracleDbType.Varchar2, 20).Value = form.panelTableInfo.Controls.Find("textBoxPanel3", false).First().Text;
                        da.InsertCommand = cmd;
                        try
                        {
                            int n = cmd.ExecuteNonQuery();
                            if (n > 0)
                            {
                                MessageBox.Show("oldu");
                                connection.Close();
                                LoadDataGrid();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Veri ekleme sırasında hata oluştu!");
                        }

                        break;
                    }
                case "C_TICKET":
                    {
                        OracleCommand cmd = new OracleCommand("INSERT INTO C_TICKET(SEAT_ID, SESSION_ID) VALUES(:SEAT_ID, :SESSION_ID)", connection);
                        cmd.Parameters.Add("SEAT_ID", OracleDbType.Int32, 20).Value = form.panelTableInfo.Controls.Find("textBoxPanel1", false).First().Text;
                        cmd.Parameters.Add("SESSION_ID", OracleDbType.Int32, 20).Value = form.panelTableInfo.Controls.Find("textBoxPanel2", false).First().Text;
                        da.InsertCommand = cmd;
                        try
                        {
                            int n = cmd.ExecuteNonQuery();
                            if (n > 0)
                            {
                                MessageBox.Show("oldu");
                                connection.Close();
                                LoadDataGrid();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Veri ekleme sırasında hata oluştu!");
                        }

                        break;
                    }
                case "C_FILM":
                    {
                        OracleCommand cmd = new OracleCommand("INSERT INTO C_FILM(NAME, PRICE, CATEGORY) VALUES(:NAME, :PRICE, :CATEGORY)", connection);
                        cmd.Parameters.Add("NAME", OracleDbType.Varchar2, 20).Value = form.panelTableInfo.Controls.Find("textBoxPanel1", false).First().Text;
                        cmd.Parameters.Add("PRICE", OracleDbType.Int32, 20).Value = form.panelTableInfo.Controls.Find("textBoxPanel2", false).First().Text;
                        cmd.Parameters.Add("CATEGORY", OracleDbType.Varchar2, 20).Value = form.panelTableInfo.Controls.Find("textBoxPanel3", false).First().Text;
                        da.InsertCommand = cmd;
                        try
                        {
                            int n = cmd.ExecuteNonQuery();
                            if (n > 0)
                            {
                                MessageBox.Show("oldu");
                                connection.Close();
                                LoadDataGrid();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Veri ekleme sırasında hata oluştu!");
                        }

                        break;
                    }
                case "C_CATEGORY":
                    {
                        OracleCommand cmd = new OracleCommand("INSERT INTO C_CATEGORY(NAME) VALUES(:NAME)", connection);
                        cmd.Parameters.Add("NAME", OracleDbType.Varchar2, 20).Value = form.panelTableInfo.Controls.Find("textBoxPanel1", false).First().Text;
                        da.InsertCommand = cmd;
                        try
                        {
                            int n = cmd.ExecuteNonQuery();
                            if (n > 0)
                            {
                                MessageBox.Show("oldu");
                                connection.Close();
                                LoadDataGrid();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Veri ekleme sırasında hata oluştu!");
                        }

                        break;
                    }
            }
        }
        public static void addSeat(string Row, string Colomn, string salonName)
        {
            int x = Int32.Parse(Row);
            int y = Int32.Parse(Colomn);
            int id;
            OracleCommand cmd = new OracleCommand("SELECT ID FROM C_SALON WHERE NAME ='" + salonName + "'");
            cmd.Connection = connection;
            connection.Open();
            try
            {
                OracleDataReader reader = cmd.ExecuteReader();
                reader.Read();
                id = Int16.Parse(reader.GetString(0));
                reader.Close();
                MessageBox.Show(id.ToString());


            }
            finally
            {
                connection.Close();
            }

            //ekle
            OracleDataAdapter da = new OracleDataAdapter();
            connection.Open();

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    cmd = new OracleCommand("INSERT INTO C_SEAT(SALON_ID, IS_OPEN, X, Y) VALUES(:SALON_ID,:IS_OPEN,:X,:Y)", connection);
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("SALON_ID", OracleDbType.Varchar2, 20).Value = id.ToString();
                    cmd.Parameters.Add("IS_OPEN", OracleDbType.Int32, 20).Value = form.panelTableInfo.Controls.Find("textBoxPanel2", false).First().Text;
                    cmd.Parameters.Add("X", OracleDbType.Int32, 20).Value = i.ToString();
                    cmd.Parameters.Add("Y", OracleDbType.Int32, 20).Value = j.ToString();
                    da.InsertCommand = cmd;
                    cmd.ExecuteNonQuery();
                }
            }
            connection.Close();
            LoadDataGrid();
          

        }
        public static void removeData()
        {
            OracleDataAdapter da = new OracleDataAdapter();
            connection.Open();
            OracleCommand cmd = new OracleCommand("DELETE FROM "+form.comboBoxTableList.SelectedItem.ToString()+" WHERE ID = "+ form.panelTableInfo.Controls.Find("textBoxPanel0", false).First().Text, connection);
            da.InsertCommand = cmd;
            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("oldu");
                    connection.Close();
                    LoadDataGrid();
                }
            }
            catch
            {
                connection.Close();
                MessageBox.Show("Veri ekleme sırasında hata oluştu!");
            }

            
        }
      public static void update2()
        {
            

            connection.Open();

            OracleCommand myCommand1 = new OracleCommand();
            myCommand1.Connection = connection;
            int id = int.Parse(form.panelTableInfo.Controls.Find("textBoxPanel0", false).First().Text);
            string type = form.panelTableInfo.Controls.Find("textBoxPanel1", false).First().Text;
            string name = form.panelTableInfo.Controls.Find("textBoxPanel2", false).First().Text;
            string password = form.panelTableInfo.Controls.Find("textBoxPanel3", false).First().Text;
            string username = form.panelTableInfo.Controls.Find("textBoxPanel4", false).First().Text;
            myCommand1.CommandText = "UPDATE C_USER SET TYPE = '"+type+"', NAME = '"+name+"', PASSWORD = '"+password+"', USERNAME= '"+username+"' WHERE ID ="+id;
            try
            {
                myCommand1.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();

            

        }
        public static void updateData()
        {
            
            switch (form.comboBoxTableList.SelectedItem.ToString())
            {
                case "C_USER":
                    {
                        connection.Open();

                        OracleCommand myCommand1 = new OracleCommand();
                        myCommand1.Connection = connection;
                        int id = int.Parse(form.panelTableInfo.Controls.Find("textBoxPanel0", false).First().Text);
                        string type = form.panelTableInfo.Controls.Find("textBoxPanel1", false).First().Text;
                        string name = form.panelTableInfo.Controls.Find("textBoxPanel2", false).First().Text;
                        string password = form.panelTableInfo.Controls.Find("textBoxPanel3", false).First().Text;
                        string username = form.panelTableInfo.Controls.Find("textBoxPanel4", false).First().Text;
                        myCommand1.CommandText = "UPDATE C_USER SET TYPE = '" + type + "', NAME = '" + name + "', PASSWORD = '" + password + "', USERNAME= '" + username + "' WHERE ID =" + id;
                        try
                        {
                            myCommand1.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        connection.Close();
                        LoadDataGrid();
                        break;
                    }
                case "C_SALON":
                    {
                       
                        break;
                    }
                case "C_SEAT":
                    {

                        break;
                    }
                case "C_SESSION":
                    {

                        break;
                    }
                case "C_TICKET":
                    {

                        break;
                    }
                case "C_FILM":
                    {

                        break;
                    }
                case "C_CATEGORY":
                    {

                        break;
                    }
            }
        }
        public static void search()
        {
            switch (form.comboBoxTableList.SelectedItem.ToString())
            {
                case "C_USER":
                    {
                        OracleCommand command = new OracleCommand();
                        command.Connection = connection;
                        //command.CommandText = "SELECT * FROM C_USER WHERE ID ="+form.textBoxSearch.Text+" OR TYPE ="+ form.textBoxSearch.Text;
                        string text = form.textBoxSearch.Text.ToString();
                        command.CommandText = "SELECT * FROM C_USER WHERE "+form.comboBoxSearch.SelectedItem.ToString()+" LIKE '%"+form.textBoxSearch.Text+"%'";
                        connection.Open();


                        OracleDataAdapter adaptor = new OracleDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        
                            adaptor.Fill(dataTable);
                            form.dataGridView1.DataSource = dataTable;
                            connection.Close();
                        
                           
                        

                        break;
                    }
                default:
                    {
                        break;
                    }
            }
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
    }
    
}
