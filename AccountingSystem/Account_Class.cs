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
    public partial class Account_Class : Form
    {
        public Account_Class()
        {
            InitializeComponent();
        }

        //设置页面显示
        private void Account_Class_Load(object sender, EventArgs e)
        {
            showAccIn();
            showAccOut();
            comboBox_inOut.SelectedIndex = 0;
        }

        //显示支出
        public void showAccOut()
        {
            dataGridView_out.DataSource = AccountServer.GetAllInOutClass(0);
            dataGridView_out.Columns["classAccName"].HeaderText = "分类名称";
            dataGridView_out.Columns["classAccName"].Width = 100;
            dataGridView_out.Columns["classAccInOut"].HeaderText = "收支";
            dataGridView_out.Columns["classAccInOut"].Width = 100;
            dataGridView_out.Columns["classAccID"].Visible = false;
        }

        //显示收入
        public void showAccIn()
        {
            dataGridView_in.DataSource = AccountServer.GetAllInOutClass(1);
            dataGridView_in.Columns["classAccName"].HeaderText = "分类名称";
            dataGridView_in.Columns["classAccName"].Width = 100;
            dataGridView_in.Columns["classAccInOut"].HeaderText = "收支";
            dataGridView_in.Columns["classAccInOut"].Width = 100;
            dataGridView_in.Columns["classAccID"].Visible = false;
        }

        //将dataGridView里的支出显示红色
        private void dataGridView_out_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int rowCount = dataGridView_out.Rows.Count;

            for (int i = 0; i < rowCount; i++)
            {
                dataGridView_out.Rows[i].Cells["classAccInOut"].Style.ForeColor = Color.Red;
            }
        }

        //将dataGridView里的收入显示绿色
        private void dataGridView_in_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int rowCount = dataGridView_in.Rows.Count;

            for (int i = 0; i < rowCount; i++)
            {
                dataGridView_in.Rows[i].Cells["classAccInOut"].Style.ForeColor = Color.Green;
            }
        }

        //确定增加分类
        private void btn_addOK_Click(object sender, EventArgs e)
        {
            string addAccClassName = textBox_name.Text.Trim();
            if (addAccClassName == "")
            {
                MessageBox.Show("账目名称不能为空", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string addAccClassInOut = comboBox_inOut.Text.Trim();
            try
            {
                DataTable dtExist = AccountServer.ExistAccClassName(addAccClassName, addAccClassInOut);
                if (dtExist.Rows.Count > 0)
                {
                    MessageBox.Show("该分类名称已存在", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (AccountServer.AddAccClass(addAccClassName,addAccClassInOut))
                {
                    MessageBox.Show("增加分类成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (addAccClassInOut == "支出") showAccOut();
                    else showAccIn();
                } 
                else
                {
                    MessageBox.Show("增加账目分类失败", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (System.Exception)
            {
                MessageBox.Show("增加账目分类出现异常", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //删除收入分类
        private void btn_delIn_Click(object sender, EventArgs e)
        {
            if (dataGridView_in.CurrentRow == null)
            {
                MessageBox.Show("请选中需要删除的收入分类", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
             DialogResult dr = MessageBox.Show("确定删除该收入分类吗？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    int selectDelClassID = int.Parse(dataGridView_in.CurrentRow.Cells["classAccID"].Value.ToString().Trim());
                    DataTable dt = AccountServer.AccClassUsed(selectDelClassID);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("该收入分类已存在账目，无法删除", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (AccountServer.DelAccClass(selectDelClassID))
                    {
                        showAccIn();
                    } 
                    else
                    {
                        MessageBox.Show("删除收入分类失败", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (System.Exception)
                {
                    MessageBox.Show("删除收入分类出现异常", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //删除支出分类
        private void btn_delOut_Click(object sender, EventArgs e)
        {
            if (dataGridView_out.CurrentRow == null)
            {
                MessageBox.Show("请选中需要删除的支出分类", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dr = MessageBox.Show("确定删除该支出分类吗？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    int selectDelClassID = int.Parse(dataGridView_out.CurrentRow.Cells["classAccID"].Value.ToString().Trim());
                    DataTable dt = AccountServer.AccClassUsed(selectDelClassID);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("该支出分类已存在账目，无法删除", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (AccountServer.DelAccClass(selectDelClassID))
                    {
                        showAccOut();
                    }
                    else
                    {
                        MessageBox.Show("删除支出分类失败", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (System.Exception)
                {
                    MessageBox.Show("删除支出分类出现异常", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //退出
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
