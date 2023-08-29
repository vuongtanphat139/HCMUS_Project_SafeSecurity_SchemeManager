namespace Project_SS.UserControls
{
    partial class UC_Department
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
            this.department_DataGrid = new System.Windows.Forms.DataGridView();
            this.name_Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.name_Text = new System.Windows.Forms.TextBox();
            this.idTP_Text = new System.Windows.Forms.TextBox();
            this.Phancong = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.department_DataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // department_DataGrid
            // 
            this.department_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.department_DataGrid.Location = new System.Drawing.Point(30, 70);
            this.department_DataGrid.Name = "department_DataGrid";
            this.department_DataGrid.RowHeadersWidth = 51;
            this.department_DataGrid.RowTemplate.Height = 24;
            this.department_DataGrid.Size = new System.Drawing.Size(920, 203);
            this.department_DataGrid.TabIndex = 0;
            this.department_DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.department_DataGrid_CellContentClick);
            // 
            // name_Label
            // 
            this.name_Label.AutoSize = true;
            this.name_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.name_Label.Location = new System.Drawing.Point(51, 44);
            this.name_Label.Name = "name_Label";
            this.name_Label.Size = new System.Drawing.Size(57, 21);
            this.name_Label.TabIndex = 2;
            this.name_Label.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.label3.Location = new System.Drawing.Point(51, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Manager:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(138)))));
            this.button1.Location = new System.Drawing.Point(139, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 49);
            this.button1.TabIndex = 4;
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
            this.button2.Location = new System.Drawing.Point(337, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 49);
            this.button2.TabIndex = 5;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // name_Text
            // 
            this.name_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_Text.Location = new System.Drawing.Point(139, 39);
            this.name_Text.Name = "name_Text";
            this.name_Text.Size = new System.Drawing.Size(354, 29);
            this.name_Text.TabIndex = 6;
            // 
            // idTP_Text
            // 
            this.idTP_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTP_Text.Location = new System.Drawing.Point(139, 92);
            this.idTP_Text.Name = "idTP_Text";
            this.idTP_Text.Size = new System.Drawing.Size(354, 29);
            this.idTP_Text.TabIndex = 7;
            // 
            // Phancong
            // 
            this.Phancong.AutoSize = true;
            this.Phancong.Cursor = System.Windows.Forms.Cursors.Default;
            this.Phancong.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.Phancong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.Phancong.Location = new System.Drawing.Point(26, 32);
            this.Phancong.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.Phancong.Name = "Phancong";
            this.Phancong.Size = new System.Drawing.Size(231, 25);
            this.Phancong.TabIndex = 8;
            this.Phancong.Text = "LIST OF DEPARTMENTS:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.name_Text);
            this.panel1.Controls.Add(this.idTP_Text);
            this.panel1.Controls.Add(this.name_Label);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(196, 306);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 229);
            this.panel1.TabIndex = 9;
            // 
            // UC_Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Phancong);
            this.Controls.Add(this.department_DataGrid);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.Name = "UC_Department";
            this.Size = new System.Drawing.Size(977, 571);
            ((System.ComponentModel.ISupportInitialize)(this.department_DataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView department_DataGrid;
        private System.Windows.Forms.Label name_Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox name_Text;
        private System.Windows.Forms.TextBox idTP_Text;
        private System.Windows.Forms.Label Phancong;
        private System.Windows.Forms.Panel panel1;
    }
}
