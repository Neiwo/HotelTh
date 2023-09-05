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
using static hotel_reservation_system.LOGIN;

namespace hotel_reservation_system
{
    public partial class RESERVATION : Form
    {
        public RESERVATION()
        {
            InitializeComponent();
            load();
        }
        
        void load()
        {
            string constring = "datasource=localhost; database=hotelth; port=3306; username=root; password=;";
            MySqlConnection conn = new MySqlConnection(constring);
            MySqlCommand cmd = new MySqlCommand("select RoomNo, CheckinDate, CheckoutDate from reservation", conn);
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

        // accounts button
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            ACCOUNT f6 = new ACCOUNT();
            f6.Show();
            this.Hide();
        }

        // logout button
        private void gunaButton2_Click(object sender, EventArgs e)
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

        // cancel reservation button
        private void gunaButton4_Click(object sender, EventArgs e)

        {
            string MyConnection = "datasource=localhost; database=hotelth; port=3306; username=root; password=;";
            MySqlConnection myConn = new MySqlConnection(MyConnection);
            string usertoguest = Session.Username;
            int guestID = 0;
            string query = "SELECT GuestID FROM guest WHERE username = @usertoguest";
            using (MySqlCommand cmd = new MySqlCommand(query, myConn))
            {
                cmd.Parameters.AddWithValue("@usertoguest", usertoguest);

                myConn.Open();
                object lol = cmd.ExecuteScalar();

                if (lol != null)
                {
                    guestID = Convert.ToInt32(lol);
                }
                myConn.Close();

            }
            int ges = guestID;
            DialogResult result = MessageBox.Show("Do you want to cancel your reservation?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string myConnection = "datasource=localhost; database=hotelth; port=3306; username=root; password=;";
                    string query1 = "delete from reservation where reservationNo = @ges";
                    MySqlConnection myconn = new MySqlConnection(myConnection);
                    MySqlCommand cmds = new MySqlCommand(query1, myconn);
                    MySqlDataReader reader;
                    myconn.Open();
                    reader = cmds.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("Successfully booked!");
                    }
                    else
                    {
                        MessageBox.Show("Invalid data. Please try again.");
                    }
                    myconn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {

            }

        }

        // back button
        private void gunaButton3_Click(object sender, EventArgs e)
        {
            HOME f2 = new HOME();
            f2.Show();
            this.Hide();
        }

        private void RESERVATION_Load(object sender, EventArgs e)
        {

        }
    }
}
