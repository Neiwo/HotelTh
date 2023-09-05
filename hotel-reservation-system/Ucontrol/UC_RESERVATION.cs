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
    public partial class UC_RESERVATION : UserControl
    {
        MySqlConnection con = new MySqlConnection("datasource = localhost; database = hotelth; port = 3306; username = root; password =;");
        DataTable table;
        MySqlDataAdapter adapter;
        MySqlCommand command;
        public UC_RESERVATION()
        {
            InitializeComponent();
            load();
        }
        void load()
        {
            MySqlCommand cmd = new MySqlCommand("select * from reservation", con);
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

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gunaDataGridView1.Rows[e.RowIndex];
                reno.Text = gunaDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                gid.Text = gunaDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                rno.Text = gunaDataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                cdate.Text = gunaDataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            string search1 = search.Text.ToString();
            searchData(search1);
        }
        public void searchData(string search1)
        {
            string query = "Select * from reservation where CONCAT (`ReservationNo`, `GuesID`, `RoomNo`, `CheckinDate`, `CheckoutDate`) like '%" + search.Text + "%'";
            MySqlCommand command = new MySqlCommand(query, con);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            gunaDataGridView1.DataSource = table;
        }

        private void UC_RESERVATION_Load(object sender, EventArgs e)
        {
            searchData("");
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;database=hotelth;port=3306;username=root;password=;";
            string query = "insert into checkout (ReservationNO, GuestID, RoomNo, CheckoutDate) values ('" + reno.Text + "', '" + gid.Text + "', '" + rno.Text + "','" + cdate.Text + "' )";
            string queryy = "Delete from reservation where ReservationNo = '" + reno.Text + "'";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmd = new MySqlCommand(query, myConn);
            MySqlCommand comd = new MySqlCommand(queryy, myConn);
            MySqlDataReader MyReader;
            try
            {
                if (reno.Text != "" && rno.Text != "" && gid.Text != "" && cdate.Text != "")
                {
                    myConn.Open();
                    MyReader = cmd.ExecuteReader();
                    load();
                    myConn.Close();
                    myConn.Open();
                    MyReader = comd.ExecuteReader();
                    MessageBox.Show("CHECKED OUT SUCCESSFULLY");
                    load();
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
