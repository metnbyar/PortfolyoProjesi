//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Steller_Portfolio.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblMessage
    {
        public int MessageId { get; set; }
        public string Email { get; set; }
        public string NameSurname { get; set; }
        public string MessageContent { get; set; }
        public Nullable<bool> isRead { get; set; }
    }
}
