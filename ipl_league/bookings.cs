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
    public partial class bookings : Form
    {
        public bookings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oradb1 = "Data Source = XE; User Id = system; Password=admin;";
            string query1 = "select * from ipl.TICKET";
            OracleConnection conn1 = new OracleConnection(oradb1);

            conn1.Open();

            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn1;
            OracleDataAdapter da = new OracleDataAdapter(query1, conn1);
            DataSet d = new DataSet();
            da.Fill(d, "TICKET");
            dataGridView1.DataSource = d.Tables[0];
            conn1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin ad = new admin();
            ad.Show();
            this.Hide();
        }
    }
}
