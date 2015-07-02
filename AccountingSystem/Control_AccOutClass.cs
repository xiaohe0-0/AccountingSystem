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
using System.Collections;

namespace AccountingSystem
{
    public partial class Control_AccOutClass : UserControl
    {
        public Control_AccOutClass()
        {
            InitializeComponent();
        }

        //显示支出分类统计饼图
        private void Control_AccOutClass_Load(object sender, EventArgs e)
        {
            Series series = new Series("Pie");
            series.ChartType = SeriesChartType.Pie;
            series.BorderWidth = 3;
            series.ShadowOffset = 2;

            DataTable dt = AccountServer.GetAllInOutClass(0);
            for (int i = 0; i < dt.Rows.Count;i++ )
            {
                int accClassID = int.Parse(dt.Rows[i]["classAccID"].ToString());
                string timeStart = Account_Chart.dateStart;
                string timeEnd = Account_Chart.dateEnd;
                DataTable dtTmp = AccountServer.GetCertainClassAccount(accClassID,timeStart,timeEnd);
                double accOut = 0;
                for (int j = 0; j < dtTmp.Rows.Count;j++ )
                {
                    accOut += double.Parse(dtTmp.Rows[j]["accNum"].ToString());

                }
                if (accOut > 0)
                {
                    series.Points.AddXY(dt.Rows[i]["classAccName"].ToString(), accOut);
                }
            }

            series.LegendText = "#VALX";
            series.Label = "#VALX" + "\n￥#VAL" + "\n#PERCENT";
            chart1.Series.Add(series);
            //chart1.Series[0]["PieLabelStyle"] = "Outside";
        }
    }
}
