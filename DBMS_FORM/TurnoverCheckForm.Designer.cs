namespace DBMS_FORM
{
    partial class TurnoverCheckForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonYear = new System.Windows.Forms.RadioButton();
            this.radioButtonMouth = new System.Windows.Forms.RadioButton();
            this.radioButtonDay = new System.Windows.Forms.RadioButton();
            this.btnCheck = new System.Windows.Forms.Button();
            this.DVGTurnOver = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.lbNameuser = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DVGTurnOver)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.radioButtonYear);
            this.panel1.Controls.Add(this.radioButtonMouth);
            this.panel1.Controls.Add(this.radioButtonDay);
            this.panel1.Location = new System.Drawing.Point(29, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 164);
            this.panel1.TabIndex = 3;
            // 
            // radioButtonYear
            // 
            this.radioButtonYear.AutoSize = true;
            this.radioButtonYear.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonYear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonYear.Location = new System.Drawing.Point(7, 112);
            this.radioButtonYear.Name = "radioButtonYear";
            this.radioButtonYear.Size = new System.Drawing.Size(138, 31);
            this.radioButtonYear.TabIndex = 5;
            this.radioButtonYear.TabStop = true;
            this.radioButtonYear.Text = "Year Check";
            this.radioButtonYear.UseVisualStyleBackColor = true;
            // 
            // radioButtonMouth
            // 
            this.radioButtonMouth.AutoSize = true;
            this.radioButtonMouth.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMouth.ForeColor = System.Drawing.Color.White;
            this.radioButtonMouth.Location = new System.Drawing.Point(7, 57);
            this.radioButtonMouth.Name = "radioButtonMouth";
            this.radioButtonMouth.Size = new System.Drawing.Size(160, 31);
            this.radioButtonMouth.TabIndex = 4;
            this.radioButtonMouth.TabStop = true;
            this.radioButtonMouth.Text = "Month Check";
            this.radioButtonMouth.UseVisualStyleBackColor = true;
            // 
            // radioButtonDay
            // 
            this.radioButtonDay.AutoSize = true;
            this.radioButtonDay.Checked = true;
            this.radioButtonDay.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDay.ForeColor = System.Drawing.Color.White;
            this.radioButtonDay.Location = new System.Drawing.Point(7, 2);
            this.radioButtonDay.Name = "radioButtonDay";
            this.radioButtonDay.Size = new System.Drawing.Size(133, 31);
            this.radioButtonDay.TabIndex = 3;
            this.radioButtonDay.TabStop = true;
            this.radioButtonDay.Text = "Day Check";
            this.radioButtonDay.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCheck.Location = new System.Drawing.Point(29, 245);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(257, 34);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "CHECK";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // DVGTurnOver
            // 
            this.DVGTurnOver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DVGTurnOver.Location = new System.Drawing.Point(299, 55);
            this.DVGTurnOver.Name = "DVGTurnOver";
            this.DVGTurnOver.RowHeadersWidth = 51;
            this.DVGTurnOver.RowTemplate.Height = 24;
            this.DVGTurnOver.Size = new System.Drawing.Size(473, 413);
            this.DVGTurnOver.TabIndex = 5;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrint.Location = new System.Drawing.Point(29, 309);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(257, 34);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(29, 371);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(257, 34);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_name.Location = new System.Drawing.Point(151, 12);
            this.label_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(135, 29);
            this.label_name.TabIndex = 10;
            this.label_name.Text = "Name User";
            // 
            // lbNameuser
            // 
            this.lbNameuser.AutoSize = true;
            this.lbNameuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameuser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNameuser.Location = new System.Drawing.Point(13, 12);
            this.lbNameuser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNameuser.Name = "lbNameuser";
            this.lbNameuser.Size = new System.Drawing.Size(135, 29);
            this.lbNameuser.TabIndex = 8;
            this.lbNameuser.Text = "Name User";
            // 
            // TurnoverCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(784, 480);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.lbNameuser);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.DVGTurnOver);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.panel1);
            this.Name = "TurnoverCheckForm";
            this.Text = "TurnoverCheckForm";
            this.Load += new System.EventHandler(this.TurnoverCheckForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DVGTurnOver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonYear;
        private System.Windows.Forms.RadioButton radioButtonMouth;
        private System.Windows.Forms.RadioButton radioButtonDay;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.DataGridView DVGTurnOver;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label lbNameuser;
    }
}