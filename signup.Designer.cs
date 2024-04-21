namespace login
{
    partial class signup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            emailTextBox = new TextBox();
            passwordTextBox = new TextBox();
            userNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            label7 = new Label();
            roleComboBox = new ComboBox();
            label3 = new Label();
            label6 = new Label();
            signUpButton = new Button();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Desktop;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(emailTextBox);
            panel1.Controls.Add(passwordTextBox);
            panel1.Controls.Add(userNameTextBox);
            panel1.Controls.Add(lastNameTextBox);
            panel1.Controls.Add(firstNameTextBox);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(roleComboBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(signUpButton);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 1);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(635, 446);
            panel1.TabIndex = 0;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(315, 251);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(183, 38);
            emailTextBox.TabIndex = 22;
            emailTextBox.TextChanged += emailTextBox_TextChanged;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(315, 209);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(183, 38);
            passwordTextBox.TabIndex = 21;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(315, 166);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(183, 38);
            userNameTextBox.TabIndex = 20;
            userNameTextBox.TextChanged += userNameTextBox_TextChanged;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(315, 121);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(183, 38);
            lastNameTextBox.TabIndex = 19;
            lastNameTextBox.TextChanged += lastNameTextBox_TextChanged;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(315, 75);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(183, 38);
            firstNameTextBox.TabIndex = 18;
            firstNameTextBox.TextChanged += firstNameTextBox_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(134, 297);
            label7.Name = "label7";
            label7.Size = new Size(56, 23);
            label7.TabIndex = 17;
            label7.Text = "Role";
            // 
            // roleComboBox
            // 
            roleComboBox.FormattingEnabled = true;
            roleComboBox.Location = new Point(315, 292);
            roleComboBox.Name = "roleComboBox";
            roleComboBox.Size = new Size(183, 31);
            roleComboBox.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(137, 255);
            label3.Name = "label3";
            label3.Size = new Size(68, 23);
            label3.TabIndex = 15;
            label3.Text = "Email";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Malgun Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(237, 0);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(148, 46);
            label6.TabIndex = 14;
            label6.Text = "Sign Up";
            label6.TextAlign = ContentAlignment.TopCenter;
            label6.UseWaitCursor = true;
            // 
            // signUpButton
            // 
            signUpButton.Location = new Point(252, 368);
            signUpButton.Margin = new Padding(2);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(102, 35);
            signUpButton.TabIndex = 11;
            signUpButton.Tag = "signup";
            signUpButton.Text = "signup";
            signUpButton.UseVisualStyleBackColor = true;
            signUpButton.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(137, 213);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(108, 23);
            label5.TabIndex = 10;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(134, 170);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(114, 23);
            label4.TabIndex = 9;
            label4.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(134, 125);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(120, 23);
            label2.TabIndex = 4;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(134, 79);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 23);
            label1.TabIndex = 1;
            label1.Text = "First Name";
            // 
            // button1
            // 
            button1.Location = new Point(18, 16);
            button1.Name = "button1";
            button1.Size = new Size(27, 29);
            button1.TabIndex = 23;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 446);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "signup";
            Text = "signup";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button signUpButton;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label3;
        private TextBox emailTextBox;
        private TextBox passwordTextBox;
        private TextBox userNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private Label label7;
        private ComboBox roleComboBox;
        private Button button1;
    }
}