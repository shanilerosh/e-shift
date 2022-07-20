namespace e_shift.views
{
    partial class CustomerDashBoard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPendingJobs = new System.Windows.Forms.Label();
            this.customerIdNameLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDiscardedJobs = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblAcceptedJobs = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblJobsToday = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblPendingJobs);
            this.panel1.Controls.Add(this.customerIdNameLabel);
            this.panel1.Location = new System.Drawing.Point(184, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 109);
            this.panel1.TabIndex = 0;
            // 
            // lblPendingJobs
            // 
            this.lblPendingJobs.AutoSize = true;
            this.lblPendingJobs.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPendingJobs.Location = new System.Drawing.Point(106, 56);
            this.lblPendingJobs.Name = "lblPendingJobs";
            this.lblPendingJobs.Size = new System.Drawing.Size(0, 23);
            this.lblPendingJobs.TabIndex = 15;
            this.lblPendingJobs.Click += new System.EventHandler(this.label1_Click);
            // 
            // customerIdNameLabel
            // 
            this.customerIdNameLabel.AutoSize = true;
            this.customerIdNameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customerIdNameLabel.Location = new System.Drawing.Point(37, 14);
            this.customerIdNameLabel.Name = "customerIdNameLabel";
            this.customerIdNameLabel.Size = new System.Drawing.Size(154, 23);
            this.customerIdNameLabel.TabIndex = 14;
            this.customerIdNameLabel.Text = "Total Pending Jobs";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.lblDiscardedJobs);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(485, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 109);
            this.panel2.TabIndex = 16;
            // 
            // lblDiscardedJobs
            // 
            this.lblDiscardedJobs.AutoSize = true;
            this.lblDiscardedJobs.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDiscardedJobs.Location = new System.Drawing.Point(106, 56);
            this.lblDiscardedJobs.Name = "lblDiscardedJobs";
            this.lblDiscardedJobs.Size = new System.Drawing.Size(0, 23);
            this.lblDiscardedJobs.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(29, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Total Discarded Jobs";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.lblAcceptedJobs);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(184, 276);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 109);
            this.panel3.TabIndex = 16;
            // 
            // lblAcceptedJobs
            // 
            this.lblAcceptedJobs.AutoSize = true;
            this.lblAcceptedJobs.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAcceptedJobs.Location = new System.Drawing.Point(122, 56);
            this.lblAcceptedJobs.Name = "lblAcceptedJobs";
            this.lblAcceptedJobs.Size = new System.Drawing.Size(0, 23);
            this.lblAcceptedJobs.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(44, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Total Accepted Jobs";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.lblJobsToday);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(485, 276);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(243, 109);
            this.panel4.TabIndex = 17;
            // 
            // lblJobsToday
            // 
            this.lblJobsToday.AutoSize = true;
            this.lblJobsToday.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJobsToday.Location = new System.Drawing.Point(126, 56);
            this.lblJobsToday.Name = "lblJobsToday";
            this.lblJobsToday.Size = new System.Drawing.Size(0, 23);
            this.lblJobsToday.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(47, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Total Completed Jobs";
            // 
            // CustomerDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(838, 470);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerDashBoard";
            this.Text = "CustomerDashBoard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label customerIdNameLabel;
        private Label lblPendingJobs;
        private Panel panel2;
        private Label lblDiscardedJobs;
        private Label label2;
        private Panel panel3;
        private Label lblAcceptedJobs;
        private Label label3;
        private Panel panel4;
        private Label lblJobsToday;
        private Label label4;
    }
}