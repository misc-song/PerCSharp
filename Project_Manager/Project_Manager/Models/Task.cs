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
    
    public partial class Task
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Task()
        {
            this.Task_Comment = new HashSet<Task_Comment>();
        }
    
        public int Task_Id { get; set; }
        public string Task_Name { get; set; }
        public Nullable<int> Priority_Level { get; set; }
        public Nullable<bool> Task_Is_Finished { get; set; }
        public Nullable<int> User_Id { get; set; }
        public Nullable<int> Task_List_Id { get; set; }
    
        public virtual Task_List Task_List { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Task_Comment> Task_Comment { get; set; }
    }
}
