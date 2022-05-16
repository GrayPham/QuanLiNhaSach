namespace DBMS_FORM
{
    partial class FormThanhVien
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
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.dOAN_QUANLYNHASACH_DBMSDataSet = new DBMS_FORM.DOAN_QUANLYNHASACH_DBMSDataSet();
            this.settingThanhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.settingThanhVienTableAdapter = new DBMS_FORM.DOAN_QUANLYNHASACH_DBMSDataSetTableAdapters.SettingThanhVienTableAdapter();
            this.mTVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoVaTenTVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conSDDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mDThanThietDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOAN_QUANLYNHASACH_DBMSDataSet1 = new DBMS_FORM.DOAN_QUANLYNHASACH_DBMSDataSet1();
            this.funThanhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fun_ThanhVienTableAdapter = new DBMS_FORM.DOAN_QUANLYNHASACH_DBMSDataSet1TableAdapters.fun_ThanhVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOAN_QUANLYNHASACH_DBMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingThanhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOAN_QUANLYNHASACH_DBMSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funThanhVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(259, 25);
            this.textBox_search.Multiline = true;
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(312, 30);
            this.textBox_search.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm ID thành viên:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mTVDataGridViewTextBoxColumn,
            this.hoVaTenTVDataGridViewTextBoxColumn,
            this.diachiDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.soDTDataGridViewTextBoxColumn,
            this.conSDDataGridViewCheckBoxColumn,
            this.mDThanThietDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.funThanhVienBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 336);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnedit.Location = new System.Drawing.Point(12, 420);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(187, 39);
            this.btnedit.TabIndex = 3;
            this.btnedit.Text = "EDIT";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnadd.Location = new System.Drawing.Point(306, 420);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(187, 39);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnremove
            // 
            this.btnremove.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnremove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnremove.Location = new System.Drawing.Point(601, 420);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(187, 39);
            this.btnremove.TabIndex = 5;
            this.btnremove.Text = "REMOVE";
            this.btnremove.UseVisualStyleBackColor = false;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(601, 25);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(86, 30);
            this.btnFind.TabIndex = 6;
            this.btnFind.Text = "FIND";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // dOAN_QUANLYNHASACH_DBMSDataSet
            // 
            this.dOAN_QUANLYNHASACH_DBMSDataSet.DataSetName = "DOAN_QUANLYNHASACH_DBMSDataSet";
            this.dOAN_QUANLYNHASACH_DBMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // settingThanhVienBindingSource
            // 
            this.settingThanhVienBindingSource.DataMember = "SettingThanhVien";
            this.settingThanhVienBindingSource.DataSource = this.dOAN_QUANLYNHASACH_DBMSDataSet;
            // 
            // settingThanhVienTableAdapter
            // 
            this.settingThanhVienTableAdapter.ClearBeforeFill = true;
            // 
            // mTVDataGridViewTextBoxColumn
            // 
            this.mTVDataGridViewTextBoxColumn.DataPropertyName = "MTV";
            this.mTVDataGridViewTextBoxColumn.HeaderText = "MTV";
            this.mTVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mTVDataGridViewTextBoxColumn.Name = "mTVDataGridViewTextBoxColumn";
            this.mTVDataGridViewTextBoxColumn.Width = 125;
            // 
            // hoVaTenTVDataGridViewTextBoxColumn
            // 
            this.hoVaTenTVDataGridViewTextBoxColumn.DataPropertyName = "HoVaTenTV";
            this.hoVaTenTVDataGridViewTextBoxColumn.HeaderText = "HoVaTenTV";
            this.hoVaTenTVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hoVaTenTVDataGridViewTextBoxColumn.Name = "hoVaTenTVDataGridViewTextBoxColumn";
            this.hoVaTenTVDataGridViewTextBoxColumn.Width = 125;
            // 
            // diachiDataGridViewTextBoxColumn
            // 
            this.diachiDataGridViewTextBoxColumn.DataPropertyName = "Diachi";
            this.diachiDataGridViewTextBoxColumn.HeaderText = "Diachi";
            this.diachiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diachiDataGridViewTextBoxColumn.Name = "diachiDataGridViewTextBoxColumn";
            this.diachiDataGridViewTextBoxColumn.Width = 125;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.Width = 125;
            // 
            // soDTDataGridViewTextBoxColumn
            // 
            this.soDTDataGridViewTextBoxColumn.DataPropertyName = "SoDT";
            this.soDTDataGridViewTextBoxColumn.HeaderText = "SoDT";
            this.soDTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soDTDataGridViewTextBoxColumn.Name = "soDTDataGridViewTextBoxColumn";
            this.soDTDataGridViewTextBoxColumn.Width = 125;
            // 
            // conSDDataGridViewCheckBoxColumn
            // 
            this.conSDDataGridViewCheckBoxColumn.DataPropertyName = "ConSD";
            this.conSDDataGridViewCheckBoxColumn.HeaderText = "ConSD";
            this.conSDDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.conSDDataGridViewCheckBoxColumn.Name = "conSDDataGridViewCheckBoxColumn";
            this.conSDDataGridViewCheckBoxColumn.Width = 125;
            // 
            // mDThanThietDataGridViewTextBoxColumn
            // 
            this.mDThanThietDataGridViewTextBoxColumn.DataPropertyName = "MDThanThiet";
            this.mDThanThietDataGridViewTextBoxColumn.HeaderText = "MDThanThiet";
            this.mDThanThietDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mDThanThietDataGridViewTextBoxColumn.Name = "mDThanThietDataGridViewTextBoxColumn";
            this.mDThanThietDataGridViewTextBoxColumn.Width = 125;
            // 
            // dOAN_QUANLYNHASACH_DBMSDataSet1
            // 
            this.dOAN_QUANLYNHASACH_DBMSDataSet1.DataSetName = "DOAN_QUANLYNHASACH_DBMSDataSet1";
            this.dOAN_QUANLYNHASACH_DBMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funThanhVienBindingSource
            // 
            this.funThanhVienBindingSource.DataMember = "fun_ThanhVien";
            this.funThanhVienBindingSource.DataSource = this.dOAN_QUANLYNHASACH_DBMSDataSet1;
            // 
            // fun_ThanhVienTableAdapter
            // 
            this.fun_ThanhVienTableAdapter.ClearBeforeFill = true;
            // 
            // FormThanhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::DBMS_FORM.Properties.Resources.ori_3640123_3l7mjhcaxzfkpsefqhle43i56egp3jrrw9874zo5_sketch_vintage_books_seamless_pattern_or_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_search);
            this.Name = "FormThanhVien";
            this.Text = "FormThanhVien";
            this.Load += new System.EventHandler(this.FormThanhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOAN_QUANLYNHASACH_DBMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingThanhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOAN_QUANLYNHASACH_DBMSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funThanhVienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DataGridViewTextBoxColumn mTVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoVaTenTVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn conSDDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mDThanThietDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource settingThanhVienBindingSource;
        private DOAN_QUANLYNHASACH_DBMSDataSet dOAN_QUANLYNHASACH_DBMSDataSet;
        private DOAN_QUANLYNHASACH_DBMSDataSetTableAdapters.SettingThanhVienTableAdapter settingThanhVienTableAdapter;
        private DOAN_QUANLYNHASACH_DBMSDataSet1 dOAN_QUANLYNHASACH_DBMSDataSet1;
        private System.Windows.Forms.BindingSource funThanhVienBindingSource;
        private DOAN_QUANLYNHASACH_DBMSDataSet1TableAdapters.fun_ThanhVienTableAdapter fun_ThanhVienTableAdapter;
    }
}