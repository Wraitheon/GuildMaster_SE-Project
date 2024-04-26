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
        private string username;
        public ExecutiveCouncilDashboard(string username)
        {
            InitializeComponent();

            this.username = username;
            usernameLabel.Text = "Welcome, " + username;
        }
    }
}
