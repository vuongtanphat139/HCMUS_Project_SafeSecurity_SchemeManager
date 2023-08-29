namespace Project_SS
{
    partial class UC_Employee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NHANVIEN_DataGrid = new System.Windows.Forms.DataGridView();
            this.Phancong = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.room_ComboBox = new System.Windows.Forms.ComboBox();
            this.manager_ComboBox = new System.Windows.Forms.ComboBox();
            this.role_ComboBox = new System.Windows.Forms.ComboBox();
            this.gender_ComboBox = new System.Windows.Forms.ComboBox();
            this.Demo = new System.Windows.Forms.Button();
            this.birthday_Datetime = new System.Windows.Forms.DateTimePicker();
            this.allowance_Text = new System.Windows.Forms.TextBox();
            this.salary_Text = new System.Windows.Forms.TextBox();
            this.address_Text = new System.Windows.Forms.TextBox();
            this.phone_Text = new System.Windows.Forms.TextBox();
            this.Name_Text = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NHANVIEN_DataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NHANVIEN_DataGrid
            // 
            this.NHANVIEN_DataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.NHANVIEN_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NHANVIEN_DataGrid.Location = new System.Drawing.Point(20, 49);
            this.NHANVIEN_DataGrid.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.NHANVIEN_DataGrid.Name = "NHANVIEN_DataGrid";
            this.NHANVIEN_DataGrid.RowHeadersWidth = 51;
            this.NHANVIEN_DataGrid.RowTemplate.Height = 24;
            this.NHANVIEN_DataGrid.Size = new System.Drawing.Size(939, 211);
            this.NHANVIEN_DataGrid.TabIndex = 6;
            this.NHANVIEN_DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NHANVIEN_DataGrid_CellContentClick);
            // 
            // Phancong
            // 
            this.Phancong.AutoSize = true;
            this.Phancong.Cursor = System.Windows.Forms.Cursors.Default;
            this.Phancong.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phancong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.Phancong.Location = new System.Drawing.Point(16, 19);
            this.Phancong.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Phancong.Name = "Phancong";
            this.Phancong.Size = new System.Drawing.Size(168, 21);
            this.Phancong.TabIndex = 5;
            this.Phancong.Text = "LIST OF EMPLOYEES:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.room_ComboBox);
            this.panel1.Controls.Add(this.manager_ComboBox);
            this.panel1.Controls.Add(this.role_ComboBox);
            this.panel1.Controls.Add(this.gender_ComboBox);
            this.panel1.Controls.Add(this.Demo);
            this.panel1.Controls.Add(this.birthday_Datetime);
            this.panel1.Controls.Add(this.allowance_Text);
            this.panel1.Controls.Add(this.salary_Text);
            this.panel1.Controls.Add(this.address_Text);
            this.panel1.Controls.Add(this.phone_Text);
            this.panel1.Controls.Add(this.Name_Text);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(20, 282);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 271);
            this.panel1.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.button3.Location = new System.Drawing.Point(754, 141);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 49);
            this.button3.TabIndex = 43;
            this.button3.Text = "Update Yourself";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // room_ComboBox
            // 
            this.room_ComboBox.FormattingEnabled = true;
            this.room_ComboBox.Location = new System.Drawing.Point(651, 138);
            this.room_ComboBox.Name = "room_ComboBox";
            this.room_ComboBox.Size = new System.Drawing.Size(96, 29);
            this.room_ComboBox.TabIndex = 42;
            // 
            // manager_ComboBox
            // 
            this.manager_ComboBox.FormattingEnabled = true;
            this.manager_ComboBox.Location = new System.Drawing.Point(651, 98);
            this.manager_ComboBox.Name = "manager_ComboBox";
            this.manager_ComboBox.Size = new System.Drawing.Size(96, 29);
            this.manager_ComboBox.TabIndex = 41;
            // 
            // role_ComboBox
            // 
            this.role_ComboBox.FormattingEnabled = true;
            this.role_ComboBox.Items.AddRange(new object[] {
            "Nhân viên",
            "QLTT",
            "Trưởng phòng",
            "Tài chính",
            "Nhân sự",
            "Trưởng đề án"});
            this.role_ComboBox.Location = new System.Drawing.Point(585, 53);
            this.role_ComboBox.Name = "role_ComboBox";
            this.role_ComboBox.Size = new System.Drawing.Size(121, 29);
            this.role_ComboBox.TabIndex = 40;
            // 
            // gender_ComboBox
            // 
            this.gender_ComboBox.FormattingEnabled = true;
            this.gender_ComboBox.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.gender_ComboBox.Location = new System.Drawing.Point(125, 93);
            this.gender_ComboBox.Name = "gender_ComboBox";
            this.gender_ComboBox.Size = new System.Drawing.Size(81, 29);
            this.gender_ComboBox.TabIndex = 39;
            // 
            // Demo
            // 
            this.Demo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.Demo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Demo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Demo.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Demo.ForeColor = System.Drawing.Color.White;
            this.Demo.Location = new System.Drawing.Point(775, 215);
            this.Demo.Name = "Demo";
            this.Demo.Size = new System.Drawing.Size(128, 38);
            this.Demo.TabIndex = 38;
            this.Demo.Text = "Encrypt demo";
            this.Demo.UseVisualStyleBackColor = false;
            this.Demo.Click += new System.EventHandler(this.Demo_Click);
            // 
            // birthday_Datetime
            // 
            this.birthday_Datetime.Location = new System.Drawing.Point(125, 134);
            this.birthday_Datetime.Name = "birthday_Datetime";
            this.birthday_Datetime.Size = new System.Drawing.Size(365, 29);
            this.birthday_Datetime.TabIndex = 37;
            // 
            // allowance_Text
            // 
            this.allowance_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.allowance_Text.Location = new System.Drawing.Point(125, 224);
            this.allowance_Text.Name = "allowance_Text";
            this.allowance_Text.Size = new System.Drawing.Size(108, 29);
            this.allowance_Text.TabIndex = 31;
            // 
            // salary_Text
            // 
            this.salary_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salary_Text.Location = new System.Drawing.Point(125, 180);
            this.salary_Text.Name = "salary_Text";
            this.salary_Text.Size = new System.Drawing.Size(108, 29);
            this.salary_Text.TabIndex = 30;
            // 
            // address_Text
            // 
            this.address_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address_Text.Location = new System.Drawing.Point(352, 176);
            this.address_Text.Multiline = true;
            this.address_Text.Name = "address_Text";
            this.address_Text.Size = new System.Drawing.Size(371, 77);
            this.address_Text.TabIndex = 29;
            // 
            // phone_Text
            // 
            this.phone_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phone_Text.Location = new System.Drawing.Point(352, 94);
            this.phone_Text.Name = "phone_Text";
            this.phone_Text.Size = new System.Drawing.Size(138, 29);
            this.phone_Text.TabIndex = 28;
            // 
            // Name_Text
            // 
            this.Name_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name_Text.Location = new System.Drawing.Point(125, 50);
            this.Name_Text.Name = "Name_Text";
            this.Name_Text.Size = new System.Drawing.Size(365, 29);
            this.Name_Text.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(523, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 21);
            this.label13.TabIndex = 24;
            this.label13.Text = "Department:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(523, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 21);
            this.label12.TabIndex = 23;
            this.label12.Text = "ID Manager:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(523, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 21);
            this.label11.TabIndex = 22;
            this.label11.Text = "Role:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 21);
            this.label10.TabIndex = 21;
            this.label10.Text = "Allowance:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 21);
            this.label9.TabIndex = 20;
            this.label9.Text = "Salary:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(263, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "No.Phone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Birthday:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Name:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.button2.Location = new System.Drawing.Point(775, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 49);
            this.button2.TabIndex = 8;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(138)))));
            this.button1.Location = new System.Drawing.Point(775, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.label1.Location = new System.Drawing.Point(241, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add/Update Employee";
            // 
            // UC_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NHANVIEN_DataGrid);
            this.Controls.Add(this.Phancong);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UC_Employee";
            this.Size = new System.Drawing.Size(977, 571);
            ((System.ComponentModel.ISupportInitialize)(this.NHANVIEN_DataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView NHANVIEN_DataGrid;
        private System.Windows.Forms.Label Phancong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox allowance_Text;
        private System.Windows.Forms.TextBox salary_Text;
        private System.Windows.Forms.TextBox address_Text;
        private System.Windows.Forms.TextBox phone_Text;
        private System.Windows.Forms.TextBox Name_Text;
        private System.Windows.Forms.DateTimePicker birthday_Datetime;
        private System.Windows.Forms.Button Demo;
        private System.Windows.Forms.ComboBox gender_ComboBox;
        private System.Windows.Forms.ComboBox room_ComboBox;
        private System.Windows.Forms.ComboBox manager_ComboBox;
        private System.Windows.Forms.ComboBox role_ComboBox;
        private System.Windows.Forms.Button button3;
    }
}
