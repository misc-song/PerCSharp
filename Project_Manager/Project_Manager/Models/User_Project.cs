//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_Manager.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User_Project
    {
        public int User_Project_Id { get; set; }
        public Nullable<int> Project_Id { get; set; }
        public Nullable<int> User_Id { get; set; }
    
        public virtual Project Project { get; set; }
        public virtual User User { get; set; }
    }
}