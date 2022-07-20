namespace e_shift.views
{
    partial class JobViewPending
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
            this.btnUpdateJob = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.itemsGrid = new System.Windows.Forms.DataGridView();
            this.lblJobId = new System.Windows.Forms.Label();
            this.customerIdNameLabel = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datePickerRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboItem = new System.Windows.Forms.ComboBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtQty = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.gridPending = new System.Windows.Forms.DataGridView();
            this.itemAddPanel = new System.Windows.Forms.Panel();
            this.fromPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPending)).BeginInit();
            this.itemAddPanel.SuspendLayout();
            this.fromPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdateJob
            // 
            this.btnUpdateJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(130)))));
            this.btnUpdateJob.FlatAppearance.BorderSize = 0;
            this.btnUpdateJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateJob.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateJob.ForeColor = System.Drawing.Color.White;
            this.btnUpdateJob.Location = new System.Drawing.Point(526, 386);
            this.btnUpdateJob.Name = "btnUpdateJob";
            this.btnUpdateJob.Size = new System.Drawing.Size(216, 23);
            this.btnUpdateJob.TabIndex = 9;
            this.btnUpdateJob.Text = "Update Job";
            this.btnUpdateJob.UseVisualStyleBackColor = false;
            this.btnUpdateJob.Click += new System.EventHandler(this.btnSubmit_onClick);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(140)))), ((int)(((byte)(36)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(9, 214);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(103, 25);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_onClick);
            // 
            // itemsGrid
            // 
            this.itemsGrid.AllowUserToAddRows = false;
            this.itemsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsGrid.Location = new System.Drawing.Point(7, 74);
            this.itemsGrid.MultiSelect = false;
            this.itemsGrid.Name = "itemsGrid";
            this.itemsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.itemsGrid.RowTemplate.Height = 25;
            this.itemsGrid.Size = new System.Drawing.Size(400, 85);
            this.itemsGrid.TabIndex = 11;
            this.itemsGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Add_Items_Mouse_Click_Handle);
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
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(337, 44);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(51, 24);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(203)))), ((int)(((byte)(135)))));
            this.label6.Location = new System.Drawing.Point(7, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Add Item";
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
            this.txtLocation.Location = new System.Drawing.Point(17, 18);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(229, 23);
            this.txtLocation.TabIndex = 7;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(9, 136);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(268, 65);
            this.txtRemark.TabIndex = 18;
            this.txtRemark.Text = "";
            this.txtRemark.TextChanged += new System.EventHandler(this.txtRemark_TextChanged);
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // datePickerRequiredDate
            // 
            this.datePickerRequiredDate.Location = new System.Drawing.Point(13, 77);
            this.datePickerRequiredDate.Name = "datePickerRequiredDate";
            this.datePickerRequiredDate.Size = new System.Drawing.Size(233, 23);
            this.datePickerRequiredDate.TabIndex = 21;
            this.datePickerRequiredDate.ValueChanged += new System.EventHandler(this.datePickerRequiredDate_ValueChanged);
            // 
            // comboItem
            // 
            this.comboItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboItem.FormattingEnabled = true;
            this.comboItem.Location = new System.Drawing.Point(7, 44);
            this.comboItem.Name = "comboItem";
            this.comboItem.Size = new System.Drawing.Size(134, 23);
            this.comboItem.TabIndex = 22;
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(130)))));
            this.btnAddItem.FlatAppearance.BorderSize = 0;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(260, 44);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(57, 23);
            this.btnAddItem.TabIndex = 23;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.Btn_Add_Item);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(147, 45);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(90, 23);
            this.txtQty.TabIndex = 24;
            this.txtQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "My Pending Basket";
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
            this.itemAddPanel.Controls.Add(this.btnAddItem);
            this.itemAddPanel.Controls.Add(this.btnDelete);
            this.itemAddPanel.Controls.Add(this.comboItem);
            this.itemAddPanel.Controls.Add(this.label6);
            this.itemAddPanel.Controls.Add(this.txtQty);
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
            this.fromPanel.Controls.Add(this.btnReset);
            this.fromPanel.Location = new System.Drawing.Point(500, 40);
            this.fromPanel.Name = "fromPanel";
            this.fromPanel.Size = new System.Drawing.Size(288, 271);
            this.fromPanel.TabIndex = 28;
            // 
            // JobViewPending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 421);
            this.Controls.Add(this.fromPanel);
            this.Controls.Add(this.itemAddPanel);
            this.Controls.Add(this.gridPending);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerIdNameLabel);
            this.Controls.Add(this.lblJobId);
            this.Controls.Add(this.btnUpdateJob);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "JobViewPending";
            this.Text = "Job View";
            this.Load += new System.EventHandler(this.JobView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPending)).EndInit();
            this.itemAddPanel.ResumeLayout(false);
            this.itemAddPanel.PerformLayout();
            this.fromPanel.ResumeLayout(false);
            this.fromPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private Button btnUpdateJob;
        private Button btnReset;
        private DataGridView itemsGrid;
        private Label lblJobId;
        private Label customerIdNameLabel;
        private Button btnDelete;
        private Label label6;
        private Label label4;
        private Label label5;
        private TextBox txtLocation;
        private RichTextBox txtRemark;
        private Label label2;
        private DateTimePicker datePickerRequiredDate;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox comboItem;
        private Button btnAddItem;
        private NumericUpDown txtQty;
        private Label label1;
        private DataGridView gridPending;
        private Panel itemAddPanel;
        private Panel fromPanel;
    }
}