using login;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using WindowsFormsApp3;

namespace SE
{
    public partial class home_login : Form
    {
        public home_login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void password_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string username = username_button.Text;
            string password = password_textbox.Text;

            // Check if username or password is empty
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            // Connect to the database and check user credentials
            string connectionString = "Data Source=WRAITH\\SQLEXPRESS;Initial Catalog=software_engineering;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            string query = "SELECT Role FROM Users WHERE Username = @Username AND Password = @Password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    // Execute the query
                    string role = (string)command.ExecuteScalar();

                    if (string.IsNullOrEmpty(role))
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                    else
                    {
                        // Show the appropriate dashboard based on the user's role
                        switch (role)
                        {
                            case "Admin":
                                AdminDashboard adminDashboard = new AdminDashboard();
                                adminDashboard.Show();
                                break;
                            case "Executive Council":
                                ExecutiveCouncilDashboard ecDashboard = new ExecutiveCouncilDashboard();    
                                ecDashboard.Show();
                                break;
                            case "Student":
                                //StudentDashboardForm studentDashboard = new StudentDashboardForm();
                                //studentDashboard.Show();
                                break;
                            default:
                                MessageBox.Show("Unknown role: " + role);
                                break;
                        }

                        // Close the current login form
                        Visible = false;
                    }
                }
            }
        }

        private void signup_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Visible = false;

            signup signup = new signup();
            signup.Show();
        }
    }
}