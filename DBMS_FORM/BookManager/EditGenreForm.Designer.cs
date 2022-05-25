namespace DBMS_FORM.BookManager
{
    partial class EditGenreForm
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
            this.radiono = new System.Windows.Forms.RadioButton();
            this.radioyes = new System.Windows.Forms.RadioButton();
            this.closebtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.GenreNametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.bookidtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radiono
            // 
            this.radiono.AutoSize = true;
            this.radiono.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiono.ForeColor = System.Drawing.Color.White;
            this.radiono.Location = new System.Drawing.Point(275, 241);
            this.radiono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radiono.Name = "radiono";
            this.radiono.Size = new System.Drawing.Size(53, 26);
            this.radiono.TabIndex = 123;
            this.radiono.TabStop = true;
            this.radiono.Text = "No";
            this.radiono.UseVisualStyleBackColor = true;
            // 
            // radioyes
            // 
            this.radioyes.AutoSize = true;
            this.radioyes.Checked = true;
            this.radioyes.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioyes.ForeColor = System.Drawing.Color.White;
            this.radioyes.Location = new System.Drawing.Point(201, 241);
            this.radioyes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioyes.Name = "radioyes";
            this.radioyes.Size = new System.Drawing.Size(55, 26);
            this.radioyes.TabIndex = 122;
            this.radioyes.TabStop = true;
            this.radioyes.Text = "Yes";
            this.radioyes.UseVisualStyleBackColor = true;
            // 
            // closebtn
            // 
            this.closebtn.BackColor = System.Drawing.Color.Tan;
            this.closebtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtn.Location = new System.Drawing.Point(230, 300);
            this.closebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(141, 39);
            this.closebtn.TabIndex = 121;
            this.closebtn.Text = "CLOSE";
            this.closebtn.UseVisualStyleBackColor = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.editbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbtn.Location = new System.Drawing.Point(32, 300);
            this.editbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(141, 39);
            this.editbtn.TabIndex = 120;
            this.editbtn.Text = "EDIT";
            this.editbtn.UseVisualStyleBackColor = false;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(28, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 22);
            this.label4.TabIndex = 119;
            this.label4.Text = "Removed";
            // 
            // GenreNametxt
            // 
            this.GenreNametxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreNametxt.Location = new System.Drawing.Point(163, 164);
            this.GenreNametxt.Name = "GenreNametxt";
            this.GenreNametxt.Size = new System.Drawing.Size(210, 28);
            this.GenreNametxt.TabIndex = 118;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(28, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 117;
            this.label3.Text = "Genre Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(142, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 42);
            this.label1.TabIndex = 114;
            this.label1.Text = "GENRE";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFind.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(307, 86);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(64, 39);
            this.btnFind.TabIndex = 127;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // bookidtxt
            // 
            this.bookidtxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookidtxt.Location = new System.Drawing.Point(163, 91);
            this.bookidtxt.Name = "bookidtxt";
            this.bookidtxt.Size = new System.Drawing.Size(128, 28);
            this.bookidtxt.TabIndex = 126;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(28, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 125;
            this.label2.Text = "Genre ID";
            // 
            // EditGenreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(399, 366);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.bookidtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radiono);
            this.Controls.Add(this.radioyes);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GenreNametxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditGenreForm";
            this.Text = "EditGenreForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radiono;
        private System.Windows.Forms.RadioButton radioyes;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GenreNametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox bookidtxt;
        private System.Windows.Forms.Label label2;
    }
}