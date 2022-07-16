namespace e_shift.views
{
    partial class LoginView
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblCustId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(356, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(356, 214);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(179, 23);
            this.txtUserName.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(130)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(356, 365);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(85, 23);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Create";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_onClick);
            // 
            // lblCustId
            // 
            this.lblCustId.AutoSize = true;
            this.lblCustId.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCustId.Location = new System.Drawing.Point(622, 57);
            this.lblCustId.Name = "lblCustId";
            this.lblCustId.Size = new System.Drawing.Size(0, 23);
            this.lblCustId.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(356, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 14);
            this.label1.TabIndex = 16;
            this.label1.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(356, 307);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(179, 23);
            this.txtPassword.TabIndex = 17;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 549);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(719, 546);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCustId);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "LoginView";
            this.Text = "CustomerView";
            this.Load += new System.EventHandler(this.LoginView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private Label label2;
        private TextBox txtUserName;
        private Button btnSubmit;
        private Label lblCustId;
        private Label label1;
        private TextBox txtPassword;
        private ContextMenuStrip contextMenuStrip1;
        private Panel panel1;
    }
}