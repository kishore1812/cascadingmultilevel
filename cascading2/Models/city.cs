//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cascading2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class city
    {
        public int cityid { get; set; }
        public string cityname { get; set; }
        public int Refstateid { get; set; }
    
        public virtual state state { get; set; }
    }
}
