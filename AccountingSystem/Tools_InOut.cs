using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AccountingSystem
{
    public partial class Tools_InOut : Form
    {
        public Tools_InOut()
        {
            InitializeComponent();
        }

        //初始设置
        private void Tools_InOut_Load(object sender, EventArgs e)
        {
            comboBox_year.SelectedIndex = 0;
        }

        //退出
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //显示不同的利率
        private void comboBox_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox_year.SelectedIndex)
            {
                case 0:
                    textBox_interest.Text = "2.85";
                    break;
                case 1:
                    textBox_interest.Text = "2.90";
                    break;
                case 2:
                    textBox_interest.Text = "3.00";
                    break;
            }
        }

        //计算
        private void btn_cal_Click(object sender, EventArgs e)
        {
            string oriMoney = textBox_ori.Text;
            string interestMoney = textBox_interest.Text;

            double oriNum;
            double interestNum;

            if (!double.TryParse(oriMoney, out oriNum) || oriNum <= 0)
            {
                MessageBox.Show("输入的存入金额有误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!double.TryParse(interestMoney, out interestNum) || interestNum >= 100 || interestNum <= 0)
            {
                MessageBox.Show("输入的利率有误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double calInterest = interestNum/1200;
            int times = 0;
            int months = 0;
            switch(comboBox_year.SelectedIndex)
            {
                case 0:
                    times = 78;
                    months = 12;
                    break;
                case 1:
                    times = 666;
                    months = 36;
                    break;
                case 2:
                    times = 1830;
                    months = 60;
                    break;
            }

            double resNum = oriNum*months + oriNum * calInterest * times;
            textBox_res.Text = resNum.ToString("F2");
        }

    }
}
