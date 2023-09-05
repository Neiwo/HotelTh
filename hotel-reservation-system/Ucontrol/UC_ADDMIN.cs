using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_reservation_system.Ucontrol
{
    public partial class UC_ADDMIN : UserControl
    {
        MySqlConnection con = new MySqlConnection("datasource = localhost; database = hotelth; port = 3306; username = root; password =;");
        DataTable table;
        MySqlDataAdapter adapter;
        MySqlCommand command;
        public UC_ADDMIN()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;database=hotelth;port=3306;username=root;password=;";
            string query = "insert into employee (Firstname, Middlename, Lastname, Email, username, Password, Accesslvl) values ('" + fname.Text + "', '" + mname.Text + "', '" + lname.Text + "', '" + email.Text + "','" + uname.Text + "','" + password.Text + "', '" + alvl.Text + "' )";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmd = new MySqlCommand(query, myConn);
            MySqlDataReader MyReader;
            try
            {
                if (fname.Text != "" && mname.Text != "" && fname.Text != "" && email.Text != "" && uname.Text != "" && password.Text != "" && alvl.Text != "")
                {
                    myConn.Open();
                    MyReader = cmd.ExecuteReader();
                    MessageBox.Show("ACCOUNT FOR "+fname.Text+" HAS CREATED");

                    myConn.Close();
                }
                else
                {
                    MessageBox.Show("PLEASE COMPLETE THE REQUIRED INFO!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
