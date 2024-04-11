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
using WindowsFormsApp3;

namespace SE
{
    public partial class EventApproval : Form
    {
        public EventApproval()
        {
            InitializeComponent();
            loadEventApprovals();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Visible = true;
            this.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void loadEventApprovals()
        {
            const string connectionString = "Data Source=WRAITH\\SQLEXPRESS;Initial Catalog=software_engineering;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

            //string connectionString = "Data Source=DESKTOP-G2GT2PU\\SQLEXPRESS;Initial Catalog=DB1;Integrated Security=True;";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT eventID, eventName, eventDate, eventVenue, eventSociety, eventDescription FROM Events WHERE eventApproved = 0";
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

                        string query = "UPDATE Events SET eventApproved = 1 WHERE eventID = @eventID";
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
                            MessageBox.Show("Failed to approve society.");
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
    }
}
