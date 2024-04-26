using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE
{
    public partial class SocietyApprovalAdmin : Form
    {
        private userInfo UserInfo;
        private DataTable societyRequests;
        public SocietyApprovalAdmin(userInfo info)
        {
            InitializeComponent();
            LoadSocietyRequests();

            UserInfo = info;
        }

        private void LoadSocietyRequests()
        {
            const string connectionString = "Data Source=WRAITH\\SQLEXPRESS;Initial Catalog=software_engineering;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT s.societyID, s.societyName, s.societyMentor, s.societyDescription, u.userName AS societyPresident FROM Society s JOIN Users u ON s.societyPresidentID = u.userID WHERE s.societyApproved = 0;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ApproveButton_Click(object sender, EventArgs e)
        {
            ApproveSociety();
        }

        private void RejectButton_Click(object sender, EventArgs e)
        {
            RejectSociety();
        }

        private void ApproveSociety()
        {
            const string connectionString = "Data Source=WRAITH\\SQLEXPRESS;Initial Catalog=software_engineering;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int societyID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["societyID"].Value);

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "UPDATE Society SET societyApproved = 1 WHERE societyID = @societyID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@societyID", societyID);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Society approved successfully.");
                            LoadSocietyRequests();
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

        private void RejectSociety()
        {
            const string connectionString = "Data Source=WRAITH\\SQLEXPRESS;Initial Catalog=software_engineering;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int societyID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["societyID"].Value);

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "DELETE FROM Society WHERE societyID = @societyID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@societyID", societyID);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Society rejected and removed successfully.");
                            LoadSocietyRequests();
                        }
                        else
                        {
                            MessageBox.Show("Failed to reject society.");
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
                MessageBox.Show("Please select a society to reject.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BackButton_Click_1(object sender, EventArgs e)
        {
            AdminDashboard admin = new AdminDashboard(UserInfo);
            admin.Show();

            Visible = false;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard(UserInfo);
            adminDashboard.Show();

            Visible = false;
        }
    }
}
