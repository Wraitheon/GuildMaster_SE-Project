namespace SE
{
    partial class ScheduleEvent
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
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            eventName = new TextBox();
            eventVenue = new TextBox();
            eventDate = new DateTimePicker();
            eventDescription = new TextBox();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(276, 41);
            label1.Name = "label1";
            label1.Size = new Size(216, 38);
            label1.TabIndex = 0;
            label1.Text = "Schedule Event";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(223, 130);
            label2.Name = "label2";
            label2.Size = new Size(85, 17);
            label2.TabIndex = 1;
            label2.Text = "Event Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.ForeColor = Color.White;
            label4.Location = new Point(223, 185);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 3;
            label4.Text = "Event Venue";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.ForeColor = Color.White;
            label5.Location = new Point(223, 237);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 4;
            label5.Text = "Event Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.ForeColor = Color.White;
            label6.Location = new Point(223, 291);
            label6.Name = "label6";
            label6.Size = new Size(125, 20);
            label6.TabIndex = 5;
            label6.Text = "Event Description";
            // 
            // eventName
            // 
            eventName.Location = new Point(367, 130);
            eventName.Name = "eventName";
            eventName.Size = new Size(125, 27);
            eventName.TabIndex = 6;
            // 
            // eventVenue
            // 
            eventVenue.Location = new Point(367, 178);
            eventVenue.Name = "eventVenue";
            eventVenue.Size = new Size(125, 27);
            eventVenue.TabIndex = 8;
            // 
            // eventDate
            // 
            eventDate.Location = new Point(367, 232);
            eventDate.Name = "eventDate";
            eventDate.Size = new Size(238, 27);
            eventDate.TabIndex = 9;
            // 
            // eventDescription
            // 
            eventDescription.Location = new Point(367, 291);
            eventDescription.Multiline = true;
            eventDescription.Name = "eventDescription";
            eventDescription.Size = new Size(325, 108);
            eventDescription.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(345, 433);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "Request Approval";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 12;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(-6, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(811, 513);
            panel1.TabIndex = 13;
            // 
            // ScheduleEvent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 502);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(eventDescription);
            Controls.Add(eventDate);
            Controls.Add(eventVenue);
            Controls.Add(eventName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "ScheduleEvent";
            Text = "ScheduleEvent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox eventName;
        private TextBox eventVenue;
        private DateTimePicker eventDate;
        private TextBox eventDescription;
        private Button button1;
        private Button button2;
        private Panel panel1;
    }
}