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
    
    public partial class order_item_report_appendix
    {
        public int Id { get; set; }
        public int order_item_report_id { get; set; }
        public byte[] appendix { get; set; }
    
        public virtual order_item_report order_item_report { get; set; }
    }
}
