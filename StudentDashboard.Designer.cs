namespace SE
{
    partial class StudentDashboard
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
            FeedbackButton = new Button();
            UpcomingEventsButton = new Button();
            ApplySocietyButton = new Button();
            button1 = new Button();
            usernameLabel = new Label();
            label1 = new Label();
            LogoutButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(LogoutButton);
            panel1.Controls.Add(FeedbackButton);
            panel1.Controls.Add(UpcomingEventsButton);
            panel1.Controls.Add(ApplySocietyButton);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(usernameLabel);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 451);
            panel1.TabIndex = 0;
            // 
            // FeedbackButton
            // 
            FeedbackButton.Location = new Point(311, 318);
            FeedbackButton.Name = "FeedbackButton";
            FeedbackButton.Size = new Size(183, 66);
            FeedbackButton.TabIndex = 5;
            FeedbackButton.Text = "Submit Event Feedback";
            FeedbackButton.UseVisualStyleBackColor = true;
            FeedbackButton.Click += FeedbackButton_Click;
            // 
            // UpcomingEventsButton
            // 
            UpcomingEventsButton.Location = new Point(531, 198);
            UpcomingEventsButton.Name = "UpcomingEventsButton";
            UpcomingEventsButton.Size = new Size(183, 66);
            UpcomingEventsButton.TabIndex = 4;
            UpcomingEventsButton.Text = "Upcoming Events";
            UpcomingEventsButton.UseVisualStyleBackColor = true;
            UpcomingEventsButton.Click += UpcomingEventsButton_Click;
            // 
            // ApplySocietyButton
            // 
            ApplySocietyButton.Location = new Point(311, 198);
            ApplySocietyButton.Name = "ApplySocietyButton";
            ApplySocietyButton.Size = new Size(183, 66);
            ApplySocietyButton.TabIndex = 3;
            ApplySocietyButton.Text = "Apply to Society";
            ApplySocietyButton.UseVisualStyleBackColor = true;
            ApplySocietyButton.Click += ApplySocietyButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(83, 198);
            button1.Name = "button1";
            button1.Size = new Size(183, 66);
            button1.TabIndex = 2;
            button1.Text = "Register Society";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Lucida Console", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.ForeColor = Color.White;
            usernameLabel.Location = new Point(311, 54);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(0, 17);
            usernameLabel.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(197, 9);
            label1.Name = "label1";
            label1.Size = new Size(381, 45);
            label1.TabIndex = 0;
            label1.Text = "Student Dashboard";
            // 
            // LogoutButton
            // 
            LogoutButton.Location = new Point(11, 12);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(94, 29);
            LogoutButton.TabIndex = 6;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // StudentDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "StudentDashboard";
            Text = "StudentDashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label usernameLabel;
        private Button button1;
        private Button ApplySocietyButton;
        private Button UpcomingEventsButton;
        private Button FeedbackButton;
        private Button LogoutButton;
    }
}