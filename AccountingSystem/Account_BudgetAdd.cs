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
    public partial class Account_BudgetAdd : Form
    {
        public Account_BudgetAdd()
        {
            InitializeComponent();
        }

        //初始设置
        private void Account_BudgetAdd_Load(object sender, EventArgs e)
        {
            //年份设置
            string nowYear = DateTime.Now.Year.ToString();
            for (int i = 0; i < 3;i++ )
            {
                comboBox_year.Items.Add(int.Parse(nowYear)+i);
            }
            comboBox_year.SelectedIndex = 0;

            //月份设置
            string nowMonth = DateTime.Now.ToString("MM");
            int addStep = 0;
            do
            {
                comboBox_month.Items.Add(nowMonth);
                addStep++;
                DateTime dtTmp = DateTime.Now.AddMonths(addStep);
                nowMonth = dtTmp.ToString("MM");
            } while (string.Compare(nowMonth, "01") != 0);
            comboBox_month.SelectedIndex = 0;

        }

        //取消
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //确定
        private void btn_OK_Click(object sender, EventArgs e)
        {
            string budgetNum = textBox_num.Text;
            double resNum;
            string budgetDate = comboBox_year.Text + "-" + comboBox_month.Text;
            if (double.TryParse(budgetNum,out resNum))
            {
                DataTable bExist = AccountServer.BudgetExist(budgetDate);
                if (bExist.Rows.Count > 0)
                {
                    MessageBox.Show(comboBox_year.Text + "年" + comboBox_month.Text + "月的预算已存在，预算为：" + bExist.Rows[0]["budgetNum"] + "元。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } 
                else
                {
                    try
                    {
                        if (AccountServer.AddBudget(budgetDate,double.Parse(budgetNum)))
                        {
                            MessageBox.Show("增加预算成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                            MessageBox.Show("增加预算失败！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (System.Exception)
                    {
                        MessageBox.Show("增加预算出现异常！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("请输入正确的预算金额", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
