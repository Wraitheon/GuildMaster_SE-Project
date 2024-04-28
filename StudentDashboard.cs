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
    public partial class StudentDashboard : Form
    {
        private userInfo UserInfo;

        public StudentDashboard(userInfo userInfo)
        {
            InitializeComponent();

            UserInfo = userInfo;
            usernameLabel.Text = "Welcome, " + UserInfo.Username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterSociety registerSocietyForm = new RegisterSociety(UserInfo);
            registerSocietyForm.Show();

            Visible = false;
        }

        private void ApplySocietyButton_Click(object sender, EventArgs e)
        {
            ApplyToSociety applyToSocietyForm = new ApplyToSociety(UserInfo);
            applyToSocietyForm.Show();

            Visible = false;
        }

        private void UpcomingEventsButton_Click(object sender, EventArgs e)
        {
            UpcomingEvents upcomingEvents = new UpcomingEvents(UserInfo);
            upcomingEvents.Show();

            Visible = false;
        }

        private void FeedbackButton_Click(object sender, EventArgs e)
        {
            SubmitFeedback submitFeedback = new SubmitFeedback(UserInfo);
            submitFeedback.Show();

            Visible = false;
        }
    }
}