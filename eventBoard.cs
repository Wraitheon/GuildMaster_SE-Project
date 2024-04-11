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
    public partial class eventBoard : Form
    {
        public eventBoard()
        {
            InitializeComponent();
            viewEvents();
        }

        private void viewEvents()
        {
            const string connectionString = "Data Source=WRAITH\\SQLEXPRESS;Initial Catalog=software_engineering;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

            //string connectionString = "Data Source=DESKTOP-G2GT2PU\\SQLEXPRESS;Initial Catalog=DB1;Integrated Security=True;";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT eventName, eventDate, eventSociety FROM Events WHERE eventApproved = 1";
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
    }
}
