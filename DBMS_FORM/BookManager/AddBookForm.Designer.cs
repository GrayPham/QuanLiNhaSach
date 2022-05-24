namespace DBMS_FORM.BookManager
{
    partial class AddBookForm
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
            this.btnclose = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.radiono = new System.Windows.Forms.RadioButton();
            this.radioyes = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bookidtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.publishyeartxt = new System.Windows.Forms.TextBox();
            this.dateaddtxt = new System.Windows.Forms.TextBox();
            this.deletedatetxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.genreidtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.booknametxt = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.DarkRed;
            this.btnclose.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(522, 471);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(263, 48);
            this.btnclose.TabIndex = 113;
            this.btnclose.Text = "CLOSE";
            this.btnclose.UseVisualStyleBackColor = false;
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.Green;
            this.addbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(128, 471);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(263, 48);
            this.addbtn.TabIndex = 112;
            this.addbtn.Text = "ADD";
            this.addbtn.UseVisualStyleBackColor = false;
            // 
            // radiono
            // 
            this.radiono.AutoSize = true;
            this.radiono.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiono.ForeColor = System.Drawing.Color.White;
            this.radiono.Location = new System.Drawing.Point(328, 414);
            this.radiono.Name = "radiono";
            this.radiono.Size = new System.Drawing.Size(63, 31);
            this.radiono.TabIndex = 111;
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
            this.radioyes.Location = new System.Drawing.Point(231, 414);
            this.radioyes.Name = "radioyes";
            this.radioyes.Size = new System.Drawing.Size(68, 31);
            this.radioyes.TabIndex = 110;
            this.radioyes.TabStop = true;
            this.radioyes.Text = "Yes";
            this.radioyes.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(654, 323);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(231, 33);
            this.numericUpDown1.TabIndex = 109;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(475, 329);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 27);
            this.label9.TabIndex = 108;
            this.label9.Text = "Quantity left";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(22, 414);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 27);
            this.label8.TabIndex = 107;
            this.label8.Text = "Deleted";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(24, 328);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 27);
            this.label7.TabIndex = 106;
            this.label7.Text = "Delete Date";
            // 
            // bookidtxt
            // 
            this.bookidtxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookidtxt.Location = new System.Drawing.Point(203, 50);
            this.bookidtxt.Margin = new System.Windows.Forms.Padding(4);
            this.bookidtxt.Name = "bookidtxt";
            this.bookidtxt.Size = new System.Drawing.Size(231, 33);
            this.bookidtxt.TabIndex = 105;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(23, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 27);
            this.label1.TabIndex = 104;
            this.label1.Text = "Book ID";
            // 
            // publishyeartxt
            // 
            this.publishyeartxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publishyeartxt.Location = new System.Drawing.Point(203, 226);
            this.publishyeartxt.Margin = new System.Windows.Forms.Padding(4);
            this.publishyeartxt.Name = "publishyeartxt";
            this.publishyeartxt.Size = new System.Drawing.Size(231, 33);
            this.publishyeartxt.TabIndex = 103;
            // 
            // dateaddtxt
            // 
            this.dateaddtxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateaddtxt.Location = new System.Drawing.Point(654, 129);
            this.dateaddtxt.Margin = new System.Windows.Forms.Padding(4);
            this.dateaddtxt.Name = "dateaddtxt";
            this.dateaddtxt.Size = new System.Drawing.Size(231, 33);
            this.dateaddtxt.TabIndex = 102;
            // 
            // deletedatetxt
            // 
            this.deletedatetxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletedatetxt.Location = new System.Drawing.Point(203, 322);
            this.deletedatetxt.Margin = new System.Windows.Forms.Padding(4);
            this.deletedatetxt.Name = "deletedatetxt";
            this.deletedatetxt.Size = new System.Drawing.Size(231, 33);
            this.deletedatetxt.TabIndex = 101;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(24, 328);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 27);
            this.label6.TabIndex = 100;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(24, 229);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 27);
            this.label5.TabIndex = 99;
            this.label5.Text = "Publish Year";
            // 
            // genreidtxt
            // 
            this.genreidtxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreidtxt.Location = new System.Drawing.Point(654, 226);
            this.genreidtxt.Margin = new System.Windows.Forms.Padding(4);
            this.genreidtxt.Name = "genreidtxt";
            this.genreidtxt.Size = new System.Drawing.Size(231, 33);
            this.genreidtxt.TabIndex = 98;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(475, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 27);
            this.label4.TabIndex = 97;
            this.label4.Text = "Genre ID";
            // 
            // pricetxt
            // 
            this.pricetxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetxt.Location = new System.Drawing.Point(203, 129);
            this.pricetxt.Margin = new System.Windows.Forms.Padding(4);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(231, 33);
            this.pricetxt.TabIndex = 96;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(22, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 27);
            this.label3.TabIndex = 95;
            this.label3.Text = "Unit Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(475, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 27);
            this.label2.TabIndex = 94;
            this.label2.Text = "Date Added";
            // 
            // booknametxt
            // 
            this.booknametxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booknametxt.Location = new System.Drawing.Point(654, 50);
            this.booknametxt.Margin = new System.Windows.Forms.Padding(4);
            this.booknametxt.Name = "booknametxt";
            this.booknametxt.Size = new System.Drawing.Size(231, 33);
            this.booknametxt.TabIndex = 93;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label.Location = new System.Drawing.Point(474, 50);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(131, 27);
            this.label.TabIndex = 92;
            this.label.Text = "Book Name";
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(906, 569);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.radiono);
            this.Controls.Add(this.radioyes);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bookidtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.publishyeartxt);
            this.Controls.Add(this.dateaddtxt);
            this.Controls.Add(this.deletedatetxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.genreidtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pricetxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.booknametxt);
            this.Controls.Add(this.label);
            this.Name = "AddBookForm";
            this.Text = "AddBookForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.RadioButton radiono;
        private System.Windows.Forms.RadioButton radioyes;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox bookidtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox publishyeartxt;
        private System.Windows.Forms.TextBox dateaddtxt;
        private System.Windows.Forms.TextBox deletedatetxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox genreidtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox booknametxt;
        private System.Windows.Forms.Label label;
    }
}