//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mistletoe.Dispatcher.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Template
    {
        public int Template_ID { get; set; }
        public int Campaign_ID { get; set; }
        public string To_Addresses { get; set; }
        public string From_Address { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    
        public virtual Campaign Campaign { get; set; }
    }
}
