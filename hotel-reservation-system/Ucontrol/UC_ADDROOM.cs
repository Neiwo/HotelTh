using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class UC_ADDROOM : UserControl
    {
        MySqlConnection con = new MySqlConnection("datasource = localhost; database = hotelth; port = 3306; username = root; password =;");
        DataTable table;
        MySqlDataAdapter adapter;
        MySqlCommand command;
        public UC_ADDROOM()
        {
            InitializeComponent();
            load();
        }
        void load()
        {

            MySqlCommand cmd = new MySqlCommand("select * from room", con);
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

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;database=hotelth;port=3306;username=root;password=;";
            string query = "insert into room (RoomNO, Type, Capacity, Price, Occupied) values ('" + rnum.Text + "', '" + rtype.Text + "', '" + cpct.Text + "', '" + price.Text + "', 'NO' )";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmd = new MySqlCommand(query, myConn);
            MySqlDataReader MyReader;
            try
            {
                if (rnum.Text != "" && rtype.Text != "" && cpct.Text != "" && price.Text != "")
                {
                    myConn.Open();
                    MyReader = cmd.ExecuteReader();
                    MessageBox.Show("ROOM "+rnum.Text+" SUCCESFULLY ADDED");
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

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            string search1 = search.Text.ToString();
            searchData(search1);
        }
        public void searchData(string search1)
        {
            string query = "Select * from room where CONCAT (`RoomNo`, `Type`, `Capacity`, `Price`, `Occupied`) like '%" + search.Text + "%'";
            MySqlCommand command = new MySqlCommand(query, con);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            gunaDataGridView1.DataSource = table;
        }

        private void UC_ADDROOM_Load(object sender, EventArgs e)
        {
            searchData("");
        }

        private void rnum_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(rnum.Text, "  ^ [0-9]"))
            {
                rnum.Text = "";
            }
        }

        private void cpct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void rnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            
            string myConnection = "datasource=localhost;database=hotelth;port=3306;username=root;password=;";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            string query = "DELETE FROM room WHERE RoomNo = '" + rnum.Text + "'";
            MySqlCommand del = new MySqlCommand(query, myConn);
            MySqlCommand cmd = new MySqlCommand("select * from room where RoomNo = '" + rnum.Text + "' ", myConn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            MySqlDataReader MyReader;
            DataSet ds1 = new DataSet();
            da.Fill(ds1);
            int i = ds1.Tables[0].Rows.Count;
            try
            {
                if (i > 0)
                {
                    myConn.Open();
                    MyReader = del.ExecuteReader();
                    MessageBox.Show("ROOM " + rnum.Text + " SUCCESFULLY DELETED");
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
