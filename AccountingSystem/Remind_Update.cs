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
    public partial class Remind_Update : Form
    {
        public Remind_Update()
        {
            InitializeComponent();
        }

        //初始设置
        private void Remind_Update_Load(object sender, EventArgs e)
        {
            remindDate.Text = Remind_Index.selectDate;
            textBox_remindSth.Text = Remind_Index.selectCon;
        }

        //确定
        private void btn_OK_Click(object sender, EventArgs e)
        {
            string upRemindDate = remindDate.Value.ToString("yyyy-MM-dd");
            string upRemindCon = textBox_remindSth.Text.ToString().Trim();

            if (upRemindCon == "")
            {
                MessageBox.Show("事务提醒内容不能为空！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                if (RemindServer.UPRemind(upRemindDate,upRemindCon,Remind_Index.selectID))
                {
                    MessageBox.Show("修改事务提醒成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                } 
                else
                {
                    MessageBox.Show("修改事务提醒失败", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (System.Exception)
            {
                MessageBox.Show("修改事务提醒出现异常", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //取消
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
