using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BLL;

namespace AccountingSystem
{
    public partial class Control_AccInOut : UserControl
    {
        public Control_AccInOut()
        {
            InitializeComponent();
        }

        //显示收支折线图
        private void Control_AccInOut_Load(object sender, EventArgs e)
        {
            string accDateStart = Account_Chart.dateStart;
            string accDateEnd = Account_Chart.dateEnd;

            string checkStart = accDateStart.Substring(0, 7);
            string checkEnd = accDateEnd.Substring(0, 7);
            string checkNow = checkStart;

            while (string.Compare(checkNow, checkEnd) <= 0)
            {
                DataTable dt = AccountServer.GetPeriodAccount(checkNow + "-01", checkNow + "-31");
                double accBillIncome = 0;
                double accBillOutCome = 0;

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

                //添加数据
                string[] tmpStr = checkNow.Split('-');
                string showDate = tmpStr[0] + "年" + tmpStr[1] + "月";
                chart1.Series["收入"].Points.AddXY(showDate, accBillIncome);
                chart1.Series["支出"].Points.AddY(accBillOutCome);

                DateTime tmpDate = DateTime.Parse(checkNow);
                checkNow = tmpDate.AddMonths(1).ToString("yyyy-MM");
            }

            //设置格式
            chart1.Series["收入"].ChartType = SeriesChartType.Spline;
            chart1.Series["支出"].ChartType = SeriesChartType.Spline; 

            chart1.Series["收入"].BorderWidth = 2;
            chart1.Series["收入"].ShadowOffset = 1;

            chart1.Series["支出"].BorderWidth = 2;
            chart1.Series["支出"].ShadowOffset = 1;

            chart1.ChartAreas["ChartArea1"].AxisX.IsMarginVisible = true;

            chart1.Series["收入"]["ShowMarkerLines"] = "True";
            chart1.Series["支出"]["ShowMarkerLines"] = "True";
        }
    }
}
