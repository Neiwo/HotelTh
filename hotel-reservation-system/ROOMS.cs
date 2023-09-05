using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_reservation_system
{
    public partial class ROOMS : Form
    {
        public ROOMS()
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

        // back button
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            HOME f2 = new HOME();
            f2.Show();
            this.Hide();
        }

        // logout button
        private void gunaButton3_Click(object sender, EventArgs e)
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

        // account button
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            ACCOUNT f6 = new ACCOUNT();
            f6.Show();
            this.Hide();
        }

        // STANDARD ROOM - BOOK HERE
        private void gunaButton4_Click(object sender, EventArgs e)
        {
            BOOKING f5 = new BOOKING();
            f5.Show();
            this.Hide();
        }

        // STANDARD DOUBLE BED - BOOK HERE
        private void gunaButton5_Click(object sender, EventArgs e)
        {
            BOOKING f5 = new BOOKING();
            f5.Show();
            this.Hide();
        }

        // DELUXE ROOM - BOOK HERE
        private void gunaButton6_Click(object sender, EventArgs e)
        {
            BOOKING f5 = new BOOKING();
            f5.Show();
            this.Hide();
        }

        // DELUXE DOUBLE BED - BOOK HERE
        private void gunaButton7_Click(object sender, EventArgs e)
        {
            BOOKING f5 = new BOOKING();
            f5.Show();
            this.Hide();
        }
    }
}
