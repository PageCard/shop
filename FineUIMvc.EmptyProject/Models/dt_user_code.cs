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
    
    public partial class dt_user_code
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public string user_name { get; set; }
        public string type { get; set; }
        public string str_code { get; set; }
        public Nullable<int> count { get; set; }
        public Nullable<byte> status { get; set; }
        public System.DateTime eff_time { get; set; }
        public System.DateTime add_time { get; set; }
    
        public virtual dt_users dt_users { get; set; }
    }
}
