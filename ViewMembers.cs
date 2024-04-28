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
    public partial class ViewMembers : Form
    {
        private userInfo UserInfo;
        public ViewMembers(userInfo userInfo)
        {
            InitializeComponent();
            UserInfo = userInfo;
            LoadMembers();
        }

        private void LoadMembers()
        {
            const string connectionString = "Data Source=WRAITH\\SQLEXPRESS;Initial Catalog=software_engineering;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT m.membershipID, u.userName AS applicantName, s.societyName AS societyName, m.membershipTeam, m.membershipRole FROM Membership m INNER JOIN Users u ON m.membershipUserID = u.userID INNER JOIN Society s ON m.membershipSocietyID = s.societyID WHERE s.societyPresidentID = @presidentUserID AND m.membershipApproved = 1;";
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
