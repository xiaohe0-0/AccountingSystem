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
    public partial class Remind_Add : Form
    {
        public Remind_Add()
        {
            InitializeComponent();
        }

        //初始设置
        private void Remind_Add_Load(object sender, EventArgs e)
        {
            remindDate.Value = DateTime.Now;
        }

        //取消
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //确定
        private void btn_OK_Click(object sender, EventArgs e)
        {
            string addRemindSth = textBox_remindSth.Text.ToString().Trim();
            if (addRemindSth == "")
            {
                MessageBox.Show("请输入提醒内容", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
            else
            {
                try
                {
                    string addDate = remindDate.Value.ToString("yyyy-MM-dd");
                    if (RemindServer.AddRemind(addDate,addRemindSth))
                    {
                        MessageBox.Show("增加事务提醒成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    } 
                    else
                    {
                        MessageBox.Show("增加事务提醒失败", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (System.Exception)
                {
                    MessageBox.Show("增加事务提醒出现异常", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

    }
}
