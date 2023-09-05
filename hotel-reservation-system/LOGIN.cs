using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace hotel_reservation_system
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        public static class Session
        {
            public static string Username
            {
                get; set; 
            }
        }

        private void frm_menu_FormClosing(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // login button
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            string username = gunaTextBox1.Text;
            

            try
            {
            string myConnection = "datasource=localhost; database=hotelth; port=3306; username=root; password=;";
            string query = "select Username, Password from guest where Username = '"+gunaTextBox1.Text+"' && Password = '"+gunaTextBox2.Text+"'";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmd = new MySqlCommand(query, myConn);
            MySqlDataReader reader;
            myConn.Open();
            reader = cmd.ExecuteReader();
                if (gunaTextBox1.Text == "m" && gunaTextBox2.Text == "m")
                {
                    Form1 admin = new Form1();
                    admin.Show();
                    this.Hide();
                }

            else if (reader.Read())
            {
                    Session.Username = username;
                    HOME f2 = new HOME();
                    f2.Show();
                    this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password. Try again.");
            }
            myConn.Close();
            }
            catch (Exception ex)
            {
            MessageBox.Show(ex.Message);
            }
            
        }

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            REGISTRATION f3 = new REGISTRATION();
            f3.Show();
            this.Hide();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
