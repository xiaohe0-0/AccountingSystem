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
    public partial class Account_BudgetUP : Form
    {
        private string selDate;
        public Account_BudgetUP()
        {
            InitializeComponent();
        }

        //初始设置
        private void Account_BudgetUP_Load(object sender, EventArgs e)
        {
            selDate = Account_BudgetManage.selectBudgetDate;
            string[] tmp = selDate.Split('-');
            textBox_date.Text = tmp[0] + "年" + tmp[1] + "月";
            textBox_num.Text = Account_BudgetManage.selectBudgetNum.ToString();
        }

        //取消
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //确定
        private void btn_OK_Click(object sender, EventArgs e)
        {
            string upNum = textBox_num.Text;
            double resNum;
            if (double.TryParse(upNum,out resNum))
            {
                try
                {
                    if (AccountServer.UPBudget(selDate, resNum))
                    {
                        MessageBox.Show("预算更新成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("预算更新失败", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (System.Exception)
                {
                    MessageBox.Show("预算更新出现异常", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } 
            else
            {
                MessageBox.Show("请输入正确的预算金额", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
