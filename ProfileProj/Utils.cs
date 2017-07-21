using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileProj
{
    public class Utils
    {

        public const string sWrongDates = "Please check again the selected dates.";

        public const string sWrongWithPort = "Please select at least one Portfolio";

        public const string sEmptyData = "No data for this time period";

        public const string ISO_DATE = "yyyy-MM-dd";

        public const string sClearBtnString = "";

        public const string sNoChoiseString = "You have not selected a Portfolio";

        public const string sClearDate = "";

        public string GetISOFormatForRowFilter(object a_date)
        {
            DateTime oTmpDate;
            if (!DateTime.TryParse(a_date.ToString(), out oTmpDate))
                throw new System.Exception(string.Format("Invalid Date Format[{0}]", a_date));
            return oTmpDate.ToString("#" + ISO_DATE + "#");
        }

        public string GetCurrString (DataSet dataset, int table)
        {
            return Convert.ToString(dataset.Tables[table].Rows[0]["CR_Name1"]);
        }

        public double? dGetBalStart(DataSet dsInformations, int table)
        {

            var date = Convert.ToDateTime(dsInformations.Tables[table].Compute("Min(DP_Date)",""));
            DataRow[] selectedRows = dsInformations.Tables[table].Select($"DP_Date={GetISOFormatForRowFilter(date)}");
            DataRow row = (DataRow)selectedRows.GetValue(0);
            double? dStartBalData = System.Convert.ToDouble(row["DP_BalStart"]);
            
            return dStartBalData; 
        }

        public double? dGetBalEnd(DataSet dsInformations, int table)
        {
            DateTime date = Convert.ToDateTime(dsInformations.Tables[table].Compute("Max(DP_Date)", ""));
            DataRow[] selectedRows = dsInformations.Tables[table].Select($"DP_Date = {GetISOFormatForRowFilter(date)}");
            DataRow row = (DataRow)selectedRows.GetValue(0);
            double? dBalEndData = Convert.ToDouble(row["DP_BalEnd"]);

            return dBalEndData;
        }

        public double? dGetInOutFlows (DataSet dsInformations, int table)
        {
            double? dInOutFlowsData = Convert.ToDouble(dsInformations.Tables[table].Compute("Sum(DP_InOutFlows)", ""));
            return dInOutFlowsData;
        }

        public string GetPLString(DataSet dsInformations, int table)
        {
            var dStartBalData = dGetBalStart(dsInformations, table);
            var dBalEndData = dGetBalEnd(dsInformations, table); 
            var dInOutFlowsData = dGetInOutFlows(dsInformations, table);
            return Convert.ToString((dBalEndData - (dStartBalData + dInOutFlowsData)));
            
        }

        public string GetPeriodString(DataSet dsInformations, int table)
        {
            var sum = 1.0;
            foreach (DataRow dr in dsInformations.Tables[table].Rows)
            {

                sum *= Convert.ToDouble(dr["PeriodReturn"]);
            }
            var result = (sum - 1.0) * 100.0;
            return  result.ToString();
        }

        public void DrawSeriesChart(ChartControl chart, DataTable data, string title)
        {

            var series1 = new DevExpress.XtraCharts.Series(title, ViewType.Line);
            chart.Series.Add(series1);
            series1.DataSource = data;
            series1.ArgumentScaleType = ScaleType.DateTime;
            series1.ArgumentDataMember = "DP_Date";
            series1.ValueDataMembers.AddRange(new string[] { "DailyReturn" });

        }

      
    }
}
