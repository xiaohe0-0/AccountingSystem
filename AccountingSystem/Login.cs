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
    public partial class Login : Form
    {
        public static string loginName;//登录名
        public static string loginPsd;//登录密码
        private bool loginSucc;

        public Login()
        {
            InitializeComponent();
            loginName = "";
            loginPsd = "";

            //添加皮肤
            //skinEngine_account.SkinFile = Application.StartupPath + @"\XPBlue.ssk";//choose skin
            //skinEngine_account.Active = true;  
        }

        //账户登录
        private void btn_logOK_Click(object sender, EventArgs e)
        {

            if (textBox_logName.Text.Trim() != "")
            {
                loginName = textBox_logName.Text.Trim();//用户输入的登录名
                loginPsd = textBox_logPsd.Text;//用户输入的密码

                try
                {
                    loginSucc = LoginServer.GetLogin(loginName, loginPsd);
                    if (loginSucc)
                    {
                        this.Hide();
                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("用户名密码错误", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (System.Exception)
                {
                    MessageBox.Show("数据库连接异常", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else{
                MessageBox.Show("请填写用户名", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //取消登录
        private void btn_logCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
