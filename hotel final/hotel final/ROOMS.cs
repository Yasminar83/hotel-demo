using System;
using System.Collections;
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
    public partial class ROOMS : Form
    {
        public ROOMS()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string roomNumber = textBox1.Text;
            string roomFloor = textBox2.Text;
            string roomType = comboBox1.SelectedItem.ToString();
            string roomService = comboBox2.SelectedItem.ToString();
            string roomPrice = textBox3.Text;
            string roomServicesPrice = textBox4.Text;
            string query = "INSERT INTO ROOMS (room_number, room_floor, room_service, room_price, room_services_price, room_type)" +
                "VALUES('" + roomNumber + "', '" + roomFloor + "', N'" + roomService + "', '" + roomPrice + "', '" + roomServicesPrice + "', N'" + roomType + "')";
            // MessageBox.Show(query);
            SqlDataAdapter adaptor = new SqlDataAdapter();
            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\yasamin\\c#\\hotel final\\hotel final\\Hotel_DB.mdf\";Integrated Security=True");
            sc.Open();
            MessageBox.Show("Connected Succesfuly");
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
            Refresh();
            SqlCommand command = new SqlCommand(query, sc);
            adaptor.InsertCommand = new SqlCommand(query, sc);
            adaptor.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            sc.Close();

        }
        void Refresh()
        {
            /*** dataGridView1.Rows.Clear();
            string query = "SELECT * FROM rooms";
            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\yasamin\\c#\\hotel final\\hotel final\\Hotel_DB.mdf\";Integrated Security=True");
            sc.Open();
            SqlCommand command = new SqlCommand(query, sc);
            SqlDataReader sdr = SqlCommand.ExecuteReader();
            while (sdr.Read())
            {
                dataGridView1.Rows.Add(sdr[id] + ":" + ["room_number"] + " " + ["room_floor"] + " " + ["room_service"] + " " + ["room_price"] + " " + ["room_services_price"] + " " + ["room_type"]);
            }
            sc.Close(); ***/
        }
        private void ROOMS_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*** string id = dataGridView1.
            id = id.Substring(0, id.IndexOf(":"));
            string query = "DELETE FROM rooms WHERE id= '" + id + "'";
            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\yasamin\\c#\\hotel final\\hotel final\\Hotel_DB.mdf\";Integrated Security=True");
            sc.Open();
            SqlCommand command = new SqlCommand(query, sc);
            SqlDataReader sdr = SqlCommand.ExecuteReader();
            while (sdr.Read())
            {
                dataGridView1.Rows.Add(sdr[id] + ":" + ["room_number"] + " " + ["room_floor"] + " " + ["room_service"] + " " + ["room_price"] + " " + ["room_services_price"] + " " + ["room_type"]);
            }
            Refresh();
            sc.Close();***/
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
