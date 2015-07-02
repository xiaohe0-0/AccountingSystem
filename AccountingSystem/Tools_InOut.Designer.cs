namespace AccountingSystem
{
    partial class Tools_InOut
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
            this.textBox_ori = new System.Windows.Forms.TextBox();
            this.textBox_interest = new System.Windows.Forms.TextBox();
            this.textBox_res = new System.Windows.Forms.TextBox();
            this.comboBox_year = new System.Windows.Forms.ComboBox();
            this.btn_cal = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "每月存入金额：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "存入期限：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "利率(%)：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "最终本息金额：";
            // 
            // textBox_ori
            // 
            this.textBox_ori.Location = new System.Drawing.Point(124, 36);
            this.textBox_ori.Name = "textBox_ori";
            this.textBox_ori.Size = new System.Drawing.Size(110, 21);
            this.textBox_ori.TabIndex = 4;
            // 
            // textBox_interest
            // 
            this.textBox_interest.Location = new System.Drawing.Point(124, 101);
            this.textBox_interest.Name = "textBox_interest";
            this.textBox_interest.Size = new System.Drawing.Size(110, 21);
            this.textBox_interest.TabIndex = 5;
            // 
            // textBox_res
            // 
            this.textBox_res.Location = new System.Drawing.Point(124, 133);
            this.textBox_res.Name = "textBox_res";
            this.textBox_res.ReadOnly = true;
            this.textBox_res.Size = new System.Drawing.Size(110, 21);
            this.textBox_res.TabIndex = 6;
            // 
            // comboBox_year
            // 
            this.comboBox_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_year.FormattingEnabled = true;
            this.comboBox_year.Items.AddRange(new object[] {
            "一年",
            "三年",
            "五年"});
            this.comboBox_year.Location = new System.Drawing.Point(124, 67);
            this.comboBox_year.Name = "comboBox_year";
            this.comboBox_year.Size = new System.Drawing.Size(110, 20);
            this.comboBox_year.TabIndex = 7;
            this.comboBox_year.SelectedIndexChanged += new System.EventHandler(this.comboBox_year_SelectedIndexChanged);
            // 
            // btn_cal
            // 
            this.btn_cal.Location = new System.Drawing.Point(79, 182);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(63, 23);
            this.btn_cal.TabIndex = 8;
            this.btn_cal.Text = "计算";
            this.btn_cal.UseVisualStyleBackColor = true;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(159, 182);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(64, 23);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "关闭";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Tools_InOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 236);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_cal);
            this.Controls.Add(this.comboBox_year);
            this.Controls.Add(this.textBox_res);
            this.Controls.Add(this.textBox_interest);
            this.Controls.Add(this.textBox_ori);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Tools_InOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "零存整取计算器";
            this.Load += new System.EventHandler(this.Tools_InOut_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_ori;
        private System.Windows.Forms.TextBox textBox_interest;
        private System.Windows.Forms.TextBox textBox_res;
        private System.Windows.Forms.ComboBox comboBox_year;
        private System.Windows.Forms.Button btn_cal;
        private System.Windows.Forms.Button btn_exit;
    }
}