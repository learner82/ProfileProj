using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileProj
{
    public class DataForReport
    {
        public DataForReport()
        {

        }

        private DateTime _date;
        private int _pfcode;
        private string _pfname;
        private string _currencyName;
        private double _balstart;
        private double _balend;
        private double _inout;
        private double _gains;
        private double _dailyR;
        private double _periodR;

        public DateTime Date { get { return this._date; }  set { this._date = value; } }

        public int PF_Code { get { return this._pfcode; } set { this._pfcode = value; } }

        public string PF_Shortcut1 { get { return this._pfname; } set { this._pfname = value; } }

        public string PF_Currency { get { return this._currencyName; } set { this._currencyName = value; } }

        public double DP_BalStart { get { return this._balstart; } set { this._balstart = value; } }

        public double DP_BalEnd { get { return this._balend; } set { this._balend = value; } }

        public double DP_InOutFlows { get { return this._inout; } set { this._inout = value; } }

        public double DP_Gains { get { return this._gains; } set { this._gains = value; } }

        public double DailyReturn { get { return this._dailyR; } set { this._dailyR = value; } }

        public double PeriodReturn { get { return this._periodR; } set { this._periodR = value; } }
    }
}
