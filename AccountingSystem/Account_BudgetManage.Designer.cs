namespace AccountingSystem
{
    partial class Account_BudgetManage
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
            this.dataGridView_budget = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.Col_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Budget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_AccOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_exit = new System.Windows.Forms.Button();
            this.Col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_budget)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_budget
            // 
            this.dataGridView_budget.AllowUserToAddRows = false;
            this.dataGridView_budget.AllowUserToDeleteRows = false;
            this.dataGridView_budget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_budget.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_budget.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_budget.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Date,
            this.Col_Budget,
            this.Col_AccOut,
            this.Col_ID});
            this.dataGridView_budget.Location = new System.Drawing.Point(11, 13);
            this.dataGridView_budget.Name = "dataGridView_budget";
            this.dataGridView_budget.ReadOnly = true;
            this.dataGridView_budget.RowTemplate.Height = 23;
            this.dataGridView_budget.Size = new System.Drawing.Size(345, 258);
            this.dataGridView_budget.TabIndex = 0;
            this.dataGridView_budget.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView_budget_RowPrePaint);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(11, 277);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(60, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "增加";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(75, 277);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(60, 23);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "修改";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(141, 277);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(60, 23);
            this.btn_del.TabIndex = 3;
            this.btn_del.Text = "删除";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // Col_Date
            // 
            this.Col_Date.HeaderText = "时间";
            this.Col_Date.Name = "Col_Date";
            this.Col_Date.ReadOnly = true;
            // 
            // Col_Budget
            // 
            this.Col_Budget.HeaderText = "预算";
            this.Col_Budget.Name = "Col_Budget";
            this.Col_Budget.ReadOnly = true;
            // 
            // Col_AccOut
            // 
            this.Col_AccOut.HeaderText = "实际支出";
            this.Col_AccOut.Name = "Col_AccOut";
            this.Col_AccOut.ReadOnly = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(283, 277);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "退出";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Col_ID
            // 
            this.Col_ID.HeaderText = "ID";
            this.Col_ID.Name = "Col_ID";
            this.Col_ID.ReadOnly = true;
            // 
            // Account_BudgetManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 312);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dataGridView_budget);
            this.Name = "Account_BudgetManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "预算管理";
            this.Load += new System.EventHandler(this.Account_BudgetManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_budget)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_budget;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Budget;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_AccOut;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ID;
    }
}