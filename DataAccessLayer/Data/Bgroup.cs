//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bgroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BloodGroup { get; set; }
        public string description { get; set; }
        public Nullable<int> ProfileId { get; set; }
    
        public virtual Profile Profile { get; set; }
    }
}
