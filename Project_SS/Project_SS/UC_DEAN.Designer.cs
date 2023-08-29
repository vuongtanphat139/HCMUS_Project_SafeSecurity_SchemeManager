namespace Project_SS
{
    partial class UC_DEAN
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
            ((System.ComponentModel.ISupportInitialize)(this.Dean_DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Dean_DataGrid
            // 
            this.Dean_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dean_DataGrid.Location = new System.Drawing.Point(40, 45);
            this.Dean_DataGrid.Name = "Dean_DataGrid";
            this.Dean_DataGrid.RowHeadersWidth = 51;
            this.Dean_DataGrid.RowTemplate.Height = 24;
            this.Dean_DataGrid.Size = new System.Drawing.Size(861, 241);
            this.Dean_DataGrid.TabIndex = 0;
            this.Dean_DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dean_DataGrid_CellContentClick);
            // 
            // name_Text
            // 
            this.name_Text.Location = new System.Drawing.Point(166, 334);
            this.name_Text.Name = "name_Text";
            this.name_Text.Size = new System.Drawing.Size(455, 22);
            this.name_Text.TabIndex = 1;
            // 
            // room_Text
            // 
            this.room_Text.Location = new System.Drawing.Point(166, 434);
            this.room_Text.Name = "room_Text";
            this.room_Text.Size = new System.Drawing.Size(455, 22);
            this.room_Text.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên đề án";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ngày bắt đầu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phòng";
            // 
            // date_Datetime
            // 
            this.date_Datetime.Location = new System.Drawing.Point(166, 383);
            this.date_Datetime.Name = "date_Datetime";
            this.date_Datetime.Size = new System.Drawing.Size(455, 22);
            this.date_Datetime.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(660, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 61);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(660, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 56);
            this.button2.TabIndex = 9;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UC_DEAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.date_Datetime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.room_Text);
            this.Controls.Add(this.name_Text);
            this.Controls.Add(this.Dean_DataGrid);
            this.Name = "UC_DEAN";
            this.Size = new System.Drawing.Size(977, 571);
            ((System.ComponentModel.ISupportInitialize)(this.Dean_DataGrid)).EndInit();
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
    }
}
