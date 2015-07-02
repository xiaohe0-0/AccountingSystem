using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using BLL;

namespace AccountingSystem
{
    public partial class MainForm : Form
    {
        public static int userID;//账户ID
        public static string userName;//账户名
        private string timeSerchStart;//选择的开始时间
        private string timeSerchEnd;//选择的截止时间
        public static int selectAccID;//选中的账目ID
        public static string selectAccInOut;//选中的账目的收支
        public static double selectAccNum;//选中的账目金额
        public static string selectAccClass;//选中的账目分类
        public static string selectAccDate;//选中的账目日期
        public static string selectAccCon;//选中的账目备注
        private string accDateStart;//账目开始时间
        private static string accDateEnd;//账目截止时间
        public double accBalance;//账目余额
        public static string mainDateStart;//开始时间
        public static string mainDateEnd;//截止时间

#region 主页面

        public MainForm()
        {
            InitializeComponent();

            //显示账户名
            userName = Login.loginName;
            this.Text = userName + "的记账簿";

            //得到账户ID
            userID = int.Parse(AccountServer.GetUserInfo(userName).Rows[0]["userID"].ToString());

            //页面底部显示日期
            timer_now.Start();


            //页面上的时间段
            time_end.Value = DateTime.Now;
            time_begin.Text = DateTime.Now.Year + "/" + DateTime.Now.Month + "/1";

            //显示账目
            showAccountInfo();
            updateMainBottomSum();

            //页面上的时间段
            time_begin.Text = accDateStart;

            //显示提醒
            timer_showAlert.Start();

            //开始时进度条不显示
            progressBar_export.Visible = false;

        }

        //显示提醒
        private void timer_showAlert_Tick(object sender, EventArgs e)
        {
            timer_showAlert.Stop();
            //余额提醒
            try
            {
                double accLimit = double.Parse(AccountServer.GetAccLimit().Rows[0]["accLimitNum"].ToString());
                if (accBalance - accLimit < 0)
                {
                    MessageBox.Show(userName + "，你好！\n你的余额已不足" + accLimit + "元，\n请手下留钱！", "余额提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (System.Exception) { }

            //事务提醒
            try
            {
                string nowDate = DateTime.Now.ToString("yyyy-MM-dd");
                if (RemindServer.ExistRemind(nowDate).Rows.Count > 0)
                {
                    Form remindShow = new Remind_Show();
                    remindShow.Show();
                }
            }
            catch (System.Exception) { }
        }

        //显示账目
        private void showAccountInfo()
        {
            gridView_info.DataSource = AccountServer.GetALLAccount();
            //gridView_info.Columns["ID"].Width = 50;
            gridView_info.Columns["日期"].Width = 180;
            gridView_info.Columns["分类"].Width = 160;
            gridView_info.Columns["数目"].Width = 120;
            gridView_info.Columns["备注"].Width = 240;
            gridView_info.Columns["ID"].Visible = false;
        }

        //将dataGridView里的收入、支出以不同颜色显示
        private void gridView_info_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int rowCount = gridView_info.Rows.Count;

            for (int i = 0; i < rowCount; i++)
            {
                string accInOut = gridView_info.Rows[i].Cells["收支"].Value.ToString().Trim();
                if (accInOut == "收入")
                {
                    gridView_info.Rows[i].Cells["收支"].Style.ForeColor = Color.Green;
                    gridView_info.Rows[i].Cells["数目"].Style.ForeColor = Color.Green;
                }
                else
                {
                    gridView_info.Rows[i].Cells["收支"].Style.ForeColor = Color.Red;
                    gridView_info.Rows[i].Cells["数目"].Style.ForeColor = Color.Red;
                }
            }
        }

        //实时显示时间
        private void timer_now_Tick(object sender, EventArgs e)
        {
            lab_bottom.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        //刷新位于页面底部的数据汇总
        private void updateMainBottomSum(int sign=0)
        {
            int rowCount = gridView_info.Rows.Count;
            double balanceNum = 0;
            double inNum = 0;
            double outNum = 0;
            for (int i = 0; i < rowCount; i++)
            {
                string accInOut = gridView_info.Rows[i].Cells["收支"].Value.ToString().Trim();
                double addIn = double.Parse(gridView_info.Rows[i].Cells["数目"].Value.ToString());

                if (accInOut == "收入")
                {
                    inNum += addIn;
                }
                else 
                { 
                    outNum += addIn;
                }
            }
            accDateStart = "";
            accDateEnd = ""; 
            if (rowCount > 0)
            {
                accDateStart = gridView_info.Rows[rowCount - 1].Cells["日期"].Value.ToString();
                accDateEnd = gridView_info.Rows[0].Cells["日期"].Value.ToString();
            } 
            else
            {
                accDateStart = time_begin.Value.ToString("yyyy-MM-dd");
                accDateEnd = time_end.Value.ToString("yyyy-MM-dd");
            }

            balanceNum = inNum - outNum;

            //收入
            if (sign == 1)
            {
                lab_boSum.Text = accDateStart + " 至 " + accDateEnd + "  共收入：" + inNum + "元";
            } 
            //支出
            else if(sign == 2)
            {
                lab_boSum.Text = accDateStart + " 至 " + accDateEnd + "  共支出：" + outNum + "元";
            }
            //收支
            else
            {
                lab_boSum.Text = accDateStart + " 至 " + accDateEnd + "  共收入：" + inNum + "元， 共支出：" + outNum + "元， 结余：" + balanceNum + "元";
                accBalance = balanceNum;
            }
        }

        //关闭主窗口
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

#endregion

#region 菜单操作

        //更改账户名
        private void menuItem_upUserName_Click(object sender, EventArgs e)
        {
            try
            {
                Form userUPName = new User_UPName();
                userUPName.ShowDialog();
                this.Text = userName + "的记账簿";
            }
            catch (System.Exception)
            { }
        }

        //更改账户密码
        private void menuItem_upUserPsd_Click(object sender, EventArgs e)
        {
            try
            {
                Form userUPPsd = new User_UPPsd();
                userUPPsd.ShowDialog();
            }
            catch (System.Exception)
            { }
        }

        //查看账单
        private void ToolStripMenuItem_CheckBill_Click(object sender, EventArgs e)
        {
            try
            {
                Form checkBill = new Account_BillCheck();
                checkBill.ShowDialog();
            }
            catch (System.Exception)
            {}
        }

        //预算管理
        private void ToolStripMenuItem_BudgetSetting_Click(object sender, EventArgs e)
        {
            try
            {
                Form budgetManage = new Account_BudgetManage();
                budgetManage.ShowDialog();
            }
            catch (System.Exception)
            {}
        }

        //收支分类
        private void ToolStripMenuItem_AccInOut_Click(object sender, EventArgs e)
        {
            try
            {
                Form accClass = new Account_Class();
                accClass.ShowDialog();
            }
            catch (System.Exception )
            {}
        }

        //余额提醒
        private void ToolStripMenuItem_balance_Click(object sender, EventArgs e)
        {
            try
            {
                Form balanceAlert = new Account_BalanceAlertSetting();
                balanceAlert.ShowDialog();
            }
            catch (System.Exception)
            {}
        }

        //事务提醒
        private void ToolStripMenuItem_RemindSth_Click(object sender, EventArgs e)
        {
            try
            {
                Form remindSth = new Remind_Index();
                remindSth.ShowDialog();
            }
            catch (System.Exception)
            {}
        }

        //复利计算器
        private void ToolStripMenuItem_InterestCal_Click(object sender, EventArgs e)
        {
            Form calForm = new Tools_Interest();
            calForm.ShowDialog();
        }

        //零存整取计算器
        private void ToolStripMenuItem_InOutCal_Click(object sender, EventArgs e)
        {
            Form inOutCal = new Tools_InOut();
            inOutCal.ShowDialog();
        }

        //退出系统
        private void menu_exit_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("确定退出记账簿？", "退出提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                System.Windows.Forms.Application.Exit();
            }
        }

#endregion

#region 主页面快捷按钮
        //记账
        private void btn_addCount_Click(object sender, EventArgs e)
        {
            Form addAccount = new Account_AddAccount();
            addAccount.ShowDialog();
            //显示账目
            showAccountInfo();
            updateMainBottomSum();
        }

        //修改账目
        private void btn_change_Click(object sender, EventArgs e)
        {
            if (gridView_info.CurrentRow == null)
            {
                MessageBox.Show("请选中需要修改的账目", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            selectAccID = int.Parse(gridView_info.CurrentRow.Cells["ID"].Value.ToString());
            selectAccNum = double.Parse(gridView_info.CurrentRow.Cells["数目"].Value.ToString());
            selectAccInOut = gridView_info.CurrentRow.Cells["收支"].Value.ToString();
            selectAccClass = gridView_info.CurrentRow.Cells["分类"].Value.ToString();
            selectAccDate = gridView_info.CurrentRow.Cells["日期"].Value.ToString();
            selectAccCon = gridView_info.CurrentRow.Cells["备注"].Value.ToString();
            Form upAccount = new Account_UPAccount();
            upAccount.ShowDialog();
            //显示账目
            showAccountInfo();
            updateMainBottomSum();
        }

        //删除账目
        private void btn_del_Click(object sender, EventArgs e)
        {
            if (gridView_info.CurrentRow == null)
            {
                MessageBox.Show("请选中需要删除的账目", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dr = MessageBox.Show("确定删除该账目吗？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                selectAccID = int.Parse(gridView_info.CurrentRow.Cells["ID"].Value.ToString());
                try
                {
                    if (AccountServer.DelAccount(selectAccID))
                    {
                        //显示账目
                        showAccountInfo();
                        updateMainBottomSum();
                    }
                    else
                    {
                        MessageBox.Show("删除失败", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (System.Exception)
                {
                    MessageBox.Show("删除时发生异常", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //查看某段时间的账目收支
        private void btn_check_Click(object sender, EventArgs e)
        {
            timeSerchStart = time_begin.Value.ToString("yyyy-MM-dd");
            timeSerchEnd = time_end.Value.ToString("yyyy-MM-dd");

            if (string.Compare(timeSerchStart,timeSerchEnd) > 0)
            {
                MessageBox.Show("查询的开始日期应在终止日期之前", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
            else
            {
                gridView_info.DataSource = AccountServer.GetPeriodAccount(timeSerchStart, timeSerchEnd);
                updateMainBottomSum();
            }
        }

        //查看某段时间的账目收入
        private void btn_allIncome_Click(object sender, EventArgs e)
        {
            timeSerchStart = time_begin.Value.ToString("yyyy-MM-dd");
            timeSerchEnd = time_end.Value.ToString("yyyy-MM-dd");

            if (string.Compare(timeSerchStart, timeSerchEnd) > 0)
            {
                MessageBox.Show("查询的开始日期应在终止日期之前", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                gridView_info.DataSource = AccountServer.GetPeriodIncome(timeSerchStart, timeSerchEnd);
                updateMainBottomSum(1);
            }
        }

        //查看某段时间的账目支出
        private void btn_outCome_Click(object sender, EventArgs e)
        {
            timeSerchStart = time_begin.Value.ToString("yyyy-MM-dd");
            timeSerchEnd = time_end.Value.ToString("yyyy-MM-dd"); 
            
            if (string.Compare(timeSerchStart, timeSerchEnd) > 0)
            {
                MessageBox.Show("查询的开始日期应在终止日期之前", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                gridView_info.DataSource = AccountServer.GetPeriodOutcome(timeSerchStart, timeSerchEnd);
                updateMainBottomSum(2);
            }
        }

        //统计图
        private void btn_chart_Click(object sender, EventArgs e)
        {
            mainDateStart = time_begin.Value.ToString("yyyy-MM-dd");
            mainDateEnd = time_end.Value.ToString("yyyy-MM-dd");
            if (string.Compare(mainDateStart, mainDateEnd) > 0)
            {
                MessageBox.Show("查询的开始日期应在终止日期之前", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Form chartForm = new Account_Chart();
            chartForm.ShowDialog();
        }

        //导出数据
        private void btn_export_Click(object sender, EventArgs e)
        {
            progressBar_export.Visible = true;
            ToExcel(gridView_info, saveFileDialog_export);
            progressBar_export.Visible = false;
        }

#endregion

#region 导出EXCEL
        //导出数据到Excel文件中
        public void ToExcel(DataGridView gridView, SaveFileDialog saveFileDialog)
        {
            try
            {
                if (gridView.Rows.Count == 0)
                {
                    MessageBox.Show("没有数据可供导出！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //获取保存EXCEL的路径
                    saveFileDialog.Filter = "Execl files (*.xls)|*.xls";
                    saveFileDialog.FilterIndex = 0;
                    saveFileDialog.RestoreDirectory = true;
                    saveFileDialog.CreatePrompt = true;
                    saveFileDialog.Title = "导出文件保存路径";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //strName储存保存EXCEL路径
                        string strName = saveFileDialog.FileName;
                        if (strName.Length != 0)
                        {
                            System.Reflection.Missing miss = System.Reflection.Missing.Value;
                            Microsoft.Office.Interop.Excel.ApplicationClass excel = new Microsoft.Office.Interop.Excel.ApplicationClass();
                            excel.Application.Workbooks.Add(true); ;
                            //若是true，则在导出的时候会显示EXcel界面。
                            excel.Visible = false;
                            if (excel == null)
                            {
                                MessageBox.Show("EXCEL无法启动！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            Microsoft.Office.Interop.Excel.Workbooks books = (Microsoft.Office.Interop.Excel.Workbooks)excel.Workbooks;
                            Microsoft.Office.Interop.Excel.Workbook book = (Microsoft.Office.Interop.Excel.Workbook)(books.Add(miss));
                            Microsoft.Office.Interop.Excel.Worksheet sheet = (Microsoft.Office.Interop.Excel.Worksheet)book.ActiveSheet;
                            sheet.Name = "Account";
                            //给进度条赋最大值，为gridView的行数                                             
                            progressBar_export.Maximum = gridView.RowCount;
                            progressBar_export.Value = 0;
                            //清零计数并开始计数
                            timer_export.Start();
                            //生成字段名称，逐条写，无效率
                            for (int i = 1; i < gridView.ColumnCount; i++)
                            {
                                excel.Cells[1, i] = gridView.Columns[i].HeaderText.ToString();
                            }
                            //以下为填充数据关键代码，逐条写，无效率
                            for (int i = 0; i < gridView.RowCount; i++)
                            {
                                for (int j = 1; j < gridView.ColumnCount; j++)
                                {
                                    if (gridView[j, i].Value == typeof(string))
                                    {
                                        excel.Cells[i + 2, j] = "" + gridView[i, j].Value.ToString();
                                    }
                                    else
                                    {
                                        excel.Cells[i + 2, j] = gridView[j, i].Value.ToString();
                                    }
                                }
                                //进度条加1
                                progressBar_export.Value++;
                                /*
                                 * 注意此Application.DoEvents()，如果无此句，当切换窗口后回到本程序无法重绘窗体会出现假死状态
                                 */
                                System.Windows.Forms.Application.DoEvents();

                            }

                            //保存EXCEL并释放资源
                            sheet.SaveAs(strName, miss, miss, miss, miss, miss, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, miss, miss, miss);
                            book.Close(false, miss, miss);
                            books.Close();
                            excel.Quit();
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(sheet);
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(book);
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(books);
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);
                            GC.Collect();
                            timer_export.Stop();
                            MessageBox.Show("数据已经成功导出到：" + saveFileDialog.FileName.ToString(), "导出完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                timer_export.Stop();
                return;
            }

        }
#endregion
    }
}
