namespace AccountingSystem
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip_main = new System.Windows.Forms.MenuStrip();
            this.menu_user = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_upUserName = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_upUserPsd = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_accounting = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_CheckBill = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_BudgetSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_AccInOut = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_importantM = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_balance = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_RemindSth = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_InterestCal = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_InOutCal = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_addCount = new System.Windows.Forms.Button();
            this.btn_check = new System.Windows.Forms.Button();
            this.btn_allIncome = new System.Windows.Forms.Button();
            this.btn_outCome = new System.Windows.Forms.Button();
            this.btn_chart = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.time_begin = new System.Windows.Forms.DateTimePicker();
            this.time_end = new System.Windows.Forms.DateTimePicker();
            this.lab_btoe = new System.Windows.Forms.Label();
            this.panel_top = new System.Windows.Forms.Panel();
            this.btn_change = new System.Windows.Forms.Button();
            this.panel_info = new System.Windows.Forms.Panel();
            this.gridView_info = new System.Windows.Forms.DataGridView();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.progressBar_export = new System.Windows.Forms.ProgressBar();
            this.lab_boSum = new System.Windows.Forms.Label();
            this.lab_bottom = new System.Windows.Forms.Label();
            this.timer_now = new System.Windows.Forms.Timer(this.components);
            this.timer_showAlert = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog_export = new System.Windows.Forms.SaveFileDialog();
            this.timer_export = new System.Windows.Forms.Timer(this.components);
            this.menuStrip_main.SuspendLayout();
            this.panel_top.SuspendLayout();
            this.panel_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_info)).BeginInit();
            this.panel_bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_main
            // 
            this.menuStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_user,
            this.menu_accounting,
            this.menu_importantM,
            this.工具ToolStripMenuItem,
            this.menu_exit});
            this.menuStrip_main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_main.Name = "menuStrip_main";
            this.menuStrip_main.Size = new System.Drawing.Size(870, 25);
            this.menuStrip_main.TabIndex = 0;
            this.menuStrip_main.Text = "menuStrip1";
            // 
            // menu_user
            // 
            this.menu_user.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_upUserName,
            this.menuItem_upUserPsd});
            this.menu_user.Name = "menu_user";
            this.menu_user.Size = new System.Drawing.Size(44, 21);
            this.menu_user.Text = "账户";
            // 
            // menuItem_upUserName
            // 
            this.menuItem_upUserName.Name = "menuItem_upUserName";
            this.menuItem_upUserName.Size = new System.Drawing.Size(136, 22);
            this.menuItem_upUserName.Text = "更改账户名";
            this.menuItem_upUserName.Click += new System.EventHandler(this.menuItem_upUserName_Click);
            // 
            // menuItem_upUserPsd
            // 
            this.menuItem_upUserPsd.Name = "menuItem_upUserPsd";
            this.menuItem_upUserPsd.Size = new System.Drawing.Size(136, 22);
            this.menuItem_upUserPsd.Text = "更改密码";
            this.menuItem_upUserPsd.Click += new System.EventHandler(this.menuItem_upUserPsd_Click);
            // 
            // menu_accounting
            // 
            this.menu_accounting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_CheckBill,
            this.ToolStripMenuItem_BudgetSetting,
            this.ToolStripMenuItem_AccInOut});
            this.menu_accounting.Name = "menu_accounting";
            this.menu_accounting.Size = new System.Drawing.Size(44, 21);
            this.menu_accounting.Text = "账目";
            // 
            // ToolStripMenuItem_CheckBill
            // 
            this.ToolStripMenuItem_CheckBill.Name = "ToolStripMenuItem_CheckBill";
            this.ToolStripMenuItem_CheckBill.Size = new System.Drawing.Size(124, 22);
            this.ToolStripMenuItem_CheckBill.Text = "查看账单";
            this.ToolStripMenuItem_CheckBill.Click += new System.EventHandler(this.ToolStripMenuItem_CheckBill_Click);
            // 
            // ToolStripMenuItem_BudgetSetting
            // 
            this.ToolStripMenuItem_BudgetSetting.Name = "ToolStripMenuItem_BudgetSetting";
            this.ToolStripMenuItem_BudgetSetting.Size = new System.Drawing.Size(124, 22);
            this.ToolStripMenuItem_BudgetSetting.Text = "预算管理";
            this.ToolStripMenuItem_BudgetSetting.Click += new System.EventHandler(this.ToolStripMenuItem_BudgetSetting_Click);
            // 
            // ToolStripMenuItem_AccInOut
            // 
            this.ToolStripMenuItem_AccInOut.Name = "ToolStripMenuItem_AccInOut";
            this.ToolStripMenuItem_AccInOut.Size = new System.Drawing.Size(124, 22);
            this.ToolStripMenuItem_AccInOut.Text = "收支分类";
            this.ToolStripMenuItem_AccInOut.Click += new System.EventHandler(this.ToolStripMenuItem_AccInOut_Click);
            // 
            // menu_importantM
            // 
            this.menu_importantM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_balance,
            this.ToolStripMenuItem_RemindSth});
            this.menu_importantM.Name = "menu_importantM";
            this.menu_importantM.Size = new System.Drawing.Size(44, 21);
            this.menu_importantM.Text = "提醒";
            // 
            // ToolStripMenuItem_balance
            // 
            this.ToolStripMenuItem_balance.Name = "ToolStripMenuItem_balance";
            this.ToolStripMenuItem_balance.Size = new System.Drawing.Size(124, 22);
            this.ToolStripMenuItem_balance.Text = "余额提醒";
            this.ToolStripMenuItem_balance.Click += new System.EventHandler(this.ToolStripMenuItem_balance_Click);
            // 
            // ToolStripMenuItem_RemindSth
            // 
            this.ToolStripMenuItem_RemindSth.Name = "ToolStripMenuItem_RemindSth";
            this.ToolStripMenuItem_RemindSth.Size = new System.Drawing.Size(124, 22);
            this.ToolStripMenuItem_RemindSth.Text = "事务提醒";
            this.ToolStripMenuItem_RemindSth.Click += new System.EventHandler(this.ToolStripMenuItem_RemindSth_Click);
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_InterestCal,
            this.ToolStripMenuItem_InOutCal});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // ToolStripMenuItem_InterestCal
            // 
            this.ToolStripMenuItem_InterestCal.Name = "ToolStripMenuItem_InterestCal";
            this.ToolStripMenuItem_InterestCal.Size = new System.Drawing.Size(160, 22);
            this.ToolStripMenuItem_InterestCal.Text = "复利计算器";
            this.ToolStripMenuItem_InterestCal.Click += new System.EventHandler(this.ToolStripMenuItem_InterestCal_Click);
            // 
            // ToolStripMenuItem_InOutCal
            // 
            this.ToolStripMenuItem_InOutCal.Name = "ToolStripMenuItem_InOutCal";
            this.ToolStripMenuItem_InOutCal.Size = new System.Drawing.Size(160, 22);
            this.ToolStripMenuItem_InOutCal.Text = "零存整取计算器";
            this.ToolStripMenuItem_InOutCal.Click += new System.EventHandler(this.ToolStripMenuItem_InOutCal_Click);
            // 
            // menu_exit
            // 
            this.menu_exit.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menu_exit.ForeColor = System.Drawing.Color.Maroon;
            this.menu_exit.Name = "menu_exit";
            this.menu_exit.Size = new System.Drawing.Size(44, 21);
            this.menu_exit.Text = "退出";
            this.menu_exit.Click += new System.EventHandler(this.menu_exit_Click);
            // 
            // btn_addCount
            // 
            this.btn_addCount.Location = new System.Drawing.Point(15, 6);
            this.btn_addCount.Name = "btn_addCount";
            this.btn_addCount.Size = new System.Drawing.Size(75, 23);
            this.btn_addCount.TabIndex = 1;
            this.btn_addCount.Text = "+记一笔";
            this.btn_addCount.UseVisualStyleBackColor = true;
            this.btn_addCount.Click += new System.EventHandler(this.btn_addCount_Click);
            // 
            // btn_check
            // 
            this.btn_check.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn_check.Location = new System.Drawing.Point(555, 7);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(55, 23);
            this.btn_check.TabIndex = 6;
            this.btn_check.Text = "收支";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // btn_allIncome
            // 
            this.btn_allIncome.ForeColor = System.Drawing.Color.Green;
            this.btn_allIncome.Location = new System.Drawing.Point(620, 7);
            this.btn_allIncome.Name = "btn_allIncome";
            this.btn_allIncome.Size = new System.Drawing.Size(55, 23);
            this.btn_allIncome.TabIndex = 7;
            this.btn_allIncome.Text = "收入";
            this.btn_allIncome.UseVisualStyleBackColor = true;
            this.btn_allIncome.Click += new System.EventHandler(this.btn_allIncome_Click);
            // 
            // btn_outCome
            // 
            this.btn_outCome.ForeColor = System.Drawing.Color.Red;
            this.btn_outCome.Location = new System.Drawing.Point(681, 7);
            this.btn_outCome.Name = "btn_outCome";
            this.btn_outCome.Size = new System.Drawing.Size(55, 23);
            this.btn_outCome.TabIndex = 8;
            this.btn_outCome.Text = "支出";
            this.btn_outCome.UseVisualStyleBackColor = true;
            this.btn_outCome.Click += new System.EventHandler(this.btn_outCome_Click);
            // 
            // btn_chart
            // 
            this.btn_chart.Location = new System.Drawing.Point(744, 7);
            this.btn_chart.Name = "btn_chart";
            this.btn_chart.Size = new System.Drawing.Size(55, 23);
            this.btn_chart.TabIndex = 9;
            this.btn_chart.Text = "统计图";
            this.btn_chart.UseVisualStyleBackColor = true;
            this.btn_chart.Click += new System.EventHandler(this.btn_chart_Click);
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(807, 7);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(55, 23);
            this.btn_export.TabIndex = 10;
            this.btn_export.Text = "导出";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(153, 6);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(51, 23);
            this.btn_del.TabIndex = 3;
            this.btn_del.Text = "删除";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // time_begin
            // 
            this.time_begin.Location = new System.Drawing.Point(287, 7);
            this.time_begin.Name = "time_begin";
            this.time_begin.Size = new System.Drawing.Size(111, 21);
            this.time_begin.TabIndex = 4;
            this.time_begin.Value = new System.DateTime(2012, 12, 17, 10, 6, 37, 0);
            // 
            // time_end
            // 
            this.time_end.Location = new System.Drawing.Point(427, 8);
            this.time_end.Name = "time_end";
            this.time_end.Size = new System.Drawing.Size(111, 21);
            this.time_end.TabIndex = 5;
            this.time_end.Value = new System.DateTime(2012, 12, 17, 10, 6, 30, 0);
            // 
            // lab_btoe
            // 
            this.lab_btoe.AutoSize = true;
            this.lab_btoe.Location = new System.Drawing.Point(404, 11);
            this.lab_btoe.Name = "lab_btoe";
            this.lab_btoe.Size = new System.Drawing.Size(17, 12);
            this.lab_btoe.TabIndex = 10;
            this.lab_btoe.Text = "至";
            // 
            // panel_top
            // 
            this.panel_top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_top.Controls.Add(this.btn_change);
            this.panel_top.Controls.Add(this.btn_check);
            this.panel_top.Controls.Add(this.btn_addCount);
            this.panel_top.Controls.Add(this.btn_allIncome);
            this.panel_top.Controls.Add(this.lab_btoe);
            this.panel_top.Controls.Add(this.btn_outCome);
            this.panel_top.Controls.Add(this.time_end);
            this.panel_top.Controls.Add(this.btn_chart);
            this.panel_top.Controls.Add(this.time_begin);
            this.panel_top.Controls.Add(this.btn_export);
            this.panel_top.Controls.Add(this.btn_del);
            this.panel_top.Location = new System.Drawing.Point(0, 28);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(870, 38);
            this.panel_top.TabIndex = 11;
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(96, 6);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(51, 23);
            this.btn_change.TabIndex = 2;
            this.btn_change.Text = "修改";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // panel_info
            // 
            this.panel_info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_info.Controls.Add(this.gridView_info);
            this.panel_info.Location = new System.Drawing.Point(15, 69);
            this.panel_info.Name = "panel_info";
            this.panel_info.Size = new System.Drawing.Size(845, 432);
            this.panel_info.TabIndex = 12;
            // 
            // gridView_info
            // 
            this.gridView_info.AllowUserToAddRows = false;
            this.gridView_info.AllowUserToDeleteRows = false;
            this.gridView_info.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridView_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridView_info.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gridView_info.Location = new System.Drawing.Point(0, 0);
            this.gridView_info.Name = "gridView_info";
            this.gridView_info.ReadOnly = true;
            this.gridView_info.RowTemplate.Height = 23;
            this.gridView_info.Size = new System.Drawing.Size(845, 432);
            this.gridView_info.TabIndex = 0;
            this.gridView_info.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.gridView_info_RowPrePaint);
            // 
            // panel_bottom
            // 
            this.panel_bottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_bottom.Controls.Add(this.progressBar_export);
            this.panel_bottom.Controls.Add(this.lab_boSum);
            this.panel_bottom.Controls.Add(this.lab_bottom);
            this.panel_bottom.Location = new System.Drawing.Point(0, 506);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(870, 29);
            this.panel_bottom.TabIndex = 13;
            // 
            // progressBar_export
            // 
            this.progressBar_export.Location = new System.Drawing.Point(719, 3);
            this.progressBar_export.Name = "progressBar_export";
            this.progressBar_export.Size = new System.Drawing.Size(139, 23);
            this.progressBar_export.TabIndex = 1;
            // 
            // lab_boSum
            // 
            this.lab_boSum.AutoSize = true;
            this.lab_boSum.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_boSum.ForeColor = System.Drawing.Color.MediumBlue;
            this.lab_boSum.Location = new System.Drawing.Point(13, 4);
            this.lab_boSum.Name = "lab_boSum";
            this.lab_boSum.Size = new System.Drawing.Size(160, 17);
            this.lab_boSum.TabIndex = 1;
            this.lab_boSum.Text = "2013-02-03 至 2013-02-03";
            // 
            // lab_bottom
            // 
            this.lab_bottom.AutoSize = true;
            this.lab_bottom.Location = new System.Drawing.Point(717, 6);
            this.lab_bottom.Name = "lab_bottom";
            this.lab_bottom.Size = new System.Drawing.Size(29, 12);
            this.lab_bottom.TabIndex = 0;
            this.lab_bottom.Text = "时间";
            // 
            // timer_now
            // 
            this.timer_now.Tick += new System.EventHandler(this.timer_now_Tick);
            // 
            // timer_showAlert
            // 
            this.timer_showAlert.Tick += new System.EventHandler(this.timer_showAlert_Tick);
            // 
            // timer_export
            // 
            this.timer_export.Interval = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 533);
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.panel_info);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.menuStrip_main);
            this.MainMenuStrip = this.menuStrip_main;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "记账簿";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuStrip_main.ResumeLayout(false);
            this.menuStrip_main.PerformLayout();
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView_info)).EndInit();
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_main;
        private System.Windows.Forms.ToolStripMenuItem menu_user;
        private System.Windows.Forms.ToolStripMenuItem menu_accounting;
        private System.Windows.Forms.ToolStripMenuItem menu_importantM;
        private System.Windows.Forms.ToolStripMenuItem menu_exit;
        private System.Windows.Forms.Button btn_addCount;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Button btn_allIncome;
        private System.Windows.Forms.Button btn_outCome;
        private System.Windows.Forms.Button btn_chart;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.DateTimePicker time_begin;
        private System.Windows.Forms.DateTimePicker time_end;
        private System.Windows.Forms.Label lab_btoe;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Panel panel_info;
        private System.Windows.Forms.Panel panel_bottom;
        private System.Windows.Forms.Label lab_bottom;
        private System.Windows.Forms.DataGridView gridView_info;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItem_upUserName;
        private System.Windows.Forms.ToolStripMenuItem menuItem_upUserPsd;
        private System.Windows.Forms.Timer timer_now;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_CheckBill;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_BudgetSetting;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_AccInOut;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_InterestCal;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_InOutCal;
        private System.Windows.Forms.Label lab_boSum;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_balance;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_RemindSth;
        private System.Windows.Forms.Timer timer_showAlert;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_export;
        private System.Windows.Forms.Timer timer_export;
        private System.Windows.Forms.ProgressBar progressBar_export;
    }
}

