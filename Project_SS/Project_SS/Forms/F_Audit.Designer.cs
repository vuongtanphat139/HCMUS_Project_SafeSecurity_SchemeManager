namespace Project_SS.Forms
{
    partial class F_Audit
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
            this.audit_DataGrid = new System.Windows.Forms.DataGridView();
            this.changetime_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.change_LP_Button = new System.Windows.Forms.Button();
            this.changenhanvien_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.QLPHANCONG = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.qlphancong_Button = new System.Windows.Forms.Button();
            this.uid_nhanvien_button = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.audit_DataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // audit_DataGrid
            // 
            this.audit_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.audit_DataGrid.Location = new System.Drawing.Point(16, 57);
            this.audit_DataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.audit_DataGrid.Name = "audit_DataGrid";
            this.audit_DataGrid.RowHeadersWidth = 51;
            this.audit_DataGrid.RowTemplate.Height = 24;
            this.audit_DataGrid.Size = new System.Drawing.Size(725, 208);
            this.audit_DataGrid.TabIndex = 0;
            // 
            // changetime_button
            // 
            this.changetime_button.Location = new System.Drawing.Point(134, 46);
            this.changetime_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.changetime_button.Name = "changetime_button";
            this.changetime_button.Size = new System.Drawing.Size(181, 31);
            this.changetime_button.TabIndex = 1;
            this.changetime_button.Text = "ENABLE AUDIT";
            this.changetime_button.UseVisualStyleBackColor = true;
            this.changetime_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CHANGETIME";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CHANGE_LP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CHANGENHANVIEN";
            // 
            // change_LP_Button
            // 
            this.change_LP_Button.Location = new System.Drawing.Point(134, 91);
            this.change_LP_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.change_LP_Button.Name = "change_LP_Button";
            this.change_LP_Button.Size = new System.Drawing.Size(181, 31);
            this.change_LP_Button.TabIndex = 5;
            this.change_LP_Button.Text = "ENABLE AUDIT";
            this.change_LP_Button.UseVisualStyleBackColor = true;
            this.change_LP_Button.Click += new System.EventHandler(this.button2_Click);
            // 
            // changenhanvien_Button
            // 
            this.changenhanvien_Button.Location = new System.Drawing.Point(134, 136);
            this.changenhanvien_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.changenhanvien_Button.Name = "changenhanvien_Button";
            this.changenhanvien_Button.Size = new System.Drawing.Size(181, 31);
            this.changenhanvien_Button.TabIndex = 6;
            this.changenhanvien_Button.Text = "ENABLE AUDIT";
            this.changenhanvien_Button.UseVisualStyleBackColor = true;
            this.changenhanvien_Button.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(230)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.changetime_button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.change_LP_Button);
            this.panel1.Controls.Add(this.changenhanvien_Button);
            this.panel1.Location = new System.Drawing.Point(26, 293);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 182);
            this.panel1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.label6.Location = new System.Drawing.Point(137, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "AUDIT";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(230)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.QLPHANCONG);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.qlphancong_Button);
            this.panel2.Controls.Add(this.uid_nhanvien_button);
            this.panel2.Location = new System.Drawing.Point(388, 293);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 182);
            this.panel2.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.label7.Location = new System.Drawing.Point(173, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "VPD";
            // 
            // QLPHANCONG
            // 
            this.QLPHANCONG.AutoSize = true;
            this.QLPHANCONG.Location = new System.Drawing.Point(37, 137);
            this.QLPHANCONG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.QLPHANCONG.Name = "QLPHANCONG";
            this.QLPHANCONG.Size = new System.Drawing.Size(82, 13);
            this.QLPHANCONG.TabIndex = 14;
            this.QLPHANCONG.Text = "QLPHANCONG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "UID_NHANVIEN";
            // 
            // qlphancong_Button
            // 
            this.qlphancong_Button.Location = new System.Drawing.Point(145, 116);
            this.qlphancong_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.qlphancong_Button.Name = "qlphancong_Button";
            this.qlphancong_Button.Size = new System.Drawing.Size(184, 46);
            this.qlphancong_Button.TabIndex = 12;
            this.qlphancong_Button.Text = "ENABLE VPD";
            this.qlphancong_Button.UseVisualStyleBackColor = true;
            this.qlphancong_Button.Click += new System.EventHandler(this.qlphancong_Button_Click);
            // 
            // uid_nhanvien_button
            // 
            this.uid_nhanvien_button.Location = new System.Drawing.Point(145, 51);
            this.uid_nhanvien_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uid_nhanvien_button.Name = "uid_nhanvien_button";
            this.uid_nhanvien_button.Size = new System.Drawing.Size(184, 46);
            this.uid_nhanvien_button.TabIndex = 11;
            this.uid_nhanvien_button.Text = "ENABLE VPD";
            this.uid_nhanvien_button.UseVisualStyleBackColor = true;
            this.uid_nhanvien_button.Click += new System.EventHandler(this.uid_nhanvien_button_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.audit_DataGrid);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(10, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(753, 479);
            this.panel3.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(728, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "x";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.label8.Location = new System.Drawing.Point(342, 17);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "DEMO";
            // 
            // F_Audit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(773, 499);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "F_Audit";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Audit";
            ((System.ComponentModel.ISupportInitialize)(this.audit_DataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView audit_DataGrid;
        private System.Windows.Forms.Button changetime_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button change_LP_Button;
        private System.Windows.Forms.Button changenhanvien_Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label QLPHANCONG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button qlphancong_Button;
        private System.Windows.Forms.Button uid_nhanvien_button;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
    }
}