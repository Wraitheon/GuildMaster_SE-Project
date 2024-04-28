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
    public partial class UpcomingEvents : Form
    {
        private userInfo UserInfo;
        public UpcomingEvents(userInfo userInfo)
        {
            InitializeComponent();
            UserInfo = userInfo;

            LoadEvents();
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
    }
}
