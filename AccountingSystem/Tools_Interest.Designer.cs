namespace AccountingSystem
{
    partial class Tools_Interest
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_cal = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.textBox_ori = new System.Windows.Forms.TextBox();
            this.textBox_interest = new System.Windows.Forms.TextBox();
            this.textBox_times = new System.Windows.Forms.TextBox();
            this.textBox_res = new System.Windows.Forms.TextBox();
            this.comboBox_year = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "存入金额：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "年利率(%)：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "存入年限：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "复利次数：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "复利终值：";
            // 
            // btn_cal
            // 
            this.btn_cal.Location = new System.Drawing.Point(70, 217);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(61, 23);
            this.btn_cal.TabIndex = 5;
            this.btn_cal.Text = "计算";
            this.btn_cal.UseVisualStyleBackColor = true;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(151, 217);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(61, 23);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "关闭";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // textBox_ori
            // 
            this.textBox_ori.Location = new System.Drawing.Point(107, 35);
            this.textBox_ori.Name = "textBox_ori";
            this.textBox_ori.Size = new System.Drawing.Size(140, 21);
            this.textBox_ori.TabIndex = 7;
            // 
            // textBox_interest
            // 
            this.textBox_interest.Location = new System.Drawing.Point(107, 99);
            this.textBox_interest.Name = "textBox_interest";
            this.textBox_interest.Size = new System.Drawing.Size(140, 21);
            this.textBox_interest.TabIndex = 8;
            // 
            // textBox_times
            // 
            this.textBox_times.Location = new System.Drawing.Point(107, 133);
            this.textBox_times.Name = "textBox_times";
            this.textBox_times.Size = new System.Drawing.Size(140, 21);
            this.textBox_times.TabIndex = 10;
            // 
            // textBox_res
            // 
            this.textBox_res.Location = new System.Drawing.Point(107, 168);
            this.textBox_res.Name = "textBox_res";
            this.textBox_res.ReadOnly = true;
            this.textBox_res.Size = new System.Drawing.Size(140, 21);
            this.textBox_res.TabIndex = 11;
            // 
            // comboBox_year
            // 
            this.comboBox_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_year.FormattingEnabled = true;
            this.comboBox_year.Items.AddRange(new object[] {
            "三个月",
            "六个月",
            "一年",
            "两年",
            "三年"});
            this.comboBox_year.Location = new System.Drawing.Point(107, 67);
            this.comboBox_year.Name = "comboBox_year";
            this.comboBox_year.Size = new System.Drawing.Size(140, 20);
            this.comboBox_year.TabIndex = 12;
            this.comboBox_year.SelectedIndexChanged += new System.EventHandler(this.comboBox_year_SelectedIndexChanged);
            // 
            // Tools_Interest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 276);
            this.Controls.Add(this.comboBox_year);
            this.Controls.Add(this.textBox_res);
            this.Controls.Add(this.textBox_times);
            this.Controls.Add(this.textBox_interest);
            this.Controls.Add(this.textBox_ori);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_cal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Tools_Interest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "复利计算器";
            this.Load += new System.EventHandler(this.Tools_Interest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_cal;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox textBox_ori;
        private System.Windows.Forms.TextBox textBox_interest;
        private System.Windows.Forms.TextBox textBox_times;
        private System.Windows.Forms.TextBox textBox_res;
        private System.Windows.Forms.ComboBox comboBox_year;
    }
}