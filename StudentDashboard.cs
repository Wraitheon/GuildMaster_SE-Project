﻿using System;
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
        public StudentDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ScheduleEvent scheduleEvent = new ScheduleEvent();
            scheduleEvent.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            eventBoard eventBoard = new eventBoard();
            eventBoard.Show();
            this.Close();
        }
    }
}