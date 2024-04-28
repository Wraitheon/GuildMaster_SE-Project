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
    public partial class ViewFeedback : Form
    {
        private userInfo UserInfo;
        public ViewFeedback(userInfo userInfo)
        {
            InitializeComponent();
            UserInfo = userInfo;

            LoadFeedback();
        }

        private void LoadFeedback()
        {
            const string connectionString = "Data Source=WRAITH\\SQLEXPRESS;Initial Catalog=software_engineering;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"SELECT ef.feedbackID, u.userName AS FeedbackUser, e.eventName, ef.feedbackRating, ef.feedbackComment
                                    FROM EventFeedback ef
                                    JOIN Users u ON ef.feedbackUserID = u.userID
                                    JOIN Event e ON ef.feedbackEventID = e.eventID
                                    JOIN Society s ON e.eventSocietyID = s.societyID
                                    WHERE s.societyPresidentID = @presidentUserID";

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
