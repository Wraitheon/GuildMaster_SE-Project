﻿namespace SE
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(291, 31);
            label1.Name = "label1";
            label1.Size = new Size(199, 38);
            label1.TabIndex = 0;
            label1.Text = "Student Panel";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Location = new Point(121, 198);
            button1.Name = "button1";
            button1.Size = new Size(183, 58);
            button1.TabIndex = 1;
            button1.Text = "Schedule Event";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(490, 198);
            button2.Name = "button2";
            button2.Size = new Size(183, 58);
            button2.TabIndex = 2;
            button2.Text = "Event Board";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // StudentDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "StudentDashboard";
            Text = "StudentDashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
    }
}