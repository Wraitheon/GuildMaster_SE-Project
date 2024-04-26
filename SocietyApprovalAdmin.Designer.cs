namespace SE
{
    partial class SocietyApprovalAdmin
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ApproveButton = new Button();
            RejectButton = new Button();
            BackButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(BackButton);
            panel1.Controls.Add(RejectButton);
            panel1.Controls.Add(ApproveButton);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 451);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(200, 35);
            label1.Name = "label1";
            label1.Size = new Size(396, 34);
            label1.TabIndex = 0;
            label1.Text = "Society Approval Requests";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(107, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(599, 245);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ApproveButton
            // 
            ApproveButton.Location = new Point(225, 380);
            ApproveButton.Name = "ApproveButton";
            ApproveButton.Size = new Size(94, 29);
            ApproveButton.TabIndex = 2;
            ApproveButton.Text = "Approve";
            ApproveButton.UseVisualStyleBackColor = true;
            ApproveButton.Click += ApproveButton_Click;
            // 
            // RejectButton
            // 
            RejectButton.Location = new Point(460, 380);
            RejectButton.Name = "RejectButton";
            RejectButton.Size = new Size(94, 29);
            RejectButton.TabIndex = 3;
            RejectButton.Text = "Reject";
            RejectButton.UseVisualStyleBackColor = true;
            RejectButton.Click += RejectButton_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(14, 13);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(94, 29);
            BackButton.TabIndex = 4;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // SocietyApprovalAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "SocietyApprovalAdmin";
            Text = "SocietyApprovalAdmin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BackButton;
        private Button RejectButton;
        private Button ApproveButton;
        private DataGridView dataGridView1;
        private Label label1;
    }
}