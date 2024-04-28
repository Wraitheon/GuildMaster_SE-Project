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
    public partial class ExecutiveCouncilDashboard : Form
    {
        private userInfo UserInfo;
        public ExecutiveCouncilDashboard(userInfo userInfo)
        {
            InitializeComponent();

            UserInfo = userInfo;
            usernameLabel.Text = "Welcome, " + UserInfo.Username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ScheduleEvent scheduleEvent = new ScheduleEvent(UserInfo);
            scheduleEvent.Show();

            Visible = false;
        }

        private void ReviewApplicationsButton_Click(object sender, EventArgs e)
        {
            ReviewApplications review = new ReviewApplications(UserInfo);
            review.Show();

            Visible = false;
        }

        private void ViewMembersButton_Click(object sender, EventArgs e)
        {
            ViewMembers viewMembers = new ViewMembers(UserInfo);
            viewMembers.Show();

            Visible = false;
        }

        private void UpcomingEventsButton_Click(object sender, EventArgs e)
        {
            UpcomingEvents upcomingEvents = new UpcomingEvents(UserInfo);
            upcomingEvents.Show();

            Visible = false;
        }

        private void ViewFeedbackButton_Click(object sender, EventArgs e)
        {
            ViewFeedback viewFeedback = new ViewFeedback(UserInfo);
            viewFeedback.Show();

            Visible = false;
        }
    }
}
