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
    public partial class ADD_MEMBERS : Form
    {
        public ADD_MEMBERS()
        {
            InitializeComponent();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string familyName = textBox2.Text;
            string fatherName = textBox3.Text;
            string nationalCode = textBox4.Text;
            string birthPlace = textBox5.Text;
            string maritalState = comboBox1.SelectedItem.ToString();
            string religion = comboBox2.SelectedItem.ToString();
            string occupation = textBox6.Text;
            string telephone = textBox7.Text;
            string birthDate= dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string address = textBox8.Text;
            string grade = comboBox3.SelectedItem.ToString();
            string field = textBox9.Text;
            string military = comboBox4.SelectedItem.ToString();
            string query = "INSERT INTO MEMBERS (name, family_name, father_name, national_code, birth_place, marital_state, religion, occupation, telephone, birth_date, address, grade, field, military)" +
                "VALUES (N'" + name + "', N'" + familyName + "', N'" + fatherName + "', '" + nationalCode + "', N'" + birthPlace + "', N'" + maritalState + "', N'" + religion + "', N'" + occupation + "', '" + telephone + "', '" + birthDate + "', N'" + address + "', N'" + grade + "', N'" + field + "', N'" + military + "')";
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
