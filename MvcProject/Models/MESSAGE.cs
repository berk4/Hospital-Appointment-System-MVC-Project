//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MESSAGE
    {
        public int messageID { get; set; }
        public Nullable<int> senderID { get; set; }
        public Nullable<int> receiverID { get; set; }
        public string senderName { get; set; }
        public string senderSurname { get; set; }
        public string receiverName { get; set; }
        public string receiverSurname { get; set; }
        public string messageContent { get; set; }
        public Nullable<System.DateTime> messageDate { get; set; }
        public Nullable<System.TimeSpan> messageHour { get; set; }
    }
}
