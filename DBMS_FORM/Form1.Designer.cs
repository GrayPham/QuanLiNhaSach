namespace DBMS_FORM
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_manager = new System.Windows.Forms.Button();
            this.button_thanhvien = new System.Windows.Forms.Button();
            this.button_cungcap = new System.Windows.Forms.Button();
            this.button_hoadon = new System.Windows.Forms.Button();
            this.button_bansach = new System.Windows.Forms.Button();
            this.button_thue = new System.Windows.Forms.Button();
            this.lb_NAMESTORE = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_name = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.lbRole = new System.Windows.Forms.Label();
            this.lbNameuser = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.button_manager);
            this.groupBox1.Controls.Add(this.button_thanhvien);
            this.groupBox1.Controls.Add(this.button_cungcap);
            this.groupBox1.Controls.Add(this.button_hoadon);
            this.groupBox1.Controls.Add(this.button_bansach);
            this.groupBox1.Controls.Add(this.button_thue);
            this.groupBox1.Controls.Add(this.lb_NAMESTORE);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(207, 690);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button_manager
            // 
            this.button_manager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_manager.Location = new System.Drawing.Point(8, 597);
            this.button_manager.Margin = new System.Windows.Forms.Padding(4);
            this.button_manager.Name = "button_manager";
            this.button_manager.Size = new System.Drawing.Size(191, 86);
            this.button_manager.TabIndex = 8;
            this.button_manager.Text = "Manager";
            this.button_manager.UseVisualStyleBackColor = true;
            this.button_manager.Click += new System.EventHandler(this.button_manager_Click);
            // 
            // button_thanhvien
            // 
            this.button_thanhvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_thanhvien.Location = new System.Drawing.Point(8, 505);
            this.button_thanhvien.Margin = new System.Windows.Forms.Padding(4);
            this.button_thanhvien.Name = "button_thanhvien";
            this.button_thanhvien.Size = new System.Drawing.Size(191, 86);
            this.button_thanhvien.TabIndex = 7;
            this.button_thanhvien.Text = "Member";
            this.button_thanhvien.UseVisualStyleBackColor = true;
            this.button_thanhvien.Click += new System.EventHandler(this.button_thanhvien_Click);
            // 
            // button_cungcap
            // 
            this.button_cungcap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cungcap.Location = new System.Drawing.Point(8, 411);
            this.button_cungcap.Margin = new System.Windows.Forms.Padding(4);
            this.button_cungcap.Name = "button_cungcap";
            this.button_cungcap.Size = new System.Drawing.Size(191, 86);
            this.button_cungcap.TabIndex = 6;
            this.button_cungcap.Text = "Provider";
            this.button_cungcap.UseVisualStyleBackColor = true;
            this.button_cungcap.Click += new System.EventHandler(this.button_cungcap_Click);
            // 
            // button_hoadon
            // 
            this.button_hoadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_hoadon.Location = new System.Drawing.Point(8, 318);
            this.button_hoadon.Margin = new System.Windows.Forms.Padding(4);
            this.button_hoadon.Name = "button_hoadon";
            this.button_hoadon.Size = new System.Drawing.Size(191, 86);
            this.button_hoadon.TabIndex = 5;
            this.button_hoadon.Text = "Sell Bill";
            this.button_hoadon.UseVisualStyleBackColor = true;
            this.button_hoadon.Click += new System.EventHandler(this.button_hoadon_Click);
            // 
            // button_bansach
            // 
            this.button_bansach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_bansach.Location = new System.Drawing.Point(8, 224);
            this.button_bansach.Margin = new System.Windows.Forms.Padding(4);
            this.button_bansach.Name = "button_bansach";
            this.button_bansach.Size = new System.Drawing.Size(191, 86);
            this.button_bansach.TabIndex = 4;
            this.button_bansach.Text = "Sell Book";
            this.button_bansach.UseVisualStyleBackColor = true;
            this.button_bansach.Click += new System.EventHandler(this.button_bansach_Click);
            // 
            // button_thue
            // 
            this.button_thue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_thue.Location = new System.Drawing.Point(8, 130);
            this.button_thue.Margin = new System.Windows.Forms.Padding(4);
            this.button_thue.Name = "button_thue";
            this.button_thue.Size = new System.Drawing.Size(191, 86);
            this.button_thue.TabIndex = 3;
            this.button_thue.Text = "Rent Book";
            this.button_thue.UseVisualStyleBackColor = true;
            this.button_thue.Click += new System.EventHandler(this.button_thue_Click);
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
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox2.Controls.Add(this.label_name);
            this.groupBox2.Controls.Add(this.btnFind);
            this.groupBox2.Controls.Add(this.textBox_search);
            this.groupBox2.Controls.Add(this.lbSearch);
            this.groupBox2.Controls.Add(this.lbRole);
            this.groupBox2.Controls.Add(this.lbNameuser);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(217, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1209, 123);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(205, 20);
            this.label_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(129, 30);
            this.label_name.TabIndex = 5;
            this.label_name.Text = "Name User";
            // 
            // btnFind
            // 
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Location = new System.Drawing.Point(1101, 75);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(100, 36);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(887, 75);
            this.textBox_search.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(205, 34);
            this.textBox_search.TabIndex = 3;
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(793, 79);
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
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(217, 133);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1209, 560);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.Gray;
            this.dataGridView1.Location = new System.Drawing.Point(8, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1193, 514);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1443, 708);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_thue;
        private System.Windows.Forms.Label lb_NAMESTORE;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Label lbNameuser;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_manager;
        private System.Windows.Forms.Button button_thanhvien;
        private System.Windows.Forms.Button button_cungcap;
        private System.Windows.Forms.Button button_hoadon;
        private System.Windows.Forms.Button button_bansach;
        private System.Windows.Forms.Label label_name;
    }
}

