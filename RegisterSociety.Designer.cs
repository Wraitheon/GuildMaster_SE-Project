namespace SE
{
    partial class RegisterSociety
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
            RequestApprovalButton = new Button();
            SocietyDescriptionTextBox = new TextBox();
            SocietyMentorTextBox = new TextBox();
            SocietyNameTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BackButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(BackButton);
            panel1.Controls.Add(RequestApprovalButton);
            panel1.Controls.Add(SocietyDescriptionTextBox);
            panel1.Controls.Add(SocietyMentorTextBox);
            panel1.Controls.Add(SocietyNameTextBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 449);
            panel1.TabIndex = 0;
            // 
            // RequestApprovalButton
            // 
            RequestApprovalButton.Location = new Point(307, 387);
            RequestApprovalButton.Name = "RequestApprovalButton";
            RequestApprovalButton.Size = new Size(151, 29);
            RequestApprovalButton.TabIndex = 7;
            RequestApprovalButton.Text = "Request Approval";
            RequestApprovalButton.UseVisualStyleBackColor = true;
            RequestApprovalButton.Click += RequestApprovalButton_Click;
            // 
            // SocietyDescriptionTextBox
            // 
            SocietyDescriptionTextBox.Location = new Point(363, 238);
            SocietyDescriptionTextBox.Multiline = true;
            SocietyDescriptionTextBox.Name = "SocietyDescriptionTextBox";
            SocietyDescriptionTextBox.Size = new Size(353, 119);
            SocietyDescriptionTextBox.TabIndex = 6;
            SocietyDescriptionTextBox.TextChanged += SocietyDescriptionTextBox_TextChanged;
            // 
            // SocietyMentorTextBox
            // 
            SocietyMentorTextBox.Location = new Point(363, 162);
            SocietyMentorTextBox.Name = "SocietyMentorTextBox";
            SocietyMentorTextBox.Size = new Size(125, 27);
            SocietyMentorTextBox.TabIndex = 5;
            SocietyMentorTextBox.TextChanged += SocietyMentorTextBox_TextChanged;
            // 
            // SocietyNameTextBox
            // 
            SocietyNameTextBox.Location = new Point(363, 110);
            SocietyNameTextBox.Name = "SocietyNameTextBox";
            SocietyNameTextBox.Size = new Size(125, 27);
            SocietyNameTextBox.TabIndex = 4;
            SocietyNameTextBox.TextChanged += SocietyNameTextBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(343, 31);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 3;
            label4.Text = "Register Society";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(160, 238);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 2;
            label3.Text = "Society Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(160, 169);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 1;
            label2.Text = "Society Mentor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(160, 117);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 0;
            label1.Text = "Society Name";
            // 
            // BackButton
            // 
            BackButton.Location = new Point(26, 22);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(94, 29);
            BackButton.TabIndex = 8;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // RegisterSociety
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "RegisterSociety";
            Text = "RegisterSociety";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button RequestApprovalButton;
        private TextBox SocietyDescriptionTextBox;
        private TextBox SocietyMentorTextBox;
        private TextBox SocietyNameTextBox;
        private Label label4;
        private Button BackButton;
    }
}