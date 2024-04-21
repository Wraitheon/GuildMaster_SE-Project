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
using SE;


namespace login
{
    public partial class signup : Form
    {
        private Label emailErrorLabel;
        private Label firstNameErrorLabel;
        private Label lastNameErrorLabel;
        private Label userNameErrorLabel;
        private Label passwordErrorLabel;
        public signup()
        {
            InitializeComponent();

            firstNameErrorLabel = new Label();
            lastNameErrorLabel = new Label();
            userNameErrorLabel = new Label();
            passwordErrorLabel = new Label();
            emailErrorLabel = new Label();

            foreach (Label errorLabel in new[] { firstNameErrorLabel, lastNameErrorLabel, userNameErrorLabel, passwordErrorLabel, emailErrorLabel })
            {
                errorLabel.AutoSize = true;
                errorLabel.ForeColor = Color.Red;
            }

            firstNameErrorLabel.Location = new Point(firstNameTextBox.Right + 5, firstNameTextBox.Top);
            lastNameErrorLabel.Location = new Point(lastNameTextBox.Right + 5, lastNameTextBox.Top);
            userNameErrorLabel.Location = new Point(userNameTextBox.Right + 5, userNameTextBox.Top);
            passwordErrorLabel.Location = new Point(passwordTextBox.Right + 5, passwordTextBox.Top);
            emailErrorLabel.Location = new Point(emailTextBox.Right + 5, emailTextBox.Top);

            Controls.AddRange(new Control[] { firstNameErrorLabel, lastNameErrorLabel, userNameErrorLabel, passwordErrorLabel, emailErrorLabel });

            roleComboBox.Items.AddRange(new string[] { "Admin", "Executive Council", "Student" });
            roleComboBox.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validate fields
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(lastNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(userNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(passwordTextBox.Text) ||
                string.IsNullOrWhiteSpace(emailTextBox.Text) ||
                roleComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Validate password
            string password = passwordTextBox.Text;
            if (!IsValidPassword(password))
            {
                MessageBox.Show("Password does not meet the required criteria.");
                return;
            }

            // Validate email
            string email = emailTextBox.Text;
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format.");
                return;
            }

            // Proceed with database insertion
            const string connectionString = "Data Source=WRAITH\\SQLEXPRESS;Initial Catalog=software_engineering;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            string query = "INSERT INTO Users (firstName, lastName, username, password, email, role) VALUES (@Fname, @Lname, @Username, @Password, @Email, @Role)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Fname", firstNameTextBox.Text);
                        command.Parameters.AddWithValue("@Lname", lastNameTextBox.Text);
                        command.Parameters.AddWithValue("@Username", userNameTextBox.Text);
                        command.Parameters.AddWithValue("@Password", passwordTextBox.Text);
                        command.Parameters.AddWithValue("@Email", emailTextBox.Text);
                        command.Parameters.AddWithValue("@Role", roleComboBox.SelectedItem?.ToString());

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data inserted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No rows inserted.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting data: " + ex.Message);
            }
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;

            if (IsValidEmail(email))
            {
                emailErrorLabel.Text = "";
            }
            else
            {
                emailErrorLabel.Text = "Invalid email format";
                emailErrorLabel.ForeColor = Color.Red;
            }
        }

        private bool IsValidPassword(string password)
        {
            // Password must be at least 8 characters
            if (password.Length < 8)
                return false;

            // Password must have at least 1 uppercase letter
            if (!password.Any(char.IsUpper))
                return false;

            // Password must have at least 1 lowercase letter
            if (!password.Any(char.IsLower))
                return false;

            // Password must have at least 1 number
            if (!password.Any(char.IsDigit))
                return false;

            // Password must have at least 1 special character
            if (!password.Any(ch => !char.IsLetterOrDigit(ch)))
                return false;

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;

            // Check if first name is empty
            if (string.IsNullOrWhiteSpace(firstName))
            {
                firstNameErrorLabel.Text = "First name cannot be empty";
            }
            else
            {
                firstNameErrorLabel.Text = "";
            }
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            string lastName = lastNameTextBox.Text;

            // Check if last name is empty
            if (string.IsNullOrWhiteSpace(lastName))
            {
                lastNameErrorLabel.Text = "Last name cannot be empty";
            }
            else
            {
                lastNameErrorLabel.Text = "";
            }
        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {
            string userName = userNameTextBox.Text;

            // Check if username is empty
            if (string.IsNullOrWhiteSpace(userName))
            {
                userNameErrorLabel.Text = "Username cannot be empty";
            }
            else
            {
                userNameErrorLabel.Text = "";
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            string password = passwordTextBox.Text;

            // Check password constraints
            if (IsValidPassword(password))
            {
                passwordErrorLabel.Text = "";
            }
            else
            {
                passwordErrorLabel.Text = "Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, one digit, and one special character";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Visible = false;

            home_login home_Login = new home_login();
            home_Login.Show();
        }
    }
}
