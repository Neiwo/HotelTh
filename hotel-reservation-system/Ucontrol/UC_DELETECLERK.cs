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
    public partial class UC_DELETECLERK : UserControl
    {
        MySqlConnection con = new MySqlConnection("datasource = localhost; database = hotelth; port = 3306; username = root; password =;");
        DataTable table;
        MySqlDataAdapter adapter;
        MySqlCommand command;
        public UC_DELETECLERK()
        {
            InitializeComponent();
            load();
        }
        void load()
        {

            MySqlCommand cmd = new MySqlCommand("select EmployeeID, Firstname, Lastname, Email, Accesslvl from employee", con);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dataset = new DataTable();
                sda.Fill(dataset);
                BindingSource source = new BindingSource();
                source.DataSource = dataset;
                sda.Update(dataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;database=hotelth;port=3306;username=root;password=;";
            string query = "delete from employee where EmployeeID = '" + deletebox.Text + "'";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmd = new MySqlCommand(query, myConn);
            MySqlDataReader MyReader;
            try
            {
                if (deletebox.Text != "")
                {
                    myConn.Open();
                    MyReader = cmd.ExecuteReader();
                    MessageBox.Show("EMPLOYEE "+deletebox.Text+" Succesfully Deleted");
                    load();
                    myConn.Close();
                }
                else
                {
                    MessageBox.Show("TEXTBOX IS EMPTY");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
