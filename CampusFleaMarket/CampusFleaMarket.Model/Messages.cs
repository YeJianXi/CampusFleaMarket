//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CampusFleaMarket.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Messages
    {
        public Messages()
        {
            this.MessageComments = new HashSet<MessageComments>();
        }
    
        public int M_ID { get; set; }
        public string M_Description { get; set; }
        public Nullable<System.DateTime> M_Date { get; set; }
        public Nullable<int> M_Users { get; set; }
    
        public virtual ICollection<MessageComments> MessageComments { get; set; }
        public virtual Users Users { get; set; }
    }
}