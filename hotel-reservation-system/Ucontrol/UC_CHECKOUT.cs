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
    public partial class UC_CHECKOUT : UserControl
    {
        MySqlConnection con = new MySqlConnection("datasource = localhost; database = hotelth; port = 3306; username = root; password =;");
        DataTable table;
        MySqlDataAdapter adapter;
        MySqlCommand command;
        public UC_CHECKOUT()
        {
            InitializeComponent();
            load();
        }
        void load()
        {
            MySqlCommand cmd = new MySqlCommand("select * from checkout", con);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dataset = new DataTable();
                sda.Fill(dataset);
                BindingSource source = new BindingSource();
                source.DataSource = dataset;
                gunaDataGridView1.DataSource = source;
                sda.Update(dataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UC_CHECKOUT_Load(object sender, EventArgs e)
        {
            searchData("");
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            string search1 = search.Text.ToString();
            searchData(search1);
        }
        public void searchData(string search1)
        {
            string query = "Select * from checkout where CONCAT (`checkoutID`, `ReservationNo`, `GuestID`, `RoomNo`, `CheckoutDate`) like '%" + search.Text + "%'";
            MySqlCommand command = new MySqlCommand(query, con);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            gunaDataGridView1.DataSource = table;
        }
    }
}
