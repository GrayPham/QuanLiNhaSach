namespace DBMS_FORM
{
    partial class Thuefrm
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnPrintf = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_NAMESTORE = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.lbRole = new System.Windows.Forms.Label();
            this.lbNameuser = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lbSoluong = new System.Windows.Forms.Label();
            this.dateTra = new System.Windows.Forms.DateTimePicker();
            this.dateMuon = new System.Windows.Forms.DateTimePicker();
            this.button7 = new System.Windows.Forms.Button();
            this.lbNgayTra = new System.Windows.Forms.Label();
            this.lbNgayMuon = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbMaSachThue = new System.Windows.Forms.Label();
            this.lbMasach = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnPrintf);
            this.groupBox5.Controls.Add(this.btnDelete);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(8, 292);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(1259, 85);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            // 
            // btnPrintf
            // 
            this.btnPrintf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintf.ForeColor = System.Drawing.Color.White;
            this.btnPrintf.Location = new System.Drawing.Point(724, 23);
            this.btnPrintf.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintf.Name = "btnPrintf";
            this.btnPrintf.Size = new System.Drawing.Size(116, 54);
            this.btnPrintf.TabIndex = 4;
            this.btnPrintf.Text = "Printf";
            this.btnPrintf.UseVisualStyleBackColor = true;
            this.btnPrintf.Click += new System.EventHandler(this.btnPrintf_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(305, 23);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 54);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(13, 314);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1275, 385);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(8, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1259, 351);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ma Sach";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ten Sach";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 230;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Don Gia";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 140;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "So Luong";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ngay Muon";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 140;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ngay Tra";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 140;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_NAMESTORE);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(207, 690);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // lb_NAMESTORE
            // 
            this.lb_NAMESTORE.AutoSize = true;
            this.lb_NAMESTORE.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NAMESTORE.Location = new System.Drawing.Point(13, 20);
            this.lb_NAMESTORE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_NAMESTORE.Name = "lb_NAMESTORE";
            this.lb_NAMESTORE.Size = new System.Drawing.Size(169, 36);
            this.lb_NAMESTORE.TabIndex = 2;
            this.lb_NAMESTORE.Text = "NameStore";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFind);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.lbSearch);
            this.groupBox2.Controls.Add(this.lbRole);
            this.groupBox2.Controls.Add(this.lbNameuser);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(221, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1067, 123);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // btnFind
            // 
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Location = new System.Drawing.Point(929, 78);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(100, 36);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(715, 78);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 34);
            this.textBox1.TabIndex = 3;
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(621, 82);
            this.lbSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(83, 30);
            this.lbSearch.TabIndex = 2;
            this.lbSearch.Text = "Search";
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Location = new System.Drawing.Point(57, 82);
            this.lbRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(68, 30);
            this.lbRole.TabIndex = 1;
            this.lbRole.Text = "ROLE";
            // 
            // lbNameuser
            // 
            this.lbNameuser.AutoSize = true;
            this.lbNameuser.Location = new System.Drawing.Point(57, 20);
            this.lbNameuser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNameuser.Name = "lbNameuser";
            this.lbNameuser.Size = new System.Drawing.Size(129, 30);
            this.lbNameuser.TabIndex = 0;
            this.lbNameuser.Text = "Name User";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Controls.Add(this.lbSoluong);
            this.groupBox4.Controls.Add(this.dateTra);
            this.groupBox4.Controls.Add(this.dateMuon);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.lbNgayTra);
            this.groupBox4.Controls.Add(this.lbNgayMuon);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.lbMaSachThue);
            this.groupBox4.Controls.Add(this.lbMasach);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(13, 135);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1275, 188);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1151, 27);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(44, 34);
            this.textBox4.TabIndex = 11;
            // 
            // lbSoluong
            // 
            this.lbSoluong.AutoSize = true;
            this.lbSoluong.Location = new System.Drawing.Point(1027, 31);
            this.lbSoluong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSoluong.Name = "lbSoluong";
            this.lbSoluong.Size = new System.Drawing.Size(105, 30);
            this.lbSoluong.TabIndex = 10;
            this.lbSoluong.Text = "Quantity";
            // 
            // dateTra
            // 
            this.dateTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTra.Location = new System.Drawing.Point(657, 92);
            this.dateTra.Margin = new System.Windows.Forms.Padding(4);
            this.dateTra.Name = "dateTra";
            this.dateTra.Size = new System.Drawing.Size(265, 34);
            this.dateTra.TabIndex = 9;
            this.dateTra.Value = new System.DateTime(2022, 5, 8, 0, 0, 0, 0);
            // 
            // dateMuon
            // 
            this.dateMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateMuon.Location = new System.Drawing.Point(171, 92);
            this.dateMuon.Margin = new System.Windows.Forms.Padding(4);
            this.dateMuon.Name = "dateMuon";
            this.dateMuon.Size = new System.Drawing.Size(265, 34);
            this.dateMuon.TabIndex = 8;
            this.dateMuon.Value = new System.DateTime(2022, 5, 8, 0, 0, 0, 0);
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(1096, 90);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 36);
            this.button7.TabIndex = 7;
            this.button7.Text = "ADD";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // lbNgayTra
            // 
            this.lbNgayTra.AutoSize = true;
            this.lbNgayTra.Location = new System.Drawing.Point(513, 92);
            this.lbNgayTra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNgayTra.Name = "lbNgayTra";
            this.lbNgayTra.Size = new System.Drawing.Size(136, 30);
            this.lbNgayTra.TabIndex = 6;
            this.lbNgayTra.Text = "Return date";
            // 
            // lbNgayMuon
            // 
            this.lbNgayMuon.AutoSize = true;
            this.lbNgayMuon.Location = new System.Drawing.Point(41, 94);
            this.lbNgayMuon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNgayMuon.Name = "lbNgayMuon";
            this.lbNgayMuon.Size = new System.Drawing.Size(114, 30);
            this.lbNgayMuon.TabIndex = 5;
            this.lbNgayMuon.Text = "Rent date";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(657, 27);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(265, 34);
            this.textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(171, 27);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(265, 34);
            this.textBox2.TabIndex = 3;
            // 
            // lbMaSachThue
            // 
            this.lbMaSachThue.AutoSize = true;
            this.lbMaSachThue.Location = new System.Drawing.Point(552, 31);
            this.lbMaSachThue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaSachThue.Name = "lbMaSachThue";
            this.lbMaSachThue.Size = new System.Drawing.Size(97, 30);
            this.lbMaSachThue.TabIndex = 1;
            this.lbMaSachThue.Text = "Book ID";
            // 
            // lbMasach
            // 
            this.lbMasach.AutoSize = true;
            this.lbMasach.Location = new System.Drawing.Point(57, 31);
            this.lbMasach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMasach.Name = "lbMasach";
            this.lbMasach.Size = new System.Drawing.Size(98, 30);
            this.lbMasach.TabIndex = 0;
            this.lbMasach.Text = "Mem ID";
            // 
            // Thuefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1303, 710);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Thuefrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thue Sach";
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnPrintf;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_NAMESTORE;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Label lbNameuser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lbSoluong;
        private System.Windows.Forms.DateTimePicker dateTra;
        private System.Windows.Forms.DateTimePicker dateMuon;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label lbNgayTra;
        private System.Windows.Forms.Label lbNgayMuon;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbMaSachThue;
        private System.Windows.Forms.Label lbMasach;
    }
}