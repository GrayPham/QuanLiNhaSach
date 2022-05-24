namespace DBMS_FORM.BookManager
{
    partial class BookManagementForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eDITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITBOOKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITGERNEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEMOVEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEMOVEBOOKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEMOVEGENREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDBOOKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(503, 68);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(501, 33);
            this.textBox1.TabIndex = 82;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(71, 76);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(412, 27);
            this.label10.TabIndex = 81;
            this.label10.Text = "Search Book by Book ID or Book Name:";
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.LightSalmon;
            this.searchbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchbtn.Location = new System.Drawing.Point(1023, 68);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(153, 37);
            this.searchbtn.TabIndex = 80;
            this.searchbtn.Text = "SEARCH";
            this.searchbtn.UseVisualStyleBackColor = false;
            // 
            // refreshbtn
            // 
            this.refreshbtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.refreshbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshbtn.Location = new System.Drawing.Point(430, 642);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(330, 48);
            this.refreshbtn.TabIndex = 79;
            this.refreshbtn.Text = "REFRESH";
            this.refreshbtn.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(76, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1100, 482);
            this.dataGridView1.TabIndex = 78;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.eDITToolStripMenuItem,
            this.rEMOVEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1238, 35);
            this.menuStrip1.TabIndex = 83;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eDITToolStripMenuItem
            // 
            this.eDITToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eDITBOOKToolStripMenuItem,
            this.eDITGERNEToolStripMenuItem});
            this.eDITToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            this.eDITToolStripMenuItem.Size = new System.Drawing.Size(73, 31);
            this.eDITToolStripMenuItem.Text = "EDIT";
            // 
            // eDITBOOKToolStripMenuItem
            // 
            this.eDITBOOKToolStripMenuItem.Name = "eDITBOOKToolStripMenuItem";
            this.eDITBOOKToolStripMenuItem.Size = new System.Drawing.Size(219, 32);
            this.eDITBOOKToolStripMenuItem.Text = "EDIT BOOK";
            // 
            // eDITGERNEToolStripMenuItem
            // 
            this.eDITGERNEToolStripMenuItem.Name = "eDITGERNEToolStripMenuItem";
            this.eDITGERNEToolStripMenuItem.Size = new System.Drawing.Size(219, 32);
            this.eDITGERNEToolStripMenuItem.Text = "EDIT GENRE";
            // 
            // rEMOVEToolStripMenuItem
            // 
            this.rEMOVEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEMOVEBOOKToolStripMenuItem,
            this.rEMOVEGENREToolStripMenuItem});
            this.rEMOVEToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.rEMOVEToolStripMenuItem.Name = "rEMOVEToolStripMenuItem";
            this.rEMOVEToolStripMenuItem.Size = new System.Drawing.Size(113, 31);
            this.rEMOVEToolStripMenuItem.Text = "REMOVE";
            // 
            // rEMOVEBOOKToolStripMenuItem
            // 
            this.rEMOVEBOOKToolStripMenuItem.Name = "rEMOVEBOOKToolStripMenuItem";
            this.rEMOVEBOOKToolStripMenuItem.Size = new System.Drawing.Size(259, 32);
            this.rEMOVEBOOKToolStripMenuItem.Text = "REMOVE BOOK";
            // 
            // rEMOVEGENREToolStripMenuItem
            // 
            this.rEMOVEGENREToolStripMenuItem.Name = "rEMOVEGENREToolStripMenuItem";
            this.rEMOVEGENREToolStripMenuItem.Size = new System.Drawing.Size(259, 32);
            this.rEMOVEGENREToolStripMenuItem.Text = "REMOVE GENRE";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDBOOKToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem1.Image = global::DBMS_FORM.Properties.Resources.bookm;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(93, 31);
            this.toolStripMenuItem1.Text = "ADD";
            // 
            // aDDBOOKToolStripMenuItem
            // 
            this.aDDBOOKToolStripMenuItem.Name = "aDDBOOKToolStripMenuItem";
            this.aDDBOOKToolStripMenuItem.Size = new System.Drawing.Size(211, 32);
            this.aDDBOOKToolStripMenuItem.Text = "ADD BOOK";
            // 
            // BookManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1238, 705);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "BookManagementForm";
            this.Text = "BookManagementForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aDDBOOKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITBOOKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITGERNEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEMOVEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEMOVEBOOKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEMOVEGENREToolStripMenuItem;
    }
}