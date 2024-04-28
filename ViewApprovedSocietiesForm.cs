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
    public partial class ViewApprovedSocietiesForm : Form
    {
        private userInfo UserInfo;
        public ViewApprovedSocietiesForm(userInfo userInfo)
        {
            InitializeComponent();
            UserInfo = userInfo;
            LoadSocieties();
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

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchKeyword = SearchTextBox.Text.Trim();
            DataView dv = dataGridView1.DataSource as DataView;
            if (dv != null)
            {
                if (!string.IsNullOrEmpty(searchKeyword))
                {
                    dv.RowFilter = $"societyName LIKE '%{searchKeyword}%' OR societyMentor LIKE '%{searchKeyword}%' OR societyDescription LIKE '%{searchKeyword}%' OR societyPresident LIKE '%{searchKeyword}%'";
                }
                else
                {
                    dv.RowFilter = string.Empty;
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard(UserInfo);
            adminDashboard.Show();

            Visible = false;
        }
    }
}
