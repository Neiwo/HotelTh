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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton6_Click(object sender, EventArgs e)
        {
            movepanel.Location = new Point(58, 242);
            uC_RESERVATION1.Visible = true;
            uC_RESERVATION1.BringToFront();
        }

        private void addroom_Click(object sender, EventArgs e)
        {
            movepanel.Location = new Point(58, 194);
            uC_ADDROOM1.Visible = true;
            uC_ADDROOM1.BringToFront();
        }

        private void chckout_Click(object sender, EventArgs e)
        {
            movepanel.Location = new Point(58, 290);
            uC_CHECKOUT1.Visible = true;
            uC_CHECKOUT1.BringToFront();
        }

        private void gunaAdvenceButton6_Click_1(object sender, EventArgs e)
        {
            movepanel.Location = new Point(58, 456);
            uC_PROFILES1.Visible = true;
            uC_PROFILES1.BringToFront();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            movepanel.Location = new Point(58, 504);
            LOGIN lg = new LOGIN();
            MessageBox.Show("Logged out");
            lg.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uC_RESERVATION1.Visible=false;
            uC_ADDROOM1.Visible = true;
            uC_PROFILES1.Visible = false;
            uC_CHECKOUT1.Visible = false;

        }

        private void uC_PROFILES1_Load(object sender, EventArgs e)
        {

        }
    }
}
