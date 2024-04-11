using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;


namespace login
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
            textBox7.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string connectionString = "Data Source=WRAITH\\SQLEXPRESS;Initial Catalog=software_engineering;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

            //string connectionString = "Data Source=DESKTOP-G2GT2PU\\SQLEXPRESS;Initial Catalog=DB1;Integrated Security=True;";
            string query = "INSERT INTO Details (Fname, Lname, Designation, Uname, pswrd, SecQ, SecA) VALUES (@Fname, @Lname, @Designation, @Uname, @pswrd, @SecQ, @SecA)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Fname", Fname.Text);
                        command.Parameters.AddWithValue("@Lname", Lname.Text);
                        command.Parameters.AddWithValue("@Designation", Designation.Text);
                        command.Parameters.AddWithValue("@Uname", Uname.Text);
                        command.Parameters.AddWithValue("@pswrd", pswrd.Text);
                        command.Parameters.AddWithValue("@SecQ", comboBox1.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@SecA", textBox7.Text);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data inserted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No rows inserted.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting data: " + ex.Message);
            }
        }

        private void signup_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem?.ToString();
            if (selectedItem != null && (selectedItem == "body mark" || selectedItem == "Your childhood town " || selectedItem == "childhood bestfriends name"))
            {
                textBox7.Visible = true;
            }
            if (selectedItem == null)
            {
                textBox7.Visible = false;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
