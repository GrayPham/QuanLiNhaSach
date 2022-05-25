namespace DBMS_FORM.BookManager
{
    partial class AddProvider
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.removebtn = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.radiono = new System.Windows.Forms.RadioButton();
            this.radioyes = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.proidtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mailtxt = new System.Windows.Forms.TextBox();
            this.addtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pronametxt = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(908, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(530, 364);
            this.dataGridView1.TabIndex = 158;
            // 
            // removebtn
            // 
            this.removebtn.BackColor = System.Drawing.Color.DarkRed;
            this.removebtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removebtn.Location = new System.Drawing.Point(334, 359);
            this.removebtn.Name = "removebtn";
            this.removebtn.Size = new System.Drawing.Size(271, 48);
            this.removebtn.TabIndex = 156;
            this.removebtn.Text = "REMOVE";
            this.removebtn.UseVisualStyleBackColor = false;
            this.removebtn.Click += new System.EventHandler(this.removebtn_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Tan;
            this.btnclose.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(629, 359);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(271, 48);
            this.btnclose.TabIndex = 155;
            this.btnclose.Text = "CLOSE";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.addbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(43, 359);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(271, 48);
            this.addbtn.TabIndex = 154;
            this.addbtn.Text = "ADD";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(38, 301);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 27);
            this.label8.TabIndex = 153;
            this.label8.Text = "Active";
            // 
            // radiono
            // 
            this.radiono.AutoSize = true;
            this.radiono.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiono.ForeColor = System.Drawing.Color.White;
            this.radiono.Location = new System.Drawing.Point(106, 3);
            this.radiono.Name = "radiono";
            this.radiono.Size = new System.Drawing.Size(63, 31);
            this.radiono.TabIndex = 138;
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
            this.radioyes.Location = new System.Drawing.Point(9, 3);
            this.radioyes.Name = "radioyes";
            this.radioyes.Size = new System.Drawing.Size(68, 31);
            this.radioyes.TabIndex = 137;
            this.radioyes.TabStop = true;
            this.radioyes.Text = "Yes";
            this.radioyes.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radiono);
            this.panel1.Controls.Add(this.radioyes);
            this.panel1.Location = new System.Drawing.Point(218, 287);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 41);
            this.panel1.TabIndex = 157;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(415, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 52);
            this.label1.TabIndex = 152;
            this.label1.Text = "PROVIDER";
            // 
            // proidtxt
            // 
            this.proidtxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proidtxt.Location = new System.Drawing.Point(218, 150);
            this.proidtxt.Margin = new System.Windows.Forms.Padding(4);
            this.proidtxt.Name = "proidtxt";
            this.proidtxt.Size = new System.Drawing.Size(231, 33);
            this.proidtxt.TabIndex = 151;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(38, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 27);
            this.label2.TabIndex = 150;
            this.label2.Text = "Provider ID ";
            // 
            // mailtxt
            // 
            this.mailtxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailtxt.Location = new System.Drawing.Point(669, 229);
            this.mailtxt.Margin = new System.Windows.Forms.Padding(4);
            this.mailtxt.Name = "mailtxt";
            this.mailtxt.Size = new System.Drawing.Size(231, 33);
            this.mailtxt.TabIndex = 149;
            // 
            // addtxt
            // 
            this.addtxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addtxt.Location = new System.Drawing.Point(218, 229);
            this.addtxt.Margin = new System.Windows.Forms.Padding(4);
            this.addtxt.Name = "addtxt";
            this.addtxt.Size = new System.Drawing.Size(231, 33);
            this.addtxt.TabIndex = 148;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(37, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 27);
            this.label3.TabIndex = 147;
            this.label3.Text = "Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(490, 229);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 27);
            this.label10.TabIndex = 146;
            this.label10.Text = "Mail";
            // 
            // pronametxt
            // 
            this.pronametxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pronametxt.Location = new System.Drawing.Point(669, 150);
            this.pronametxt.Margin = new System.Windows.Forms.Padding(4);
            this.pronametxt.Name = "pronametxt";
            this.pronametxt.Size = new System.Drawing.Size(231, 33);
            this.pronametxt.TabIndex = 145;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label.Location = new System.Drawing.Point(489, 150);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(164, 27);
            this.label.TabIndex = 144;
            this.label.Text = "Provider Name";
            // 
            // AddProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1475, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.removebtn);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.proidtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mailtxt);
            this.Controls.Add(this.addtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pronametxt);
            this.Controls.Add(this.label);
            this.Name = "AddProvider";
            this.Text = "AddProvider";
            this.Load += new System.EventHandler(this.AddProvider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button removebtn;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radiono;
        private System.Windows.Forms.RadioButton radioyes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox proidtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mailtxt;
        private System.Windows.Forms.TextBox addtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox pronametxt;
        private System.Windows.Forms.Label label;
    }
}