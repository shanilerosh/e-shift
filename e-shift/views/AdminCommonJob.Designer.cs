namespace e_shift.views
{
    partial class AdminCommonJob
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
            this.itemsGrid = new System.Windows.Forms.DataGridView();
            this.lblJobId = new System.Windows.Forms.Label();
            this.customerIdNameLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datePickerRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblHeader = new System.Windows.Forms.Label();
            this.gridPending = new System.Windows.Forms.DataGridView();
            this.itemAddPanel = new System.Windows.Forms.Panel();
            this.fromPanel = new System.Windows.Forms.Panel();
            this.panelAcceptReject = new System.Windows.Forms.Panel();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPending)).BeginInit();
            this.itemAddPanel.SuspendLayout();
            this.fromPanel.SuspendLayout();
            this.panelAcceptReject.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemsGrid
            // 
            this.itemsGrid.AllowUserToAddRows = false;
            this.itemsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsGrid.Location = new System.Drawing.Point(7, 60);
            this.itemsGrid.MultiSelect = false;
            this.itemsGrid.Name = "itemsGrid";
            this.itemsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.itemsGrid.RowTemplate.Height = 25;
            this.itemsGrid.Size = new System.Drawing.Size(400, 85);
            this.itemsGrid.TabIndex = 11;
            // 
            // lblJobId
            // 
            this.lblJobId.AutoSize = true;
            this.lblJobId.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJobId.Location = new System.Drawing.Point(312, -1);
            this.lblJobId.Name = "lblJobId";
            this.lblJobId.Size = new System.Drawing.Size(0, 23);
            this.lblJobId.TabIndex = 12;
            // 
            // customerIdNameLabel
            // 
            this.customerIdNameLabel.AutoSize = true;
            this.customerIdNameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customerIdNameLabel.Location = new System.Drawing.Point(240, -1);
            this.customerIdNameLabel.Name = "customerIdNameLabel";
            this.customerIdNameLabel.Size = new System.Drawing.Size(66, 23);
            this.customerIdNameLabel.TabIndex = 13;
            this.customerIdNameLabel.Text = "Job ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(203)))), ((int)(((byte)(135)))));
            this.label6.Location = new System.Drawing.Point(7, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Items";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(19, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(17, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Remarks";
            // 
            // txtLocation
            // 
            this.txtLocation.Enabled = false;
            this.txtLocation.Location = new System.Drawing.Point(17, 18);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(229, 23);
            this.txtLocation.TabIndex = 7;
            // 
            // txtRemark
            // 
            this.txtRemark.Enabled = false;
            this.txtRemark.Location = new System.Drawing.Point(9, 136);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(268, 65);
            this.txtRemark.TabIndex = 18;
            this.txtRemark.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 14);
            this.label2.TabIndex = 19;
            this.label2.Text = "Required Date";
            // 
            // datePickerRequiredDate
            // 
            this.datePickerRequiredDate.Enabled = false;
            this.datePickerRequiredDate.Location = new System.Drawing.Point(13, 77);
            this.datePickerRequiredDate.Name = "datePickerRequiredDate";
            this.datePickerRequiredDate.Size = new System.Drawing.Size(233, 23);
            this.datePickerRequiredDate.TabIndex = 21;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.Location = new System.Drawing.Point(39, -1);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(0, 23);
            this.lblHeader.TabIndex = 25;
            // 
            // gridPending
            // 
            this.gridPending.AllowUserToAddRows = false;
            this.gridPending.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPending.Location = new System.Drawing.Point(46, 49);
            this.gridPending.MultiSelect = false;
            this.gridPending.Name = "gridPending";
            this.gridPending.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridPending.RowTemplate.Height = 25;
            this.gridPending.Size = new System.Drawing.Size(406, 204);
            this.gridPending.TabIndex = 26;
            this.gridPending.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.On_Row_Click);
            // 
            // itemAddPanel
            // 
            this.itemAddPanel.Controls.Add(this.itemsGrid);
            this.itemAddPanel.Controls.Add(this.label6);
            this.itemAddPanel.Location = new System.Drawing.Point(45, 254);
            this.itemAddPanel.Name = "itemAddPanel";
            this.itemAddPanel.Size = new System.Drawing.Size(441, 167);
            this.itemAddPanel.TabIndex = 27;
            // 
            // fromPanel
            // 
            this.fromPanel.Controls.Add(this.txtRemark);
            this.fromPanel.Controls.Add(this.label4);
            this.fromPanel.Controls.Add(this.label5);
            this.fromPanel.Controls.Add(this.txtLocation);
            this.fromPanel.Controls.Add(this.datePickerRequiredDate);
            this.fromPanel.Controls.Add(this.label2);
            this.fromPanel.Location = new System.Drawing.Point(500, 40);
            this.fromPanel.Name = "fromPanel";
            this.fromPanel.Size = new System.Drawing.Size(288, 271);
            this.fromPanel.TabIndex = 28;
            // 
            // panelAcceptReject
            // 
            this.panelAcceptReject.Controls.Add(this.btnReject);
            this.panelAcceptReject.Controls.Add(this.btnAccept);
            this.panelAcceptReject.Location = new System.Drawing.Point(509, 354);
            this.panelAcceptReject.Name = "panelAcceptReject";
            this.panelAcceptReject.Size = new System.Drawing.Size(268, 55);
            this.panelAcceptReject.TabIndex = 29;
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReject.FlatAppearance.BorderSize = 0;
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReject.ForeColor = System.Drawing.Color.White;
            this.btnReject.Location = new System.Drawing.Point(143, 16);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(94, 23);
            this.btnReject.TabIndex = 34;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.Btn_Reject_Job_Handle);
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(130)))));
            this.btnAccept.FlatAppearance.BorderSize = 0;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAccept.ForeColor = System.Drawing.Color.White;
            this.btnAccept.Location = new System.Drawing.Point(26, 16);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(81, 23);
            this.btnAccept.TabIndex = 33;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.Btn_Accept_Job_Handle);
            // 
            // AdminCommonJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 421);
            this.Controls.Add(this.panelAcceptReject);
            this.Controls.Add(this.fromPanel);
            this.Controls.Add(this.itemAddPanel);
            this.Controls.Add(this.gridPending);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.customerIdNameLabel);
            this.Controls.Add(this.lblJobId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "AdminCommonJob";
            this.Text = "Job View";
            ((System.ComponentModel.ISupportInitialize)(this.itemsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPending)).EndInit();
            this.itemAddPanel.ResumeLayout(false);
            this.itemAddPanel.PerformLayout();
            this.fromPanel.ResumeLayout(false);
            this.fromPanel.PerformLayout();
            this.panelAcceptReject.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private DataGridView itemsGrid;
        private Label lblJobId;
        private Label customerIdNameLabel;
        private Label label6;
        private Label label4;
        private Label label5;
        private TextBox txtLocation;
        private RichTextBox txtRemark;
        private Label label2;
        private DateTimePicker datePickerRequiredDate;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblHeader;
        private DataGridView gridPending;
        private Panel itemAddPanel;
        private Panel fromPanel;
        private Panel panelAcceptReject;
        private Button btnReject;
        private Button btnAccept;
    }
}