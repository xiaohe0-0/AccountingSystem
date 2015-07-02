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
    public partial class Account_Chart : Form
    {
        public static string dateStart;
        public static string dateEnd;

        public Account_Chart()
        {
            InitializeComponent();
            dateStart = MainForm.mainDateStart;
            dateEnd = MainForm.mainDateEnd;

            panel.Controls.Clear();
            Control_AccInOut accInOutChart = new Control_AccInOut();
            panel.Controls.Add(accInOutChart);
            dateTimePicker_start.Text = dateStart;
            dateTimePicker_end.Text = dateEnd;
        }

        //收支折线图
        private void btn_accInOut_Click(object sender, EventArgs e)
        {
            dateStart = dateTimePicker_start.Value.ToString("yyyy-MM-dd");
            dateEnd = dateTimePicker_end.Value.ToString("yyyy-MM-dd");

            if (string.Compare(dateStart,dateEnd) > 0)
            {
                MessageBox.Show("查询的开始日期应在终止日期之前", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.panel.Controls.Clear();
            Control_AccInOut accInOutChart = new Control_AccInOut();
            this.panel.Controls.Add(accInOutChart);
        }

        //支出分类图
        private void btn_accOutClass_Click(object sender, EventArgs e)
        {
            dateStart = dateTimePicker_start.Value.ToString("yyyy-MM-dd");
            dateEnd = dateTimePicker_end.Value.ToString("yyyy-MM-dd");

            if (string.Compare(dateStart, dateEnd) > 0)
            {
                MessageBox.Show("查询的开始日期应在终止日期之前", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.panel.Controls.Clear();
            Control_AccOutClass accOutClass = new Control_AccOutClass();
            this.panel.Controls.Add(accOutClass);
        }
        //退出
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
