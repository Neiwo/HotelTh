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
    public partial class ACCOUNT : Form
    {
        public ACCOUNT()
        {
            InitializeComponent();
        }

        // update button
        private void gunaButton3_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost; database=hotelth; port=3306; username=root; password=;";
            string query = "Update guest set password = '" + gunaTextBox3.Text + "' where username = '" + gunaTextBox1.Text + "'";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmd = new MySqlCommand(query, myConn);
            MySqlDataReader MyReader;
            try
            {
                myConn.Open();
                MyReader = cmd.ExecuteReader();
                MessageBox.Show("Successfully updated!");
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // cancel button
        private void gunaButton4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                gunaTextBox1.Text = "";
                gunaTextBox2.Text = "";
                gunaTextBox3.Text = "";
            }
            else
            {

            }
        }

        // back button
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            HOME f2 = new HOME();
            f2.Show();
            this.Hide();
        }

        // logout button
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you wish logout your account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
    }
}
