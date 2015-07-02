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
    public partial class Account_BillCheck : Form
    {
        public Account_BillCheck()
        {
            InitializeComponent();
        }

        //显示账单
        private void Account_BillCheck_Load(object sender, EventArgs e)
        {
            string accDateStart = AccountServer.GetAccStartDate().Rows[0]["accDate"].ToString();
            string accDateEnd = AccountServer.GetAccEndDate().Rows[0]["accDate"].ToString();

            string checkStart = accDateStart.Substring(0, 7);
            string checkEnd = accDateEnd.Substring(0, 7);
            string checkNow = checkEnd;
            int gridViewRowsCount = 0;

            while (string.Compare(checkNow, checkStart) >= 0)
            {
                DataTable dt = AccountServer.GetPeriodAccount(checkNow + "-01", checkNow + "-31");
                double accBillIncome = 0;
                double accBillOutCome = 0;
                double accBillBalance = 0;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["收支"].ToString() == "支出")
                    {
                        accBillOutCome += double.Parse(dt.Rows[i]["数目"].ToString());
                    }
                    else
                    {
                        accBillIncome += double.Parse(dt.Rows[i]["数目"].ToString());
                    }
                }
                accBillBalance = accBillIncome - accBillOutCome;

                //添加数据
                if (accBillOutCome != 0 || accBillIncome != 0)
                {
                    dataGridView_billInfo.Rows.Add();
                    string[] tmpStr = checkNow.Split('-');
                    string showDate = tmpStr[0] + "年" + tmpStr[1] + "月";
                    dataGridView_billInfo.Rows[gridViewRowsCount].Cells["Col_Date"].Value = showDate;
                    dataGridView_billInfo.Rows[gridViewRowsCount].Cells["Col_AccountIn"].Value = accBillIncome;
                    dataGridView_billInfo.Rows[gridViewRowsCount].Cells["Col_AccountOut"].Value = accBillOutCome;
                    dataGridView_billInfo.Rows[gridViewRowsCount].Cells["Col_AccountBalance"].Value = accBillBalance;
                    gridViewRowsCount++;
                }

                DateTime tmpDate = DateTime.Parse(checkNow);
                checkNow = tmpDate.AddMonths(-1).ToString("yyyy-MM");
            }
        }

        //收入、支出和结余显示不同的颜色
        private void dataGridView_billInfo_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int rowCount = dataGridView_billInfo.Rows.Count;

            for (int i = 0; i < rowCount; i++)
            {
                dataGridView_billInfo.Rows[i].Cells["Col_AccountIn"].Style.ForeColor = Color.DarkBlue;
                dataGridView_billInfo.Rows[i].Cells["Col_AccountOut"].Style.ForeColor = Color.Chocolate;
                dataGridView_billInfo.Rows[i].Cells["Col_AccountBalance"].Style.BackColor = Color.Cornsilk;
                if (double.Parse(dataGridView_billInfo.Rows[i].Cells["Col_AccountBalance"].Value.ToString()) > 0)
                    dataGridView_billInfo.Rows[i].Cells["Col_AccountBalance"].Style.ForeColor = Color.Green;
                else dataGridView_billInfo.Rows[i].Cells["Col_AccountBalance"].Style.ForeColor = Color.Red;
            }
        }
    }
}
