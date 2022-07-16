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
            this.btnOrder = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 513);
            this.panel1.TabIndex = 0;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(43, 132);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(113, 37);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Customer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(194, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(710, 513);
            this.panelMain.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(710, 33);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Logged User :";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUser.Location = new System.Drawing.Point(401, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 15);
            this.lblUser.TabIndex = 0;
            // 
            // MainPanelView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 513);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.Name = "MainPanelView";
            this.Text = "MainPanelView";
            this.Load += new System.EventHandler(this.MainPanelView_Load);
            this.panel1.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Button button2;
        private Panel panelMain;
        private Button btnOrder;
        private Panel panel2;
        private Label label1;
        private Label lblUser;
    }
}