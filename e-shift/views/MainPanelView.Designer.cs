namespace e_shift.views
{
    partial class MainPanelView
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelMainCustomer = new System.Windows.Forms.Panel();
            this.btnItemsMain = new System.Windows.Forms.Button();
            this.btnLoadMain = new System.Windows.Forms.Button();
            this.btnCustomerMain = new System.Windows.Forms.Button();
            this.btnDashBoardMain = new System.Windows.Forms.Button();
            this.btnJobMain = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelMainCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panelMainCustomer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 447);
            this.panel1.TabIndex = 0;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserName.Location = new System.Drawing.Point(78, 9);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(0, 14);
            this.lblUserName.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 14);
            this.label3.TabIndex = 31;
            this.label3.Text = "Welcome ,";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panelMainCustomer
            // 
            this.panelMainCustomer.Controls.Add(this.btnItemsMain);
            this.panelMainCustomer.Controls.Add(this.btnLoadMain);
            this.panelMainCustomer.Controls.Add(this.btnCustomerMain);
            this.panelMainCustomer.Controls.Add(this.btnDashBoardMain);
            this.panelMainCustomer.Controls.Add(this.btnJobMain);
            this.panelMainCustomer.Location = new System.Drawing.Point(12, 45);
            this.panelMainCustomer.Name = "panelMainCustomer";
            this.panelMainCustomer.Size = new System.Drawing.Size(124, 359);
            this.panelMainCustomer.TabIndex = 5;
            // 
            // btnItemsMain
            // 
            this.btnItemsMain.BackColor = System.Drawing.Color.SlateGray;
            this.btnItemsMain.Location = new System.Drawing.Point(8, 321);
            this.btnItemsMain.Name = "btnItemsMain";
            this.btnItemsMain.Size = new System.Drawing.Size(113, 37);
            this.btnItemsMain.TabIndex = 7;
            this.btnItemsMain.Text = "Paraameters";
            this.btnItemsMain.UseVisualStyleBackColor = false;
            this.btnItemsMain.Click += new System.EventHandler(this.Btn_Item_Panel_Click);
            // 
            // btnLoadMain
            // 
            this.btnLoadMain.BackColor = System.Drawing.Color.SlateGray;
            this.btnLoadMain.Location = new System.Drawing.Point(6, 242);
            this.btnLoadMain.Name = "btnLoadMain";
            this.btnLoadMain.Size = new System.Drawing.Size(113, 37);
            this.btnLoadMain.TabIndex = 6;
            this.btnLoadMain.Text = "Load";
            this.btnLoadMain.UseVisualStyleBackColor = false;
            this.btnLoadMain.Click += new System.EventHandler(this.btnLoadMain_Click);
            // 
            // btnCustomerMain
            // 
            this.btnCustomerMain.BackColor = System.Drawing.Color.SlateGray;
            this.btnCustomerMain.Location = new System.Drawing.Point(7, 173);
            this.btnCustomerMain.Name = "btnCustomerMain";
            this.btnCustomerMain.Size = new System.Drawing.Size(113, 37);
            this.btnCustomerMain.TabIndex = 5;
            this.btnCustomerMain.Text = "Manage Customer";
            this.btnCustomerMain.UseVisualStyleBackColor = false;
            this.btnCustomerMain.Click += new System.EventHandler(this.Manage_Customer_Btn_Click);
            // 
            // btnDashBoardMain
            // 
            this.btnDashBoardMain.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDashBoardMain.Location = new System.Drawing.Point(8, 27);
            this.btnDashBoardMain.Name = "btnDashBoardMain";
            this.btnDashBoardMain.Size = new System.Drawing.Size(113, 37);
            this.btnDashBoardMain.TabIndex = 4;
            this.btnDashBoardMain.Text = "Dashboard";
            this.btnDashBoardMain.UseVisualStyleBackColor = false;
            this.btnDashBoardMain.Click += new System.EventHandler(this.Btn_Customer_DashBoard_Click);
            // 
            // btnJobMain
            // 
            this.btnJobMain.BackColor = System.Drawing.Color.SlateGray;
            this.btnJobMain.Location = new System.Drawing.Point(8, 104);
            this.btnJobMain.Name = "btnJobMain";
            this.btnJobMain.Size = new System.Drawing.Size(113, 37);
            this.btnJobMain.TabIndex = 3;
            this.btnJobMain.Text = "Job";
            this.btnJobMain.UseVisualStyleBackColor = false;
            this.btnJobMain.Click += new System.EventHandler(this.Btn_Cust_Job_Panel_Click);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(164, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(815, 447);
            this.panelMain.TabIndex = 1;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // MainPanelView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 447);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.Name = "MainPanelView";
            this.Text = "E Shift";
            this.Load += new System.EventHandler(this.MainPanelView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMainCustomer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnJobMain;
        private Panel panel1;
        private Panel panelMain;
        private Button btnDashBoardMain;
        private Panel panelMainCustomer;
        private Label label3;
        private Label lblUserName;
        private Button btnCustomerMain;
        private Button btnLoadMain;
        private Button btnItemsMain;
    }
}