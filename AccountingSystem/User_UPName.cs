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
    public partial class User_UPName : Form
    {
        public string oriName;
        public string upName;

        public User_UPName()
        {
            InitializeComponent();
            oriName = MainForm.userName;
            upName = "";
            textBox_OriUserName.Text = oriName;
        }

        //取消更改
        private void btn_cencel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //确定更改
        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_NewUserName.Text.Trim() == "")
                {
                    MessageBox.Show("新账户名不能为空", "更新提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    upName = textBox_NewUserName.Text.Trim();
                    if (UserServer.UPUserName(oriName, upName))
                    {
                        MessageBox.Show("账户名更新成功", "更新提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MainForm.userName = upName;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("账户名更新失败", "更新提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
