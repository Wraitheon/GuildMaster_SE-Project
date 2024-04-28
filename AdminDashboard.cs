using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SE
{
    public partial class AdminDashboard : Form
    {
        private userInfo UserInfo;
        public AdminDashboard(userInfo info)
        {
            InitializeComponent();

            UserInfo = info;
            usernameLabel.Text = "Welcome, " + UserInfo.Username;
        }

        private void SocietyApprovalButton_Click(object sender, EventArgs e)
        {
            SocietyApprovalAdmin societyApprovalAdmin = new SocietyApprovalAdmin(UserInfo);
            societyApprovalAdmin.Show();

            Visible = false;
        }

        private void ViewApprovedSocieties_Click(object sender, EventArgs e)
        {
            ViewApprovedSocietiesForm viewApprovedSocieties = new ViewApprovedSocietiesForm();
            viewApprovedSocieties.Show();

            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EventApproval eventApproval = new EventApproval(UserInfo);
            eventApproval.Show();

            Visible = false;
        }
    }
}
