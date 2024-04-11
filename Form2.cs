using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            LoadPendingApprovalRequests();
        }




        private void LoadPendingApprovalRequests()
        {
            const string connectionString = "Data Source=WRAITH\\SQLEXPRESS;Initial Catalog=software_engineering;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

            //string connectionString = "Data Source=DESKTOP-G2GT2PU\\SQLEXPRESS;Initial Catalog=DB1;Integrated Security=True;";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Society_ID, Society_Name, Registration_Date FROM Societies WHERE Status = 'Pending'";
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Visible = true;
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //string connectionString = "Data Source=DESKTOP-G2GT2PU\\SQLEXPRESS;Initial Catalog=DB1;Integrated Security=True;";
            const string connectionString = "Data Source=DESKTOP-M65O6PF\\SQLEXPRESS;Initial Catalog=Society;Integrated Security=True;";

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
                            MessageBox.Show("Society approved successfully.");
                            LoadPendingApprovalRequests();
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            const string connectionString = "Data Source=DESKTOP-M65O6PF\\SQLEXPRESS;Initial Catalog=Society;Integrated Security=True;";

            //string connectionString = "Data Source=DESKTOP-G2GT2PU\\SQLEXPRESS;Initial Catalog=DB1;Integrated Security=True;";
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                int societyID = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells[0].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Societies SET Status = 'Rejected' WHERE Society_ID = @SocietyID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SocietyID", societyID);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Society request rejected successfully.");
                        LoadPendingApprovalRequests();
                    }
                    else
                    {
                        MessageBox.Show("Failed to reject society request.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a society to reject.");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form Form4 = new Form4();
            Form4.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
