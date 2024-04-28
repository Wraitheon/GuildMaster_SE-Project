namespace SE
{
    partial class ExecutiveCouncilDashboard
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
            label1 = new Label();
            panel1 = new Panel();
            ViewFeedbackButton = new Button();
            UpcomingEventsButton = new Button();
            ViewMembersButton = new Button();
            ReviewApplicationsButton = new Button();
            button1 = new Button();
            usernameLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(112, 17);
            label1.Name = "label1";
            label1.Size = new Size(572, 45);
            label1.TabIndex = 0;
            label1.Text = "Executive Council Dashboard";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(ViewFeedbackButton);
            panel1.Controls.Add(UpcomingEventsButton);
            panel1.Controls.Add(ViewMembersButton);
            panel1.Controls.Add(ReviewApplicationsButton);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(usernameLabel);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 449);
            panel1.TabIndex = 3;
            // 
            // ViewFeedbackButton
            // 
            ViewFeedbackButton.Location = new Point(432, 289);
            ViewFeedbackButton.Name = "ViewFeedbackButton";
            ViewFeedbackButton.Size = new Size(198, 71);
            ViewFeedbackButton.TabIndex = 6;
            ViewFeedbackButton.Text = "View Feedback";
            ViewFeedbackButton.UseVisualStyleBackColor = true;
            ViewFeedbackButton.Click += ViewFeedbackButton_Click;
            // 
            // UpcomingEventsButton
            // 
            UpcomingEventsButton.Location = new Point(197, 289);
            UpcomingEventsButton.Name = "UpcomingEventsButton";
            UpcomingEventsButton.Size = new Size(198, 71);
            UpcomingEventsButton.TabIndex = 5;
            UpcomingEventsButton.Text = "Upcoming Events";
            UpcomingEventsButton.UseVisualStyleBackColor = true;
            UpcomingEventsButton.Click += UpcomingEventsButton_Click;
            // 
            // ViewMembersButton
            // 
            ViewMembersButton.Location = new Point(548, 177);
            ViewMembersButton.Name = "ViewMembersButton";
            ViewMembersButton.Size = new Size(198, 71);
            ViewMembersButton.TabIndex = 4;
            ViewMembersButton.Text = "View Members";
            ViewMembersButton.UseVisualStyleBackColor = true;
            ViewMembersButton.Click += ViewMembersButton_Click;
            // 
            // ReviewApplicationsButton
            // 
            ReviewApplicationsButton.Location = new Point(310, 177);
            ReviewApplicationsButton.Name = "ReviewApplicationsButton";
            ReviewApplicationsButton.Size = new Size(198, 71);
            ReviewApplicationsButton.TabIndex = 3;
            ReviewApplicationsButton.Text = "ReviewApplications";
            ReviewApplicationsButton.UseVisualStyleBackColor = true;
            ReviewApplicationsButton.Click += ReviewApplicationsButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(74, 177);
            button1.Name = "button1";
            button1.Size = new Size(198, 71);
            button1.TabIndex = 2;
            button1.Text = "Schedule Event";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.ForeColor = SystemColors.ButtonHighlight;
            usernameLabel.Location = new Point(310, 62);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(0, 21);
            usernameLabel.TabIndex = 1;
            // 
            // ExecutiveCouncilDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "ExecutiveCouncilDashboard";
            Text = "StudentDashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label usernameLabel;
        private Button button1;
        private Button ReviewApplicationsButton;
        private Button ViewMembersButton;
        private Button ViewFeedbackButton;
        private Button UpcomingEventsButton;
    }
}