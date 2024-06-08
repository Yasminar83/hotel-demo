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
    public partial class ENTRANCE : Form
    {
        public ENTRANCE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ENTRANCE_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string adminUsername = textBox1.Text;
            string adminPassword = textBox2.Text;

            if(adminUsername == "yasamin" && adminPassword == "123456")
            {
                MAIN_PANNEL mnp = new MAIN_PANNEL();
                mnp.Show();
            }
            else{
                MessageBox.Show("نام کاربری یا رمز عبور اشتباه است");
            }



        }
    }
}
