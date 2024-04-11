using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            LoadPendingApprovalRequests("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Visible = true;
            this.Hide();
        }

        private void LoadPendingApprovalRequests(string societyName)
        {
            //string connectionString = "Data Source=DESKTOP-G2GT2PU\\SQLEXPRESS;Initial Catalog=DB1;Integrated Security=True;";
            const string connectionString = "Data Source=WRAITH\\SQLEXPRESS;Initial Catalog=software_engineering;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Society_ID, Society_Name, Registration_Date FROM Societies WHERE Status = 'Approved'";

                    if (!string.IsNullOrEmpty(societyName))
                    {
                        query += " AND Society_Name LIKE @SocietyName";
                    }

                    SqlCommand command = new SqlCommand(query, connection);


                    if (!string.IsNullOrEmpty(societyName))
                    {
                        command.Parameters.AddWithValue("@SocietyName", "%" + societyName + "%");
                    }

                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView1.DataSource = dataTable;

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Visible = true;
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Visible = true;
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Visible = true;
            this.Hide();
        }

       
        private void button5_Click_1(object sender, EventArgs e)
        {
            string societyName = textBox1.Text.Trim();
            LoadPendingApprovalRequests(societyName);
        }
    }
}
