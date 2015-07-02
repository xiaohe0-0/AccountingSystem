namespace AccountingSystem
{
    partial class Account_UPAccount
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
            this.dateTimePicker_acc = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lab_setAccClass = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.textBox_accCon = new System.Windows.Forms.TextBox();
            this.comboBox_accClass = new System.Windows.Forms.ComboBox();
            this.textBox_accNum = new System.Windows.Forms.TextBox();
            this.comboBox_accInOut = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker_acc
            // 
            this.dateTimePicker_acc.Location = new System.Drawing.Point(117, 131);
            this.dateTimePicker_acc.Name = "dateTimePicker_acc";
            this.dateTimePicker_acc.Size = new System.Drawing.Size(122, 21);
            this.dateTimePicker_acc.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "账目时间：";
            // 
            // lab_setAccClass
            // 
            this.lab_setAccClass.AutoSize = true;
            this.lab_setAccClass.Font = new System.Drawing.Font("KaiTi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_setAccClass.ForeColor = System.Drawing.Color.Firebrick;
            this.lab_setAccClass.Location = new System.Drawing.Point(246, 105);
            this.lab_setAccClass.Name = "lab_setAccClass";
            this.lab_setAccClass.Size = new System.Drawing.Size(65, 12);
            this.lab_setAccClass.TabIndex = 23;
            this.lab_setAccClass.Text = "分类设置>>";
            this.lab_setAccClass.Click += new System.EventHandler(this.lab_setAccClass_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(160, 204);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(62, 23);
            this.btn_cancel.TabIndex = 22;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(79, 204);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(63, 23);
            this.btn_OK.TabIndex = 21;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // textBox_accCon
            // 
            this.textBox_accCon.Location = new System.Drawing.Point(117, 161);
            this.textBox_accCon.Name = "textBox_accCon";
            this.textBox_accCon.Size = new System.Drawing.Size(121, 21);
            this.textBox_accCon.TabIndex = 20;
            // 
            // comboBox_accClass
            // 
            this.comboBox_accClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_accClass.FormattingEnabled = true;
            this.comboBox_accClass.Location = new System.Drawing.Point(118, 99);
            this.comboBox_accClass.Name = "comboBox_accClass";
            this.comboBox_accClass.Size = new System.Drawing.Size(121, 20);
            this.comboBox_accClass.TabIndex = 18;
            // 
            // textBox_accNum
            // 
            this.textBox_accNum.Location = new System.Drawing.Point(118, 66);
            this.textBox_accNum.Name = "textBox_accNum";
            this.textBox_accNum.Size = new System.Drawing.Size(120, 21);
            this.textBox_accNum.TabIndex = 17;
            // 
            // comboBox_accInOut
            // 
            this.comboBox_accInOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_accInOut.FormattingEnabled = true;
            this.comboBox_accInOut.Items.AddRange(new object[] {
            "支出",
            "收入"});
            this.comboBox_accInOut.Location = new System.Drawing.Point(117, 34);
            this.comboBox_accInOut.Name = "comboBox_accInOut";
            this.comboBox_accInOut.Size = new System.Drawing.Size(121, 20);
            this.comboBox_accInOut.TabIndex = 16;
            this.comboBox_accInOut.SelectedIndexChanged += new System.EventHandler(this.comboBox_accInOut_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "备注说明：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "账目分类：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "账目金额：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "账目类型：";
            // 
            // Account_UPAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 239);
            this.Controls.Add(this.dateTimePicker_acc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lab_setAccClass);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.textBox_accCon);
            this.Controls.Add(this.comboBox_accClass);
            this.Controls.Add(this.textBox_accNum);
            this.Controls.Add(this.comboBox_accInOut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Account_UPAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改账目";
            this.Load += new System.EventHandler(this.Account_UPAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_acc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lab_setAccClass;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.TextBox textBox_accCon;
        private System.Windows.Forms.ComboBox comboBox_accClass;
        private System.Windows.Forms.TextBox textBox_accNum;
        private System.Windows.Forms.ComboBox comboBox_accInOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}