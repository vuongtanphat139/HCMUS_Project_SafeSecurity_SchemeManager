namespace Project_SS.Forms
{
    partial class Admin
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
            this.btn_User = new System.Windows.Forms.Button();
            this.btn_Role = new System.Windows.Forms.Button();
            this.panel_Container = new System.Windows.Forms.Panel();
            this.label_Exit = new System.Windows.Forms.Label();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.Audit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_User
            // 
            this.btn_User.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(121)))), ((int)(((byte)(195)))));
            this.btn_User.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_User.FlatAppearance.BorderSize = 0;
            this.btn_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_User.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.btn_User.ForeColor = System.Drawing.Color.White;
            this.btn_User.Location = new System.Drawing.Point(0, 41);
            this.btn_User.Margin = new System.Windows.Forms.Padding(0);
            this.btn_User.Name = "btn_User";
            this.btn_User.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_User.Size = new System.Drawing.Size(600, 79);
            this.btn_User.TabIndex = 2;
            this.btn_User.Text = "USER";
            this.btn_User.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_User.UseVisualStyleBackColor = false;
            this.btn_User.Click += new System.EventHandler(this.btn_User_Click);
            // 
            // btn_Role
            // 
            this.btn_Role.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Role.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(138)))));
            this.btn_Role.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Role.FlatAppearance.BorderSize = 0;
            this.btn_Role.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Role.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.btn_Role.ForeColor = System.Drawing.Color.White;
            this.btn_Role.Location = new System.Drawing.Point(600, 38);
            this.btn_Role.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Role.Name = "btn_Role";
            this.btn_Role.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Role.Size = new System.Drawing.Size(600, 82);
            this.btn_Role.TabIndex = 3;
            this.btn_Role.Text = "ROLE";
            this.btn_Role.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Role.UseVisualStyleBackColor = false;
            this.btn_Role.Click += new System.EventHandler(this.btn_Role_Click);
            // 
            // panel_Container
            // 
            this.panel_Container.Location = new System.Drawing.Point(0, 120);
            this.panel_Container.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Container.Name = "panel_Container";
            this.panel_Container.Size = new System.Drawing.Size(1200, 600);
            this.panel_Container.TabIndex = 4;
            // 
            // label_Exit
            // 
            this.label_Exit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Exit.AutoSize = true;
            this.label_Exit.BackColor = System.Drawing.Color.White;
            this.label_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Exit.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(19)))), ((int)(((byte)(117)))));
            this.label_Exit.Location = new System.Drawing.Point(1171, -3);
            this.label_Exit.Name = "label_Exit";
            this.label_Exit.Size = new System.Drawing.Size(34, 41);
            this.label_Exit.TabIndex = 9;
            this.label_Exit.Text = "x";
            this.label_Exit.Click += new System.EventHandler(this.label_Exit_Click);
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAboutUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAboutUs.FlatAppearance.BorderSize = 0;
            this.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutUs.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnAboutUs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(85)))));
            this.btnAboutUs.Image = global::Project_SS.Properties.Resources.logout__4_;
            this.btnAboutUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutUs.Location = new System.Drawing.Point(2, -1);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Size = new System.Drawing.Size(123, 35);
            this.btnAboutUs.TabIndex = 10;
            this.btnAboutUs.Text = "       Logout";
            this.btnAboutUs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutUs.UseVisualStyleBackColor = true;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // Audit
            // 
            this.Audit.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Audit.Location = new System.Drawing.Point(1126, 38);
            this.Audit.Name = "Audit";
            this.Audit.Size = new System.Drawing.Size(74, 31);
            this.Audit.TabIndex = 0;
            this.Audit.Text = "Audit";
            this.Audit.UseVisualStyleBackColor = true;
            this.Audit.Click += new System.EventHandler(this.Audit_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.Audit);
            this.Controls.Add(this.btnAboutUs);
            this.Controls.Add(this.label_Exit);
            this.Controls.Add(this.panel_Container);
            this.Controls.Add(this.btn_Role);
            this.Controls.Add(this.btn_User);
            this.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_User;
        private System.Windows.Forms.Button btn_Role;
        private System.Windows.Forms.Panel panel_Container;
        private System.Windows.Forms.Label label_Exit;
        private System.Windows.Forms.Button btnAboutUs;
        private System.Windows.Forms.Button Audit;
    }
}