namespace SE
{
    partial class home_login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label5 = new Label();
            signup_link = new LinkLabel();
            login_button = new Button();
            password_textbox = new TextBox();
            username_button = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(signup_link);
            panel1.Controls.Add(login_button);
            panel1.Controls.Add(password_textbox);
            panel1.Controls.Add(username_button);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(641, 362);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(188, 318);
            label5.Name = "label5";
            label5.Size = new Size(137, 20);
            label5.TabIndex = 12;
            label5.Text = "Not already a user?";
            // 
            // signup_link
            // 
            signup_link.AutoSize = true;
            signup_link.Location = new Point(323, 318);
            signup_link.Name = "signup_link";
            signup_link.Size = new Size(146, 20);
            signup_link.TabIndex = 11;
            signup_link.TabStop = true;
            signup_link.Text = "Click here to sign up.";
            signup_link.LinkClicked += signup_link_LinkClicked;
            // 
            // login_button
            // 
            login_button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            login_button.Location = new Point(270, 270);
            login_button.Name = "login_button";
            login_button.Size = new Size(94, 29);
            login_button.TabIndex = 10;
            login_button.Text = "Login";
            login_button.UseVisualStyleBackColor = true;
            login_button.Click += login_button_Click;
            // 
            // password_textbox
            // 
            password_textbox.Location = new Point(213, 226);
            password_textbox.Name = "password_textbox";
            password_textbox.Size = new Size(207, 27);
            password_textbox.TabIndex = 9;
            password_textbox.TextChanged += password_textbox_TextChanged;
            // 
            // username_button
            // 
            username_button.Location = new Point(213, 151);
            username_button.Name = "username_button";
            username_button.Size = new Size(207, 27);
            username_button.TabIndex = 8;
            username_button.TextChanged += textBox1_TextChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(261, 200);
            label4.Name = "label4";
            label4.Size = new Size(108, 23);
            label4.TabIndex = 7;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(261, 125);
            label3.Name = "label3";
            label3.Size = new Size(114, 23);
            label3.TabIndex = 6;
            label3.Text = "Username";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MingLiU-ExtB", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(78, 19);
            label2.Name = "label2";
            label2.Size = new Size(485, 80);
            label2.TabIndex = 5;
            label2.Text = "GUILDMASTER";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 128);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 4;
            // 
            // home_login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "home_login";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button login_button;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox username_button;
        private Label label4;
        private TextBox password_textbox;
        private Label label5;
        private LinkLabel signup_link;
    }
}