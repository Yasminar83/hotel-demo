using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_final
{
    public partial class MAIN_PANNEL : Form
    {
        public MAIN_PANNEL()
        {
            InitializeComponent();
        }

        private void کارمندانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADD_MEMBERS am = new ADD_MEMBERS();
            am.Show();
        }

        private void کاربرانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CLIENTS cl = new CLIENTS();
            cl.Show();
        }

        private void اتاقهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ROOMS rm = new ROOMS();
            rm.Show();
        }

        private void رزروهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RESERVATIONS rsv = new RESERVATIONS();
            rsv.Show();
        }
    }
}
