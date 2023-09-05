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
    public partial class UC_PROFILES : UserControl
    {
        public UC_PROFILES()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            mpanel.Location = new Point(48, 507);
            uC_EMPACCOUNTS1.Visible = true;
            uC_EMPACCOUNTS1.BringToFront();
        }


        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            mpanel.Location = new Point(528, 507);
            uC_ADDMIN1.Visible = true;
            uC_ADDMIN1.BringToFront();
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            mpanel.Location = new Point(759, 507);
            uC_DELETECLERK1.Visible = true;
            uC_DELETECLERK1.BringToFront();
        }

        private void UC_PROFILES_Load(object sender, EventArgs e)
        {
            uC_EMPACCOUNTS1.Visible=false;
            uC_GUESTACCOUNTS1.Visible=false;
            uC_ADDMIN1.Visible=false;
            uC_DELETECLERK1.Visible=false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaAdvenceButton2_Click_1(object sender, EventArgs e)
        {
            mpanel.Location = new Point(279, 507);
            uC_GUESTACCOUNTS1.Visible = true;
            uC_GUESTACCOUNTS1.BringToFront();
        }
    }
}
