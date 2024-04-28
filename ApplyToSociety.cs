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
    public partial class ApplyToSociety : Form
    {
        private userInfo UserInfo;

        private readonly string[] roles = { "Vice President", "Secretary", "Head", "Officer" };
        private readonly string[] teams = { "PR & Marketing", "Operations", "Events", "Finance", "Media" };
        public ApplyToSociety(userInfo userInfo)
        {
            InitializeComponent();
            UserInfo = userInfo;

            LoadSocieties();
            LoadRoles();
            LoadTeams();
        }
        private void LoadRoles()
        {
            comboBox1.Items.AddRange(roles);
        }
        private void LoadTeams()
        {
            comboBox2.Items.AddRange(teams);
        }
        private void LoadSocieties()
        {
            const string connectionString = "Data Source=WRAITH\\SQLEXPRESS;Initial Catalog=software_engineering;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT s.societyID, s.societyName, s.societyMentor, s.societyDescription, u.userName AS societyPresident FROM Society s JOIN Users u ON s.societyPresidentID = u.userID WHERE s.societyApproved = 1;";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int societyID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["societyID"].Value);
                string societyName = dataGridView1.SelectedRows[0].Cells["societyName"].Value.ToString();
                string societyMentor = dataGridView1.SelectedRows[0].Cells["societyMentor"].Value.ToString();
                string societyDescription = dataGridView1.SelectedRows[0].Cells["societyDescription"].Value.ToString();
                string societyPresident = dataGridView1.SelectedRows[0].Cells["societyPresident"].Value.ToString();

                if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
                {
                    string selectedRole = comboBox1.SelectedItem.ToString();
                    string selectedTeam = comboBox2.SelectedItem.ToString();

                    const string connectionString = "Data Source=WRAITH\\SQLEXPRESS;Initial Catalog=software_engineering;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            string query = @"INSERT INTO Membership (membershipUserID, membershipSocietyID, membershipTeam, membershipRole, membershipApproved) 
                                     VALUES (@userID, @societyID, @team, @role, 0)";
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                // Set parameter values
                                command.Parameters.AddWithValue("@userID", UserInfo.UserID);
                                command.Parameters.AddWithValue("@societyID", societyID);
                                command.Parameters.AddWithValue("@team", selectedTeam);
                                command.Parameters.AddWithValue("@role", selectedRole);

                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Application submitted successfully.");
                                }
                                else
                                {
                                    MessageBox.Show("Failed to submit application.");
                                }
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
                    MessageBox.Show("Please select a role and a team.");
                }
            }
            else
            {
                MessageBox.Show("Please select a society to apply to.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            StudentDashboard studentdash = new StudentDashboard(UserInfo);
            studentdash.Show();

            Visible = false;
        }
    }
}
