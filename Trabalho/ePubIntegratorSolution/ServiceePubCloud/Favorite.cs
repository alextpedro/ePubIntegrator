//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceePubCloud
{
    using System;
    using System.Collections.Generic;
    
    public partial class Favorite
    {
        public int Id { get; set; }
        public string Book { get; set; }
        public string Chapter { get; set; }
    
        public virtual eBook eBook { get; set; }
        public virtual Chapter Chapter1 { get; set; }
    }
}
