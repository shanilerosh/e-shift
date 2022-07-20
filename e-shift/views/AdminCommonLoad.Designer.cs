namespace e_shift.views
{
    partial class AdminCommonLoad
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelLoad = new System.Windows.Forms.Panel();
            this.gridLoad = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRemarkLoad = new System.Windows.Forms.RichTextBox();
            this.btnDeleteLoad = new System.Windows.Forms.Button();
            this.btnAddLoad = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboVehicleNo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboDriver = new System.Windows.Forms.ComboBox();
            this.btnCompleteLoad = new System.Windows.Forms.Button();
            this.loadDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPending)).BeginInit();
            this.itemAddPanel.SuspendLayout();
            this.fromPanel.SuspendLayout();
            this.panelLoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // itemsGrid
            // 
            this.itemsGrid.AllowUserToAddRows = false;
            this.itemsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsGrid.Location = new System.Drawing.Point(11, 9);
            this.itemsGrid.MultiSelect = false;
            this.itemsGrid.Name = "itemsGrid";
            this.itemsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.itemsGrid.RowTemplate.Height = 25;
            this.itemsGrid.Size = new System.Drawing.Size(227, 85);
            this.itemsGrid.TabIndex = 11;
            this.itemsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsGrid_CellContentClick);
            // 
            // lblJobId
            // 
            this.lblJobId.AutoSize = true;
            this.lblJobId.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJobId.Location = new System.Drawing.Point(610, 9);
            this.lblJobId.Name = "lblJobId";
            this.lblJobId.Size = new System.Drawing.Size(0, 23);
            this.lblJobId.TabIndex = 12;
            // 
            // customerIdNameLabel
            // 
            this.customerIdNameLabel.AutoSize = true;
            this.customerIdNameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customerIdNameLabel.Location = new System.Drawing.Point(538, 9);
            this.customerIdNameLabel.Name = "customerIdNameLabel";
            this.customerIdNameLabel.Size = new System.Drawing.Size(66, 23);
            this.customerIdNameLabel.TabIndex = 13;
            this.customerIdNameLabel.Text = "Job ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(68, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(69, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Remarks";
            // 
            // txtLocation
            // 
            this.txtLocation.Enabled = false;
            this.txtLocation.Location = new System.Drawing.Point(64, 17);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(182, 23);
            this.txtLocation.TabIndex = 7;
            // 
            // txtRemark
            // 
            this.txtRemark.Enabled = false;
            this.txtRemark.Location = new System.Drawing.Point(65, 111);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(180, 49);
            this.txtRemark.TabIndex = 18;
            this.txtRemark.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(64, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 14);
            this.label2.TabIndex = 19;
            this.label2.Text = "Required Date";
            // 
            // datePickerRequiredDate
            // 
            this.datePickerRequiredDate.Enabled = false;
            this.datePickerRequiredDate.Location = new System.Drawing.Point(64, 64);
            this.datePickerRequiredDate.Name = "datePickerRequiredDate";
            this.datePickerRequiredDate.Size = new System.Drawing.Size(182, 23);
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
            this.gridPending.Location = new System.Drawing.Point(27, 40);
            this.gridPending.MultiSelect = false;
            this.gridPending.Name = "gridPending";
            this.gridPending.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridPending.RowTemplate.Height = 25;
            this.gridPending.Size = new System.Drawing.Size(494, 94);
            this.gridPending.TabIndex = 26;
            this.gridPending.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.On_Row_Click);
            // 
            // itemAddPanel
            // 
            this.itemAddPanel.Controls.Add(this.itemsGrid);
            this.itemAddPanel.Location = new System.Drawing.Point(527, 40);
            this.itemAddPanel.Name = "itemAddPanel";
            this.itemAddPanel.Size = new System.Drawing.Size(257, 106);
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
            this.fromPanel.Location = new System.Drawing.Point(538, 172);
            this.fromPanel.Name = "fromPanel";
            this.fromPanel.Size = new System.Drawing.Size(250, 202);
            this.fromPanel.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "Create Load";
            // 
            // panelLoad
            // 
            this.panelLoad.Controls.Add(this.loadDate);
            this.panelLoad.Controls.Add(this.label8);
            this.panelLoad.Controls.Add(this.gridLoad);
            this.panelLoad.Controls.Add(this.label7);
            this.panelLoad.Controls.Add(this.txtRemarkLoad);
            this.panelLoad.Controls.Add(this.btnDeleteLoad);
            this.panelLoad.Controls.Add(this.btnAddLoad);
            this.panelLoad.Controls.Add(this.label6);
            this.panelLoad.Controls.Add(this.comboVehicleNo);
            this.panelLoad.Controls.Add(this.label3);
            this.panelLoad.Controls.Add(this.comboDriver);
            this.panelLoad.Location = new System.Drawing.Point(27, 140);
            this.panelLoad.Name = "panelLoad";
            this.panelLoad.Size = new System.Drawing.Size(505, 269);
            this.panelLoad.TabIndex = 30;
            // 
            // gridLoad
            // 
            this.gridLoad.AllowUserToAddRows = false;
            this.gridLoad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLoad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLoad.Location = new System.Drawing.Point(12, 119);
            this.gridLoad.Name = "gridLoad";
            this.gridLoad.RowTemplate.Height = 25;
            this.gridLoad.Size = new System.Drawing.Size(482, 150);
            this.gridLoad.TabIndex = 35;
            this.gridLoad.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Row_Click_Load_Grid);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(300, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 14);
            this.label7.TabIndex = 34;
            this.label7.Text = "Remark";
            // 
            // txtRemarkLoad
            // 
            this.txtRemarkLoad.Location = new System.Drawing.Point(300, 33);
            this.txtRemarkLoad.Name = "txtRemarkLoad";
            this.txtRemarkLoad.Size = new System.Drawing.Size(180, 39);
            this.txtRemarkLoad.TabIndex = 22;
            this.txtRemarkLoad.Text = "";
            // 
            // btnDeleteLoad
            // 
            this.btnDeleteLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteLoad.FlatAppearance.BorderSize = 0;
            this.btnDeleteLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteLoad.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteLoad.ForeColor = System.Drawing.Color.White;
            this.btnDeleteLoad.Location = new System.Drawing.Point(403, 80);
            this.btnDeleteLoad.Name = "btnDeleteLoad";
            this.btnDeleteLoad.Size = new System.Drawing.Size(77, 23);
            this.btnDeleteLoad.TabIndex = 33;
            this.btnDeleteLoad.Text = "Delete Load";
            this.btnDeleteLoad.UseVisualStyleBackColor = false;
            this.btnDeleteLoad.Click += new System.EventHandler(this.Btn_Delete_Load_Click_Handle);
            // 
            // btnAddLoad
            // 
            this.btnAddLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(130)))));
            this.btnAddLoad.FlatAppearance.BorderSize = 0;
            this.btnAddLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLoad.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddLoad.ForeColor = System.Drawing.Color.White;
            this.btnAddLoad.Location = new System.Drawing.Point(300, 80);
            this.btnAddLoad.Name = "btnAddLoad";
            this.btnAddLoad.Size = new System.Drawing.Size(80, 23);
            this.btnAddLoad.TabIndex = 28;
            this.btnAddLoad.Text = "Add Load";
            this.btnAddLoad.UseVisualStyleBackColor = false;
            this.btnAddLoad.Click += new System.EventHandler(this.Btn_Add_Load_Click_Handle);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(162, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "Vehicle No";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // comboVehicleNo
            // 
            this.comboVehicleNo.FormattingEnabled = true;
            this.comboVehicleNo.Location = new System.Drawing.Point(162, 32);
            this.comboVehicleNo.Name = "comboVehicleNo";
            this.comboVehicleNo.Size = new System.Drawing.Size(132, 23);
            this.comboVehicleNo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Driver";
            // 
            // comboDriver
            // 
            this.comboDriver.FormattingEnabled = true;
            this.comboDriver.Location = new System.Drawing.Point(12, 33);
            this.comboDriver.Name = "comboDriver";
            this.comboDriver.Size = new System.Drawing.Size(132, 23);
            this.comboDriver.TabIndex = 0;
            this.comboDriver.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnCompleteLoad
            // 
            this.btnCompleteLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(130)))));
            this.btnCompleteLoad.FlatAppearance.BorderSize = 0;
            this.btnCompleteLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompleteLoad.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCompleteLoad.ForeColor = System.Drawing.Color.White;
            this.btnCompleteLoad.Location = new System.Drawing.Point(591, 384);
            this.btnCompleteLoad.Name = "btnCompleteLoad";
            this.btnCompleteLoad.Size = new System.Drawing.Size(189, 29);
            this.btnCompleteLoad.TabIndex = 35;
            this.btnCompleteLoad.Text = "Complete Load";
            this.btnCompleteLoad.UseVisualStyleBackColor = false;
            this.btnCompleteLoad.Click += new System.EventHandler(this.btnCompleteLoad_Click);
            // 
            // loadDate
            // 
            this.loadDate.Location = new System.Drawing.Point(13, 83);
            this.loadDate.Name = "loadDate";
            this.loadDate.Size = new System.Drawing.Size(182, 23);
            this.loadDate.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(13, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 14);
            this.label8.TabIndex = 22;
            this.label8.Text = "Load Rquired Date";
            // 
            // AdminCommonLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 421);
            this.Controls.Add(this.btnCompleteLoad);
            this.Controls.Add(this.panelLoad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fromPanel);
            this.Controls.Add(this.itemAddPanel);
            this.Controls.Add(this.gridPending);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.customerIdNameLabel);
            this.Controls.Add(this.lblJobId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "AdminCommonLoad";
            this.Text = "Job View";
            this.Load += new System.EventHandler(this.AdminCommonLoad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPending)).EndInit();
            this.itemAddPanel.ResumeLayout(false);
            this.fromPanel.ResumeLayout(false);
            this.fromPanel.PerformLayout();
            this.panelLoad.ResumeLayout(false);
            this.panelLoad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLoad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private DataGridView itemsGrid;
        private Label lblJobId;
        private Label customerIdNameLabel;
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
        private Label label1;
        private Panel panelLoad;
        private Label label3;
        private ComboBox comboDriver;
        private Label label6;
        private ComboBox comboVehicleNo;
        private Button btnAddLoad;
        private Label label7;
        private RichTextBox txtRemarkLoad;
        private Button btnDeleteLoad;
        private Button btnCompleteLoad;
        private DataGridView gridLoad;
        private DateTimePicker loadDate;
        private Label label8;
    }
}