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
    
    public partial class Currencies
    {
        public int CR_Code { get; set; }
        public string CR_Name1 { get; set; }
        public string CR_Name2 { get; set; }
        public string CR_PRSymbol { get; set; }
        public string CR_ShortCut { get; set; }
        public Nullable<short> CR_Number { get; set; }
        public string CR_Reverse { get; set; }
        public Nullable<double> CR_Factor { get; set; }
        public string CR_ViewFmt { get; set; }
        public string CR_ISO { get; set; }
        public int CR_UCAccCode { get; set; }
        public int CR_DefAccCode { get; set; }
        public int CR_Decimals { get; set; }
        public string CR_AltCode { get; set; }
        public Nullable<int> CR_ParityPriority { get; set; }
        public int CR_YCLastID { get; set; }
        public int CR_BASE { get; set; }
        public Nullable<byte> CR_REVERSEENUM { get; set; }
        public string CR_LinkExport1 { get; set; }
        public string CR_LinkExport2 { get; set; }
        public Nullable<int> Cr_ExtFeedModelId { get; set; }
        public Nullable<int> Cr_RevalAccTCode { get; set; }
        public Nullable<int> Cr_AmortAccTCode { get; set; }
        public Nullable<int> Cr_ImpairmentAccTCode { get; set; }
    
        public virtual Titles Titles { get; set; }
        public virtual ExternalFeedModels ExternalFeedModels { get; set; }
        public virtual Titles Titles1 { get; set; }
        public virtual Titles Titles2 { get; set; }
    }
}