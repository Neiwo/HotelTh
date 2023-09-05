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
    public partial class BOOKING : Form
    {

        private string selectedRoomID = "";

        public BOOKING()
        {
            InitializeComponent();
            load();
            gunaDataGridView1.SelectionMode = D ataGridViewSelectionMode.FullRowSelect;
            string username = Session.Username;
         }

        void load()
        {
            string constring = "datasource=localhost; database=hotelth; port=3306; username=root; password=;";
            MySqlConnection conn = new MySqlConnection(constring);
            MySqlCommand cmd = new MySqlCommand("select RoomNo, Type, Capacity, Price from room", conn);
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
        
        // back button
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            HOME f2 = new HOME();
            f2.Show();
            this.Hide();
        }

        // account button
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            ACCOUNT f6 = new ACCOUNT();
            f6.Show();
            this.Hide();
        }

        // logout button
        private void gunaButton3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you wish to logout your account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Thank you for trusting us!");
                LOGIN f1 = new LOGIN();
                f1.Show();
                this.Hide();
            }
            else
            {

            }
        }

        // confirm booking button
        private void gunaButton4_Click(object sender, EventArgs e)
        {
            string MyConnection = "datasource=localhost; database=hotelth; port=3306; username=root; password=;";
            string query = "select GuestID from guest where username = '"+gunaTextBox1+"'";
            string query2 = " insert into reservation(GuesID, RoomNo, CheckinDate, CheckoutDate) values (@retGuestID,'" + RoomID.Text + "', '" + CheckIn.Text + "', '" + CheckOut.Text + "')";
            MySqlConnection myConn = new MySqlConnection(MyConnection);
            MySqlCommand wews = new MySqlCommand(query2, myConn);
            MySqlCommand cmd = new MySqlCommand(query, myConn);
            MySqlDataReader reader;
            try
            {
                myConn.Open();
                reader = cmd.ExecuteReader();
                MessageBox.Show("GuestID retrieved!");
                myConn.Close();

                myConn.Open();
                //int GIDfromdb = Convert.ToInt32(cmd.ExecuteScalar());
                //string retGuestID = GIDfromdb.ToString(); 
                reader = wews.ExecuteReader();
                MessageBox.Show("yey");
                myConn.Close();
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
        }





        // check in
        private void gunaDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            CINDATE.Text = gunaDateTimePicker1.Value.ToString();
        }
        // check out 
        private void gunaDateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            COUTDATE.Text = gunaDateTimePicker2.Value.ToString();
        }

        private void gunaDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = this.gunaDataGridView1.Rows[e.RowIndex];
                RoomID.Text = gunaDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                RoomType.Text = gunaDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                Capacity.Text = gunaDataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                Price.Text = gunaDataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }
    }
    }

