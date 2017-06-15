//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class SALARy
    {
        public string SalaryID { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string CareerGroup { get; set; }
        public string Career { get; set; }
        public long GrossSalary { get; set; }
        public long NetSalary { get; set; }
        public string Experiences { get; set; }
        public string Education { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public string PermanentContract { get; set; }
        public string VisitorIP { get; set; }
        public string VisitorCountry { get; set; }
        public string Gender { get; set; }
        public Nullable<short> Age { get; set; }
        public Nullable<short> YearsAtCurrentEmployeer { get; set; }
        public Nullable<short> NumberOfAllCompanies { get; set; }
        public string HoursOfEducation { get; set; }
        public Nullable<short> WorkSatisfaction { get; set; }
        public Nullable<short> CompanySatisfaction { get; set; }
        public Nullable<short> SalarySatisfaction { get; set; }
        public string WorkHoursPerWeek { get; set; }
        public string SportsPerWeek { get; set; }
        public string SleepPerDay { get; set; }
        public int ID { get; set; }
        public string CareerDescription { get; set; }
        public string ProceedID { get; set; }
        public Nullable<int> SalaryLevel { get; set; }
        public Nullable<int> SalaryLevelEUR { get; set; }
        public Nullable<int> SalaryLevelUSD { get; set; }
        public string IsSalaryChecked { get; set; }
        public Nullable<int> AgeID { get; set; }
        public Nullable<bool> IsBrowser { get; set; }
        public Nullable<bool> IsMobile { get; set; }
        public string BrowserVersion { get; set; }
        public string BrowserSettings { get; set; }
    }
}
