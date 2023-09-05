using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace hotel_reservation_system
{
    public partial class HOME : Form
    {
        public HOME()
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

        // check in or reservation button
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            BOOKING f5 = new BOOKING();
            f5.Show();
            this.Hide();
        }


        // calendar button

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            RESERVATION f7 = new RESERVATION();
            f7.Show();
            this.Hide();
        }

        // bed button

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            Form CheckIn = new ROOMS();
            CheckIn.Show();
            this.Hide();
        }

        // 1st button slideshow
        private void gunaButton8_Click_1(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\oween\\source\\repos\\hotel-reservation-system\\Resources\\1.png";
            Image image = Image.FromFile(filePath);
            gunaPictureBox9.Image = image;
        }

        // 2nd button ng slideshow
        private void gunaButton9_Click(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\oween\\source\\repos\\hotel-reservation-system\\Resources\\2.png";
            Image image = Image.FromFile(filePath);
            gunaPictureBox9.Image = image;
        }

        // 3rd button ng slideshow
        private void gunaButton10_Click(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\oween\\source\\repos\\hotel-reservation-system\\Resources\\3.png";
            Image image = Image.FromFile(filePath);
            gunaPictureBox9.Image = image;

        }

        // account button
        private void gunaButton3_Click(object sender, EventArgs e)
        {
            ACCOUNT f6 = new ACCOUNT();
            f6.Show();
            this.Hide();
        }

        // logout button
        private void gunaButton4_Click(object sender, EventArgs e)
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

        
    }
}
