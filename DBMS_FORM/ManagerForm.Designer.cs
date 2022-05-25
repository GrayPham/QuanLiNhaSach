namespace DBMS_FORM
{
    partial class Manager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.DVGNhanVien = new System.Windows.Forms.DataGridView();
            this.lbNameuser = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.providerManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnoverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProviderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addGenreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importBookToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editGenreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DVGNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 30);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importBookToolStripMenuItem,
            this.staffManagementToolStripMenuItem,
            this.turnoverToolStripMenuItem,
            this.providerManagementToolStripMenuItem,
            this.bookManagerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // DVGNhanVien
            // 
            this.DVGNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DVGNhanVien.Location = new System.Drawing.Point(12, 90);
            this.DVGNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DVGNhanVien.Name = "DVGNhanVien";
            this.DVGNhanVien.RowHeadersWidth = 51;
            this.DVGNhanVien.RowTemplate.Height = 24;
            this.DVGNhanVien.Size = new System.Drawing.Size(776, 338);
            this.DVGNhanVien.TabIndex = 1;
            // 
            // lbNameuser
            // 
            this.lbNameuser.AutoSize = true;
            this.lbNameuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameuser.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbNameuser.Location = new System.Drawing.Point(15, 50);
            this.lbNameuser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNameuser.Name = "lbNameuser";
            this.lbNameuser.Size = new System.Drawing.Size(110, 25);
            this.lbNameuser.TabIndex = 59;
            this.lbNameuser.Text = "Name User";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_name.Location = new System.Drawing.Point(163, 50);
            this.label_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(110, 25);
            this.label_name.TabIndex = 61;
            this.label_name.Text = "Name User";
            // 
            // providerManagementToolStripMenuItem
            // 
            this.providerManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProviderToolStripMenuItem});
            this.providerManagementToolStripMenuItem.Name = "providerManagementToolStripMenuItem";
            this.providerManagementToolStripMenuItem.Size = new System.Drawing.Size(170, 34);
            this.providerManagementToolStripMenuItem.Text = "Provider Management";
            this.providerManagementToolStripMenuItem.Click += new System.EventHandler(this.providerManagementToolStripMenuItem_Click);
            // 
            // importBookToolStripMenuItem
            // 
            this.importBookToolStripMenuItem.Image = global::DBMS_FORM.Properties.Resources.Book_icon_bible;
            this.importBookToolStripMenuItem.Name = "importBookToolStripMenuItem";
            this.importBookToolStripMenuItem.Size = new System.Drawing.Size(126, 34);
            this.importBookToolStripMenuItem.Text = "Import Book";
            this.importBookToolStripMenuItem.Click += new System.EventHandler(this.importBookToolStripMenuItem_Click);
            // 
            // staffManagementToolStripMenuItem
            // 
            this.staffManagementToolStripMenuItem.Image = global::DBMS_FORM.Properties.Resources.staff_icostafficon;
            this.staffManagementToolStripMenuItem.Name = "staffManagementToolStripMenuItem";
            this.staffManagementToolStripMenuItem.Size = new System.Drawing.Size(166, 34);
            this.staffManagementToolStripMenuItem.Text = "Staff Management";
            this.staffManagementToolStripMenuItem.Click += new System.EventHandler(this.staffManagementToolStripMenuItem_Click);
            // 
            // turnoverToolStripMenuItem
            // 
            this.turnoverToolStripMenuItem.Image = global::DBMS_FORM.Properties.Resources.turnover_png;
            this.turnoverToolStripMenuItem.Name = "turnoverToolStripMenuItem";
            this.turnoverToolStripMenuItem.Size = new System.Drawing.Size(101, 34);
            this.turnoverToolStripMenuItem.Text = "Turnover";
            this.turnoverToolStripMenuItem.Click += new System.EventHandler(this.turnoverToolStripMenuItem_Click);
            // 
            // addProviderToolStripMenuItem
            // 
            this.addProviderToolStripMenuItem.Name = "addProviderToolStripMenuItem";
            this.addProviderToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addProviderToolStripMenuItem.Text = "Add Provider";
            this.addProviderToolStripMenuItem.Click += new System.EventHandler(this.addProviderToolStripMenuItem_Click);
            // 
            // bookManagerToolStripMenuItem
            // 
            this.bookManagerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editBookToolStripMenuItem,
            this.addGenreToolStripMenuItem,
            this.importBookToolStripMenuItem1,
            this.editGenreToolStripMenuItem});
            this.bookManagerToolStripMenuItem.Name = "bookManagerToolStripMenuItem";
            this.bookManagerToolStripMenuItem.Size = new System.Drawing.Size(120, 34);
            this.bookManagerToolStripMenuItem.Text = "Book Manager";
            // 
            // editBookToolStripMenuItem
            // 
            this.editBookToolStripMenuItem.Name = "editBookToolStripMenuItem";
            this.editBookToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editBookToolStripMenuItem.Text = "Edit Book";
            this.editBookToolStripMenuItem.Click += new System.EventHandler(this.editBookToolStripMenuItem_Click_1);
            // 
            // addGenreToolStripMenuItem
            // 
            this.addGenreToolStripMenuItem.Name = "addGenreToolStripMenuItem";
            this.addGenreToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addGenreToolStripMenuItem.Text = "Add Genre";
            this.addGenreToolStripMenuItem.Click += new System.EventHandler(this.addGenreToolStripMenuItem_Click);
            // 
            // importBookToolStripMenuItem1
            // 
            this.importBookToolStripMenuItem1.Name = "importBookToolStripMenuItem1";
            this.importBookToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.importBookToolStripMenuItem1.Text = "Import Book";
            this.importBookToolStripMenuItem1.Click += new System.EventHandler(this.importBookToolStripMenuItem1_Click);
            // 
            // editGenreToolStripMenuItem
            // 
            this.editGenreToolStripMenuItem.Name = "editGenreToolStripMenuItem";
            this.editGenreToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editGenreToolStripMenuItem.Text = "Edit Genre";
            this.editGenreToolStripMenuItem.Click += new System.EventHandler(this.editGenreToolStripMenuItem_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.lbNameuser);
            this.Controls.Add(this.DVGNhanVien);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerForm";
            this.Load += new System.EventHandler(this.Manager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DVGNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem importBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnoverToolStripMenuItem;
        private System.Windows.Forms.DataGridView DVGNhanVien;
        private System.Windows.Forms.Label lbNameuser;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.ToolStripMenuItem providerManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProviderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addGenreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importBookToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editGenreToolStripMenuItem;
    }
}