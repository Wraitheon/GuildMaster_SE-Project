using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace login
{
    public partial class forgotpassword : Form
    {
        public forgotpassword()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

private void button1_Click(object sender, EventArgs e)
    {
            string connectionString = "Data Source=WRAITH\\SQLEXPRESS;Initial Catalog=software_engineering;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            string queryCheck = "SELECT COUNT(*) FROM Details WHERE Uname = @Uname AND SecA = @SecA";

        string queryUpdatePassword = "UPDATE Details SET pswrd = @pswrdN WHERE Uname = @Uname";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand commandCheck = new SqlCommand(queryCheck, connection))
                {
                    commandCheck.Parameters.AddWithValue("@Uname", UnameF.Text);
                    commandCheck.Parameters.AddWithValue("@SecA", SecF.Text);

                    int count = (int)commandCheck.ExecuteScalar();

                    if (count > 0)
                    {
                        using (SqlCommand commandUpdatePassword = new SqlCommand(queryUpdatePassword, connection))
                        {
                            commandUpdatePassword.Parameters.AddWithValue("@pswrdN", pswrdN.Text);
                            commandUpdatePassword.Parameters.AddWithValue("@Uname", UnameF.Text);

                            int rowsAffected = commandUpdatePassword.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Password updated successfully!");
                            }
                            else
                            {
                                MessageBox.Show("Password update failed.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or security answer!");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error updating password: " + ex.Message);
        }
    }


    private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-G2GT2PU\\SQLEXPRESS;Initial Catalog=DB1;Integrated Security=True;";
            string query = "SELECT SecQ FROM Details WHERE Uname = @Uname";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Uname", UnameF.Text);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            label5.Text = result.ToString();
                        }
                        else
                        {
                            label5.Text = "Security question not found for the provided username.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving security question: " + ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
