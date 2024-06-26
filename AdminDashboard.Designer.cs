﻿namespace SE
{
    partial class AdminDashboard
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
            usernameLabel = new Label();
            SocietyApprovalButton = new Button();
            ViewApprovedSocieties = new Button();
            button3 = new Button();
            UpcomingEventsButton = new Button();
            panel1 = new Panel();
            LogoutButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Lucida Sans Unicode", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(268, 72);
            label1.Name = "label1";
            label1.Size = new Size(273, 34);
            label1.TabIndex = 0;
            label1.Text = "Admin Dashboard";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.Black;
            usernameLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.ForeColor = Color.White;
            usernameLabel.Location = new Point(336, 72);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(0, 20);
            usernameLabel.TabIndex = 1;
            // 
            // SocietyApprovalButton
            // 
            SocietyApprovalButton.Location = new Point(85, 167);
            SocietyApprovalButton.Name = "SocietyApprovalButton";
            SocietyApprovalButton.Size = new Size(187, 45);
            SocietyApprovalButton.TabIndex = 2;
            SocietyApprovalButton.Text = "Society Approvals";
            SocietyApprovalButton.UseVisualStyleBackColor = true;
            SocietyApprovalButton.Click += SocietyApprovalButton_Click;
            // 
            // ViewApprovedSocieties
            // 
            ViewApprovedSocieties.Location = new Point(320, 167);
            ViewApprovedSocieties.Name = "ViewApprovedSocieties";
            ViewApprovedSocieties.Size = new Size(187, 45);
            ViewApprovedSocieties.TabIndex = 3;
            ViewApprovedSocieties.Text = "Approved Societies";
            ViewApprovedSocieties.UseVisualStyleBackColor = true;
            ViewApprovedSocieties.Click += ViewApprovedSocieties_Click;
            // 
            // button3
            // 
            button3.Location = new Point(564, 167);
            button3.Name = "button3";
            button3.Size = new Size(187, 45);
            button3.TabIndex = 4;
            button3.Text = "Event Approvals";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // UpcomingEventsButton
            // 
            UpcomingEventsButton.Location = new Point(320, 279);
            UpcomingEventsButton.Name = "UpcomingEventsButton";
            UpcomingEventsButton.Size = new Size(187, 45);
            UpcomingEventsButton.TabIndex = 5;
            UpcomingEventsButton.Text = "Upcoming Events";
            UpcomingEventsButton.UseVisualStyleBackColor = true;
            UpcomingEventsButton.Click += UpcomingEventsButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(LogoutButton);
            panel1.Controls.Add(usernameLabel);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(831, 562);
            panel1.TabIndex = 6;
            // 
            // LogoutButton
            // 
            LogoutButton.Location = new Point(14, 12);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(94, 29);
            LogoutButton.TabIndex = 2;
            LogoutButton.Text = "LogOut";
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 560);
            Controls.Add(UpcomingEventsButton);
            Controls.Add(button3);
            Controls.Add(ViewApprovedSocieties);
            Controls.Add(SocietyApprovalButton);
            Controls.Add(panel1);
            Name = "AdminDashboard";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button SocietyApprovalButton;
        private System.Windows.Forms.Button ViewApprovedSocieties;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button UpcomingEventsButton;
        private Panel panel1;
        private Button LogoutButton;
    }
}

