using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_final
{
    public partial class CLIENTS : Form
    {
        public CLIENTS()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string family = textBox2.Text;
            string telephone = textBox3.Text;
            string nationality = textBox4.Text;
            string query = "INSERT INTO CLIENTS (name , family , telephone , nationality)" +
                "VALUES ('" + name + "', '" + family + "', '" + telephone + "', '" + nationality + "')";
            // MessageBox.Show(query);
            SqlDataAdapter adaptor = new SqlDataAdapter();
            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\yasamin\\c#\\hotel final\\hotel final\\Hotel_DB.mdf\";Integrated Security=True");
            sc.Open();
            MessageBox.Show("Connected Succesfuly");
            SqlCommand command = new SqlCommand(query, sc);
            adaptor.InsertCommand = new SqlCommand(query, sc);
            adaptor.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            sc.Close();
        }
    }
}
