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
    public partial class SubmitFeedback : Form
    {
        private userInfo UserInfo;
        public SubmitFeedback(userInfo userInfo)
        {
            InitializeComponent();
            UserInfo = userInfo;

            LoadEvents();
            for (int i = 1; i <= 5; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }
        }

        private void LoadEvents()
        {
            const string connectionString = "Data Source=WRAITH\\SQLEXPRESS;Initial Catalog=software_engineering;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT e.eventID, e.eventName, e.eventDate, e.eventLocation, s.societyName AS eventSociety, e.eventDescription FROM Event e JOIN Society s ON e.eventSocietyID = s.societyID WHERE e.eventApproved = 1;";
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

        private void SubmitFeedbackButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int eventID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["eventID"].Value);

                if (!string.IsNullOrEmpty(textBox1.Text) && comboBox1.SelectedIndex >= 0)
                {
                    int rating = comboBox1.SelectedIndex + 1; // Rating is 1-indexed
                    string comment = textBox1.Text;

                    const string connectionString = "Data Source=WRAITH\\SQLEXPRESS;Initial Catalog=software_engineering;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            string query = "INSERT INTO EventFeedback (feedbackUserID, feedbackEventID, feedbackRating, feedbackComment) VALUES (@userID, @eventID, @rating, @comment)";
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@userID", UserInfo.UserID);
                                command.Parameters.AddWithValue("@eventID", eventID);
                                command.Parameters.AddWithValue("@rating", rating);
                                command.Parameters.AddWithValue("@comment", comment);

                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Feedback submitted successfully.");
                                }
                                else
                                {
                                    MessageBox.Show("Failed to submit feedback.");
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
                    MessageBox.Show("Please provide both rating and comment.");
                }
            }
            else
            {
                MessageBox.Show("Please select an event to submit feedback.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            StudentDashboard studDash = new StudentDashboard(UserInfo);
            studDash.Show();

            Visible = false;
        }
    }
}
