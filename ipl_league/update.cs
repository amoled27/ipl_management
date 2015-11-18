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
    public partial class update : Form
    {
        public update()
        {
            InitializeComponent();
        }

        private void update_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.MATCH' table. You can move, or remove it, as needed.
            this.mATCHTableAdapter.Fill(this.dataSet2.MATCH);

        }

        private void time1_TextChanged(object sender, EventArgs e)
        {

        }

        private void match_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void opp1_TextChanged(object sender, EventArgs e)
        {

        }

        private void opp2_TextChanged(object sender, EventArgs e)
        {

        }

        private void date1_TextChanged(object sender, EventArgs e)
        {

        }

        private void venue_TextChanged(object sender, EventArgs e)
        {

        }

        private void duration_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string oradb = "Data Source = XE; User Id = system; Password=admin;";

            OracleConnection conn = new OracleConnection(oradb);

            conn.Open();
            OracleCommand cmd = new OracleCommand();

            cmd.Connection = conn;
            cmd.CommandText = "update ipl.MATCH set MATCH_ID =" + match_id.Text + ", OPP1= '" + opp1.Text + "', OPP2='" + opp2.Text + "',M_DATE = '" + date1.Text + "',TIME ='" + time1.Text + "', VENUE='" + venue.Text + "',DURATION_HR =" + duration.Text + "WHERE MATCH_ID="+ match_id.Text ;

            int r = cmd.ExecuteNonQuery();
            if (r == 0)
                MessageBox.Show("Insertion failed");
            else
                MessageBox.Show("Success!");


            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oradb1 = "Data Source = XE; User Id = system; Password=admin;";
            string query1 = "select * from ipl.MATCH WHERE MATCH_ID = " + textBox1.Text;
            OracleConnection conn1 = new OracleConnection(oradb1);

            conn1.Open();

            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn1;
            OracleDataAdapter da = new OracleDataAdapter(query1, conn1);
            DataSet d = new DataSet();
            da.Fill(d,"MATCH");
            dataGridView1.DataSource = d.Tables[0];
            conn1.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            admin ad = new admin();
            ad.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
