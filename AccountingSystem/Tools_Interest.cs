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
    public partial class Tools_Interest : Form
    {
        public Tools_Interest()
        {
            InitializeComponent();
        }

        //初始值
        private void Tools_Interest_Load(object sender, EventArgs e)
        {
            comboBox_year.SelectedIndex = 0;
        }
        //选择时间变化
        private void comboBox_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox_year.SelectedIndex)
            {
                case 0:
                    textBox_interest.Text = "2.85";
                    break;
                case 1:
                    textBox_interest.Text = "3.05";
                    break;
                case 2:
                    textBox_interest.Text = "3.25";
                    break;
                case 3:
                    textBox_interest.Text = "3.75";
                    break;
                case 4:
                    textBox_interest.Text = "4.25";
                    break;
            }
        }
        //退出
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //计算
        private void btn_cal_Click(object sender, EventArgs e)
        {
            string oriMoney = textBox_ori.Text;
            string yearMoney = comboBox_year.Text;
            string interestMoney = textBox_interest.Text;
            string timesMoney = textBox_times.Text;

            double oriNum;
            double interestNum;
            int timesNum;

            if (!double.TryParse(oriMoney,out oriNum) || oriNum <= 0)
            {
                MessageBox.Show("输入的存入金额有误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!double.TryParse(interestMoney,out interestNum) || interestNum >= 100 || interestNum <= 0)
            {
                MessageBox.Show("输入的年利率有误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(timesMoney, out timesNum) || timesNum <= 0)
            {
                MessageBox.Show("输入的复利次数有误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double calInterest = 0;
            switch(comboBox_year.SelectedIndex)
            {
                case 0:
                    calInterest = interestNum / 400;
                    break;
                case 1:
                    calInterest = interestNum / 200;
                    break;
                case 2:
                    calInterest = interestNum / 100;
                    break;
                case 3:
                    calInterest = (interestNum * 2)/100;
                    break;
                case 4:
                    calInterest = (interestNum * 3)/100;
                    break;
            }
            double resMoney = oriNum * Math.Pow((1 + calInterest), timesNum);
            textBox_res.Text = resMoney.ToString("F2");
        }

        

    }
}
