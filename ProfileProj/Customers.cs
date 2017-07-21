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
    
    public partial class Customers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customers()
        {
            this.Portfolios = new HashSet<Portfolios>();
        }
    
        public int Cust_ID { get; set; }
        public string Cust_Code { get; set; }
        public string Cust_FName { get; set; }
        public string Cust_Name { get; set; }
        public Nullable<short> Cust_Branch { get; set; }
        public Nullable<int> Cust_Category { get; set; }
        public Nullable<int> Cust_Curr { get; set; }
        public Nullable<int> Cust_Resident { get; set; }
        public Nullable<System.DateTime> Cust_DeactiveDate { get; set; }
        public short Cust_Active { get; set; }
        public string Cust_address { get; set; }
        public string Cust_Town { get; set; }
        public string Cust_Telex { get; set; }
        public string Cust_Fax { get; set; }
        public string Cust_Email { get; set; }
        public Nullable<int> Cust_Country { get; set; }
        public string Cust_Tel { get; set; }
        public string Cust_Doy { get; set; }
        public string Cust_Zip { get; set; }
        public string Cust_AFM { get; set; }
        public string Cust_PName { get; set; }
        public Nullable<int> Cust_Profession { get; set; }
        public Nullable<System.DateTime> Cust_Birthdate { get; set; }
        public Nullable<int> Cust_Citizenship { get; set; }
        public string Cust_FEK { get; set; }
        public string Cust_CorpType { get; set; }
        public string Cust_BOGCode { get; set; }
        public string Cust_BOGSector { get; set; }
        public string Cust_Base { get; set; }
        public Nullable<short> Cust_SendFax { get; set; }
        public Nullable<int> Cust_Report { get; set; }
        public Nullable<short> Cust_RepPeriod { get; set; }
        public Nullable<short> Cust_RepPeriodType { get; set; }
        public Nullable<System.DateTime> Cust_NextDate { get; set; }
        public Nullable<short> Cust_RepLabels { get; set; }
        public Nullable<short> Cust_RepLang { get; set; }
        public Nullable<short> Cust_ObjectSet { get; set; }
        public string Cust_ShortCut2 { get; set; }
        public string Cust_SName2 { get; set; }
        public string Cust_FName2 { get; set; }
        public string Cust_PName2 { get; set; }
        public string Cust_Contaddr { get; set; }
        public Nullable<int> Cust_ContCountry { get; set; }
        public string Cust_ContTel { get; set; }
        public string Cust_ContEmail { get; set; }
        public string Cust_ContPerson { get; set; }
        public short Cust_ContMethod { get; set; }
        public string Cust_ContZip { get; set; }
        public string Cust_ContCity { get; set; }
        public string Cust_ContFax { get; set; }
        public Nullable<int> Cust_IDType { get; set; }
        public string Cust_IDNumber { get; set; }
        public Nullable<System.DateTime> Cust_IDDate { get; set; }
        public string Cust_IDIssuer { get; set; }
        public Nullable<int> Cust_IDCountry { get; set; }
        public string Cust_SwiftAddress { get; set; }
        public Nullable<int> Cust_TaxResidentCountry { get; set; }
        public int cust_ApproveIn { get; set; }
        public string Cust_AseEntity { get; set; }
        public string Cust_AseAccount { get; set; }
        public short Cust_WalkIn { get; set; }
        public string Cust_SATShortCut { get; set; }
        public int Cust_Custodian { get; set; }
        public int Cust_AssetManager { get; set; }
        public string Cust_Area { get; set; }
        public string Cust_ContArea { get; set; }
        public string Cust_MifidID { get; set; }
        public string Cust_MifidCID { get; set; }
        public string Cust_InvProfID { get; set; }
        public string Cust_AseAccountKem { get; set; }
        public string Cust_AseEntityKem { get; set; }
        public string Cust_SATShortCutKem { get; set; }
        public Nullable<byte> Cust_AMLControl { get; set; }
        public Nullable<int> Cust_ManageType { get; set; }
        public Nullable<short> Cust_FundType { get; set; }
        public string Cust_Call1 { get; set; }
        public string Cust_Call2 { get; set; }
        public Nullable<System.DateTime> Cust_InsDate { get; set; }
        public string Cust_InsUser { get; set; }
        public byte Cust_KEPYO { get; set; }
        public int Cust_VATCategory { get; set; }
        public byte CUST_SERVICELEVEL { get; set; }
        public string Cust_InvHorizon { get; set; }
        public Nullable<int> CUST_RM1 { get; set; }
        public Nullable<int> CUST_RM2 { get; set; }
        public Nullable<System.DateTime> CUST_SRVLVLASTUPDDT { get; set; }
        public Nullable<int> CUST_MNGMNTUNIT { get; set; }
        public Nullable<System.DateTime> CUST_IDEXPDATE { get; set; }
        public Nullable<System.DateTime> Cust_InvProfReviewDate { get; set; }
        public Nullable<int> Cust_PlaceOfBirth { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Portfolios> Portfolios { get; set; }
    }
}