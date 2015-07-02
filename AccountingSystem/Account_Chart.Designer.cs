namespace AccountingSystem
{
    partial class Account_Chart
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
            this.btn_accInOut = new System.Windows.Forms.Button();
            this.btn_accOutClass = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.dateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_end = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_accInOut
            // 
            this.btn_accInOut.Location = new System.Drawing.Point(519, 12);
            this.btn_accInOut.Name = "btn_accInOut";
            this.btn_accInOut.Size = new System.Drawing.Size(75, 23);
            this.btn_accInOut.TabIndex = 0;
            this.btn_accInOut.Text = "收支折线图";
            this.btn_accInOut.UseVisualStyleBackColor = true;
            this.btn_accInOut.Click += new System.EventHandler(this.btn_accInOut_Click);
            // 
            // btn_accOutClass
            // 
            this.btn_accOutClass.Location = new System.Drawing.Point(600, 12);
            this.btn_accOutClass.Name = "btn_accOutClass";
            this.btn_accOutClass.Size = new System.Drawing.Size(75, 23);
            this.btn_accOutClass.TabIndex = 1;
            this.btn_accOutClass.Text = "支出分类图";
            this.btn_accOutClass.UseVisualStyleBackColor = true;
            this.btn_accOutClass.Click += new System.EventHandler(this.btn_accOutClass_Click);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Location = new System.Drawing.Point(13, 42);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(743, 453);
            this.panel.TabIndex = 2;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(681, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "关闭";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.Location = new System.Drawing.Point(194, 13);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.Size = new System.Drawing.Size(135, 21);
            this.dateTimePicker_start.TabIndex = 4;
            // 
            // dateTimePicker_end
            // 
            this.dateTimePicker_end.Location = new System.Drawing.Point(358, 13);
            this.dateTimePicker_end.Name = "dateTimePicker_end";
            this.dateTimePicker_end.Size = new System.Drawing.Size(137, 21);
            this.dateTimePicker_end.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "至";
            // 
            // Account_Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 507);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker_end);
            this.Controls.Add(this.dateTimePicker_start);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btn_accOutClass);
            this.Controls.Add(this.btn_accInOut);
            this.Name = "Account_Chart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "统计图";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_accInOut;
        private System.Windows.Forms.Button btn_accOutClass;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.DateTimePicker dateTimePicker_start;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end;
        private System.Windows.Forms.Label label1;
    }
}