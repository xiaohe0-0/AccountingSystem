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
    public partial class Remind_Index : Form
    {
        public static int selectID;
        public static string selectDate;
        public static string selectCon;

        public Remind_Index()
        {
            InitializeComponent();
        }

        //初始设置
        private void Remind_Index_Load(object sender, EventArgs e)
        {
            showData();
        }

        //显示数据内容
        private void showData()
        {
            DataTable dt = RemindServer.GetALLRemind();
            dataGridView_info.DataSource = dt;
            dataGridView_info.Columns["remindID"].Visible = false;
            dataGridView_info.Columns["remindDate"].HeaderText = "日期";
            dataGridView_info.Columns["remindDate"].Width = 70;
            dataGridView_info.Columns["remindCon"].HeaderText = "提醒内容";
            dataGridView_info.Columns["remindCon"].Width = 300;
        }
        //退出
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //增加
        private void btn_add_Click(object sender, EventArgs e)
        {
            Form addRemind = new Remind_Add();
            addRemind.ShowDialog();
            showData();
        }

        //修改
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dataGridView_info.CurrentRow == null)
            {
                MessageBox.Show("请选中需要修改的事务提醒", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            selectID = int.Parse(dataGridView_info.CurrentRow.Cells["remindID"].Value.ToString());
            selectDate = dataGridView_info.CurrentRow.Cells["remindDate"].Value.ToString();
            selectCon = dataGridView_info.CurrentRow.Cells["remindCon"].Value.ToString();

            Form upRemind = new Remind_Update();
            upRemind.ShowDialog();
            showData();
        }

        //删除事物提醒
        private void btn_del_Click(object sender, EventArgs e)
        {
            if (dataGridView_info.CurrentRow == null)
            {
                MessageBox.Show("请选中需要删除的事务提醒", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dr = MessageBox.Show("确定删除" + dataGridView_info.CurrentRow.Cells["remindDate"].Value.ToString() + "的事务提醒吗？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int delRemindID = int.Parse(dataGridView_info.CurrentRow.Cells["remindID"].Value.ToString());
                try
                {
                    if (RemindServer.DelRemind(delRemindID))
                    {
                        showData();
                    } 
                    else
                    {
                        MessageBox.Show("删除事务提醒失败", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (System.Exception )
                {
                    MessageBox.Show("删除事务提醒出现异常", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //显示今天的事物提醒
        private void dataGridView_info_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            string dtNow = DateTime.Now.ToString("yyyy-MM-dd");
            int rowsCount = dataGridView_info.Rows.Count;

            for (int i = 0; i < rowsCount;i++ )
            {
                if (string.Compare(dataGridView_info.Rows[i].Cells["remindDate"].Value.ToString(),dtNow)== 0)
                {
                    dataGridView_info.Rows[i].Cells["remindDate"].Style.ForeColor = Color.Red;
                    dataGridView_info.Rows[i].Cells["remindCon"].Style.ForeColor = Color.Red;
                }
            }

        }

    }
}
