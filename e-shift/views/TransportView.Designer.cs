namespace e_shift.views
{
    partial class TransportView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVehicleNo = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gridTransportUnit = new System.Windows.Forms.DataGridView();
            this.lblTransportId = new System.Windows.Forms.Label();
            this.customerIdNameLabel = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.searchCombo = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboVehicleType = new System.Windows.Forms.ComboBox();
            this.txtCapacity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransportUnit)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transport Unit Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(46, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vehicle Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(50, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vehicle Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(267, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Model";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(486, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Remarks";
            // 
            // txtVehicleNo
            // 
            this.txtVehicleNo.Location = new System.Drawing.Point(49, 195);
            this.txtVehicleNo.Name = "txtVehicleNo";
            this.txtVehicleNo.Size = new System.Drawing.Size(179, 23);
            this.txtVehicleNo.TabIndex = 6;
            this.txtVehicleNo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(264, 131);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(179, 23);
            this.txtModel.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(130)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(486, 246);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(85, 23);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Create";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_onClick);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(140)))), ((int)(((byte)(36)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(48, 244);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_onClick);
            // 
            // gridTransportUnit
            // 
            this.gridTransportUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTransportUnit.Location = new System.Drawing.Point(46, 338);
            this.gridTransportUnit.MultiSelect = false;
            this.gridTransportUnit.Name = "gridTransportUnit";
            this.gridTransportUnit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridTransportUnit.RowTemplate.Height = 25;
            this.gridTransportUnit.Size = new System.Drawing.Size(654, 196);
            this.gridTransportUnit.TabIndex = 11;
            this.gridTransportUnit.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.On_Row_Click);
            // 
            // lblCustId
            // 
            this.lblTransportId.AutoSize = true;
            this.lblTransportId.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTransportId.Location = new System.Drawing.Point(622, 57);
            this.lblTransportId.Name = "lblCustId";
            this.lblTransportId.Size = new System.Drawing.Size(0, 23);
            this.lblTransportId.TabIndex = 12;
            // 
            // customerIdNameLabel
            // 
            this.customerIdNameLabel.AutoSize = true;
            this.customerIdNameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customerIdNameLabel.Location = new System.Drawing.Point(445, 57);
            this.customerIdNameLabel.Name = "customerIdNameLabel";
            this.customerIdNameLabel.Size = new System.Drawing.Size(154, 23);
            this.customerIdNameLabel.TabIndex = 13;
            this.customerIdNameLabel.Text = "Transport Unit ID :";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(600, 244);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 24);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(167, 309);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Type to search";
            this.txtSearch.Size = new System.Drawing.Size(204, 23);
            this.txtSearch.TabIndex = 15;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtsearch_Change);
            // 
            // searchCombo
            // 
            this.searchCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchCombo.FormattingEnabled = true;
            this.searchCombo.Location = new System.Drawing.Point(50, 309);
            this.searchCombo.Name = "searchCombo";
            this.searchCombo.Size = new System.Drawing.Size(93, 23);
            this.searchCombo.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1196, 55);
            this.panel1.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(203)))), ((int)(((byte)(135)))));
            this.label6.Location = new System.Drawing.Point(46, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Add Transport Unit";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(486, 131);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(194, 87);
            this.txtRemark.TabIndex = 18;
            this.txtRemark.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(265, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 14);
            this.label7.TabIndex = 19;
            this.label7.Text = "Capacity";
            // 
            // comboVehicleType
            // 
            this.comboVehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVehicleType.FormattingEnabled = true;
            this.comboVehicleType.Location = new System.Drawing.Point(50, 128);
            this.comboVehicleType.Name = "comboVehicleType";
            this.comboVehicleType.Size = new System.Drawing.Size(178, 23);
            this.comboVehicleType.TabIndex = 21;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(264, 196);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(179, 23);
            this.txtCapacity.TabIndex = 22;
            // 
            // TransportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(719, 546);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.comboVehicleType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchCombo);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.customerIdNameLabel);
            this.Controls.Add(this.lblTransportId);
            this.Controls.Add(this.gridTransportUnit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtVehicleNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "TransportView";
            this.Text = "CustomerView";
            ((System.ComponentModel.ISupportInitialize)(this.gridTransportUnit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtVehicleNo;
        private TextBox txtModel;
        private Button btnSubmit;
        private Button btnReset;
        private DataGridView gridTransportUnit;
        private Label lblTransportId;
        private Label customerIdNameLabel;
        private Button btnDelete;
        private TextBox txtSearch;
        private ComboBox searchCombo;
        private Panel panel1;
        private Label label6;
        private RichTextBox txtRemark;
        private Label label7;
        private ComboBox comboVehicleType;
        private NumericUpDown txtCapacity;
    }
}