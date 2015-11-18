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
    public partial class delete : Form
    {
        public delete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oradb = "Data Source = XE; User Id = system; password=admin;";

            OracleConnection conn = new OracleConnection(oradb);

            conn.Open();
            OracleCommand cmd = new OracleCommand();

            cmd.Connection = conn;
            cmd.CommandText = "DELETE ipl.MATCH where MATCH_ID = " + textBox1.Text;

            int r = cmd.ExecuteNonQuery();
            if (r == 0)
                MessageBox.Show("Insertion failed");
            else
                MessageBox.Show("Success!");


            conn.Close();
        }

        private void delete_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet4.MATCH' table. You can move, or remove it, as needed.
            this.mATCHTableAdapter.Fill(this.dataSet4.MATCH);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin ad = new admin();
            ad.Show();
            this.Hide();
        }
    }
}
