//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CompanyHRManagement
{
    using System;
    using System.Collections.Generic;
    
    public partial class Insurance
    {
        public int InsuranceID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public string InsuranceType { get; set; }
        public Nullable<System.DateTime> RegistrationDate { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
