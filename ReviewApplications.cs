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
    public partial class ReviewApplications : Form
    {
        private userInfo UserInfo;
        public ReviewApplications(userInfo userInfo)
        {
            InitializeComponent();
            UserInfo = userInfo;

            LoadMembershipApplications();
        }
        private void LoadMembershipApplications()
        {
            const string connectionString = "Data Source=WRAITH\\SQLEXPRESS;Initial Catalog=software_engineering;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT m.membershipID, u.userName AS applicantName, s.societyName AS societyName, m.membershipTeam, m.membershipRole FROM Membership m INNER JOIN Users u ON m.membershipUserID = u.userID INNER JOIN Society s ON m.membershipSocietyID = s.societyID WHERE s.societyPresidentID = @presidentUserID AND m.membershipApproved = 0;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@presidentUserID", UserInfo.UserID);

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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Accept_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int membershipID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["membershipID"].Value);

                const string connectionString = "Data Source=WRAITH\\SQLEXPRESS;Initial Catalog=software_engineering;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "UPDATE Membership SET membershipApproved = 1 WHERE membershipID = @membershipID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@membershipID", membershipID);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Membership application accepted successfully.");
                            LoadMembershipApplications();
                        }
                        else
                        {
                            MessageBox.Show("Failed to accept membership application.");
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
                MessageBox.Show("Please select a membership application to accept.");
            }
        }
    }
}
