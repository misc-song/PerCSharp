//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_Mgr.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Message_Comment
    {
        public int Message_Comment_Id { get; set; }
        public string C_Message_Comment_Content { get; set; }
        public Nullable<int> User_Id { get; set; }
        public Nullable<int> Message_Id { get; set; }
    
        public virtual Message Message { get; set; }
        public virtual User User { get; set; }
    }
}
