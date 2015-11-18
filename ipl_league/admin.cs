using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ipl_league
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            match m = new match();
            m.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            update u = new update();
            u.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            delete d = new delete();
            d.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ticket t = new ticket();
            t.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            display di = new display();
            di.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bookings b = new bookings();
            b.Show();
            this.Hide();
        }

    }
}
