using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace AccountingSystem
{
    public partial class Account_BudgetManage : Form
    {
        public static int selectBudgetID;
        public static string selectBudgetDate;
        public static double selectBudgetNum;
        public Account_BudgetManage()
        {
            InitializeComponent();
            dataGridView_budget.Columns["Col_ID"].Visible = false;
        }

        //显示预算
        private void Account_BudgetManage_Load(object sender, EventArgs e)
        {
            showBudget();
        }

        //删除预算
        private void btn_del_Click(object sender, EventArgs e)
        {
            if (dataGridView_budget.CurrentRow == null)
            {
                MessageBox.Show("请选中需要删除的预算", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string delDate = dataGridView_budget.CurrentRow.Cells["Col_Date"].Value.ToString();
            DialogResult dr = MessageBox.Show("确定删除"+delDate+"的预算吗？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    selectBudgetID = int.Parse(dataGridView_budget.CurrentRow.Cells["Col_ID"].Value.ToString());
                    if (AccountServer.DelBudget(selectBudgetID))
                    {
                        MessageBox.Show("删除预算成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showBudget();
                    } 
                    else
                    {
                        MessageBox.Show("删除预算失败", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (System.Exception)
                {
                    MessageBox.Show("删除预算出现异常", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //修改预算
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dataGridView_budget.CurrentRow == null)
            {
                MessageBox.Show("请选中需要修改的预算", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            selectBudgetID = int.Parse(dataGridView_budget.CurrentRow.Cells["Col_ID"].Value.ToString());
            selectBudgetDate = dataGridView_budget.CurrentRow.Cells["Col_Date"].Value.ToString();
            selectBudgetNum = double.Parse(dataGridView_budget.CurrentRow.Cells["Col_Budget"].Value.ToString());
            Form budgetUP = new Account_BudgetUP();
            budgetUP.ShowDialog();
            showBudget();
        }

        //增加预算
        private void btn_add_Click(object sender, EventArgs e)
        {
            Form budgetAdd = new Account_BudgetAdd();
            budgetAdd.ShowDialog();
            showBudget();
        }

        //显示预算表格的函数
        private void showBudget()
        {
            DataTable dt = AccountServer.GetAllBudget();
            int rowsCount = dt.Rows.Count;
            dataGridView_budget.Rows.Clear();
            for (int i = 0; i < rowsCount; i++)
            {
                string budgetDate = dt.Rows[i]["budgetDate"].ToString();
                dataGridView_budget.Rows.Add();
                dataGridView_budget.Rows[i].Cells["Col_ID"].Value = dt.Rows[i]["budgetID"].ToString();
                dataGridView_budget.Rows[i].Cells["Col_Date"].Value = budgetDate;
                dataGridView_budget.Rows[i].Cells["Col_Budget"].Value = dt.Rows[i]["budgetNum"].ToString();

                DataTable dtTmp = AccountServer.GetPeriodOutcome(budgetDate + "-01", budgetDate + "-31");
                double accOut = 0;
                for (int j = 0; j < dtTmp.Rows.Count; j++)
                {
                    accOut += double.Parse(dtTmp.Rows[j]["数目"].ToString());
                }
                dataGridView_budget.Rows[i].Cells["Col_AccOut"].Value = accOut.ToString();
            }
        }

        //退出
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //当实际支出大于预算时显示成红色
        private void dataGridView_budget_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int rowCount = dataGridView_budget.Rows.Count;

            for (int i = 0; i < rowCount; i++)
            {
                // string curBudget = dataGridView_budget.Rows[i].Cells["Col_Budget"].Value.ToString();
                // string curAccOut = dataGridView_budget.Rows[i].Cells["Col_AccOut"].Value.ToString();

                double curBudget = double.Parse(dataGridView_budget.Rows[i].Cells["Col_Budget"].Value.ToString());
                double curAccOut = double.Parse(dataGridView_budget.Rows[i].Cells["Col_AccOut"].Value.ToString());
                if (curAccOut - curBudget > 0)
                {
                    dataGridView_budget.Rows[i].Cells["Col_AccOut"].Style.ForeColor = Color.Red;
                }
               
            }
        }
    }
}
