using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace ipl_league
{
    public partial class match : Form
    {
        public match()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            string oradb = "Data Source = XE; User Id = system; password=admin;";
          

            OracleConnection conn = new OracleConnection(oradb);

            conn.Open();
            OracleCommand cmd = new OracleCommand();

            cmd.Connection = conn;

            
            cmd.CommandText = "insert into ipl.MATCH values ("+ match_id.Text + ",'"+ opp1.Text + "','" + opp2.Text + "','" + date1.Text + "','" +time1.Text+ "','"+ venue.Text+"',"+hr.Text+")";

                int r = cmd.ExecuteNonQuery();
                if (r == 0)
                    MessageBox.Show("Insertion failed");
                else
                    MessageBox.Show("Success!");


                conn.Close();
        }

        private void match_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void opp1_TextChanged(object sender, EventArgs e)
        {

        }

        private void date1_TextChanged(object sender, EventArgs e)
        {

        }

        private void time1_TextChanged(object sender, EventArgs e)
        {

        }

        private void venue_TextChanged(object sender, EventArgs e)
        {

        }

        private void hr_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin ad = new admin();
            ad.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void match_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
