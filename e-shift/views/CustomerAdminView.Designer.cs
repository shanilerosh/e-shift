namespace e_shift.views
{
    partial class CustomerAdminView
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
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gridCustomer = new System.Windows.Forms.DataGridView();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.customerIdNameLabel = new System.Windows.Forms.Label();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.searchCombo = new System.Windows.Forms.ComboBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.txtNic = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Approve Reject Customers";
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(130)))));
            this.btnApprove.FlatAppearance.BorderSize = 0;
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnApprove.ForeColor = System.Drawing.Color.White;
            this.btnApprove.Location = new System.Drawing.Point(491, 183);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(142, 23);
            this.btnApprove.TabIndex = 9;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.Btn_Approve_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(140)))), ((int)(((byte)(36)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(44, 183);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_onClick);
            // 
            // gridCustomer
            // 
            this.gridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCustomer.Location = new System.Drawing.Point(37, 269);
            this.gridCustomer.MultiSelect = false;
            this.gridCustomer.Name = "gridCustomer";
            this.gridCustomer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridCustomer.RowTemplate.Height = 25;
            this.gridCustomer.Size = new System.Drawing.Size(654, 156);
            this.gridCustomer.TabIndex = 11;
            this.gridCustomer.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.On_Row_Click);
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCustomerId.Location = new System.Drawing.Point(633, 11);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(0, 23);
            this.lblCustomerId.TabIndex = 12;
            // 
            // customerIdNameLabel
            // 
            this.customerIdNameLabel.AutoSize = true;
            this.customerIdNameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customerIdNameLabel.Location = new System.Drawing.Point(456, 11);
            this.customerIdNameLabel.Name = "customerIdNameLabel";
            this.customerIdNameLabel.Size = new System.Drawing.Size(108, 23);
            this.customerIdNameLabel.TabIndex = 13;
            this.customerIdNameLabel.Text = "Customer ID";
            // 
            // btnDiscard
            // 
            this.btnDiscard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.btnDiscard.FlatAppearance.BorderSize = 0;
            this.btnDiscard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscard.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDiscard.ForeColor = System.Drawing.Color.White;
            this.btnDiscard.Location = new System.Drawing.Point(491, 223);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(142, 24);
            this.btnDiscard.TabIndex = 14;
            this.btnDiscard.Text = "Discard";
            this.btnDiscard.UseVisualStyleBackColor = false;
            this.btnDiscard.Click += new System.EventHandler(this.Btn_Discard_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(159, 224);
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
            this.searchCombo.Location = new System.Drawing.Point(41, 224);
            this.searchCombo.Name = "searchCombo";
            this.searchCombo.Size = new System.Drawing.Size(93, 23);
            this.searchCombo.TabIndex = 16;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Enabled = false;
            this.txtContactNumber.Location = new System.Drawing.Point(255, 144);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(179, 23);
            this.txtContactNumber.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(256, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 14);
            this.label7.TabIndex = 33;
            this.label7.Text = "Contact Number";
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(477, 80);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(194, 87);
            this.txtAddress.TabIndex = 32;
            this.txtAddress.Text = "";
            // 
            // txtNic
            // 
            this.txtNic.Enabled = false;
            this.txtNic.Location = new System.Drawing.Point(255, 80);
            this.txtNic.Name = "txtNic";
            this.txtNic.Size = new System.Drawing.Size(179, 23);
            this.txtNic.TabIndex = 31;
            // 
            // txtLastName
            // 
            this.txtLastName.Enabled = false;
            this.txtLastName.Location = new System.Drawing.Point(40, 144);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(179, 23);
            this.txtLastName.TabIndex = 30;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Location = new System.Drawing.Point(37, 80);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(179, 23);
            this.txtFirstName.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(477, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 14);
            this.label5.TabIndex = 28;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(258, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 14);
            this.label4.TabIndex = 27;
            this.label4.Text = "NIC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(41, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 14);
            this.label3.TabIndex = 26;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 14);
            this.label2.TabIndex = 25;
            this.label2.Text = "First Name";
            // 
            // CustomerAdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(836, 535);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtNic);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchCombo);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDiscard);
            this.Controls.Add(this.customerIdNameLabel);
            this.Controls.Add(this.lblCustomerId);
            this.Controls.Add(this.gridCustomer);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnApprove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "CustomerAdminView";
            this.Load += new System.EventHandler(this.CustomerAdminView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private Label label1;
        private Button btnApprove;
        private Button btnReset;
        private DataGridView gridCustomer;
        private Label lblCustomerId;
        private Label customerIdNameLabel;
        private Button btnDiscard;
        private TextBox txtSearch;
        private ComboBox searchCombo;
        private Panel panel1;
        private TextBox txtContactNumber;
        private Label label7;
        private RichTextBox txtAddress;
        private TextBox txtNic;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}