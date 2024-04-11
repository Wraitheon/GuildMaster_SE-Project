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

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
            LoadRejectedRequests();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Visible = true;
            this.Hide();
        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void LoadRejectedRequests()
        {
            const string connectionString = "Data Source=WRAITH\\SQLEXPRESS;Initial Catalog=software_engineering;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Society_ID, Society_Name, Registration_Date,Status FROM Societies WHERE Status = 'Rejected'";
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView1.DataSource = dataTable;

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            const string connectionString = "Data Source=DESKTOP-M65O6PF\\SQLEXPRESS;Initial Catalog=Society;Integrated Security=True;";
            //string connectionString = "Data Source=DESKTOP-G2GT2PU\\SQLEXPRESS;Initial Catalog=DB1;Integrated Security=True;";
            if (dataGridView1.SelectedRows.Count > 0)
            {

                int societyID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Society_ID"].Value);

                try
                {

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "UPDATE Societies SET Status = 'Approved' WHERE Society_ID = @SocietyID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@SocietyID", societyID);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Society approved successfully. After reviewing the requests.");
                            LoadRejectedRequests();
                        }
                        else
                        {
                            MessageBox.Show("Failed to approve society.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a society to approve.");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Visible = true;
            this.Hide();
        }
    }
}
