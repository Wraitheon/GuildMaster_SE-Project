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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SE
{
    public partial class ScheduleEvent : Form
    {
        private userInfo UserInfo;

        public ScheduleEvent(userInfo userInfo)
        {
            InitializeComponent();
            UserInfo = userInfo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string connectionString = "Data Source=WRAITH\\SQLEXPRESS;Initial Catalog=software_engineering;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

            string getSocietyIdQuery = "SELECT societyID FROM Society WHERE societyPresidentID = @presidentUserID";

            string insertEventQuery = "INSERT INTO Event (eventName, eventDate, eventDescription, eventLocation, eventSocietyID, eventApproved) " +
                                      "VALUES (@eventName, @eventDate, @eventDescription, @eventLocation, @eventSocietyID, 0)";

            try
            {
                int societyID = 0;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(getSocietyIdQuery, connection))
                    {
                        command.Parameters.AddWithValue("@presidentUserID", UserInfo.UserID);
                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            societyID = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("Error: Society ID not found for the president user.");
                            return;
                        }
                    }
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(insertEventQuery, connection))
                    {
                        command.Parameters.AddWithValue("@eventName", eventName.Text);
                        command.Parameters.AddWithValue("@eventDate", eventDate.Value);
                        command.Parameters.AddWithValue("@eventDescription", eventDescription.Text);
                        command.Parameters.AddWithValue("@eventLocation", eventVenue.Text);
                        command.Parameters.AddWithValue("@eventSocietyID", societyID);

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

        private void button2_Click(object sender, EventArgs e)
        {
            ExecutiveCouncilDashboard studentDash = new ExecutiveCouncilDashboard(UserInfo);
            studentDash.Show();
            this.Close();
        }
    }
}