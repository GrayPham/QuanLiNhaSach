namespace DBMS_FORM.BookManager
{
    partial class AddGenre
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
            this.addbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.genrenametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.genreidtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radiono
            // 
            this.radiono.AutoSize = true;
            this.radiono.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiono.ForeColor = System.Drawing.Color.White;
            this.radiono.Location = new System.Drawing.Point(501, 297);
            this.radiono.Name = "radiono";
            this.radiono.Size = new System.Drawing.Size(63, 31);
            this.radiono.TabIndex = 143;
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
            this.radioyes.Location = new System.Drawing.Point(402, 297);
            this.radioyes.Name = "radioyes";
            this.radioyes.Size = new System.Drawing.Size(68, 31);
            this.radioyes.TabIndex = 142;
            this.radioyes.TabStop = true;
            this.radioyes.Text = "Yes";
            this.radioyes.UseVisualStyleBackColor = true;
            // 
            // closebtn
            // 
            this.closebtn.BackColor = System.Drawing.Color.Tan;
            this.closebtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtn.Location = new System.Drawing.Point(441, 369);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(188, 48);
            this.closebtn.TabIndex = 141;
            this.closebtn.Text = "CLOSE";
            this.closebtn.UseVisualStyleBackColor = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.addbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(177, 369);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(188, 48);
            this.addbtn.TabIndex = 140;
            this.addbtn.Text = "ADD";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(172, 297);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 27);
            this.label4.TabIndex = 139;
            this.label4.Text = "Removed";
            // 
            // genrenametxt
            // 
            this.genrenametxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genrenametxt.Location = new System.Drawing.Point(351, 202);
            this.genrenametxt.Margin = new System.Windows.Forms.Padding(4);
            this.genrenametxt.Name = "genrenametxt";
            this.genrenametxt.Size = new System.Drawing.Size(278, 33);
            this.genrenametxt.TabIndex = 138;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(172, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 27);
            this.label3.TabIndex = 137;
            this.label3.Text = "Genre Name";
            // 
            // genreidtxt
            // 
            this.genreidtxt.AcceptsReturn = true;
            this.genreidtxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreidtxt.Location = new System.Drawing.Point(351, 114);
            this.genreidtxt.Margin = new System.Windows.Forms.Padding(4);
            this.genreidtxt.Name = "genreidtxt";
            this.genreidtxt.Size = new System.Drawing.Size(278, 33);
            this.genreidtxt.TabIndex = 136;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(172, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 27);
            this.label2.TabIndex = 135;
            this.label2.Text = "Genre ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(324, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 52);
            this.label1.TabIndex = 134;
            this.label1.Text = "GENRE";
            // 
            // AddGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radiono);
            this.Controls.Add(this.radioyes);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.genrenametxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.genreidtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddGenre";
            this.Text = "AddGenre";
            this.Load += new System.EventHandler(this.AddGenre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radiono;
        private System.Windows.Forms.RadioButton radioyes;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox genrenametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox genreidtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}