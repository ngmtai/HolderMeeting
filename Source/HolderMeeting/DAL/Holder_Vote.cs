//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Holder_Vote
    {
        public int HolderId { get; set; }
        public int VoteId { get; set; }
        public int AnswerId { get; set; }
        public string AnswerName { get; set; }
        public Nullable<decimal> TotalShare { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string CreateUser { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string UpdateUser { get; set; }
    
        public virtual Answer Answer { get; set; }
        public virtual Holder Holder { get; set; }
        public virtual Vote Vote { get; set; }
    }
}
