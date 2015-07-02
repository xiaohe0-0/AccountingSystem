namespace AccountingSystem
{
    partial class Login
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
            this.lab_logName = new System.Windows.Forms.Label();
            this.textBox_logName = new System.Windows.Forms.TextBox();
            this.textBox_logPsd = new System.Windows.Forms.TextBox();
            this.lab_logPsd = new System.Windows.Forms.Label();
            this.btn_logOK = new System.Windows.Forms.Button();
            this.btn_logCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_logName
            // 
            this.lab_logName.AutoSize = true;
            this.lab_logName.Location = new System.Drawing.Point(114, 53);
            this.lab_logName.Name = "lab_logName";
            this.lab_logName.Size = new System.Drawing.Size(53, 12);
            this.lab_logName.TabIndex = 0;
            this.lab_logName.Text = "账户名：";
            // 
            // textBox_logName
            // 
            this.textBox_logName.Location = new System.Drawing.Point(174, 49);
            this.textBox_logName.Name = "textBox_logName";
            this.textBox_logName.Size = new System.Drawing.Size(106, 21);
            this.textBox_logName.TabIndex = 1;
            // 
            // textBox_logPsd
            // 
            this.textBox_logPsd.Location = new System.Drawing.Point(174, 76);
            this.textBox_logPsd.Name = "textBox_logPsd";
            this.textBox_logPsd.PasswordChar = '*';
            this.textBox_logPsd.Size = new System.Drawing.Size(106, 21);
            this.textBox_logPsd.TabIndex = 3;
            // 
            // lab_logPsd
            // 
            this.lab_logPsd.AutoSize = true;
            this.lab_logPsd.Location = new System.Drawing.Point(114, 80);
            this.lab_logPsd.Name = "lab_logPsd";
            this.lab_logPsd.Size = new System.Drawing.Size(53, 12);
            this.lab_logPsd.TabIndex = 2;
            this.lab_logPsd.Text = "密  码：";
            // 
            // btn_logOK
            // 
            this.btn_logOK.Location = new System.Drawing.Point(143, 124);
            this.btn_logOK.Name = "btn_logOK";
            this.btn_logOK.Size = new System.Drawing.Size(53, 23);
            this.btn_logOK.TabIndex = 4;
            this.btn_logOK.Text = "确定";
            this.btn_logOK.UseVisualStyleBackColor = true;
            this.btn_logOK.Click += new System.EventHandler(this.btn_logOK_Click);
            // 
            // btn_logCancel
            // 
            this.btn_logCancel.Location = new System.Drawing.Point(216, 124);
            this.btn_logCancel.Name = "btn_logCancel";
            this.btn_logCancel.Size = new System.Drawing.Size(53, 23);
            this.btn_logCancel.TabIndex = 5;
            this.btn_logCancel.Text = "取消";
            this.btn_logCancel.UseVisualStyleBackColor = true;
            this.btn_logCancel.Click += new System.EventHandler(this.btn_logCancel_Click);
            // 
            // skinEngine_account
            // 
            //this.skinEngine_account.@__DrawButtonFocusRectangle = true;
            //this.skinEngine_account.DisabledButtonTextColor = System.Drawing.Color.Gray;
            //this.skinEngine_account.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            //this.skinEngine_account.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            //this.skinEngine_account.SerialNumber = "";
            //this.skinEngine_account.SkinFile = null;
            // 
            // Login
            // 
            this.AcceptButton = this.btn_logOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 182);
            this.Controls.Add(this.btn_logCancel);
            this.Controls.Add(this.btn_logOK);
            this.Controls.Add(this.textBox_logPsd);
            this.Controls.Add(this.lab_logPsd);
            this.Controls.Add(this.textBox_logName);
            this.Controls.Add(this.lab_logName);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "账簿登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_logName;
        private System.Windows.Forms.TextBox textBox_logName;
        private System.Windows.Forms.TextBox textBox_logPsd;
        private System.Windows.Forms.Label lab_logPsd;
        private System.Windows.Forms.Button btn_logOK;
        private System.Windows.Forms.Button btn_logCancel;
    }
}