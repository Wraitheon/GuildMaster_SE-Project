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

namespace SE
{
    public partial class ScheduleEvent : Form
    {
        public ScheduleEvent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string connectionString = "Data Source=WRAITH\\SQLEXPRESS;Initial Catalog=software_engineering;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

            string query = "INSERT INTO Events (eventName, eventDate, eventDescription, eventVenue, eventSociety, eventApproved) VALUES (@eventName, @eventDate, @eventDescription, @eventVenue, @eventSociety, 0)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@eventName", eventName.Text);
                        command.Parameters.AddWithValue("@eventDate", eventDate.Value);
                        command.Parameters.AddWithValue("@eventDescription", eventDescription.Text);
                        command.Parameters.AddWithValue("@eventVenue", eventVenue.Text);
                        command.Parameters.AddWithValue("@eventSociety", eventSociety.Text);

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
            ExecutiveCouncilDashboard studentDash = new ExecutiveCouncilDashboard();
            studentDash.Show();
            this.Close();
        }
    }
}
