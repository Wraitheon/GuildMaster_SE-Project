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
    public partial class EventApproval : Form
    {
        private userInfo UserInfo;

        public EventApproval(userInfo userInfo)
        {
            InitializeComponent();
            UserInfo = userInfo;
            loadEventApprovals();
        }

        private void loadEventApprovals()
        {
            const string connectionString = "Data Source=WRAITH\\SQLEXPRESS;Initial Catalog=software_engineering;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT e.eventID, e.eventName, e.eventDate, e.eventLocation, s.societyName AS eventSociety, e.eventDescription FROM Event e JOIN Society s ON e.eventSocietyID = s.societyID WHERE e.eventApproved = 0;";
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

        private void button2_Click(object sender, EventArgs e)
        {
            const string connectionString = "Data Source=WRAITH\\SQLEXPRESS;Initial Catalog=software_engineering;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int eventID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["eventID"].Value);

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "UPDATE Event SET eventApproved = 1 WHERE eventID = @eventID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@eventID", eventID);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Event approved successfully.");
                            loadEventApprovals();
                        }
                        else
                        {
                            MessageBox.Show("Failed to approve event.");
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
                MessageBox.Show("Please select an event to approve.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            const string connectionString = "Data Source=WRAITH\\SQLEXPRESS;Initial Catalog=software_engineering;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int eventID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["eventID"].Value);

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "DELETE FROM Event WHERE eventID = @eventID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@eventID", eventID);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Event deleted successfully.");
                            loadEventApprovals();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete event.");
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
                MessageBox.Show("Please select an event to delete.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminDashboard admindash = new AdminDashboard(UserInfo);
            admindash.Show();

            Visible = false;
        }
    }
}