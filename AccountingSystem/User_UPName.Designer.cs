namespace AccountingSystem
{
    partial class User_UPName
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
            this.textBox_OriUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_NewUserName = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_cencel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "原账户名：";
            // 
            // textBox_OriUserName
            // 
            this.textBox_OriUserName.Location = new System.Drawing.Point(158, 38);
            this.textBox_OriUserName.Name = "textBox_OriUserName";
            this.textBox_OriUserName.ReadOnly = true;
            this.textBox_OriUserName.Size = new System.Drawing.Size(118, 21);
            this.textBox_OriUserName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "新账户名：";
            // 
            // textBox_NewUserName
            // 
            this.textBox_NewUserName.Location = new System.Drawing.Point(158, 77);
            this.textBox_NewUserName.Name = "textBox_NewUserName";
            this.textBox_NewUserName.Size = new System.Drawing.Size(118, 21);
            this.textBox_NewUserName.TabIndex = 0;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(131, 127);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(50, 23);
            this.btn_OK.TabIndex = 4;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_cencel
            // 
            this.btn_cencel.Location = new System.Drawing.Point(207, 127);
            this.btn_cencel.Name = "btn_cencel";
            this.btn_cencel.Size = new System.Drawing.Size(50, 23);
            this.btn_cencel.TabIndex = 5;
            this.btn_cencel.Text = "取消";
            this.btn_cencel.UseVisualStyleBackColor = true;
            this.btn_cencel.Click += new System.EventHandler(this.btn_cencel_Click);
            // 
            // User_UPName
            // 
            this.AcceptButton = this.btn_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 184);
            this.Controls.Add(this.btn_cencel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.textBox_NewUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_OriUserName);
            this.Controls.Add(this.label1);
            this.Name = "User_UPName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "更改账户名";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_OriUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_NewUserName;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_cencel;
    }
}