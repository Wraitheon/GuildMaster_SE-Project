using Microsoft.Data.SqlClient;
using Microsoft.Web.WebView2.Core;
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
    public partial class RegisterSociety : Form
    {
        private userInfo UserInfo;

        public RegisterSociety(userInfo userInfo)
        {
            InitializeComponent();
            UserInfo = userInfo;
        }

        private void RequestApprovalButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SocietyNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(SocietyMentorTextBox.Text) ||
                string.IsNullOrWhiteSpace(SocietyDescriptionTextBox.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            const string connectionString = "Data Source=WRAITH\\SQLEXPRESS;Initial Catalog=software_engineering;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Society (societyName, societyDescription, societyMentor, societyApproved, societyPresidentID) VALUES (@Name, @Description, @Mentor, 0, @PresidentID)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", SocietyNameTextBox.Text);
                    command.Parameters.AddWithValue("@Description", SocietyDescriptionTextBox.Text);
                    command.Parameters.AddWithValue("@Mentor", SocietyMentorTextBox.Text);
                    command.Parameters.AddWithValue("@PresidentID", UserInfo.UserID);

                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Society registration request submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to submit society registration request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void SocietyNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SocietyMentorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SocietyDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            StudentDashboard studentDashboard = new StudentDashboard(UserInfo);
            studentDashboard.Show();

            Visible = false;
        }
    }
}
