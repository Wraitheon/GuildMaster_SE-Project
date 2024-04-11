namespace login
{
    partial class login
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
            button3 = new Button();
            pswrdL = new TextBox();
            UnameL = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(pswrdL);
            panel1.Controls.Add(UnameL);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(59, 12);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(671, 426);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(242, 292);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(174, 34);
            button3.TabIndex = 9;
            button3.Text = "Forgot Password";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // pswrdL
            // 
            pswrdL.Location = new Point(258, 175);
            pswrdL.Margin = new Padding(2);
            pswrdL.Name = "pswrdL";
            pswrdL.Size = new Size(150, 31);
            pswrdL.TabIndex = 7;
            // 
            // UnameL
            // 
            UnameL.Location = new Point(258, 108);
            UnameL.Margin = new Padding(2);
            UnameL.Name = "UnameL";
            UnameL.Size = new Size(150, 31);
            UnameL.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(258, 28);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(134, 31);
            textBox2.TabIndex = 5;
            textBox2.Text = "GUILDMASTER";
            // 
            // button1
            // 
            button1.Location = new Point(269, 238);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 148);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(168, 80);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "login";
            Text = "login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox2;
        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox pswrdL;
        private TextBox UnameL;
        private Button button3;
    }
}