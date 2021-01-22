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
    public partial class Customer : Form
    {
        static OracleConnection connection = new OracleConnection("Data Source=localhost:1521/XEPDB1; User Id=SYSTEM;Password=oraclepass;");
        int vote = 1;
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
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

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            OracleCommand myCommand1 = new OracleCommand();
            myCommand1.Connection = connection;
            //int ticketID = int.Parse(labelTıcketID.Text);
            int vote = trackBarVote.Value;
            myCommand1.CommandText = "UPDATE C_TICKET SET VOTE = " + vote + " WHERE ID ="+ textBoxUser.Text;
            try
            {
                myCommand1.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();


            textBoxUser.Text = "";
                trackBarVote.Value = 1;
        }

        private void trackBarVote_Scroll(object sender, EventArgs e)
        {
            vote = trackBarVote.Value;
            labelVote.Text = "Puan: " + vote;
        }
    }
}
