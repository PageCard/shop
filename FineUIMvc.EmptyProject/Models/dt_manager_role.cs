//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace FineUIMvc.EmptyProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class dt_manager_role
    {
        public dt_manager_role()
        {
            this.dt_manager_role_value = new HashSet<dt_manager_role_value>();
        }
    
        public int id { get; set; }
        public string role_name { get; set; }
        public Nullable<byte> role_type { get; set; }
        public Nullable<byte> is_sys { get; set; }
        public Nullable<int> agentId { get; set; }
    
        public virtual ICollection<dt_manager_role_value> dt_manager_role_value { get; set; }
    }
}