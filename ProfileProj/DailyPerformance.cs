//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProfileProj
{
    using System;
    using System.Collections.Generic;
    
    public partial class DailyPerformance
    {
        public decimal DP_ID { get; set; }
        public System.DateTime DP_Date { get; set; }
        public int DP_PFCode { get; set; }
        public int DP_TICode { get; set; }
        public Nullable<decimal> DP_QtyStart { get; set; }
        public Nullable<decimal> DP_QtyTran { get; set; }
        public Nullable<decimal> DP_QtyEnd { get; set; }
        public Nullable<double> DP_BalStart { get; set; }
        public Nullable<double> DP_InOutFlows { get; set; }
        public Nullable<double> DP_IncExp { get; set; }
        public Nullable<double> DP_Gains { get; set; }
        public Nullable<double> DP_BalEnd { get; set; }
        public Nullable<double> DP_BalStartTI { get; set; }
        public Nullable<double> DP_InOutFlowsTI { get; set; }
        public Nullable<double> DP_IncExpTI { get; set; }
        public Nullable<double> DP_GainsTI { get; set; }
        public Nullable<double> DP_BalEndTI { get; set; }
        public Nullable<short> DP_IsDirty { get; set; }
        public Nullable<int> DP_TType { get; set; }
        public Nullable<double> DP_InOutFlowsDenom { get; set; }
        public Nullable<double> DP_InOutFlowsDenomTi { get; set; }
        public Nullable<double> DP_InOutFlowsAcc { get; set; }
        public Nullable<double> DP_InOutFlowsAccTi { get; set; }
        public Nullable<double> DP_BalStartTaxed { get; set; }
        public Nullable<double> DP_BalEndTaxed { get; set; }
        public Nullable<double> DP_BalStartTaxedTi { get; set; }
        public Nullable<double> DP_BalEndTaxedTi { get; set; }
        public Nullable<double> DP_BalStartUntaxed { get; set; }
        public Nullable<double> DP_BalEndUntaxed { get; set; }
        public Nullable<double> DP_BalStartUntaxedTi { get; set; }
        public Nullable<double> DP_BalEndUntaxedTi { get; set; }
        public Nullable<double> DP_VirtualInOut { get; set; }
        public Nullable<double> DP_VirtualInOutTi { get; set; }
        public int DP_GroupBrokerCode { get; set; }
    }
}
