//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SPA_Datahandler
{
    using System;
    using System.Collections.Generic;
    
    public partial class sow_user_delivery_address
    {
        public int Id { get; set; }
        public int sow_user_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string address_1 { get; set; }
        public string address_2 { get; set; }
        public string city { get; set; }
        public string zip { get; set; }
        public int zone_id { get; set; }
        public int country_id { get; set; }
        public string phone_1 { get; set; }
        public string phone_2 { get; set; }
        public string tax_number { get; set; }
        public System.DateTime createdAt { get; set; }
        public Nullable<System.DateTime> deletedAt { get; set; }
    
        public virtual country country { get; set; }
        public virtual sow_user sow_user { get; set; }
        public virtual zone zone { get; set; }
    }
}
