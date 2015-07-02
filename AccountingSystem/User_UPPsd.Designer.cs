namespace AccountingSystem
{
    partial class User_UPPsd
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
            this.textBox_userName = new System.Windows.Forms.TextBox();
            this.textBox_oriPsd = new System.Windows.Forms.TextBox();
            this.textBox_newPsd = new System.Windows.Forms.TextBox();
            this.textBox_checkPsd = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "账户名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "原密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "新密码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "确认密码：";
            // 
            // textBox_userName
            // 
            this.textBox_userName.Location = new System.Drawing.Point(199, 31);
            this.textBox_userName.Name = "textBox_userName";
            this.textBox_userName.ReadOnly = true;
            this.textBox_userName.Size = new System.Drawing.Size(120, 21);
            this.textBox_userName.TabIndex = 10;
            // 
            // textBox_oriPsd
            // 
            this.textBox_oriPsd.Location = new System.Drawing.Point(199, 61);
            this.textBox_oriPsd.Name = "textBox_oriPsd";
            this.textBox_oriPsd.PasswordChar = '*';
            this.textBox_oriPsd.Size = new System.Drawing.Size(120, 21);
            this.textBox_oriPsd.TabIndex = 5;
            // 
            // textBox_newPsd
            // 
            this.textBox_newPsd.Location = new System.Drawing.Point(199, 88);
            this.textBox_newPsd.Name = "textBox_newPsd";
            this.textBox_newPsd.PasswordChar = '*';
            this.textBox_newPsd.Size = new System.Drawing.Size(120, 21);
            this.textBox_newPsd.TabIndex = 6;
            // 
            // textBox_checkPsd
            // 
            this.textBox_checkPsd.Location = new System.Drawing.Point(199, 119);
            this.textBox_checkPsd.Name = "textBox_checkPsd";
            this.textBox_checkPsd.PasswordChar = '*';
            this.textBox_checkPsd.Size = new System.Drawing.Size(120, 21);
            this.textBox_checkPsd.TabIndex = 7;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(194, 159);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(52, 23);
            this.btn_OK.TabIndex = 8;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(254, 159);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(52, 23);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // User_UPPsd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 199);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.textBox_checkPsd);
            this.Controls.Add(this.textBox_newPsd);
            this.Controls.Add(this.textBox_oriPsd);
            this.Controls.Add(this.textBox_userName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "User_UPPsd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "更改账户密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_userName;
        private System.Windows.Forms.TextBox textBox_oriPsd;
        private System.Windows.Forms.TextBox textBox_newPsd;
        private System.Windows.Forms.TextBox textBox_checkPsd;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_cancel;
    }
}