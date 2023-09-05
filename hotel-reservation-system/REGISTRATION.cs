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
using MySql.Data.MySqlClient;

namespace hotel_reservation_system
{
    public partial class REGISTRATION : Form
    {
        public REGISTRATION()
        {
            InitializeComponent();
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
        

        // register button
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {
            string myConnection = "datasource=localhost; database=hotelth; port=3306; username=root; password=;";
            string query = "insert into guest(Firstname, Middlename, Lastname, Age, Phoneno, Email, Password, Username ) values('" + gunaTextBox1.Text + "', '" + gunaTextBox2.Text + "', '" + gunaTextBox3.Text + "','" + gunaComboBox1.Text + "', '" + gunaTextBox7.Text + "', '" + gunaTextBox4.Text + "', '" + gunaTextBox6.Text + "', '"+gunaTextBox5.Text+"')";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmd = new MySqlCommand(query, myConn);
            MySqlDataReader MyReader;
                if (gunaCheckBox1.Checked)
                {
                    try
                    {
                        myConn.Open();
                        MyReader = cmd.ExecuteReader();
                        myConn.Close();
                        Form f1 = new LOGIN();
                        f1.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Please confirm the checkbox to proceed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // cancel button
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you wish to cancel registration?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form f1 = new LOGIN();
                f1.Show();
                this.Hide();
            }
            else
            {

            }
        }
    }
}
