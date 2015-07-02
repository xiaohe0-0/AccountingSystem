namespace AccountingSystem
{
    partial class Account_BillCheck
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
            this.dataGridView_billInfo = new System.Windows.Forms.DataGridView();
            this.Col_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_AccountIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_AccountOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_AccountBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_billInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_billInfo
            // 
            this.dataGridView_billInfo.AllowUserToAddRows = false;
            this.dataGridView_billInfo.AllowUserToDeleteRows = false;
            this.dataGridView_billInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_billInfo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_billInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_billInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Date,
            this.Col_AccountIn,
            this.Col_AccountOut,
            this.Col_AccountBalance});
            this.dataGridView_billInfo.Location = new System.Drawing.Point(24, 12);
            this.dataGridView_billInfo.Name = "dataGridView_billInfo";
            this.dataGridView_billInfo.ReadOnly = true;
            this.dataGridView_billInfo.RowTemplate.Height = 23;
            this.dataGridView_billInfo.Size = new System.Drawing.Size(446, 281);
            this.dataGridView_billInfo.TabIndex = 0;
            this.dataGridView_billInfo.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView_billInfo_RowPrePaint);
            // 
            // Col_Date
            // 
            this.Col_Date.HeaderText = "日期";
            this.Col_Date.Name = "Col_Date";
            this.Col_Date.ReadOnly = true;
            // 
            // Col_AccountIn
            // 
            this.Col_AccountIn.HeaderText = "收入";
            this.Col_AccountIn.Name = "Col_AccountIn";
            this.Col_AccountIn.ReadOnly = true;
            // 
            // Col_AccountOut
            // 
            this.Col_AccountOut.HeaderText = "支出";
            this.Col_AccountOut.Name = "Col_AccountOut";
            this.Col_AccountOut.ReadOnly = true;
            // 
            // Col_AccountBalance
            // 
            this.Col_AccountBalance.HeaderText = "结余";
            this.Col_AccountBalance.Name = "Col_AccountBalance";
            this.Col_AccountBalance.ReadOnly = true;
            // 
            // Account_BillCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 305);
            this.Controls.Add(this.dataGridView_billInfo);
            this.Name = "Account_BillCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查看账单";
            this.Load += new System.EventHandler(this.Account_BillCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_billInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_billInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_AccountIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_AccountOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_AccountBalance;
    }
}