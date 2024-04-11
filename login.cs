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
using System.Xml.Linq;
using Microsoft.Data.SqlClient;
using WindowsFormsApp3;
using SE;

namespace login
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            forgotpassword fp = new forgotpassword();
            fp.Show();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            const string connectionString = "Data Source=WRAITH\\SQLEXPRESS;Initial Catalog=software_engineering;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

            //string connectionString = "Data Source=DESKTOP-G2GT2PU\\SQLEXPRESS;Initial Catalog=DB1;Integrated Security=True;";
            string query = "SELECT * FROM Details WHERE Uname = @Uname AND pswrd = @pswrd";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Uname", UnameL.Text);
                        command.Parameters.AddWithValue("@pswrd", pswrdL.Text);

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            //MessageBox.Show("Login successful!");
                            //welcome F1 = new welcome();
                            //F1.Show();
                            //this.Hide();

                            StudentDashboard studentDash = new StudentDashboard();
                            studentDash.Show();
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password!");
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error during login: " + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            const string connectionString = "Data Source=WRAITH\\SQLEXPRESS;Initial Catalog=software_engineering;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            //string connectionString = "Data Source=DESKTOP-G2GT2PU\\SQLEXPRESS;Initial Catalog=DB1;Integrated Security=True;";
            string query = "SELECT * FROM Details WHERE Uname = @Uname AND pswrd = @pswrd";

            try
            {
                SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Uname", UnameL.Text);
                    command.Parameters.AddWithValue("@pswrd", pswrdL.Text);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        //MessageBox.Show("Login successful!");
                        //Form1 F1 = new Form1();
                        //F1.Show();
                        //this.Hide();

                        StudentDashboard studentDash = new StudentDashboard();
                        studentDash.Show();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password!");
                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error during login: " + ex.Message);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
