namespace AccountingSystem
{
    partial class Account_Class
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_delIn = new System.Windows.Forms.Button();
            this.dataGridView_in = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_delOut = new System.Windows.Forms.Button();
            this.dataGridView_out = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox_inOut = new System.Windows.Forms.ComboBox();
            this.btn_addOK = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_in)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_out)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_delIn);
            this.groupBox1.Controls.Add(this.dataGridView_in);
            this.groupBox1.Location = new System.Drawing.Point(320, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 309);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "收入分类";
            // 
            // btn_delIn
            // 
            this.btn_delIn.Location = new System.Drawing.Point(179, 272);
            this.btn_delIn.Name = "btn_delIn";
            this.btn_delIn.Size = new System.Drawing.Size(75, 23);
            this.btn_delIn.TabIndex = 1;
            this.btn_delIn.Text = "删除";
            this.btn_delIn.UseVisualStyleBackColor = true;
            this.btn_delIn.Click += new System.EventHandler(this.btn_delIn_Click);
            // 
            // dataGridView_in
            // 
            this.dataGridView_in.AllowUserToAddRows = false;
            this.dataGridView_in.AllowUserToDeleteRows = false;
            this.dataGridView_in.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_in.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_in.Location = new System.Drawing.Point(7, 21);
            this.dataGridView_in.Name = "dataGridView_in";
            this.dataGridView_in.ReadOnly = true;
            this.dataGridView_in.RowTemplate.Height = 23;
            this.dataGridView_in.Size = new System.Drawing.Size(247, 245);
            this.dataGridView_in.TabIndex = 0;
            this.dataGridView_in.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView_in_RowPrePaint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_delOut);
            this.groupBox2.Controls.Add(this.dataGridView_out);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 309);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "支出分类";
            // 
            // btn_delOut
            // 
            this.btn_delOut.Location = new System.Drawing.Point(179, 272);
            this.btn_delOut.Name = "btn_delOut";
            this.btn_delOut.Size = new System.Drawing.Size(75, 23);
            this.btn_delOut.TabIndex = 2;
            this.btn_delOut.Text = "删除";
            this.btn_delOut.UseVisualStyleBackColor = true;
            this.btn_delOut.Click += new System.EventHandler(this.btn_delOut_Click);
            // 
            // dataGridView_out
            // 
            this.dataGridView_out.AllowUserToAddRows = false;
            this.dataGridView_out.AllowUserToDeleteRows = false;
            this.dataGridView_out.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_out.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_out.Location = new System.Drawing.Point(7, 21);
            this.dataGridView_out.Name = "dataGridView_out";
            this.dataGridView_out.ReadOnly = true;
            this.dataGridView_out.RowTemplate.Height = 23;
            this.dataGridView_out.Size = new System.Drawing.Size(247, 245);
            this.dataGridView_out.TabIndex = 1;
            this.dataGridView_out.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView_out_RowPrePaint);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox_inOut);
            this.groupBox3.Controls.Add(this.btn_addOK);
            this.groupBox3.Controls.Add(this.textBox_name);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(624, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(208, 192);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "增加分类";
            // 
            // comboBox_inOut
            // 
            this.comboBox_inOut.FormattingEnabled = true;
            this.comboBox_inOut.Items.AddRange(new object[] {
            "支出",
            "收入"});
            this.comboBox_inOut.Location = new System.Drawing.Point(90, 50);
            this.comboBox_inOut.Name = "comboBox_inOut";
            this.comboBox_inOut.Size = new System.Drawing.Size(100, 20);
            this.comboBox_inOut.TabIndex = 6;
            // 
            // btn_addOK
            // 
            this.btn_addOK.Location = new System.Drawing.Point(105, 115);
            this.btn_addOK.Name = "btn_addOK";
            this.btn_addOK.Size = new System.Drawing.Size(85, 23);
            this.btn_addOK.TabIndex = 5;
            this.btn_addOK.Text = "确定增加";
            this.btn_addOK.UseVisualStyleBackColor = true;
            this.btn_addOK.Click += new System.EventHandler(this.btn_addOK_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(90, 77);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 21);
            this.textBox_name.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "账目名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "账目收支：";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(739, 257);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 50);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "关闭";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Account_Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 333);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Account_Class";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "记账分类";
            this.Load += new System.EventHandler(this.Account_Class_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_in)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_out)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView_in;
        private System.Windows.Forms.DataGridView dataGridView_out;
        private System.Windows.Forms.Button btn_delIn;
        private System.Windows.Forms.Button btn_delOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_inOut;
        private System.Windows.Forms.Button btn_addOK;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button btn_exit;
    }
}