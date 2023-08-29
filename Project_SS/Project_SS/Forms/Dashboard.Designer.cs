namespace Project_SS
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.timerRoll = new System.Windows.Forms.Timer(this.components);
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel_Left = new System.Windows.Forms.Panel();
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.btnProject = new System.Windows.Forms.Button();
            this.btnWorks = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnJobs = new System.Windows.Forms.Button();
            this.panel_Logo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Roll_Dashboard = new System.Windows.Forms.Button();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.label_Exit = new System.Windows.Forms.Label();
            this.panel_Time = new System.Windows.Forms.Panel();
            this.text_Title = new System.Windows.Forms.Label();
            this.panel_Role = new System.Windows.Forms.Panel();
            this.panel_Left.SuspendLayout();
            this.panel_Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_Time.SuspendLayout();
            this.panel_Role.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerRoll
            // 
            this.timerRoll.Tick += new System.EventHandler(this.timerRoll_Tick);
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Location = new System.Drawing.Point(223, 126);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(977, 594);
            this.panelContainer.TabIndex = 6;
            // 
            // panel_Left
            // 
            this.panel_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(121)))), ((int)(((byte)(195)))));
            this.panel_Left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Left.Controls.Add(this.panelSide);
            this.panel_Left.Controls.Add(this.btnAboutUs);
            this.panel_Left.Controls.Add(this.btnProject);
            this.panel_Left.Controls.Add(this.btnWorks);
            this.panel_Left.Controls.Add(this.btnEmployee);
            this.panel_Left.Controls.Add(this.btnJobs);
            this.panel_Left.Controls.Add(this.panel_Logo);
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Left.Location = new System.Drawing.Point(0, 0);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(223, 720);
            this.panel_Left.TabIndex = 4;
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.White;
            this.panelSide.Location = new System.Drawing.Point(0, 158);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(8, 44);
            this.panelSide.TabIndex = 3;
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAboutUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAboutUs.FlatAppearance.BorderSize = 0;
            this.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutUs.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.btnAboutUs.ForeColor = System.Drawing.Color.White;
            this.btnAboutUs.Image = global::Project_SS.Properties.Resources.logout__2_;
            this.btnAboutUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutUs.Location = new System.Drawing.Point(10, 663);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Size = new System.Drawing.Size(206, 44);
            this.btnAboutUs.TabIndex = 1;
            this.btnAboutUs.Text = "         Logout";
            this.btnAboutUs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutUs.UseVisualStyleBackColor = true;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // btnProject
            // 
            this.btnProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProject.FlatAppearance.BorderSize = 0;
            this.btnProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProject.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.btnProject.ForeColor = System.Drawing.Color.White;
            this.btnProject.Image = ((System.Drawing.Image)(resources.GetObject("btnProject.Image")));
            this.btnProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProject.Location = new System.Drawing.Point(10, 339);
            this.btnProject.Name = "btnProject";
            this.btnProject.Size = new System.Drawing.Size(209, 44);
            this.btnProject.TabIndex = 1;
            this.btnProject.Text = "   Project";
            this.btnProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProject.UseVisualStyleBackColor = true;
            this.btnProject.Click += new System.EventHandler(this.btnProject_Click);
            // 
            // btnWorks
            // 
            this.btnWorks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWorks.FlatAppearance.BorderSize = 0;
            this.btnWorks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorks.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.btnWorks.ForeColor = System.Drawing.Color.White;
            this.btnWorks.Image = ((System.Drawing.Image)(resources.GetObject("btnWorks.Image")));
            this.btnWorks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorks.Location = new System.Drawing.Point(9, 277);
            this.btnWorks.Name = "btnWorks";
            this.btnWorks.Size = new System.Drawing.Size(209, 44);
            this.btnWorks.TabIndex = 1;
            this.btnWorks.Text = "   Department";
            this.btnWorks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWorks.UseVisualStyleBackColor = true;
            this.btnWorks.Click += new System.EventHandler(this.btnWorks_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(10, 158);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(209, 44);
            this.btnEmployee.TabIndex = 1;
            this.btnEmployee.Text = "   Employee";
            this.btnEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnJobs
            // 
            this.btnJobs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJobs.FlatAppearance.BorderSize = 0;
            this.btnJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJobs.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.btnJobs.ForeColor = System.Drawing.Color.White;
            this.btnJobs.Image = ((System.Drawing.Image)(resources.GetObject("btnJobs.Image")));
            this.btnJobs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJobs.Location = new System.Drawing.Point(10, 217);
            this.btnJobs.Name = "btnJobs";
            this.btnJobs.Size = new System.Drawing.Size(209, 44);
            this.btnJobs.TabIndex = 1;
            this.btnJobs.Text = "   Assigned Jobs";
            this.btnJobs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnJobs.UseVisualStyleBackColor = true;
            this.btnJobs.Click += new System.EventHandler(this.btnJobs_Click);
            // 
            // panel_Logo
            // 
            this.panel_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(121)))), ((int)(((byte)(195)))));
            this.panel_Logo.Controls.Add(this.pictureBox1);
            this.panel_Logo.Controls.Add(this.btn_Roll_Dashboard);
            this.panel_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Logo.Location = new System.Drawing.Point(0, 0);
            this.panel_Logo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_Logo.Name = "panel_Logo";
            this.panel_Logo.Size = new System.Drawing.Size(221, 121);
            this.panel_Logo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_SS.Properties.Resources.LogoText_white__4x;
            this.pictureBox1.Location = new System.Drawing.Point(39, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Roll_Dashboard
            // 
            this.btn_Roll_Dashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Roll_Dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Roll_Dashboard.FlatAppearance.BorderSize = 0;
            this.btn_Roll_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Roll_Dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_Roll_Dashboard.Image = ((System.Drawing.Image)(resources.GetObject("btn_Roll_Dashboard.Image")));
            this.btn_Roll_Dashboard.Location = new System.Drawing.Point(230, 2);
            this.btn_Roll_Dashboard.Name = "btn_Roll_Dashboard";
            this.btn_Roll_Dashboard.Size = new System.Drawing.Size(46, 44);
            this.btn_Roll_Dashboard.TabIndex = 1;
            this.btn_Roll_Dashboard.UseVisualStyleBackColor = true;
            this.btn_Roll_Dashboard.Click += new System.EventHandler(this.btn_Roll_Dashboard_Click);
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // labelTime
            // 
            this.labelTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.labelTime.Location = new System.Drawing.Point(49, 9);
            this.labelTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(90, 21);
            this.labelTime.TabIndex = 8;
            this.labelTime.Text = "HH:MM:SS";
            // 
            // label_Exit
            // 
            this.label_Exit.AutoSize = true;
            this.label_Exit.BackColor = System.Drawing.Color.White;
            this.label_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_Exit.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(19)))), ((int)(((byte)(117)))));
            this.label_Exit.Location = new System.Drawing.Point(950, 0);
            this.label_Exit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Exit.Name = "label_Exit";
            this.label_Exit.Size = new System.Drawing.Size(27, 32);
            this.label_Exit.TabIndex = 8;
            this.label_Exit.Text = "x";
            this.label_Exit.Click += new System.EventHandler(this.label_Exit_Click);
            // 
            // panel_Time
            // 
            this.panel_Time.BackColor = System.Drawing.Color.White;
            this.panel_Time.Controls.Add(this.label_Exit);
            this.panel_Time.Controls.Add(this.labelTime);
            this.panel_Time.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Time.Location = new System.Drawing.Point(223, 0);
            this.panel_Time.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_Time.Name = "panel_Time";
            this.panel_Time.Size = new System.Drawing.Size(977, 40);
            this.panel_Time.TabIndex = 3;
            // 
            // text_Title
            // 
            this.text_Title.AutoSize = true;
            this.text_Title.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Title.ForeColor = System.Drawing.Color.White;
            this.text_Title.Location = new System.Drawing.Point(410, 19);
            this.text_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.text_Title.Name = "text_Title";
            this.text_Title.Size = new System.Drawing.Size(182, 45);
            this.text_Title.TabIndex = 14;
            this.text_Title.Text = "EMPLOYEE";
            // 
            // panel_Role
            // 
            this.panel_Role.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_Role.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(121)))), ((int)(((byte)(195)))));
            this.panel_Role.Controls.Add(this.text_Title);
            this.panel_Role.Location = new System.Drawing.Point(223, 37);
            this.panel_Role.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_Role.Name = "panel_Role";
            this.panel_Role.Size = new System.Drawing.Size(977, 88);
            this.panel_Role.TabIndex = 5;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.panel_Role);
            this.Controls.Add(this.panel_Time);
            this.Controls.Add(this.panel_Left);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel_Left.ResumeLayout(false);
            this.panel_Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_Time.ResumeLayout(false);
            this.panel_Time.PerformLayout();
            this.panel_Role.ResumeLayout(false);
            this.panel_Role.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerRoll;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btnJobs;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnWorks;
        private System.Windows.Forms.Button btnProject;
        private System.Windows.Forms.Button btnAboutUs;
        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.Panel panel_Logo;
        private System.Windows.Forms.Button btn_Roll_Dashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label_Exit;
        private System.Windows.Forms.Panel panel_Time;
        private System.Windows.Forms.Label text_Title;
        private System.Windows.Forms.Panel panel_Role;
        private System.Windows.Forms.Panel panelSide;
    }
}