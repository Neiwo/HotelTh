using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static hotel_reservation_system.LOGIN;

namespace hotel_reservation_system
{
    public partial class BOOKING : Form
    {
        

        public BOOKING()
        {
            InitializeComponent();
            load();
            gunaDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            using (MySqlConnection myConn = new MySqlConnection(MyConnection))
            {
                string usertoguest = Session.Username;
                int guestID = 0;
                string query = "SELECT GuestID FROM guest WHERE username = @usertoguest";

                using (MySqlCommand cmd = new MySqlCommand(query, myConn))
                {
                    cmd.Parameters.AddWithValue("@usertoguest", usertoguest);

                    try
                    {
                        myConn.Open();
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            guestID = Convert.ToInt32(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return; // Exit the method if there's an error.
                    }
                }

                string RoomNo = RoomID.Text; // Replace with the actual TextBox name
                string checkinDate = check1.Text; // Replace with the actual TextBox name
                string checkoutDate = check2.Text; // Replace with the actual TextBox name

                string insertQuery = "INSERT INTO reservation (GuesID, RoomNo, CheckinDate, CheckoutDate) " +
                                     "VALUES (@guestID, @roomNo, @checkinDate, @checkoutDate)";

                using (MySqlCommand wews = new MySqlCommand(insertQuery, myConn))
                {
                    wews.Parameters.AddWithValue("@guestID", guestID);
                    wews.Parameters.AddWithValue("@roomNo", RoomNo);
                    wews.Parameters.AddWithValue("@checkinDate", checkinDate);
                    wews.Parameters.AddWithValue("@checkoutDate", checkoutDate);

                    try
                    {
                     
                        int rowsAffected = wews.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("RESERVATION COMPLETE");
                        }
                        else
                        {
                            MessageBox.Show("Reservation failed.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                // Update room status to 'Occupied'
                string updateQuery = "UPDATE room SET Occupied = 'YES' WHERE RoomNo = @roomNo";

                using (MySqlCommand wew1 = new MySqlCommand(updateQuery, myConn))
                {
                    wew1.Parameters.AddWithValue("@roomNo", RoomNo);

                    try
                    {
                        int rowsAffected = wew1.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Update successful
                        }
                        else
                        {
                            // Update failed
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    myConn.Close();
                }
            }
        }





        // check in
        private void gunaDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
   
        }
        // check out 
        private void gunaDateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
     
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

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CINDATE_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chckindate_ValueChanged(object sender, EventArgs e)
        {
            string chk1 = chckindate.Text;
            check1.Text = chk1;
        }

        private void chckoutdate_ValueChanged(object sender, EventArgs e)
        {
            string chk2 = chckoutdate.Text;
            check2.Text = chk2;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    }

