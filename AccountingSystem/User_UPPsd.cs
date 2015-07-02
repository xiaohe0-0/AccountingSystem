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
    public partial class User_UPPsd : Form
    {
        private string userName;
        private string userOriPsd;
        private string userNewPsd;
        private string userCheckPsd;

        public User_UPPsd()
        {
            InitializeComponent();
            userName = MainForm.userName;
            textBox_userName.Text = userName;
        }

        //取消
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //确定修改
        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                userOriPsd = textBox_oriPsd.Text;
                userNewPsd = textBox_newPsd.Text;
                userCheckPsd = textBox_checkPsd.Text;

                //原密码错误
                if (!LoginServer.GetLogin(userName, userOriPsd))
                {
                    MessageBox.Show("原密码错误", "更改提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //新密码与确认密码不一致
                else if (userNewPsd != userCheckPsd)
                {
                    MessageBox.Show("新密码与确认密码不一致", "更改提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (UserServer.UPUserPsd(userName, userNewPsd))
                    {
                        MessageBox.Show("账户密码更改成功", "更改提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("账户密码更改失败", "更改提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
