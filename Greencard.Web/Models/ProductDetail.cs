//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Greencard.Web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductDetail
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int Status { get; set; }
        public string Slug { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
