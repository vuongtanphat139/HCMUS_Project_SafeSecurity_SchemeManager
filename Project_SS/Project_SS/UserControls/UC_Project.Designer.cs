namespace Project_SS
{
    partial class UC_Project
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
            this.Dean_DataGrid = new System.Windows.Forms.DataGridView();
            this.name_Text = new System.Windows.Forms.TextBox();
            this.room_Text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.date_Datetime = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Phancong = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Dean_DataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dean_DataGrid
            // 
            this.Dean_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dean_DataGrid.Location = new System.Drawing.Point(46, 60);
            this.Dean_DataGrid.Name = "Dean_DataGrid";
            this.Dean_DataGrid.RowHeadersWidth = 51;
            this.Dean_DataGrid.RowTemplate.Height = 24;
            this.Dean_DataGrid.Size = new System.Drawing.Size(886, 246);
            this.Dean_DataGrid.TabIndex = 0;
            this.Dean_DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dean_DataGrid_CellContentClick);
            // 
            // name_Text
            // 
            this.name_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_Text.Location = new System.Drawing.Point(199, 29);
            this.name_Text.Name = "name_Text";
            this.name_Text.Size = new System.Drawing.Size(346, 29);
            this.name_Text.TabIndex = 1;
            // 
            // room_Text
            // 
            this.room_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.room_Text.Location = new System.Drawing.Point(199, 128);
            this.room_Text.Name = "room_Text";
            this.room_Text.Size = new System.Drawing.Size(346, 29);
            this.room_Text.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.label1.Location = new System.Drawing.Point(89, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Project:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.label2.Location = new System.Drawing.Point(89, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Start date:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.label3.Location = new System.Drawing.Point(89, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Department:";
            // 
            // date_Datetime
            // 
            this.date_Datetime.Location = new System.Drawing.Point(199, 77);
            this.date_Datetime.Name = "date_Datetime";
            this.date_Datetime.Size = new System.Drawing.Size(346, 29);
            this.date_Datetime.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(138)))));
            this.button1.Location = new System.Drawing.Point(637, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 51);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.button2.Location = new System.Drawing.Point(637, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 50);
            this.button2.TabIndex = 9;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Phancong
            // 
            this.Phancong.AutoSize = true;
            this.Phancong.Cursor = System.Windows.Forms.Cursors.Default;
            this.Phancong.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.Phancong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.Phancong.Location = new System.Drawing.Point(41, 26);
            this.Phancong.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.Phancong.Name = "Phancong";
            this.Phancong.Size = new System.Drawing.Size(185, 25);
            this.Phancong.TabIndex = 10;
            this.Phancong.Text = "LIST OF PROJECTS:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(230)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.name_Text);
            this.panel1.Controls.Add(this.room_Text);
            this.panel1.Controls.Add(this.date_Datetime);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(46, 344);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 185);
            this.panel1.TabIndex = 11;
            // 
            // UC_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Phancong);
            this.Controls.Add(this.Dean_DataGrid);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.Name = "UC_Project";
            this.Size = new System.Drawing.Size(977, 571);
            ((System.ComponentModel.ISupportInitialize)(this.Dean_DataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dean_DataGrid;
        private System.Windows.Forms.TextBox name_Text;
        private System.Windows.Forms.TextBox room_Text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date_Datetime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Phancong;
        private System.Windows.Forms.Panel panel1;
    }
}
