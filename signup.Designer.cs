namespace login
{
    partial class signup
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
            textBox7 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            pswrd = new TextBox();
            Uname = new TextBox();
            Designation = new TextBox();
            label3 = new Label();
            label2 = new Label();
            Lname = new TextBox();
            Fname = new TextBox();
            label1 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pswrd);
            panel1.Controls.Add(Uname);
            panel1.Controls.Add(Designation);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Lname);
            panel1.Controls.Add(Fname);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(32, 23);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(566, 400);
            panel1.TabIndex = 0;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(153, 321);
            textBox7.Margin = new Padding(2, 2, 2, 2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(121, 27);
            textBox7.TabIndex = 13;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Your childhood town ", "body mark", "childhood bestfriends name" });
            comboBox1.Location = new Point(109, 281);
            comboBox1.Margin = new Padding(2, 2, 2, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(212, 28);
            comboBox1.TabIndex = 12;
            comboBox1.Text = "Choose security Question";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(162, 362);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(90, 27);
            button1.TabIndex = 11;
            button1.Tag = "signup";
            button1.Text = "signup";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 242);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 10;
            label5.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 204);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 9;
            label4.Text = "Username:";
            // 
            // pswrd
            // 
            pswrd.Location = new Point(153, 242);
            pswrd.Margin = new Padding(2, 2, 2, 2);
            pswrd.Name = "pswrd";
            pswrd.Size = new Size(121, 27);
            pswrd.TabIndex = 8;
            // 
            // Uname
            // 
            Uname.Location = new Point(153, 202);
            Uname.Margin = new Padding(2, 2, 2, 2);
            Uname.Name = "Uname";
            Uname.Size = new Size(121, 27);
            Uname.TabIndex = 7;
            // 
            // Designation
            // 
            Designation.Location = new Point(153, 159);
            Designation.Margin = new Padding(2, 2, 2, 2);
            Designation.Name = "Designation";
            Designation.Size = new Size(121, 27);
            Designation.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 159);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 5;
            label3.Text = "Designation:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 116);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 4;
            label2.Text = "Last Name :";
            label2.Click += label2_Click;
            // 
            // Lname
            // 
            Lname.Location = new Point(153, 114);
            Lname.Margin = new Padding(2, 2, 2, 2);
            Lname.Name = "Lname";
            Lname.Size = new Size(121, 27);
            Lname.TabIndex = 3;
            // 
            // Fname
            // 
            Fname.Location = new Point(153, 68);
            Fname.Margin = new Padding(2, 2, 2, 2);
            Fname.Name = "Fname";
            Fname.Size = new Size(121, 27);
            Fname.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 68);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 1;
            label1.Text = "First Name :";
            label1.Click += label1_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(227, 11);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(122, 38);
            label6.TabIndex = 14;
            label6.Text = "Sign Up";
            label6.TextAlign = ContentAlignment.TopCenter;
            label6.UseWaitCursor = true;
            label6.Click += label6_Click;
            // 
            // signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 446);
            Controls.Add(panel1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "signup";
            Text = "signup";
            Load += signup_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox Lname;
        private TextBox Fname;
        private Label label3;
        private Button button1;
        private Label label5;
        private Label label4;
        private TextBox pswrd;
        private TextBox Uname;
        private TextBox Designation;
        private ComboBox comboBox1;
        private TextBox textBox7;
        private Label label6;
    }
}