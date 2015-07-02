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
    public partial class Account_AddAccount : Form
    {
        public Account_AddAccount()
        {
            InitializeComponent();
        }

        //自定义一个类,用其对象来存储Text,Value.
        public class ComboBoxItem
        {
            private string m_Text;
            private string m_Value;
            public ComboBoxItem()
            {
                this.m_Text = String.Empty;
                this.m_Value = String.Empty;
            }
            public string Text
            {
                get { return this.m_Text; }
                set { this.m_Text = value; }
            }
            public string Value
            {
                get { return this.m_Value; }
                set { this.m_Value = value; }
            }
            public override string ToString()
            {
                return this.m_Text;  //最关键的
            }
        }

        //初始设置
        private void Account_AddAccount_Load(object sender, EventArgs e)
        {
            comboBox_accInOut.SelectedIndex = 0;
            dateTimePicker_acc.Value = DateTime.Now;
        }
        //显示账目分类下拉列表
        private void showAccClass()
        {
            //0为支出 1为收入
            DataTable dt = AccountServer.GetAllInOutClass(comboBox_accInOut.SelectedIndex);
            comboBox_accClass.Items.Clear();
            //根据收支不同显示分类
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string comboText = dt.Rows[i]["classAccName"].ToString();
                string comboValue = dt.Rows[i]["classAccID"].ToString();

                ComboBoxItem itemAdd = new ComboBoxItem();
                itemAdd.Text = dt.Rows[i]["classAccName"].ToString();
                itemAdd.Value = dt.Rows[i]["classAccID"].ToString();

                comboBox_accClass.Items.Add(itemAdd);
            }
            comboBox_accClass.DisplayMember = "Text";
            comboBox_accClass.ValueMember = "Value";
            try
            {
                comboBox_accClass.SelectedIndex = 0;
            }
            catch (System.Exception)
            {
                comboBox_accClass.Text = "";
            }
        }
        //账目类型变化 账目分类变化
        private void comboBox_accInOut_SelectedIndexChanged(object sender, EventArgs e)
        {
            showAccClass();
        }

        //确定
        private void btn_OK_Click(object sender, EventArgs e)
        {
            string accountNum = textBox_accNum.Text.ToString().Trim();
            double res;
            
            //正确的账目金额
            if (double.TryParse(accountNum,out res))
            {
                //正确的账目分类
                if (comboBox_accClass.SelectedIndex < 0)
                {
                    MessageBox.Show("请选择账目分类", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        bool insertSucc;
                        string accDate = dateTimePicker_acc.Value.ToString("yyyy-MM-dd");
                        int accClassID = int.Parse(((ComboBoxItem)comboBox_accClass.SelectedItem).Value);
                        string accCon = textBox_accCon.Text.Trim();
                        if (insertSucc = AccountServer.AddAccount(res,accDate,accClassID,MainForm.userID,accCon))
                        {
                            this.Close();
                        } 
                        else
                        {
                            MessageBox.Show("记账失败", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (System.Exception)
                    {
                        MessageBox.Show("记账失败", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            } 
            else
            {
                MessageBox.Show("请输入正确的账目金额", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_accNum.Text = "";
            }
        }

        //取消
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //分类设置
        private void lab_setAccClass_Click(object sender, EventArgs e)
        {
            Form accClass = new Account_Class();
            accClass.ShowDialog();
            showAccClass();
        }
    }
}
