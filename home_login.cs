using login;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            string query = "SELECT userID, firstName, lastName, email, role FROM Users WHERE Username = @Username AND Password = @Password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    // Execute the query
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Create UserInfo object with retrieved information
                        userInfo UserInfo = new userInfo(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            username,
                            password,
                            reader.GetString(3),
                            reader.GetString(4)
                        );

                        // Show the appropriate dashboard based on the user's role
                        switch (UserInfo.Role)
                        {
                            case "Admin":
                                AdminDashboard adminDashboard = new AdminDashboard(UserInfo);
                                adminDashboard.Show();
                                break;
                            case "Executive Council":
                                //ExecutiveCouncilDashboard ecDashboard = new ExecutiveCouncilDashboard(userInfo);
                                //ecDashboard.Show();
                                break;
                            case "Student":
                                StudentDashboard studentDashboard = new StudentDashboard(UserInfo);
                                studentDashboard.Show();
                                break;
                            default:
                                MessageBox.Show("Unknown role: " + UserInfo.Role);
                                break;
                        }

                        // Close the current login form
                        Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
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
