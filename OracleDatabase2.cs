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
    public class OracleDatabase2
    {
        static OracleConnection connection = new OracleConnection("Data Source=localhost:1521/XEPDB1; User Id=SYSTEM;Password=oraclepass;");
        public static FormSellTicket form;

        public static string selectedColoumn;
        public static int selectedFilmID;
        public static string buttonSelectedNo;
        public static DateTime date;
        public static int session_ID;
        public static int ticketID;
        public static int seat_ID;
        public static int[,] array = new int[50,50];
        public static void LoadFilmList()
        {
            form.comboBoxFilmList.Items.Clear();
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "SELECT NAME FROM C_FILM";
            connection.Open();


            OracleDataAdapter adaptor = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable();
            adaptor.Fill(dataTable);
            DataGridView dataGridView = new DataGridView();
            form.dataGridView1.DataSource = dataTable;
            connection.Close();

            for (int i = 0; i < form.dataGridView1.Rows.Count-1; i++)
            {
                form.comboBoxFilmList.Items.Add(form.dataGridView1.Rows[i].Cells["NAME"].Value.ToString());
            }
            form.comboBoxFilmList.SelectedIndex=0;
            form.dataGridView1.DataSource = null;

            form.comboBoxFilmList.SelectedIndex=0;
            loadDataGrid();

        }
        public static void loadDataGrid()
        {
            //FILM ID CEKME
            OracleCommand command = new OracleCommand("SELECT ID FROM C_FILM WHERE NAME = '" + form.comboBoxFilmList.SelectedItem.ToString() + "'");
            command.Connection = connection;
            connection.Open();

            try
            {
                OracleDataReader reader = command.ExecuteReader();
                reader.Read();
                selectedFilmID = Int16.Parse(reader.GetString(0));
                reader.Close();

            }
            finally
            {
                connection.Close();
            }


            //DATA GRİD DOLDURMA
            command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM C_SESSION WHERE FILM_ID ='" + selectedFilmID.ToString() + "'";
            connection.Open();


            OracleDataAdapter adaptor = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable();
            adaptor.Fill(dataTable);
            form.dataGridView1.DataSource = dataTable;
            connection.Close();

        }
        public static void createSeat(int salon_ID)
        {
            form.panelSeats.Controls.Clear();
            //salon x,y
            OracleCommand command = new OracleCommand("SELECT X, Y FROM C_SALON WHERE ID = " + salon_ID.ToString() + "");
            command.Connection = connection;
            connection.Open();
            int x;
            int y;
            try
            {
                OracleDataReader reader = command.ExecuteReader();
                reader.Read();
                x = Int16.Parse(reader.GetString(0));
                y = Int16.Parse(reader.GetString(1));
                
                reader.Close();

            }
            finally
            {
                connection.Close();
            }
            //koltuk doluluk çekme
            command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "SELECT ID, X, Y, IS_OPEN FROM C_SEAT WHERE SALON_ID = "+salon_ID+"";
            connection.Open();


            OracleDataAdapter adaptor = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable();
            adaptor.Fill(dataTable);
            DataGridView dataGridView = new DataGridView();
            form.dataGridView1.DataSource = dataTable;
            connection.Close();
            string is_open;

            int sayac = 1;
            for (int i = 0; i < y; i++) //Satır
            {
                for (int j = 0; j < x; j++) //Sutün
                {
                    //koltuk id
                    command = new OracleCommand("SELECT ID FROM C_SEAT WHERE X = '"+i+"' AND Y='"+j+"' AND SALON_ID ='"+salon_ID+"'");
                    command.Connection = connection;
                    connection.Open();
                    
                        OracleDataReader reader = command.ExecuteReader();
                        reader.Read();
                        int seat_ID2 = Int16.Parse(reader.GetString(0));
                        reader.Close();

                    
                    connection.Close();
                    //
                    command = new OracleCommand("SELECT IS_OPEN FROM C_SEAT WHERE X = '" + i + "' AND Y='" + j + "' AND SALON_ID ='" + salon_ID + "'");
                    command.Connection = connection;
                    connection.Open();

                    OracleDataReader reader2 = command.ExecuteReader();
                    reader2.Read();
                    int is_openN = Int16.Parse(reader2.GetString(0));
                    reader.Close();

                    is_open = is_openN.ToString();
                    array[i, j] = is_openN;
                    connection.Close();
                    //


                    string seat_x = i.ToString();
                    string seat_y = j.ToString();

                    //ekleme
                    Button btn = new Button();
                    btn.Size = new Size(30, 30);
                    btn.Text = sayac.ToString();
                    btn.Name = sayac.ToString();
                    if (array[i, j] == 1)
                    {
                        form.checkBox1.Checked = false;
                        btn.BackColor = Color.Green;
                    }
                    else if (array[i, j] == 0)
                    {
                        form.checkBox1.Checked = true;
                        btn.BackColor = Color.Red;
                    }

                    btn.Click += (s, e) => {
                        buttonSelectedNo = btn.Name;
                        form.textBoxX.Text = seat_x;
                        form.textBoxY.Text = seat_y;
                        form.textBoxSalonID.Text = salon_ID.ToString();
                        form.textBoxSeatID.Text = seat_ID2.ToString();

                        form.textBoxSessionID.Text = session_ID.ToString();
                        form.textBoxDate.Text = date.ToString();
                        if (btn.BackColor==Color.Green)
                        {
                            form.checkBox1.Checked = false;
                        }
                        else if (btn.BackColor == Color.Red)
                        {
                            form.checkBox1.Checked = true;
                        }
                    
                    };

                    

                    btn.Location = new Point(j * 30 + 20, i * 30 + 30);

                    

                    form.panelSeats.Controls.Add(btn);
                    sayac++;
                }
            }
        }
        public static void addTicket()
        {
            OracleDataAdapter da = new OracleDataAdapter();
            connection.Open();

            OracleCommand cmd = new OracleCommand("INSERT INTO C_TICKET(SEAT_ID, SESSION_ID) VALUES(:SEAT_ID,:SESSION_ID)", connection);
            cmd.Parameters.Add("SEAT_ID", OracleDbType.Int32, 20).Value = form.groupBoxTicket.Controls.Find("textBoxSeatID", false).First().Text;
            cmd.Parameters.Add("SESSION_ID", OracleDbType.Int32, 20).Value = form.groupBoxTicket.Controls.Find("textBoxSessionID", false).First().Text;
            da.InsertCommand = cmd;
            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    connection.Close();
                    MessageBox.Show("Bilet Satıldı!\nBilet Yazdırılıyor ...");

                }
            }
            catch
            {
                MessageBox.Show("Veri ekleme sırasında hata oluştu!");
            }
            ///ticket id çekiliyor
            OracleCommand command = new OracleCommand("SELECT ID FROM C_TICKET WHERE SEAT_ID='"+ form.groupBoxTicket.Controls.Find("textBoxSeatID", false).First().Text + "' AND SESSION_ID ='"+ form.groupBoxTicket.Controls.Find("textBoxSessionID", false).First().Text + "'", connection);
            command.Connection = connection;
            connection.Open();
            try
            {
                OracleDataReader reader = command.ExecuteReader();
                reader.Read();
                ticketID = Int16.Parse(reader.GetString(0));

                reader.Close();

            }
            finally
            {
                connection.Close();
            }
            //KOLTUK DOLU YAPILIYOR
            connection.Open();
            OracleCommand myCommand1 = new OracleCommand();
            myCommand1.Connection = connection;

            myCommand1.CommandText = "UPDATE C_SEAT SET IS_OPEN = '0' WHERE ID='"+ form.groupBoxTicket.Controls.Find("textBoxSeatID", false).First().Text + "'";
            try
            {
                myCommand1.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();


            ///LOG
            connection.Open();
            cmd = new OracleCommand("INSERT INTO C_LOG(USER_ID, USER_NAME, USERNAME, ADD_DATE, TICKET_ID) VALUES(:USER_ID,:USER_NAME,:USERNAME,:ADD_DATE,:TICKET_ID)", connection);
            cmd.Parameters.Add("USER_ID", OracleDbType.Int32, 20).Value = Global.id;
            cmd.Parameters.Add("USER_NAME", OracleDbType.Varchar2, 20).Value = Global.name;
            cmd.Parameters.Add("USERNAME", OracleDbType.Varchar2, 20).Value = Global.userName;
            cmd.Parameters.Add("ADD_DATE", OracleDbType.Varchar2).Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            cmd.Parameters.Add("TICKET_ID", OracleDbType.Int32, 20).Value = ticketID;

            da.InsertCommand = cmd;
            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    connection.Close();
                    

                }
            }
            catch
            {
                MessageBox.Show("Veri ekleme sırasında hata oluştu!");
            }
        }
    }
    

}
