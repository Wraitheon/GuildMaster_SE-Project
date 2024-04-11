namespace login
{
    partial class forgotpassword
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
            label5 = new Label();
            button2 = new Button();
            UnameF = new TextBox();
            label4 = new Label();
            label3 = new Label();
            button1 = new Button();
            label2 = new Label();
            pswrdN = new TextBox();
            SecF = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(UnameF);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pswrdN);
            panel1.Controls.Add(SecF);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(25, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(738, 386);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(301, 187);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 9;
            label5.Click += label5_Click;
            // 
            // button2
            // 
            button2.Location = new Point(251, 136);
            button2.Name = "button2";
            button2.Size = new Size(239, 34);
            button2.TabIndex = 8;
            button2.Text = "FIND ACCOUNT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // UnameF
            // 
            UnameF.Location = new Point(301, 81);
            UnameF.Name = "UnameF";
            UnameF.Size = new Size(150, 31);
            UnameF.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(165, 84);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 6;
            label4.Text = "Username";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(313, 12);
            label3.Name = "label3";
            label3.Size = new Size(129, 25);
            label3.TabIndex = 5;
            label3.Text = "GUILDMASTER";
            // 
            // button1
            // 
            button1.Location = new Point(281, 335);
            button1.Name = "button1";
            button1.Size = new Size(161, 34);
            button1.TabIndex = 4;
            button1.Text = "Change Password";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 289);
            label2.Name = "label2";
            label2.Size = new Size(136, 25);
            label2.TabIndex = 3;
            label2.Text = "New Password :";
            label2.Click += label2_Click;
            // 
            // pswrdN
            // 
            pswrdN.Location = new Point(292, 283);
            pswrdN.Name = "pswrdN";
            pswrdN.Size = new Size(150, 31);
            pswrdN.TabIndex = 2;
            // 
            // SecF
            // 
            SecF.Location = new Point(292, 228);
            SecF.Name = "SecF";
            SecF.Size = new Size(150, 31);
            SecF.TabIndex = 1;
            SecF.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 234);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 0;
            label1.Text = "Security ";
            label1.Click += label1_Click;
            // 
            // forgotpassword
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "forgotpassword";
            Text = "forgotpassword";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox pswrdN;
        private TextBox SecF;
        private Button button1;
        private Label label3;
        private Label label4;
        private Button button2;
        private TextBox UnameF;
        private Label label5;
    }
}