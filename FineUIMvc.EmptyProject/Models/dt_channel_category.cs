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
    
    public partial class dt_channel_category
    {
        public dt_channel_category()
        {
            this.dt_channel = new HashSet<dt_channel>();
        }
    
        public int id { get; set; }
        public string title { get; set; }
        public string build_path { get; set; }
        public string templet_path { get; set; }
        public string domain { get; set; }
        public Nullable<byte> is_default { get; set; }
        public Nullable<int> sort_id { get; set; }
        public Nullable<int> wid { get; set; }
    
        public virtual ICollection<dt_channel> dt_channel { get; set; }
    }
}
