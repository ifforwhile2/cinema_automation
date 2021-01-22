using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Cinema
{
    public partial class Login : Form
    {
        OracleConnection connection = new OracleConnection("Data Source=localhost:1521/XEPDB1; User Id=SYSTEM;Password=oraclepass;");

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            //OracleCommand command = new OracleCommand();
            //command.Connection = connection;
            //command.CommandText = "select * from C_USER";


            //OracleDataAdapter adaptor = new OracleDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adaptor.Fill(dataTable);
            //dataGridView1.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                GetMyString(connection, textBoxUser.Text);
                connection.Open();
                OracleCommand comand = new OracleCommand("SELECT * FROM C_USER WHERE USERNAME = :kullaniciAdi AND PASSWORD = :sifre", connection);
                comand.Parameters.Add(":kullaniciAdi", textBoxUser.Text);
                comand.Parameters.Add("sifre", textBoxPassword.Text);
                OracleDataReader reader = comand.ExecuteReader();

                if (reader.Read())
                {
                    if (Global.type == 0)
                    {
                        AdminMain adminMain = new AdminMain();
                        adminMain.Show();
                    }
                    else if (Global.type == 1)
                    {
                        Main main = new Main();
                        main.Show();
                    }
                    
                    connection.Close();

                    this.Hide();
                }
                else if (true)
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre !");
                    connection.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Close();
        }
        private void GetMyString(OracleConnection connection, string username)
        {
            OracleCommand cmd = new OracleCommand("SELECT * FROM C_USER WHERE USERNAME ='"+username+"'");
            cmd.Connection = connection;
            connection.Open();
            try
            {
                OracleDataReader reader = cmd.ExecuteReader();
                reader.Read();
                //Kullanıcının verileri global'e atılıyor
                Global.id = Int16.Parse(reader.GetString(0));
                Global.type = Int16.Parse( reader.GetString(1));
                Global.name = reader.GetString(2);
                Global.password = reader.GetString(3);
                Global.userName = reader.GetString(4);
                reader.Close();
                
            }
            finally
            {
                connection.Close();
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ıconPictureBoxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
