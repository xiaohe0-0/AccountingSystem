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
    public partial class Account_BalanceAlertSetting : Form
    {
        public Account_BalanceAlertSetting()
        {
            InitializeComponent();
        }

        //初始设置
        private void Account_BalanceAlertSetting_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = AccountServer.GetAccLimit();
                textBox_accNum.Text = dt.Rows[0]["accLimitNum"].ToString();
            }
            catch (System.Exception)
            {
                textBox_accNum.Text = "0";
            }
        }

        //取消
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //确定
        private void btn_OK_Click(object sender, EventArgs e)
        {
            double accLimitRes;
            string accLimitNum = textBox_accNum.Text;
            if (double.TryParse(accLimitNum, out accLimitRes))
            {
                try
                {
                    if (AccountServer.UPAccLimit(accLimitRes))
                    {
                        MessageBox.Show("成功修改余额提醒值为"+accLimitRes+"元", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Close();
                    } 
                    else
                    {
                        MessageBox.Show("修改余额提醒值失败", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (System.Exception)
                {
                    MessageBox.Show("修改余额提醒值出现异常", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } 
            else
            {
                MessageBox.Show("请输入正确的余额提醒值", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_accNum.Text = "";
            }
        }
    }
}
